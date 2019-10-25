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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        bool flag = false;
        string msgErro = "";
        //double salarioPret = 0;
        private bool verificaCampos()
        {
            msgErro = "Erro!\n";
            bool valido = true;
            flag = false; // 

            if (txtNome.TextLength == 0)
            {
                msgErro += "Nome não pode estar vazio.\n";
                valido = false;
            }
            if (txtTelefone.TextLength == 0)
            {
                msgErro += "Telefone não pode estar vazio.\n";
                valido = false;
            }
            if (cbxIdade.Text == "")
            {
                msgErro += "Informar a Idade é obrigatório.\n";
                valido = false;
            }
            if (txtLastJob.TextLength == 0)
            {
                msgErro += "Nome da empresa onde trabalhou anteriormente é obrigatório.\n";
                valido = false;
            }
            if (cbxDistancia.Text == "")
            {
                msgErro += "Informar a distância de residência é obrigatório\n";
                valido = false;
            }
            else if (cbxDistancia.Text == "maior que 100KM")
            {
                msgErro += "Distância>100KM.\nEmpresa não fornece transporte\n";
                valido = false;
            }
            if (!(ckbxMasc.Checked || ckbxFem.Checked))
            {
                msgErro += "É necessário selecionar um ou mais gêneros\n";
                valido = false;
            }
            if (!mskbxSalario.MaskCompleted)
            {
                msgErro += "Preencher Salário Pretendido é obrigatório.\n";
                valido = false;
            }
            else if (!double.TryParse(mskbxSalario.Text, out double salarioPret))
            {
                msgErro += "Pretensão Salarial Inválida!\n";
                valido = false;
            }
            else if (salarioPret < 1000 || salarioPret > 2500)
            {
                msgErro += "Pretensão Salarial precisa estar entre 1000 e 2500\n";
                valido = false;
            }
            if (cbxTempoEXP.Text == "")
            {
                msgErro += "Informar Tempo de Expêriencia é obrigatório.\n";
                valido = false;
            }
            else if (cbxTempoEXP.Text == "Menos de 1 Ano")
            {
                msgErro = "Agradecemos a Participação, mas é necessário no mínimo 1 ano de Experiência.\n";
                valido = false;
            }
            else if (cbxTempoEXP.Text == "De 1 a 2 Anos")
            {
                flag = true;
            }

            return valido;
        }
        private void BtnCandidatar_Click(object sender, EventArgs e)
        {
            if (verificaCampos())
            {
                if (!flag)
                {
                    MessageBox.Show("Cadastro Realizado com Sucesso!");
                }
                else
                {
                    MessageBox.Show("Aguarde! Voce será chamado para um teste.");
                }
            }
            else
            {
                MessageBox.Show(msgErro);
            }
        }

        private void CbxDistancia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
