using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FisioMetric.Views
{
    public partial class novoform : Form
    {
        public novoform()
        {
            InitializeComponent();
        }

        private int originalPanelWidth;
        private int originalPanelHeight;
        private int yOffset = 0; // Variável para acompanhar a posição vertical dos controles
        private const int controlSpacing = 10;

        private void novoform_Load(object sender, EventArgs e)
        {
            originalPanelWidth = panel1.Width;
            originalPanelHeight = panel1.Height;
        }

        private void Frm_Main_Resize(object sender, EventArgs e)
        {
            // Obtém as novas dimensões do painel após o redimensionamento do formulário
            int newWidth = panel1.Width;
            int newHeight = panel1.Height;

            // Calcula as proporções de redimensionamento
            if (originalPanelWidth > 0 && originalPanelHeight > 0)
            {
                float widthRatio = (float)newWidth / originalPanelWidth;
                float heightRatio = (float)newHeight / originalPanelHeight;
                originalPanelWidth = panel1.Width;
                originalPanelHeight = panel1.Height;
                // Percorre todos os controles dentro do panel1 e redimensiona proporcionalmente
                foreach (Control control in panel1.Controls)
                {
                    // Verifica se o controle é um botão
                    if (control is Button button )
                    {
                        // Calcula o novo tamanho da fonte proporcionalmente
                        button.Font = new Font(button.Font.FontFamily, button.Font.Size * widthRatio, button.Font.Style);
                    }
                    
                    if(control is not ListView)
                    {
                        // Calcula os novos tamanhos baseados nas proporções
                        control.Location = new Point(control.Location.X, yOffset);
                        yOffset += control.Height + controlSpacing;

                    }


                }
            }
            else
            {
                originalPanelWidth = panel1.Width;
                originalPanelHeight = panel1.Height;
            }
        }
    }
}
