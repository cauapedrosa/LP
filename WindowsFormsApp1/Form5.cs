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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        //
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if ((this.ActiveControl == txtDe) && (keyData == Keys.Return))
            {
                ConvertDe();
                return true;
            }
            else if ((this.ActiveControl == txtPara) && (keyData == Keys.Return))
            {
                ConvertPara();
                return true;
            }
            else
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }
        }
        //
        double de, para, fator;
        private void ConvertDe()
        {
            fator = getFactor();
            if (fator != 0 && double.TryParse(txtDe.Text, out de))
            {
                txtPara.Text = (de * fator).ToString();
            }
        }
        //
        private void ConvertPara()
        {
            fator = getFactor();
            if (fator != 0 && double.TryParse(txtPara.Text, out para))
            {
                txtDe.Text = (para / fator).ToString();
            }
        }

        private double getFactor()
        {
            double ret = 0;
            switch (cbxTipoConversao.SelectedIndex)
            {
                case 0:
                    ret = 15;
                    break;
                case 1:
                    ret = 0.4535923;
                    break;
                case 2:
                    ret = 28.349;
                    break;
                case 3:
                    ret = 0.4046856224;
                    break;
                case 4:
                    ret = 10000.0;
                    break;
                case 5:
                    ret = 4.84;
                    break;
                case 6:
                    ret = 2.42;
                    break;
                case 7:
                    ret = 2.72;
                    break;
                case 8:
                    ret = 1.8288;
                    break;
                case 9:
                    ret = 0.9144;
                    break;
                case 10:
                    ret = 30.48;
                    break;
                case 11:
                    ret = 2.54;
                    break;
                case 12:
                    ret = 1.609344;
                    break;
                default:
                    break;
            }
            return ret;
        }

        private void CbxTipoConversao_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDe.Text = "";
            txtPara.Text = "";
            txtDe.Focus();
        }

        private void BtnConverter_Click(object sender, EventArgs e) {}
    }
}
