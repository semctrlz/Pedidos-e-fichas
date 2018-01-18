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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLevantamento));
            this.cbUnidade = new System.Windows.Forms.ComboBox();
            this.lbUnidade = new System.Windows.Forms.Label();
            this.BtCriar = new System.Windows.Forms.Button();
            this.TxtNumeroLevantamento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GbBase = new System.Windows.Forms.GroupBox();
            this.TxtObs = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GbItens = new System.Windows.Forms.GroupBox();
            this.PnItensDerivados = new System.Windows.Forms.Panel();
            this.BtnOk = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.LvMatDer = new System.Windows.Forms.ListView();
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
            this.BtEditar = new System.Windows.Forms.Button();
            this.BtBuscar = new System.Windows.Forms.Button();
            this.BtExcluir = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.del = new System.Windows.Forms.DataGridViewImageColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.GbBase.SuspendLayout();
            this.GbItens.SuspendLayout();
            this.PnItensDerivados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvItens)).BeginInit();
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
            this.BtCriar.Image = global::GerenciadorEstoque.Properties.Resources.plus2x;
            this.BtCriar.Location = new System.Drawing.Point(532, 82);
            this.BtCriar.Name = "BtCriar";
            this.BtCriar.Size = new System.Drawing.Size(26, 26);
            this.BtCriar.TabIndex = 1;
            this.BtCriar.UseVisualStyleBackColor = true;
            this.BtCriar.Click += new System.EventHandler(this.BtCriar_Click);
            // 
            // TxtNumeroLevantamento
            // 
            this.TxtNumeroLevantamento.Enabled = false;
            this.TxtNumeroLevantamento.Location = new System.Drawing.Point(436, 47);
            this.TxtNumeroLevantamento.Name = "TxtNumeroLevantamento";
            this.TxtNumeroLevantamento.Size = new System.Drawing.Size(53, 20);
            this.TxtNumeroLevantamento.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(433, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nº";
            // 
            // GbBase
            // 
            this.GbBase.Controls.Add(this.TxtObs);
            this.GbBase.Controls.Add(this.label2);
            this.GbBase.Controls.Add(this.lbUnidade);
            this.GbBase.Controls.Add(this.TxtNumeroLevantamento);
            this.GbBase.Controls.Add(this.label7);
            this.GbBase.Controls.Add(this.label6);
            this.GbBase.Controls.Add(this.label1);
            this.GbBase.Controls.Add(this.BtExcluir);
            this.GbBase.Controls.Add(this.BtBuscar);
            this.GbBase.Controls.Add(this.BtEditar);
            this.GbBase.Controls.Add(this.BtCriar);
            this.GbBase.Controls.Add(this.cbUnidade);
            this.GbBase.Dock = System.Windows.Forms.DockStyle.Top;
            this.GbBase.Location = new System.Drawing.Point(0, 0);
            this.GbBase.Name = "GbBase";
            this.GbBase.Size = new System.Drawing.Size(580, 122);
            this.GbBase.TabIndex = 15;
            this.GbBase.TabStop = false;
            // 
            // TxtObs
            // 
            this.TxtObs.Location = new System.Drawing.Point(65, 50);
            this.TxtObs.MaxLength = 140;
            this.TxtObs.Multiline = true;
            this.TxtObs.Name = "TxtObs";
            this.TxtObs.Size = new System.Drawing.Size(365, 58);
            this.TxtObs.TabIndex = 0;
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
            // GbItens
            // 
            this.GbItens.Controls.Add(this.button1);
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
            this.GbItens.Size = new System.Drawing.Size(580, 516);
            this.GbItens.TabIndex = 16;
            this.GbItens.TabStop = false;
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
            // BtnOk
            // 
            this.BtnOk.Location = new System.Drawing.Point(302, 326);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(106, 23);
            this.BtnOk.TabIndex = 21;
            this.BtnOk.Text = "Ok";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(192, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Selecione as alternativas desse produto";
            // 
            // LvMatDer
            // 
            this.LvMatDer.Location = new System.Drawing.Point(170, 45);
            this.LvMatDer.MultiSelect = false;
            this.LvMatDer.Name = "LvMatDer";
            this.LvMatDer.Size = new System.Drawing.Size(238, 274);
            this.LvMatDer.TabIndex = 19;
            this.LvMatDer.UseCompatibleStateImageBehavior = false;
            this.LvMatDer.View = System.Windows.Forms.View.List;
            // 
            // CbUm
            // 
            this.CbUm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbUm.FormattingEnabled = true;
            this.CbUm.Location = new System.Drawing.Point(479, 32);
            this.CbUm.Name = "CbUm";
            this.CbUm.Size = new System.Drawing.Size(61, 21);
            this.CbUm.TabIndex = 3;
            // 
            // DgvItens
            // 
            this.DgvItens.AllowUserToAddRows = false;
            this.DgvItens.AllowUserToDeleteRows = false;
            this.DgvItens.AllowUserToResizeColumns = false;
            this.DgvItens.AllowUserToResizeRows = false;
            this.DgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nome,
            this.UM,
            this.QUANT,
            this.del});
            this.DgvItens.Location = new System.Drawing.Point(9, 59);
            this.DgvItens.Name = "DgvItens";
            this.DgvItens.ReadOnly = true;
            this.DgvItens.RowHeadersVisible = false;
            this.DgvItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvItens.Size = new System.Drawing.Size(561, 412);
            this.DgvItens.TabIndex = 18;
            this.DgvItens.SelectionChanged += new System.EventHandler(this.DgvItens_SelectionChanged);
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
            this.BtAddItem.Click += new System.EventHandler(this.BtAddItem_Click);
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
            this.label4.Location = new System.Drawing.Point(408, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Quantidade";
            // 
            // lbUm
            // 
            this.lbUm.AutoSize = true;
            this.lbUm.Enabled = false;
            this.lbUm.Location = new System.Drawing.Point(475, 16);
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
            this.txtQuant.Location = new System.Drawing.Point(411, 32);
            this.txtQuant.Name = "txtQuant";
            this.txtQuant.Size = new System.Drawing.Size(62, 20);
            this.txtQuant.TabIndex = 2;
            // 
            // BtEditar
            // 
            this.BtEditar.Image = global::GerenciadorEstoque.Properties.Resources.pencil2x;
            this.BtEditar.Location = new System.Drawing.Point(500, 82);
            this.BtEditar.Name = "BtEditar";
            this.BtEditar.Size = new System.Drawing.Size(26, 26);
            this.BtEditar.TabIndex = 2;
            this.BtEditar.UseVisualStyleBackColor = true;
            this.BtEditar.Click += new System.EventHandler(this.BtCriar_Click);
            // 
            // BtBuscar
            // 
            this.BtBuscar.Image = global::GerenciadorEstoque.Properties.Resources.magnifyingGlass2x;
            this.BtBuscar.Location = new System.Drawing.Point(468, 82);
            this.BtBuscar.Name = "BtBuscar";
            this.BtBuscar.Size = new System.Drawing.Size(26, 26);
            this.BtBuscar.TabIndex = 3;
            this.BtBuscar.UseVisualStyleBackColor = true;
            this.BtBuscar.Click += new System.EventHandler(this.BtBuscar_Click);
            // 
            // BtExcluir
            // 
            this.BtExcluir.Image = global::GerenciadorEstoque.Properties.Resources.trash2x;
            this.BtExcluir.Location = new System.Drawing.Point(436, 82);
            this.BtExcluir.Name = "BtExcluir";
            this.BtExcluir.Size = new System.Drawing.Size(26, 26);
            this.BtExcluir.TabIndex = 4;
            this.BtExcluir.UseVisualStyleBackColor = true;
            this.BtExcluir.Click += new System.EventHandler(this.BtCriar_Click);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // nome
            // 
            this.nome.HeaderText = "NOME";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 350;
            // 
            // UM
            // 
            this.UM.HeaderText = "UM";
            this.UM.Name = "UM";
            this.UM.ReadOnly = true;
            this.UM.Width = 60;
            // 
            // QUANT
            // 
            this.QUANT.HeaderText = "QUANT";
            this.QUANT.Name = "QUANT";
            this.QUANT.ReadOnly = true;
            // 
            // del
            // 
            this.del.HeaderText = "DEL";
            this.del.Image = global::GerenciadorEstoque.Properties.Resources.trash2x;
            this.del.Name = "del";
            this.del.ReadOnly = true;
            this.del.Width = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(504, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Status";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(504, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Inicial";
            // 
            // button1
            // 
            this.button1.Image = global::GerenciadorEstoque.Properties.Resources.circleCheck2x;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(459, 478);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 26);
            this.button1.TabIndex = 21;
            this.button1.Text = "Gerar cotações";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmLevantamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 638);
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
            this.PnItensDerivados.ResumeLayout(false);
            this.PnItensDerivados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvItens)).EndInit();
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
        private System.Windows.Forms.Button BtExcluir;
        private System.Windows.Forms.Button BtBuscar;
        private System.Windows.Forms.Button BtEditar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn UM;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANT;
        private System.Windows.Forms.DataGridViewImageColumn del;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}