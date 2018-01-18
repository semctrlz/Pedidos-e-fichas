namespace GerenciadorEstoque.Forms.Pedidos
{
    partial class FrmLevantamento
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Opção 01");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Item 02 onde aparece ");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLevantamento));
            this.cbUnidade = new System.Windows.Forms.ComboBox();
            this.lbUnidade = new System.Windows.Forms.Label();
            this.BtCriar = new System.Windows.Forms.Button();
            this.TxtNumeroLevantamento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GbBase = new System.Windows.Forms.GroupBox();
            this.GbItens = new System.Windows.Forms.GroupBox();
            this.CbUm = new System.Windows.Forms.ComboBox();
            this.DgvItens = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.BtAddItem = new System.Windows.Forms.Button();
            this.txtCodItem = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbUm = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtNomeItem = new System.Windows.Forms.TextBox();
            this.txtQuant = new System.Windows.Forms.TextBox();
            this.TxtObs = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LvMatDer = new System.Windows.Forms.ListView();
            this.PnItensDerivados = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnOk = new System.Windows.Forms.Button();
            this.GbBase.SuspendLayout();
            this.GbItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvItens)).BeginInit();
            this.PnItensDerivados.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbUnidade
            // 
            this.cbUnidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUnidade.FormattingEnabled = true;
            this.cbUnidade.Location = new System.Drawing.Point(65, 23);
            this.cbUnidade.Name = "cbUnidade";
            this.cbUnidade.Size = new System.Drawing.Size(116, 21);
            this.cbUnidade.TabIndex = 0;
            // 
            // lbUnidade
            // 
            this.lbUnidade.AutoSize = true;
            this.lbUnidade.Location = new System.Drawing.Point(12, 26);
            this.lbUnidade.Name = "lbUnidade";
            this.lbUnidade.Size = new System.Drawing.Size(47, 13);
            this.lbUnidade.TabIndex = 11;
            this.lbUnidade.Text = "Unidade";
            // 
            // BtCriar
            // 
            this.BtCriar.Location = new System.Drawing.Point(446, 85);
            this.BtCriar.Name = "BtCriar";
            this.BtCriar.Size = new System.Drawing.Size(124, 23);
            this.BtCriar.TabIndex = 2;
            this.BtCriar.Text = "Criar levantamento";
            this.BtCriar.UseVisualStyleBackColor = true;
            this.BtCriar.Click += new System.EventHandler(this.BtCriar_Click);
            // 
            // TxtNumeroLevantamento
            // 
            this.TxtNumeroLevantamento.Enabled = false;
            this.TxtNumeroLevantamento.Location = new System.Drawing.Point(458, 47);
            this.TxtNumeroLevantamento.Name = "TxtNumeroLevantamento";
            this.TxtNumeroLevantamento.Size = new System.Drawing.Size(100, 20);
            this.TxtNumeroLevantamento.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(463, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Levantamento:";
            // 
            // GbBase
            // 
            this.GbBase.Controls.Add(this.TxtObs);
            this.GbBase.Controls.Add(this.label2);
            this.GbBase.Controls.Add(this.lbUnidade);
            this.GbBase.Controls.Add(this.TxtNumeroLevantamento);
            this.GbBase.Controls.Add(this.label1);
            this.GbBase.Controls.Add(this.BtCriar);
            this.GbBase.Controls.Add(this.cbUnidade);
            this.GbBase.Dock = System.Windows.Forms.DockStyle.Top;
            this.GbBase.Location = new System.Drawing.Point(0, 0);
            this.GbBase.Name = "GbBase";
            this.GbBase.Size = new System.Drawing.Size(579, 122);
            this.GbBase.TabIndex = 15;
            this.GbBase.TabStop = false;
            // 
            // GbItens
            // 
            this.GbItens.Controls.Add(this.PnItensDerivados);
            this.GbItens.Controls.Add(this.CbUm);
            this.GbItens.Controls.Add(this.DgvItens);
            this.GbItens.Controls.Add(this.label3);
            this.GbItens.Controls.Add(this.BtAddItem);
            this.GbItens.Controls.Add(this.txtCodItem);
            this.GbItens.Controls.Add(this.label4);
            this.GbItens.Controls.Add(this.lbUm);
            this.GbItens.Controls.Add(this.label15);
            this.GbItens.Controls.Add(this.txtNomeItem);
            this.GbItens.Controls.Add(this.txtQuant);
            this.GbItens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GbItens.Location = new System.Drawing.Point(0, 122);
            this.GbItens.Name = "GbItens";
            this.GbItens.Size = new System.Drawing.Size(579, 516);
            this.GbItens.TabIndex = 16;
            this.GbItens.TabStop = false;
            // 
            // CbUm
            // 
            this.CbUm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbUm.FormattingEnabled = true;
            this.CbUm.Location = new System.Drawing.Point(411, 31);
            this.CbUm.Name = "CbUm";
            this.CbUm.Size = new System.Drawing.Size(61, 21);
            this.CbUm.TabIndex = 2;
            // 
            // DgvItens
            // 
            this.DgvItens.AllowUserToAddRows = false;
            this.DgvItens.AllowUserToDeleteRows = false;
            this.DgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvItens.Location = new System.Drawing.Point(9, 59);
            this.DgvItens.Name = "DgvItens";
            this.DgvItens.ReadOnly = true;
            this.DgvItens.Size = new System.Drawing.Size(561, 445);
            this.DgvItens.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Item";
            // 
            // BtAddItem
            // 
            this.BtAddItem.Enabled = false;
            this.BtAddItem.Image = global::GerenciadorEstoque.Properties.Resources.arrowCircleBottom2x;
            this.BtAddItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtAddItem.Location = new System.Drawing.Point(546, 29);
            this.BtAddItem.Name = "BtAddItem";
            this.BtAddItem.Size = new System.Drawing.Size(24, 24);
            this.BtAddItem.TabIndex = 4;
            this.BtAddItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtAddItem.UseVisualStyleBackColor = true;
            // 
            // txtCodItem
            // 
            this.txtCodItem.Location = new System.Drawing.Point(9, 32);
            this.txtCodItem.Mask = "00\\.00\\.0000";
            this.txtCodItem.Name = "txtCodItem";
            this.txtCodItem.PromptChar = ' ';
            this.txtCodItem.Size = new System.Drawing.Size(68, 20);
            this.txtCodItem.TabIndex = 0;
            this.txtCodItem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCodItem_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(475, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Quantidade";
            // 
            // lbUm
            // 
            this.lbUm.AutoSize = true;
            this.lbUm.Enabled = false;
            this.lbUm.Location = new System.Drawing.Point(407, 15);
            this.lbUm.Name = "lbUm";
            this.lbUm.Size = new System.Drawing.Size(30, 13);
            this.lbUm.TabIndex = 12;
            this.lbUm.Text = "U.M.";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Enabled = false;
            this.label15.Location = new System.Drawing.Point(80, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.TabIndex = 13;
            this.label15.Text = "Nome";
            // 
            // txtNomeItem
            // 
            this.txtNomeItem.Enabled = false;
            this.txtNomeItem.Location = new System.Drawing.Point(83, 32);
            this.txtNomeItem.Name = "txtNomeItem";
            this.txtNomeItem.Size = new System.Drawing.Size(322, 20);
            this.txtNomeItem.TabIndex = 1;
            // 
            // txtQuant
            // 
            this.txtQuant.Location = new System.Drawing.Point(478, 32);
            this.txtQuant.Name = "txtQuant";
            this.txtQuant.Size = new System.Drawing.Size(62, 20);
            this.txtQuant.TabIndex = 3;
            // 
            // TxtObs
            // 
            this.TxtObs.Location = new System.Drawing.Point(65, 50);
            this.TxtObs.MaxLength = 140;
            this.TxtObs.Multiline = true;
            this.TxtObs.Name = "TxtObs";
            this.TxtObs.Size = new System.Drawing.Size(375, 58);
            this.TxtObs.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Obs";
            // 
            // LvMatDer
            // 
            this.LvMatDer.CheckBoxes = true;
            listViewItem1.StateImageIndex = 0;
            listViewItem2.StateImageIndex = 0;
            listViewItem3.StateImageIndex = 0;
            listViewItem4.StateImageIndex = 0;
            listViewItem5.StateImageIndex = 0;
            this.LvMatDer.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5});
            this.LvMatDer.Location = new System.Drawing.Point(170, 45);
            this.LvMatDer.Name = "LvMatDer";
            this.LvMatDer.Size = new System.Drawing.Size(238, 274);
            this.LvMatDer.TabIndex = 19;
            this.LvMatDer.UseCompatibleStateImageBehavior = false;
            this.LvMatDer.View = System.Windows.Forms.View.List;
            // 
            // PnItensDerivados
            // 
            this.PnItensDerivados.Controls.Add(this.BtnOk);
            this.PnItensDerivados.Controls.Add(this.BtnCancelar);
            this.PnItensDerivados.Controls.Add(this.label5);
            this.PnItensDerivados.Controls.Add(this.LvMatDer);
            this.PnItensDerivados.Location = new System.Drawing.Point(576, 59);
            this.PnItensDerivados.Name = "PnItensDerivados";
            this.PnItensDerivados.Size = new System.Drawing.Size(561, 445);
            this.PnItensDerivados.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(192, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Selecione as alternativas desse produto";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(170, 326);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(106, 23);
            this.BtnCancelar.TabIndex = 21;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnOk
            // 
            this.BtnOk.Location = new System.Drawing.Point(302, 326);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(106, 23);
            this.BtnOk.TabIndex = 21;
            this.BtnOk.Text = "Ok";
            this.BtnOk.UseVisualStyleBackColor = true;
            // 
            // FrmLevantamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 638);
            this.Controls.Add(this.GbItens);
            this.Controls.Add(this.GbBase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmLevantamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Levantamento";
            this.Load += new System.EventHandler(this.FrmLevantamento_Load);
            this.GbBase.ResumeLayout(false);
            this.GbBase.PerformLayout();
            this.GbItens.ResumeLayout(false);
            this.GbItens.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvItens)).EndInit();
            this.PnItensDerivados.ResumeLayout(false);
            this.PnItensDerivados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbUnidade;
        private System.Windows.Forms.Label lbUnidade;
        private System.Windows.Forms.Button BtCriar;
        private System.Windows.Forms.TextBox TxtNumeroLevantamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GbBase;
        private System.Windows.Forms.GroupBox GbItens;
        private System.Windows.Forms.ComboBox CbUm;
        private System.Windows.Forms.DataGridView DgvItens;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtAddItem;
        private System.Windows.Forms.MaskedTextBox txtCodItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbUm;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtNomeItem;
        private System.Windows.Forms.TextBox txtQuant;
        private System.Windows.Forms.TextBox TxtObs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel PnItensDerivados;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView LvMatDer;
    }
}