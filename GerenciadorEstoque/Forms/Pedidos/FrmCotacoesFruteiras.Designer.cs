namespace GerenciadorEstoque.Forms.Pedidos
{
    partial class FrmCotacoesFruteiras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCotacoesFruteiras));
            this.TxtCodFornecedor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CbUnidade = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DtpData = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.DgvItens = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCotacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Del = new System.Windows.Forms.DataGridViewImageColumn();
            this.TxtCodItem = new System.Windows.Forms.MaskedTextBox();
            this.TxtNomeItem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNomeForn = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.CbUm = new System.Windows.Forms.ComboBox();
            this.TxtCusto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CbxTodasUnidades = new System.Windows.Forms.CheckBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.BtAddItem = new System.Windows.Forms.Button();
            this.BtClonarCotacao = new System.Windows.Forms.Button();
            this.GbItens = new System.Windows.Forms.GroupBox();
            this.TxtItensAExcluir = new System.Windows.Forms.TextBox();
            this.BtSalvar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvItens)).BeginInit();
            this.GbItens.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtCodFornecedor
            // 
            this.TxtCodFornecedor.Location = new System.Drawing.Point(12, 78);
            this.TxtCodFornecedor.Name = "TxtCodFornecedor";
            this.TxtCodFornecedor.Size = new System.Drawing.Size(61, 20);
            this.TxtCodFornecedor.TabIndex = 1;
            this.TxtCodFornecedor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCodFornecedor_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Unidade";
            // 
            // CbUnidade
            // 
            this.CbUnidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbUnidade.FormattingEnabled = true;
            this.CbUnidade.Location = new System.Drawing.Point(12, 21);
            this.CbUnidade.Name = "CbUnidade";
            this.CbUnidade.Size = new System.Drawing.Size(137, 21);
            this.CbUnidade.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cod. Forn.";
            // 
            // DtpData
            // 
            this.DtpData.Enabled = false;
            this.DtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpData.Location = new System.Drawing.Point(363, 78);
            this.DtpData.Name = "DtpData";
            this.DtpData.Size = new System.Drawing.Size(105, 20);
            this.DtpData.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(360, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Data";
            // 
            // DgvItens
            // 
            this.DgvItens.AllowUserToAddRows = false;
            this.DgvItens.AllowUserToDeleteRows = false;
            this.DgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.idCotacao,
            this.Desc,
            this.UM,
            this.Valor,
            this.Del});
            this.DgvItens.Location = new System.Drawing.Point(9, 108);
            this.DgvItens.Name = "DgvItens";
            this.DgvItens.RowHeadersVisible = false;
            this.DgvItens.Size = new System.Drawing.Size(456, 380);
            this.DgvItens.TabIndex = 9;
            this.DgvItens.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvItens_CellClick);
            this.DgvItens.SelectionChanged += new System.EventHandler(this.DgvItens_SelectionChanged);
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Codigo";
            this.codigo.Name = "codigo";
            this.codigo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.codigo.Visible = false;
            this.codigo.Width = 40;
            // 
            // idCotacao
            // 
            this.idCotacao.HeaderText = "id";
            this.idCotacao.Name = "idCotacao";
            this.idCotacao.Visible = false;
            // 
            // Desc
            // 
            this.Desc.HeaderText = "Desc";
            this.Desc.Name = "Desc";
            this.Desc.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Desc.Width = 250;
            // 
            // UM
            // 
            this.UM.HeaderText = "U.M.";
            this.UM.Name = "UM";
            this.UM.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.UM.Width = 60;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Del
            // 
            this.Del.HeaderText = "";
            this.Del.Image = global::GerenciadorEstoque.Properties.Resources.trash2x;
            this.Del.Name = "Del";
            this.Del.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Del.Width = 26;
            // 
            // TxtCodItem
            // 
            this.TxtCodItem.Location = new System.Drawing.Point(9, 80);
            this.TxtCodItem.Mask = "00\\.00\\.0000";
            this.TxtCodItem.Name = "TxtCodItem";
            this.TxtCodItem.Size = new System.Drawing.Size(73, 20);
            this.TxtCodItem.TabIndex = 6;
            this.TxtCodItem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCodItem_KeyDown);
            // 
            // TxtNomeItem
            // 
            this.TxtNomeItem.Enabled = false;
            this.TxtNomeItem.Location = new System.Drawing.Point(89, 81);
            this.TxtNomeItem.Name = "TxtNomeItem";
            this.TxtNomeItem.Size = new System.Drawing.Size(233, 20);
            this.TxtNomeItem.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Codigo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(86, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Nome";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(326, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "U.M.";
            // 
            // txtNomeForn
            // 
            this.txtNomeForn.Enabled = false;
            this.txtNomeForn.Location = new System.Drawing.Point(79, 78);
            this.txtNomeForn.Name = "txtNomeForn";
            this.txtNomeForn.Size = new System.Drawing.Size(278, 20);
            this.txtNomeForn.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(79, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Nome";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(9, 32);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(105, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Início vigência";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(120, 32);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(105, 20);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(117, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Fim vigência";
            // 
            // CbUm
            // 
            this.CbUm.FormattingEnabled = true;
            this.CbUm.Location = new System.Drawing.Point(329, 80);
            this.CbUm.Name = "CbUm";
            this.CbUm.Size = new System.Drawing.Size(48, 21);
            this.CbUm.TabIndex = 8;
            this.CbUm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CbUm_KeyDown);
            this.CbUm.Leave += new System.EventHandler(this.CbUm_Leave);
            // 
            // TxtCusto
            // 
            this.TxtCusto.Enabled = false;
            this.TxtCusto.Location = new System.Drawing.Point(383, 82);
            this.TxtCusto.Name = "TxtCusto";
            this.TxtCusto.Size = new System.Drawing.Size(50, 20);
            this.TxtCusto.TabIndex = 9;
            this.TxtCusto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CbUm_KeyDown);
            this.TxtCusto.Validating += new System.ComponentModel.CancelEventHandler(this.TxtCusto_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(380, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Custo";
            // 
            // CbxTodasUnidades
            // 
            this.CbxTodasUnidades.AutoSize = true;
            this.CbxTodasUnidades.Checked = true;
            this.CbxTodasUnidades.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbxTodasUnidades.Location = new System.Drawing.Point(156, 21);
            this.CbxTodasUnidades.Name = "CbxTodasUnidades";
            this.CbxTodasUnidades.Size = new System.Drawing.Size(116, 17);
            this.CbxTodasUnidades.TabIndex = 18;
            this.CbxTodasUnidades.Text = "Todas as unidades";
            this.CbxTodasUnidades.UseVisualStyleBackColor = true;
            this.CbxTodasUnidades.CheckedChanged += new System.EventHandler(this.CbxTodasUnidades_CheckedChanged);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::GerenciadorEstoque.Properties.Resources.trash2x;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn1.Width = 26;
            // 
            // BtAddItem
            // 
            this.BtAddItem.BackgroundImage = global::GerenciadorEstoque.Properties.Resources.arrowCircleBottom2x;
            this.BtAddItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtAddItem.Location = new System.Drawing.Point(439, 78);
            this.BtAddItem.Name = "BtAddItem";
            this.BtAddItem.Size = new System.Drawing.Size(26, 26);
            this.BtAddItem.TabIndex = 10;
            this.BtAddItem.UseVisualStyleBackColor = true;
            this.BtAddItem.Click += new System.EventHandler(this.BtAddItem_Click);
            // 
            // BtClonarCotacao
            // 
            this.BtClonarCotacao.Enabled = false;
            this.BtClonarCotacao.Location = new System.Drawing.Point(342, 10);
            this.BtClonarCotacao.Name = "BtClonarCotacao";
            this.BtClonarCotacao.Size = new System.Drawing.Size(123, 23);
            this.BtClonarCotacao.TabIndex = 19;
            this.BtClonarCotacao.Text = "Clonar última cotação";
            this.BtClonarCotacao.UseVisualStyleBackColor = true;
            // 
            // GbItens
            // 
            this.GbItens.Controls.Add(this.TxtItensAExcluir);
            this.GbItens.Controls.Add(this.BtSalvar);
            this.GbItens.Controls.Add(this.label10);
            this.GbItens.Controls.Add(this.BtClonarCotacao);
            this.GbItens.Controls.Add(this.label6);
            this.GbItens.Controls.Add(this.label7);
            this.GbItens.Controls.Add(this.TxtCusto);
            this.GbItens.Controls.Add(this.label8);
            this.GbItens.Controls.Add(this.label4);
            this.GbItens.Controls.Add(this.BtAddItem);
            this.GbItens.Controls.Add(this.CbUm);
            this.GbItens.Controls.Add(this.DgvItens);
            this.GbItens.Controls.Add(this.dateTimePicker2);
            this.GbItens.Controls.Add(this.TxtCodItem);
            this.GbItens.Controls.Add(this.label11);
            this.GbItens.Controls.Add(this.TxtNomeItem);
            this.GbItens.Controls.Add(this.dateTimePicker1);
            this.GbItens.Enabled = false;
            this.GbItens.Location = new System.Drawing.Point(12, 104);
            this.GbItens.Name = "GbItens";
            this.GbItens.Size = new System.Drawing.Size(476, 529);
            this.GbItens.TabIndex = 20;
            this.GbItens.TabStop = false;
            // 
            // TxtItensAExcluir
            // 
            this.TxtItensAExcluir.Location = new System.Drawing.Point(9, 495);
            this.TxtItensAExcluir.Name = "TxtItensAExcluir";
            this.TxtItensAExcluir.Size = new System.Drawing.Size(100, 20);
            this.TxtItensAExcluir.TabIndex = 22;
            // 
            // BtSalvar
            // 
            this.BtSalvar.Image = global::GerenciadorEstoque.Properties.Resources.circleCheck2x;
            this.BtSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtSalvar.Location = new System.Drawing.Point(390, 494);
            this.BtSalvar.Name = "BtSalvar";
            this.BtSalvar.Size = new System.Drawing.Size(75, 26);
            this.BtSalvar.TabIndex = 21;
            this.BtSalvar.Text = "Salvar";
            this.BtSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtSalvar.UseVisualStyleBackColor = true;
            this.BtSalvar.Click += new System.EventHandler(this.BtSalvar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(278, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(103, 20);
            this.textBox1.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(275, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Número cotação";
            // 
            // FrmCotacoesFruteiras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 644);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.GbItens);
            this.Controls.Add(this.CbxTodasUnidades);
            this.Controls.Add(this.DtpData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CbUnidade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomeForn);
            this.Controls.Add(this.TxtCodFornecedor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCotacoesFruteiras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cotação Fruteiras";
            this.Load += new System.EventHandler(this.FrmCotacoesFruteiras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvItens)).EndInit();
            this.GbItens.ResumeLayout(false);
            this.GbItens.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtCodFornecedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbUnidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DtpData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DgvItens;
        private System.Windows.Forms.MaskedTextBox TxtCodItem;
        private System.Windows.Forms.TextBox TxtNomeItem;
        private System.Windows.Forms.Button BtAddItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNomeForn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox CbUm;
        private System.Windows.Forms.TextBox TxtCusto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox CbxTodasUnidades;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Button BtClonarCotacao;
        private System.Windows.Forms.GroupBox GbItens;
        private System.Windows.Forms.Button BtSalvar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCotacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn UM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewImageColumn Del;
        private System.Windows.Forms.TextBox TxtItensAExcluir;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
    }
}