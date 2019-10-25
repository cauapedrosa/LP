using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            //Exercícios Práticos:

            Application.Run(new Form1()); //Exercício 38
            Application.Run(new Form2()); //Exercício 39
            Application.Run(new Form3()); //Exercício 40
            Application.Run(new Form4()); //Exercício 41
            Application.Run(new Form5()); //Exercício 42
            
        }
    }
}
