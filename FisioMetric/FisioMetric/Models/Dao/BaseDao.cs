using FisioMetric.Models.Dao;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

public class BaseDao<T>
{
    private string _connectionString;

    public BaseDao()
    {
        _connectionString = Conn.strConn;
    }

    public void Insert(T item, string tableName)
    {
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            connection.Open();

            SqlCommand command = connection.CreateCommand();
            string columns = string.Join(", ", GetPropertyNames(item));
            string values = "@" + string.Join(", @", GetPropertyNames(item));
            command.CommandText = $"INSERT INTO {tableName} ({columns}) VALUES ({values})";

            // Add parameters and set values based on T properties
            SetParameters(command, item);

            command.ExecuteNonQuery();
        }
    }

    public void Update(T item, string tableName, string idColumnName = "Id")
    {
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            connection.Open();

            SqlCommand command = connection.CreateCommand();
            string updateColumns = string.Join(", ", GetPropertyNames(item, idColumnName));
            command.CommandText = $"UPDATE {tableName} SET {updateColumns} WHERE {idColumnName} = @{idColumnName}";

            // Add parameters and set values based on T properties
            SetParameters(command, item);
            command.Parameters.AddWithValue($"@{idColumnName}", GetPropertyValue(item, idColumnName));

            command.ExecuteNonQuery();
        }
    }

    public void Update(T item, string tableName, string[] updateColumns, string idColumnName = "Id")
    {
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            connection.Open();

            PropertyInfo idProperty = typeof(T).GetProperty(idColumnName);
            object idValue = idProperty.GetValue(item);

            string updateColumnList = string.Join(", ", updateColumns.Select(col => $"{col} = @{col}"));

            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"UPDATE {tableName} SET {updateColumnList} WHERE {idColumnName} = @{idColumnName}";

            foreach (string column in updateColumns)
            {
                PropertyInfo property = typeof(T).GetProperty(column);
                object value = property.GetValue(item);
                command.Parameters.AddWithValue($"@{column}", value);
            }

            command.Parameters.AddWithValue($"@{idColumnName}", idValue);

            command.ExecuteNonQuery();
        }
    }

    public void Delete(object id, string tableName, string idColumnName = "Id")
    {
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            connection.Open();

            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"DELETE FROM {tableName} WHERE {idColumnName} = @{idColumnName}";
            command.Parameters.AddWithValue($"@{idColumnName}", id);

            command.ExecuteNonQuery();
        }
    }

    public DataTable SelectAll(string tableName)
    {
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            connection.Open();

            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"SELECT * FROM {tableName}";

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            return dataTable;
        }
    }

    public DataTable SelectJoin(string primaryTable, string[] columns, string[] joinTables, string[] joinConditions)
    {
        if (columns.Length == 0 || joinTables.Length == 0 || joinTables.Length != joinConditions.Length)
        {
            throw new ArgumentException("Invalid parameters.");
        }

        string query = $"SELECT {string.Join(", ", columns.Select(c => $"{primaryTable}.{c}"))} " +
                       $"FROM {primaryTable} ";

        for (int i = 0; i < joinTables.Length; i++)
        {
            query += $"INNER JOIN {joinTables[i]} ON {joinConditions[i]} ";
        }

        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            connection.Open();

            SqlCommand command = connection.CreateCommand();
            command.CommandText = query;

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            return dataTable;
        }
    }

    private string[] GetPropertyNames(T item, string excludePropertyName = null)
    {
        var properties = typeof(T).GetProperties();
        if (!string.IsNullOrEmpty(excludePropertyName))
        {
            properties = properties
                .Where(prop => prop.Name != excludePropertyName)
                .ToArray();
        }
        return properties.Select(prop => prop.Name).ToArray();
    }

    private object GetPropertyValue(T item, string propertyName)
    {
        var property = typeof(T).GetProperty(propertyName);
        return property.GetValue(item);
    }

    private void SetParameters(SqlCommand command, T item)
    {
        var properties = typeof(T).GetProperties();
        foreach (var property in properties)
        {
            command.Parameters.AddWithValue($"@{property.Name}", property.GetValue(item));
        }
    }
}
