namespace FisioMetric.Views
{
    partial class Frm_Paciente
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
            Mtxt_tel = new MaskedTextBox();
            Mtxt_Date = new MaskedTextBox();
            Txt_Email = new TextBox();
            Txt_Name = new TextBox();
            Lbl_Date = new Label();
            Lbl_Tel = new Label();
            Lbl_Email = new Label();
            Lbl_Name = new Label();
            Btn_Cancel = new Button();
            Btn_Save = new Button();
            SuspendLayout();
            // 
            // Mtxt_tel
            // 
            Mtxt_tel.Location = new Point(63, 234);
            Mtxt_tel.Margin = new Padding(4, 3, 4, 3);
            Mtxt_tel.Mask = "(00)00000-0000";
            Mtxt_tel.Name = "Mtxt_tel";
            Mtxt_tel.Size = new Size(116, 23);
            Mtxt_tel.TabIndex = 20;
            // 
            // Mtxt_Date
            // 
            Mtxt_Date.Location = new Point(63, 280);
            Mtxt_Date.Margin = new Padding(4, 3, 4, 3);
            Mtxt_Date.Mask = "00/00/0000";
            Mtxt_Date.Name = "Mtxt_Date";
            Mtxt_Date.Size = new Size(116, 23);
            Mtxt_Date.TabIndex = 19;
            // 
            // Txt_Email
            // 
            Txt_Email.Location = new Point(63, 189);
            Txt_Email.Margin = new Padding(4, 3, 4, 3);
            Txt_Email.Name = "Txt_Email";
            Txt_Email.Size = new Size(116, 23);
            Txt_Email.TabIndex = 18;
            // 
            // Txt_Name
            // 
            Txt_Name.Location = new Point(63, 144);
            Txt_Name.Margin = new Padding(4, 3, 4, 3);
            Txt_Name.Name = "Txt_Name";
            Txt_Name.Size = new Size(116, 23);
            Txt_Name.TabIndex = 17;
            // 
            // Lbl_Date
            // 
            Lbl_Date.AutoSize = true;
            Lbl_Date.Location = new Point(63, 261);
            Lbl_Date.Margin = new Padding(4, 0, 4, 0);
            Lbl_Date.Name = "Lbl_Date";
            Lbl_Date.Size = new Size(31, 15);
            Lbl_Date.TabIndex = 16;
            Lbl_Date.Text = "Data";
            // 
            // Lbl_Tel
            // 
            Lbl_Tel.AutoSize = true;
            Lbl_Tel.Location = new Point(60, 216);
            Lbl_Tel.Margin = new Padding(4, 0, 4, 0);
            Lbl_Tel.Name = "Lbl_Tel";
            Lbl_Tel.Size = new Size(51, 15);
            Lbl_Tel.TabIndex = 15;
            Lbl_Tel.Text = "Telefone";
            // 
            // Lbl_Email
            // 
            Lbl_Email.AutoSize = true;
            Lbl_Email.Location = new Point(63, 171);
            Lbl_Email.Margin = new Padding(4, 0, 4, 0);
            Lbl_Email.Name = "Lbl_Email";
            Lbl_Email.Size = new Size(36, 15);
            Lbl_Email.TabIndex = 14;
            Lbl_Email.Text = "Email";
            // 
            // Lbl_Name
            // 
            Lbl_Name.AutoSize = true;
            Lbl_Name.Location = new Point(63, 126);
            Lbl_Name.Margin = new Padding(4, 0, 4, 0);
            Lbl_Name.Name = "Lbl_Name";
            Lbl_Name.Size = new Size(40, 15);
            Lbl_Name.TabIndex = 13;
            Lbl_Name.Text = "Nome";
            // 
            // Btn_Cancel
            // 
            Btn_Cancel.Location = new Point(173, 64);
            Btn_Cancel.Margin = new Padding(4, 3, 4, 3);
            Btn_Cancel.Name = "Btn_Cancel";
            Btn_Cancel.Size = new Size(88, 27);
            Btn_Cancel.TabIndex = 12;
            Btn_Cancel.Text = "Cancelar";
            Btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // Btn_Save
            // 
            Btn_Save.Location = new Point(63, 64);
            Btn_Save.Margin = new Padding(4, 3, 4, 3);
            Btn_Save.Name = "Btn_Save";
            Btn_Save.Size = new Size(88, 27);
            Btn_Save.TabIndex = 11;
            Btn_Save.Text = "Salvar";
            Btn_Save.UseVisualStyleBackColor = true;
            // 
            // Frm_Paciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Mtxt_tel);
            Controls.Add(Mtxt_Date);
            Controls.Add(Txt_Email);
            Controls.Add(Txt_Name);
            Controls.Add(Lbl_Date);
            Controls.Add(Lbl_Tel);
            Controls.Add(Lbl_Email);
            Controls.Add(Lbl_Name);
            Controls.Add(Btn_Cancel);
            Controls.Add(Btn_Save);
            Name = "Frm_Paciente";
            Text = "Frm_Paciente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox Mtxt_tel;
        private MaskedTextBox Mtxt_Date;
        private TextBox Txt_Email;
        private TextBox Txt_Name;
        private Label Lbl_Date;
        private Label Lbl_Tel;
        private Label Lbl_Email;
        private Label Lbl_Name;
        private Button Btn_Cancel;
        private Button Btn_Save;
    }
}