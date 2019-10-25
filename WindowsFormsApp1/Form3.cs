using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            /* 40. Faça um programa que carregue valores (usando InputBox) de uma compra em uma matriz 7x5 
             * (a linha é o dia da semana e a coluna são os produtos), depois some os elementos de cada linha,
             * gerando  o  vetor  TotalporDia.  Em  seguida  somar  os  elementos  do  vetor  na  variável  TotalGeral.
             * Finalmente jogar todos os resultados do Vetor Linha e do TotalGeral em um componente ListBox.  */
            int i, j;
            double[,] matriz = new double[7,5];
            double[] TotalporDia = new double[7];
            double TotalGeral=0;
            //entrada de dados:
/*            double[,] matriz = new double[7, 5]    {{ 1, 1, 1, 1, 1 },
                                                    { 1, 1, 1, 1, 1 }, 
                                                    { 1, 1, 1, 1, 1 }, 
                                                    { 1, 1, 1, 1, 1 }, 
                                                    { 1, 1, 1, 1, 1 }, 
                                                    { 1, 1, 1, 1, 1 }, 
                                                    { 1, 1, 1, 1, 1 } };
*/

            for (i = 0; i < 7; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    string input = Interaction.InputBox("Digite o valor da " + (i + 1) + "ª linha, "+ (j+1) +"ª Coluna.", "Entrada de Dados", "Valor", -1, -1);
                    if (!double.TryParse(input, out matriz[i,j]))
                    {
                        MessageBox.Show("Entrada \"" + input + "\" Inválida!\nTente Novamente.");
                        j--;
                    }
                }

            }
            //somatoria
            for (i = 0; i < 7; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    TotalporDia[i] += matriz[i, j];
                    TotalGeral += matriz[i, j];
                }
            }
            //saída
            listBox1.Items.Insert(0, "Total do dia 1:   " + TotalporDia[0]);
            listBox1.Items.Insert(1, "Total do dia 2:   " + TotalporDia[1]);
            listBox1.Items.Insert(2, "Total do dia 3:   " + TotalporDia[2]);
            listBox1.Items.Insert(3, "Total do dia 4:   " + TotalporDia[3]);
            listBox1.Items.Insert(4, "Total do dia 5:   " + TotalporDia[4]);
            listBox1.Items.Insert(5, "Total do dia 6:   " + TotalporDia[5]);
            listBox1.Items.Insert(6, "Total do dia 7:   " + TotalporDia[6]);
            listBox1.Items.Insert(7, "Total Geral:      " + TotalGeral);

        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
