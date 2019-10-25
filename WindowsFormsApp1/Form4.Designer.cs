namespace WindowsFormsApp1
{
    partial class Form4
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.rbtnSolteiro = new System.Windows.Forms.RadioButton();
            this.ckbxMasc = new System.Windows.Forms.CheckBox();
            this.btnCandidatar = new System.Windows.Forms.Button();
            this.cbxIdade = new System.Windows.Forms.ComboBox();
            this.gbxEstadoCivil = new System.Windows.Forms.GroupBox();
            this.rbtnOutros = new System.Windows.Forms.RadioButton();
            this.rbtnDivorciado = new System.Windows.Forms.RadioButton();
            this.rbtnDesquitado = new System.Windows.Forms.RadioButton();
            this.rbtnViuvo = new System.Windows.Forms.RadioButton();
            this.rbtnCasado = new System.Windows.Forms.RadioButton();
            this.gbxSexo = new System.Windows.Forms.GroupBox();
            this.ckbxFem = new System.Windows.Forms.CheckBox();
            this.cbxDistancia = new System.Windows.Forms.ComboBox();
            this.lblIdade = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblDistancia = new System.Windows.Forms.Label();
            this.txtLastJob = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxTempoEXP = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mskbxSalario = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbxEstadoCivil.SuspendLayout();
            this.gbxSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 23);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(300, 20);
            this.txtNome.TabIndex = 0;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(12, 61);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(123, 20);
            this.txtTelefone.TabIndex = 1;
            // 
            // rbtnSolteiro
            // 
            this.rbtnSolteiro.AutoSize = true;
            this.rbtnSolteiro.Checked = true;
            this.rbtnSolteiro.Location = new System.Drawing.Point(6, 19);
            this.rbtnSolteiro.Name = "rbtnSolteiro";
            this.rbtnSolteiro.Size = new System.Drawing.Size(72, 17);
            this.rbtnSolteiro.TabIndex = 3;
            this.rbtnSolteiro.TabStop = true;
            this.rbtnSolteiro.Text = "Solteiro(a)";
            this.rbtnSolteiro.UseVisualStyleBackColor = true;
            // 
            // ckbxMasc
            // 
            this.ckbxMasc.AutoSize = true;
            this.ckbxMasc.Checked = true;
            this.ckbxMasc.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbxMasc.Location = new System.Drawing.Point(6, 19);
            this.ckbxMasc.Name = "ckbxMasc";
            this.ckbxMasc.Size = new System.Drawing.Size(74, 17);
            this.ckbxMasc.TabIndex = 8;
            this.ckbxMasc.Text = "Masculino";
            this.ckbxMasc.UseVisualStyleBackColor = true;
            // 
            // btnCandidatar
            // 
            this.btnCandidatar.Location = new System.Drawing.Point(322, 249);
            this.btnCandidatar.Name = "btnCandidatar";
            this.btnCandidatar.Size = new System.Drawing.Size(150, 50);
            this.btnCandidatar.TabIndex = 10;
            this.btnCandidatar.Text = "Candidatar-se";
            this.btnCandidatar.UseVisualStyleBackColor = true;
            this.btnCandidatar.Click += new System.EventHandler(this.BtnCandidatar_Click);
            // 
            // cbxIdade
            // 
            this.cbxIdade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxIdade.FormattingEnabled = true;
            this.cbxIdade.Items.AddRange(new object[] {
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75"});
            this.cbxIdade.Location = new System.Drawing.Point(12, 105);
            this.cbxIdade.Name = "cbxIdade";
            this.cbxIdade.Size = new System.Drawing.Size(88, 21);
            this.cbxIdade.Sorted = true;
            this.cbxIdade.TabIndex = 2;
            // 
            // gbxEstadoCivil
            // 
            this.gbxEstadoCivil.Controls.Add(this.rbtnOutros);
            this.gbxEstadoCivil.Controls.Add(this.rbtnDivorciado);
            this.gbxEstadoCivil.Controls.Add(this.rbtnDesquitado);
            this.gbxEstadoCivil.Controls.Add(this.rbtnViuvo);
            this.gbxEstadoCivil.Controls.Add(this.rbtnCasado);
            this.gbxEstadoCivil.Controls.Add(this.rbtnSolteiro);
            this.gbxEstadoCivil.Location = new System.Drawing.Point(12, 138);
            this.gbxEstadoCivil.Name = "gbxEstadoCivil";
            this.gbxEstadoCivil.Size = new System.Drawing.Size(120, 155);
            this.gbxEstadoCivil.TabIndex = 3;
            this.gbxEstadoCivil.TabStop = false;
            this.gbxEstadoCivil.Text = "Estado Civil";
            // 
            // rbtnOutros
            // 
            this.rbtnOutros.AutoSize = true;
            this.rbtnOutros.Location = new System.Drawing.Point(6, 134);
            this.rbtnOutros.Name = "rbtnOutros";
            this.rbtnOutros.Size = new System.Drawing.Size(56, 17);
            this.rbtnOutros.TabIndex = 3;
            this.rbtnOutros.Text = "Outros";
            this.rbtnOutros.UseVisualStyleBackColor = true;
            // 
            // rbtnDivorciado
            // 
            this.rbtnDivorciado.AutoSize = true;
            this.rbtnDivorciado.Location = new System.Drawing.Point(6, 111);
            this.rbtnDivorciado.Name = "rbtnDivorciado";
            this.rbtnDivorciado.Size = new System.Drawing.Size(88, 17);
            this.rbtnDivorciado.TabIndex = 3;
            this.rbtnDivorciado.Text = "Divorciado(a)";
            this.rbtnDivorciado.UseVisualStyleBackColor = true;
            // 
            // rbtnDesquitado
            // 
            this.rbtnDesquitado.AutoSize = true;
            this.rbtnDesquitado.Location = new System.Drawing.Point(6, 88);
            this.rbtnDesquitado.Name = "rbtnDesquitado";
            this.rbtnDesquitado.Size = new System.Drawing.Size(91, 17);
            this.rbtnDesquitado.TabIndex = 3;
            this.rbtnDesquitado.Text = "Desquitado(a)";
            this.rbtnDesquitado.UseVisualStyleBackColor = true;
            // 
            // rbtnViuvo
            // 
            this.rbtnViuvo.AutoSize = true;
            this.rbtnViuvo.Location = new System.Drawing.Point(6, 65);
            this.rbtnViuvo.Name = "rbtnViuvo";
            this.rbtnViuvo.Size = new System.Drawing.Size(64, 17);
            this.rbtnViuvo.TabIndex = 3;
            this.rbtnViuvo.Text = "Viúvo(a)";
            this.rbtnViuvo.UseVisualStyleBackColor = true;
            // 
            // rbtnCasado
            // 
            this.rbtnCasado.AutoSize = true;
            this.rbtnCasado.Location = new System.Drawing.Point(6, 42);
            this.rbtnCasado.Name = "rbtnCasado";
            this.rbtnCasado.Size = new System.Drawing.Size(73, 17);
            this.rbtnCasado.TabIndex = 3;
            this.rbtnCasado.Text = "Casado(a)";
            this.rbtnCasado.UseVisualStyleBackColor = true;
            // 
            // gbxSexo
            // 
            this.gbxSexo.Controls.Add(this.ckbxFem);
            this.gbxSexo.Controls.Add(this.ckbxMasc);
            this.gbxSexo.Location = new System.Drawing.Point(141, 228);
            this.gbxSexo.Name = "gbxSexo";
            this.gbxSexo.Size = new System.Drawing.Size(120, 61);
            this.gbxSexo.TabIndex = 8;
            this.gbxSexo.TabStop = false;
            this.gbxSexo.Text = "Sexo";
            // 
            // ckbxFem
            // 
            this.ckbxFem.AutoSize = true;
            this.ckbxFem.Location = new System.Drawing.Point(6, 43);
            this.ckbxFem.Name = "ckbxFem";
            this.ckbxFem.Size = new System.Drawing.Size(68, 17);
            this.ckbxFem.TabIndex = 9;
            this.ckbxFem.Text = "Feminino";
            this.ckbxFem.UseVisualStyleBackColor = true;
            // 
            // cbxDistancia
            // 
            this.cbxDistancia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDistancia.FormattingEnabled = true;
            this.cbxDistancia.Items.AddRange(new object[] {
            "de 0 a 20KM",
            "de 21 a 50KM",
            "de 51 a 100KM",
            "maior que 100KM"});
            this.cbxDistancia.Location = new System.Drawing.Point(141, 199);
            this.cbxDistancia.Name = "cbxDistancia";
            this.cbxDistancia.Size = new System.Drawing.Size(153, 21);
            this.cbxDistancia.TabIndex = 7;
            this.cbxDistancia.SelectedIndexChanged += new System.EventHandler(this.CbxDistancia_SelectedIndexChanged);
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(9, 88);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(34, 13);
            this.lblIdade.TabIndex = 9;
            this.lblIdade.Text = "Idade";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(9, 46);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone.TabIndex = 9;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblDistancia
            // 
            this.lblDistancia.AutoSize = true;
            this.lblDistancia.Location = new System.Drawing.Point(141, 178);
            this.lblDistancia.Name = "lblDistancia";
            this.lblDistancia.Size = new System.Drawing.Size(170, 13);
            this.lblDistancia.TabIndex = 9;
            this.lblDistancia.Text = "Distância entre empresa e moradia";
            // 
            // txtLastJob
            // 
            this.txtLastJob.Location = new System.Drawing.Point(141, 106);
            this.txtLastJob.Name = "txtLastJob";
            this.txtLastJob.Size = new System.Drawing.Size(153, 20);
            this.txtLastJob.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Última empresa onde trabalhou";
            // 
            // cbxTempoEXP
            // 
            this.cbxTempoEXP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTempoEXP.FormattingEnabled = true;
            this.cbxTempoEXP.Items.AddRange(new object[] {
            "Menos de 1 Ano",
            "De 1 a 2 Anos",
            "De 2 a 3 Anos",
            "De 3 a 5 Anos",
            "Mais de 5 Anos"});
            this.cbxTempoEXP.Location = new System.Drawing.Point(141, 150);
            this.cbxTempoEXP.Name = "cbxTempoEXP";
            this.cbxTempoEXP.Size = new System.Drawing.Size(153, 21);
            this.cbxTempoEXP.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tempo de Experiência";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nome";
            // 
            // mskbxSalario
            // 
            this.mskbxSalario.AsciiOnly = true;
            this.mskbxSalario.BeepOnError = true;
            this.mskbxSalario.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskbxSalario.Location = new System.Drawing.Point(141, 62);
            this.mskbxSalario.Mask = "0000";
            this.mskbxSalario.Name = "mskbxSalario";
            this.mskbxSalario.Size = new System.Drawing.Size(153, 20);
            this.mskbxSalario.TabIndex = 4;
            this.mskbxSalario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Salário pretendido ";
            // 
            // Form4
            // 
            this.AcceptButton = this.btnCandidatar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.mskbxSalario);
            this.Controls.Add(this.cbxTempoEXP);
            this.Controls.Add(this.txtLastJob);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDistancia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.cbxDistancia);
            this.Controls.Add(this.gbxSexo);
            this.Controls.Add(this.gbxEstadoCivil);
            this.Controls.Add(this.cbxIdade);
            this.Controls.Add(this.btnCandidatar);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtNome);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.gbxEstadoCivil.ResumeLayout(false);
            this.gbxEstadoCivil.PerformLayout();
            this.gbxSexo.ResumeLayout(false);
            this.gbxSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.RadioButton rbtnSolteiro;
        private System.Windows.Forms.CheckBox ckbxMasc;
        private System.Windows.Forms.Button btnCandidatar;
        private System.Windows.Forms.ComboBox cbxIdade;
        private System.Windows.Forms.GroupBox gbxEstadoCivil;
        private System.Windows.Forms.RadioButton rbtnCasado;
        private System.Windows.Forms.RadioButton rbtnViuvo;
        private System.Windows.Forms.RadioButton rbtnDesquitado;
        private System.Windows.Forms.RadioButton rbtnOutros;
        private System.Windows.Forms.RadioButton rbtnDivorciado;
        private System.Windows.Forms.GroupBox gbxSexo;
        private System.Windows.Forms.CheckBox ckbxFem;
        private System.Windows.Forms.ComboBox cbxDistancia;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblDistancia;
        private System.Windows.Forms.TextBox txtLastJob;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxTempoEXP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskbxSalario;
        private System.Windows.Forms.Label label4;
    }
}