namespace WindowsFormsApp1
{
    partial class Form5
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
            this.txtDe = new System.Windows.Forms.TextBox();
            this.txtPara = new System.Windows.Forms.TextBox();
            this.cbxTipoConversao = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDe
            // 
            this.txtDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtDe.Location = new System.Drawing.Point(16, 111);
            this.txtDe.Name = "txtDe";
            this.txtDe.Size = new System.Drawing.Size(150, 23);
            this.txtDe.TabIndex = 1;
            // 
            // txtPara
            // 
            this.txtPara.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPara.Location = new System.Drawing.Point(202, 111);
            this.txtPara.Name = "txtPara";
            this.txtPara.Size = new System.Drawing.Size(150, 23);
            this.txtPara.TabIndex = 2;
            // 
            // cbxTipoConversao
            // 
            this.cbxTipoConversao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxTipoConversao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoConversao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxTipoConversao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbxTipoConversao.FormattingEnabled = true;
            this.cbxTipoConversao.Items.AddRange(new object[] {
            "De Arroba para Quilo",
            "De Libra para Quilo",
            "De Onça para Grama",
            "De Acre para Hectare",
            "De Hectare para Metro Quadrado",
            "De AlqueireMG para Hectare",
            "De AlqueireSP para Hectare",
            "De AlqueireNorte para Hectare",
            "De Braça para Metro",
            "De Jarda para Metro",
            "De Pé para Centímetro",
            "De Polegada para Centímetro",
            "De Milha para Quilometro"});
            this.cbxTipoConversao.Location = new System.Drawing.Point(12, 34);
            this.cbxTipoConversao.Name = "cbxTipoConversao";
            this.cbxTipoConversao.Size = new System.Drawing.Size(360, 24);
            this.cbxTipoConversao.TabIndex = 0;
            this.cbxTipoConversao.TabStop = false;
            this.cbxTipoConversao.SelectedIndexChanged += new System.EventHandler(this.CbxTipoConversao_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Selecione o Tipo de Conversão:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "De:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(199, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Para:";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxTipoConversao);
            this.Controls.Add(this.txtPara);
            this.Controls.Add(this.txtDe);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDe;
        private System.Windows.Forms.TextBox txtPara;
        private System.Windows.Forms.ComboBox cbxTipoConversao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}