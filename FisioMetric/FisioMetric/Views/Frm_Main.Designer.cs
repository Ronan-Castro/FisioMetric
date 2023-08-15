namespace FisioMetric.Views
{
    partial class Frm_Main
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
            panel1 = new Panel();
            listView1 = new ListView();
            Btn_NovoRelatorio = new Button();
            Btn_VerRelatorio = new Button();
            Btn_Deletar = new Button();
            Btn_regPaciente = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(listView1);
            panel1.Controls.Add(Btn_NovoRelatorio);
            panel1.Controls.Add(Btn_VerRelatorio);
            panel1.Controls.Add(Btn_Deletar);
            panel1.Controls.Add(Btn_regPaciente);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1050, 591);
            panel1.TabIndex = 1;
            // 
            // listView1
            // 
            listView1.Location = new Point(64, 125);
            listView1.Name = "listView1";
            listView1.Size = new Size(924, 416);
            listView1.TabIndex = 5;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Btn_NovoRelatorio
            // 
            Btn_NovoRelatorio.AutoSize = true;
            Btn_NovoRelatorio.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Btn_NovoRelatorio.Location = new Point(892, 81);
            Btn_NovoRelatorio.Name = "Btn_NovoRelatorio";
            Btn_NovoRelatorio.Size = new Size(96, 25);
            Btn_NovoRelatorio.TabIndex = 4;
            Btn_NovoRelatorio.Text = "Novo Relatório";
            Btn_NovoRelatorio.UseVisualStyleBackColor = true;
            // 
            // Btn_VerRelatorio
            // 
            Btn_VerRelatorio.AutoSize = true;
            Btn_VerRelatorio.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Btn_VerRelatorio.Location = new Point(724, 81);
            Btn_VerRelatorio.Name = "Btn_VerRelatorio";
            Btn_VerRelatorio.Size = new Size(134, 25);
            Btn_VerRelatorio.TabIndex = 3;
            Btn_VerRelatorio.Text = "Relatórios do Paciente";
            Btn_VerRelatorio.UseVisualStyleBackColor = true;
            // 
            // Btn_Deletar
            // 
            Btn_Deletar.AutoSize = true;
            Btn_Deletar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Btn_Deletar.Location = new Point(190, 81);
            Btn_Deletar.Name = "Btn_Deletar";
            Btn_Deletar.Size = new Size(54, 25);
            Btn_Deletar.TabIndex = 2;
            Btn_Deletar.Text = "Deletar";
            Btn_Deletar.UseVisualStyleBackColor = true;
            // 
            // Btn_regPaciente
            // 
            Btn_regPaciente.AutoSize = true;
            Btn_regPaciente.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Btn_regPaciente.Location = new Point(64, 81);
            Btn_regPaciente.Name = "Btn_regPaciente";
            Btn_regPaciente.Size = new Size(111, 25);
            Btn_regPaciente.TabIndex = 1;
            Btn_regPaciente.Text = "Registrar Paciente";
            Btn_regPaciente.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(64, 35);
            label1.Name = "label1";
            label1.Size = new Size(224, 29);
            label1.TabIndex = 0;
            label1.Text = "Lista De Pacientes";
            // 
            // Frm_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1050, 591);
            Controls.Add(panel1);
            Name = "Frm_Main";
            Text = "Frm_Main";
            Load += Frm_Main_Load;
            Resize += Frm_Main_Resize;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private ListView listView1;
        private Button Btn_NovoRelatorio;
        private Button Btn_VerRelatorio;
        private Button Btn_Deletar;
        private Button Btn_regPaciente;
        private Label label1;
    }
}