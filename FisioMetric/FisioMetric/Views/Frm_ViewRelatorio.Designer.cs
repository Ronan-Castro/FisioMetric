namespace FisioMetric.Views
{
    partial class Frm_ViewRelatorio
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
            Txt_conteudo = new TextBox();
            Btn_voltar = new Button();
            SuspendLayout();
            // 
            // Txt_conteudo
            // 
            Txt_conteudo.Location = new Point(13, 78);
            Txt_conteudo.Margin = new Padding(4, 3, 4, 3);
            Txt_conteudo.Multiline = true;
            Txt_conteudo.Name = "Txt_conteudo";
            Txt_conteudo.ReadOnly = true;
            Txt_conteudo.Size = new Size(770, 403);
            Txt_conteudo.TabIndex = 4;
            // 
            // Btn_voltar
            // 
            Btn_voltar.Location = new Point(13, 10);
            Btn_voltar.Margin = new Padding(4, 3, 4, 3);
            Btn_voltar.Name = "Btn_voltar";
            Btn_voltar.Size = new Size(114, 27);
            Btn_voltar.TabIndex = 3;
            Btn_voltar.Text = "Voltar";
            Btn_voltar.UseVisualStyleBackColor = true;
            // 
            // Frm_ViewRelatorio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 507);
            Controls.Add(Txt_conteudo);
            Controls.Add(Btn_voltar);
            Name = "Frm_ViewRelatorio";
            Text = "Frm_ViewRelatorio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Txt_conteudo;
        private Button Btn_voltar;
    }
}