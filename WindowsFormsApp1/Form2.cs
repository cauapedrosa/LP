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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int i;
            double[] vetA = new double[10];
            //Primeiro Vetor:
            for (i = 0; i < 10; i++) {
                string input = Interaction.InputBox("Digite o " + (i + 1) + "º valor.", "Entrada de Dados", "Valor", -1, -1);
                if (!double.TryParse(input, out vetA[i])){
                    MessageBox.Show("Entrada \""+input+"\" Inválida!\nTente Novamente.");
                    i--;
                }
            }

            /*  O enunciado não estava tão claro quanto ao comportamento do segundo vetor...
             *  Espero que este seja o esperado */
            //Segundo Vetor:
            double[] vetB = new double[10];
            for (i = 0; i < 10; i++) {
                vetB[i] = !(i % 2 == 0) ? vetA[i] * 5 : vetA[i] + 5;
            }
            //Imprimir Vetores:
            string output = "Vetor A:\n";
            for (i = 0; i < 10; i++) { output += vetA[i].ToString() + ", "; }
            output += "\nVetor B:\n";
            for (i = 0; i < 10; i++) { output += vetB[i].ToString() + ", "; }
            MessageBox.Show(output);
        }
    }
}
