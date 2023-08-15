namespace FisioMetric.Views
{
    partial class Frm_ListaRelatório
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Btn_voltar = new Button();
            Btn_edit = new Button();
            Btn_erase = new Button();
            Lvw_relatorios = new ListView();
            relatorioId = new ColumnHeader();
            Nome = new ColumnHeader();
            DataAtendimento = new ColumnHeader();
            SuspendLayout();
            // 
            // Btn_voltar
            // 
            Btn_voltar.Location = new Point(790, 172);
            Btn_voltar.Margin = new Padding(4, 3, 4, 3);
            Btn_voltar.Name = "Btn_voltar";
            Btn_voltar.Size = new Size(128, 38);
            Btn_voltar.TabIndex = 7;
            Btn_voltar.Text = "Voltar";
            Btn_voltar.UseVisualStyleBackColor = true;
            // 
            // Btn_edit
            // 
            Btn_edit.Location = new Point(790, 114);
            Btn_edit.Margin = new Padding(4, 3, 4, 3);
            Btn_edit.Name = "Btn_edit";
            Btn_edit.Size = new Size(128, 38);
            Btn_edit.TabIndex = 6;
            Btn_edit.Text = "Editar Relatório";
            Btn_edit.UseVisualStyleBackColor = true;
            // 
            // Btn_erase
            // 
            Btn_erase.Location = new Point(790, 54);
            Btn_erase.Margin = new Padding(4, 3, 4, 3);
            Btn_erase.Name = "Btn_erase";
            Btn_erase.Size = new Size(128, 38);
            Btn_erase.TabIndex = 5;
            Btn_erase.Text = "Apagar Relatório";
            Btn_erase.UseVisualStyleBackColor = true;
            // 
            // Lvw_relatorios
            // 
            Lvw_relatorios.Columns.AddRange(new ColumnHeader[] { relatorioId, Nome, DataAtendimento });
            Lvw_relatorios.FullRowSelect = true;
            Lvw_relatorios.Location = new Point(13, 21);
            Lvw_relatorios.Margin = new Padding(4, 3, 4, 3);
            Lvw_relatorios.Name = "Lvw_relatorios";
            Lvw_relatorios.Size = new Size(759, 491);
            Lvw_relatorios.TabIndex = 4;
            Lvw_relatorios.UseCompatibleStateImageBehavior = false;
            Lvw_relatorios.View = View.Details;
            // 
            // relatorioId
            // 
            relatorioId.DisplayIndex = 2;
            relatorioId.Text = "relatorioId";
            relatorioId.Width = 0;
            // 
            // Nome
            // 
            Nome.DisplayIndex = 0;
            Nome.Text = "Nome";
            Nome.Width = 136;
            // 
            // DataAtendimento
            // 
            DataAtendimento.DisplayIndex = 1;
            DataAtendimento.Text = "Data de Atendimento";
            DataAtendimento.Width = 145;
            // 
            // Frm_VisualizaRelatório
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 565);
            Controls.Add(Btn_voltar);
            Controls.Add(Btn_edit);
            Controls.Add(Btn_erase);
            Controls.Add(Lvw_relatorios);
            Name = "Frm_VisualizaRelatório";
            Text = "Frm_VisualizaRelatório";
            ResumeLayout(false);
        }

        #endregion

        private Button Btn_voltar;
        private Button Btn_edit;
        private Button Btn_erase;
        private ListView Lvw_relatorios;
        private ColumnHeader relatorioId;
        private ColumnHeader Nome;
        private ColumnHeader DataAtendimento;
    }
}