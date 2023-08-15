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
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private int originalPanelWidth;
        private int originalPanelHeight;

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            // Captura as dimensões originais do panel1 ao carregar o formulário
            originalPanelWidth = 0;
            originalPanelHeight = 0;
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
                    if (control is Button button)
                    {
                        // Calcula o novo tamanho da fonte proporcionalmente
                        button.Font = new Font(button.Font.FontFamily, button.Font.Size * widthRatio, button.Font.Style);
                    }
                    else
                    {
                        // Calcula os novos tamanhos baseados nas proporções
                        int newControlWidth = (int)(control.Width * widthRatio);
                        int newControlHeight = (int)(control.Height * heightRatio);

                        // Define os novos tamanhos para o controle
                        control.Width = newControlWidth;
                        control.Height = newControlHeight;

                    }

                    int newControlX = (int)(control.Left * widthRatio);
                    int newControlY = (int)(control.Top * heightRatio);
                    control.Left = newControlX;
                    control.Top = newControlY;
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
