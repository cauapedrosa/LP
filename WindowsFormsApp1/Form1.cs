using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int i;
            double soma = 0;
            if (int.TryParse(textBox1.Text, out int n) && n > 0 && n < 50) {
                for (i = 0; i <= n; i++) {
                    soma += (double)i / (i + 1);
                    //Console.WriteLine("i: " + i + " soma: " + soma); //debug
                }
                MessageBox.Show(soma.ToString());
            } else {
                MessageBox.Show("Entrada Inválida.\nTente Novamente.");
            }
            
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
