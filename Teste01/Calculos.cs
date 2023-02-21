using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Teste01
{
    public partial class Calculos : Form
    {
        public Calculos()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Botão "Calcular"
        private void button_Calcular_Click(object sender, EventArgs e)
        {
            int numeroA = 0, numeroB = 0, numeroC = 0;
            var passe = false;

            if(textBox_A.Text != "" && textBox_B.Text != "" && textBox_C.Text != "" &&                                                                                             //Valores Válidos
               textBox_A.Text != "0" && textBox_B.Text != "0" && textBox_C.Text != "0" )
            {
                numeroA = int.Parse(textBox_A.Text);
                numeroB = int.Parse(textBox_B.Text);
                numeroC = int.Parse(textBox_C.Text);
                passe = true;
                label_Resultado.ForeColor = System.Drawing.SystemColors.ControlText;
            } else
            {
                label_Resultado.Text = "Digite os valores do triângulo!";
                label_Resultado.ForeColor = System.Drawing.Color.Red;
            }

            if (numeroA + numeroB >= numeroC && numeroB + numeroC >= numeroA && numeroA + numeroC >= numeroB)                                                                      //Calculo Triângulo Válido
            {

                Graphics triangulo;
                triangulo = this.CreateGraphics();
                SolidBrush pincel = new SolidBrush(Color.Black);
                triangulo.Clear(Color.White);

                if (numeroA*2 == numeroB+numeroC && passe)                                                                                                                         //Calculo Equilátero
                {
                    label_Resultado.Text = "Esse é um Triângulo equilátero";
                    Point[] pontos = { new Point(390, 100), new Point(330 - numeroC / 2, 200 + numeroA), new Point(450 + numeroC / 2, 200 + numeroB) };
                    triangulo.FillPolygon(pincel, pontos);
                }
                else if (numeroA != numeroB && numeroA != numeroC && numeroB != numeroC)                                                                                           //Calculo Escaleno
                {
                    label_Resultado.Text = "Esse é um Triângulo escaleno";
                    Point[] pontos = { new Point(390, 100), new Point(330-numeroC/2, 200+numeroA), new Point(450+numeroC/2, 200+numeroB) };
                    triangulo.FillPolygon(pincel, pontos);
                }
                else if (numeroA != numeroB || numeroB != numeroC)                                                                                                                 //Calculo Isósceles
                {
                    label_Resultado.Text = "Esse é um Triângulo isósceles";
                    Point[] pontos = { new Point(390, 100), new Point(330 - numeroC / 2, 200 + numeroA), new Point(450 + numeroC / 2, 200 + numeroB) };
                    triangulo.FillPolygon(pincel, pontos);
                }
            } else                                                                                                                                                                 //Triângulo Inválido
            {
                Graphics triangulo;
                triangulo = this.CreateGraphics();
                triangulo.Clear(Color.White);

                label_Resultado.ForeColor = System.Drawing.Color.Red;
                label_Resultado.Text = "Triângulo Inválido";
            }
        }

        //Permitir apenas números nas TextBox
        private void textBox_A_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.ApenasNumero(e);
        }

        private void textBox_B_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.ApenasNumero(e);
        }

        private void textBox_C_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.ApenasNumero(e);
        }
        //Botão "Descrição"
        private void button_Descricao_Click(object sender, EventArgs e)
        {
            Descricao descricao = new Descricao();

            if (Application.OpenForms.OfType<Descricao>().Count() > 0)                                                                                                             //Verificar se a janela já está aberta
            {

            } else
            {
                descricao.Show();
            }  
        }
    }
}
