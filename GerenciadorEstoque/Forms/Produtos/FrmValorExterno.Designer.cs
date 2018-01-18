namespace GerenciadorEstoque.Forms.Produtos
{
    partial class FrmValorExterno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmValorExterno));
            this.label1 = new System.Windows.Forms.Label();
            this.LbNomeMaterial = new System.Windows.Forms.Label();
            this.TxtValor = new System.Windows.Forms.TextBox();
            this.BtSalvar = new System.Windows.Forms.Button();
            this.BtCancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.LbUm = new System.Windows.Forms.Label();
            this.txtCodItem = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Material";
            // 
            // LbNomeMaterial
            // 
            this.LbNomeMaterial.Location = new System.Drawing.Point(93, 28);
            this.LbNomeMaterial.Name = "LbNomeMaterial";
            this.LbNomeMaterial.Size = new System.Drawing.Size(207, 44);
            this.LbNomeMaterial.TabIndex = 0;
            // 
            // TxtValor
            // 
            this.TxtValor.Location = new System.Drawing.Point(16, 75);
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.Size = new System.Drawing.Size(62, 20);
            this.TxtValor.TabIndex = 1;
            this.TxtValor.Validating += new System.ComponentModel.CancelEventHandler(this.TxtValor_Validating);
            // 
            // BtSalvar
            // 
            this.BtSalvar.Location = new System.Drawing.Point(231, 106);
            this.BtSalvar.Name = "BtSalvar";
            this.BtSalvar.Size = new System.Drawing.Size(62, 23);
            this.BtSalvar.TabIndex = 3;
            this.BtSalvar.Text = "Salvar";
            this.BtSalvar.UseVisualStyleBackColor = true;
            this.BtSalvar.Click += new System.EventHandler(this.BtSalvar_Click);
            // 
            // BtCancelar
            // 
            this.BtCancelar.Location = new System.Drawing.Point(163, 106);
            this.BtCancelar.Name = "BtCancelar";
            this.BtCancelar.Size = new System.Drawing.Size(62, 23);
            this.BtCancelar.TabIndex = 2;
            this.BtCancelar.Text = "Cancelar";
            this.BtCancelar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(16, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(281, 56);
            this.label4.TabIndex = 5;
            this.label4.Text = "OBS: Esse valor ficará disponível até que uma movimentação de estoque seja feita " +
    "com este item, neste momento o valor externo será apagado.";
            // 
            // LbUm
            // 
            this.LbUm.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LbUm.AutoSize = true;
            this.LbUm.Location = new System.Drawing.Point(84, 78);
            this.LbUm.Name = "LbUm";
            this.LbUm.Size = new System.Drawing.Size(31, 13);
            this.LbUm.TabIndex = 3;
            this.LbUm.Text = "Valor";
            // 
            // txtCodItem
            // 
            this.txtCodItem.Location = new System.Drawing.Point(16, 28);
            this.txtCodItem.Mask = "00\\.00\\.0000";
            this.txtCodItem.Name = "txtCodItem";
            this.txtCodItem.PromptChar = ' ';
            this.txtCodItem.Size = new System.Drawing.Size(68, 20);
            this.txtCodItem.TabIndex = 0;
            this.txtCodItem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCodItem_KeyDown);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "R$";
            // 
            // FrmValorExterno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 215);
            this.Controls.Add(this.txtCodItem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtCancelar);
            this.Controls.Add(this.BtSalvar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LbUm);
            this.Controls.Add(this.TxtValor);
            this.Controls.Add(this.LbNomeMaterial);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmValorExterno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criar valor externo";
            this.Load += new System.EventHandler(this.FrmValorExterno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbNomeMaterial;
        private System.Windows.Forms.TextBox TxtValor;
        private System.Windows.Forms.Button BtSalvar;
        private System.Windows.Forms.Button BtCancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LbUm;
        private System.Windows.Forms.MaskedTextBox txtCodItem;
        private System.Windows.Forms.Label label2;
    }
}