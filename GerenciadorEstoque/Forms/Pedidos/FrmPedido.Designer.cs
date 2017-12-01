namespace GerenciadorEstoque.Forms.Pedidos
{
    partial class FrmPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPedido));
            this.TxtObs = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CbUm = new System.Windows.Forms.ComboBox();
            this.DtpDataEntrega = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtNomeItem = new System.Windows.Forms.TextBox();
            this.TxtCodItem = new System.Windows.Forms.MaskedTextBox();
            this.DgvItens = new System.Windows.Forms.DataGridView();
            this.id_itemPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDDer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_um = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Del = new System.Windows.Forms.DataGridViewImageColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CbUnidade = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.BtAddItem = new System.Windows.Forms.Button();
            this.CbSetores = new System.Windows.Forms.ComboBox();
            this.TxtObsSetor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.GbItens = new System.Windows.Forms.GroupBox();
            this.GbSetores = new System.Windows.Forms.GroupBox();
            this.BtEditaSetor = new System.Windows.Forms.Button();
            this.TxtIdMaterial = new System.Windows.Forms.TextBox();
            this.BtCancelar = new System.Windows.Forms.Button();
            this.BtExcluir = new System.Windows.Forms.Button();
            this.TxtItensACancelar = new System.Windows.Forms.TextBox();
            this.BtSalvarItensSetor = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtQuant = new System.Windows.Forms.TextBox();
            this.TxtIdPedido = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DgvSetores = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.BtAdicionaSetor = new System.Windows.Forms.Button();
            this.BtCriarCotacao = new System.Windows.Forms.Button();
            this.TxtObsPedido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GbPedido = new System.Windows.Forms.GroupBox();
            this.BtEdita = new System.Windows.Forms.Button();
            this.BtCancelarPedido = new System.Windows.Forms.Button();
            this.BtExcluirPedido = new System.Windows.Forms.Button();
            this.BtSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvItens)).BeginInit();
            this.GbItens.SuspendLayout();
            this.GbSetores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSetores)).BeginInit();
            this.GbPedido.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtObs
            // 
            this.TxtObs.Location = new System.Drawing.Point(386, 93);
            this.TxtObs.MaxLength = 65;
            this.TxtObs.Name = "TxtObs";
            this.TxtObs.Size = new System.Drawing.Size(147, 20);
            this.TxtObs.TabIndex = 6;
            this.TxtObs.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtObs_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(383, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "OBS";
            // 
            // CbUm
            // 
            this.CbUm.FormattingEnabled = true;
            this.CbUm.Location = new System.Drawing.Point(332, 92);
            this.CbUm.Name = "CbUm";
            this.CbUm.Size = new System.Drawing.Size(48, 21);
            this.CbUm.TabIndex = 5;
            this.CbUm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtObs_KeyDown);
            this.CbUm.Leave += new System.EventHandler(this.CbUm_Leave);
            // 
            // DtpDataEntrega
            // 
            this.DtpDataEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDataEntrega.Location = new System.Drawing.Point(91, 35);
            this.DtpDataEntrega.Name = "DtpDataEntrega";
            this.DtpDataEntrega.Size = new System.Drawing.Size(105, 20);
            this.DtpDataEntrega.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(88, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 40;
            this.label11.Text = "Data entrega";
            // 
            // TxtNomeItem
            // 
            this.TxtNomeItem.Enabled = false;
            this.TxtNomeItem.Location = new System.Drawing.Point(86, 93);
            this.TxtNomeItem.Name = "TxtNomeItem";
            this.TxtNomeItem.Size = new System.Drawing.Size(166, 20);
            this.TxtNomeItem.TabIndex = 3;
            // 
            // TxtCodItem
            // 
            this.TxtCodItem.Location = new System.Drawing.Point(6, 93);
            this.TxtCodItem.Mask = "00\\.00\\.0000";
            this.TxtCodItem.Name = "TxtCodItem";
            this.TxtCodItem.Size = new System.Drawing.Size(73, 20);
            this.TxtCodItem.TabIndex = 2;
            this.TxtCodItem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCodItem_KeyDown);
            // 
            // DgvItens
            // 
            this.DgvItens.AllowUserToAddRows = false;
            this.DgvItens.AllowUserToDeleteRows = false;
            this.DgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_itemPedido,
            this.IDDer,
            this.CodItem,
            this.Desc,
            this.id_um,
            this.UM,
            this.Quant,
            this.Valor,
            this.Del});
            this.DgvItens.Location = new System.Drawing.Point(7, 121);
            this.DgvItens.Name = "DgvItens";
            this.DgvItens.ReadOnly = true;
            this.DgvItens.RowHeadersVisible = false;
            this.DgvItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvItens.Size = new System.Drawing.Size(559, 370);
            this.DgvItens.TabIndex = 36;
            this.DgvItens.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvItens_CellClick);
            this.DgvItens.SelectionChanged += new System.EventHandler(this.DgvItens_SelectionChanged);
            // 
            // id_itemPedido
            // 
            this.id_itemPedido.HeaderText = "ID_ItemPedido";
            this.id_itemPedido.Name = "id_itemPedido";
            this.id_itemPedido.ReadOnly = true;
            this.id_itemPedido.Visible = false;
            // 
            // IDDer
            // 
            this.IDDer.HeaderText = "id_item";
            this.IDDer.Name = "IDDer";
            this.IDDer.ReadOnly = true;
            this.IDDer.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.IDDer.Visible = false;
            this.IDDer.Width = 40;
            // 
            // CodItem
            // 
            this.CodItem.HeaderText = "Codigo";
            this.CodItem.Name = "CodItem";
            this.CodItem.ReadOnly = true;
            this.CodItem.Visible = false;
            // 
            // Desc
            // 
            this.Desc.HeaderText = "ITEM";
            this.Desc.Name = "Desc";
            this.Desc.ReadOnly = true;
            this.Desc.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Desc.Width = 200;
            // 
            // id_um
            // 
            this.id_um.HeaderText = "id_um";
            this.id_um.Name = "id_um";
            this.id_um.ReadOnly = true;
            this.id_um.Visible = false;
            // 
            // UM
            // 
            this.UM.HeaderText = "U.M.";
            this.UM.Name = "UM";
            this.UM.ReadOnly = true;
            this.UM.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.UM.Width = 60;
            // 
            // Quant
            // 
            this.Quant.HeaderText = "QUANT.";
            this.Quant.Name = "Quant";
            this.Quant.ReadOnly = true;
            this.Quant.Width = 60;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "OBS";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            this.Valor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Valor.Width = 185;
            // 
            // Del
            // 
            this.Del.HeaderText = "";
            this.Del.Image = global::GerenciadorEstoque.Properties.Resources.trash2x;
            this.Del.Name = "Del";
            this.Del.ReadOnly = true;
            this.Del.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Del.Width = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(329, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "U.M.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(83, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Nome";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Setor";
            // 
            // CbUnidade
            // 
            this.CbUnidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbUnidade.FormattingEnabled = true;
            this.CbUnidade.Location = new System.Drawing.Point(202, 35);
            this.CbUnidade.Name = "CbUnidade";
            this.CbUnidade.Size = new System.Drawing.Size(127, 21);
            this.CbUnidade.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Unidade";
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
            this.BtAddItem.Location = new System.Drawing.Point(539, 90);
            this.BtAddItem.Name = "BtAddItem";
            this.BtAddItem.Size = new System.Drawing.Size(26, 26);
            this.BtAddItem.TabIndex = 7;
            this.BtAddItem.UseVisualStyleBackColor = true;
            this.BtAddItem.Click += new System.EventHandler(this.BtAddItem_Click);
            // 
            // CbSetores
            // 
            this.CbSetores.FormattingEnabled = true;
            this.CbSetores.Location = new System.Drawing.Point(6, 29);
            this.CbSetores.Name = "CbSetores";
            this.CbSetores.Size = new System.Drawing.Size(151, 21);
            this.CbSetores.TabIndex = 0;
            this.CbSetores.Leave += new System.EventHandler(this.CbSetores_Leave);
            // 
            // TxtObsSetor
            // 
            this.TxtObsSetor.Location = new System.Drawing.Point(164, 29);
            this.TxtObsSetor.MaxLength = 65;
            this.TxtObsSetor.Name = "TxtObsSetor";
            this.TxtObsSetor.Size = new System.Drawing.Size(197, 20);
            this.TxtObsSetor.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(161, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "OBS";
            // 
            // GbItens
            // 
            this.GbItens.Controls.Add(this.GbSetores);
            this.GbItens.Controls.Add(this.BtEditaSetor);
            this.GbItens.Controls.Add(this.TxtIdMaterial);
            this.GbItens.Controls.Add(this.BtCancelar);
            this.GbItens.Controls.Add(this.BtExcluir);
            this.GbItens.Controls.Add(this.TxtItensACancelar);
            this.GbItens.Controls.Add(this.BtSalvarItensSetor);
            this.GbItens.Controls.Add(this.label6);
            this.GbItens.Controls.Add(this.label10);
            this.GbItens.Controls.Add(this.label7);
            this.GbItens.Controls.Add(this.label8);
            this.GbItens.Controls.Add(this.TxtObs);
            this.GbItens.Controls.Add(this.label4);
            this.GbItens.Controls.Add(this.CbUm);
            this.GbItens.Controls.Add(this.BtAddItem);
            this.GbItens.Controls.Add(this.DgvItens);
            this.GbItens.Controls.Add(this.TxtCodItem);
            this.GbItens.Controls.Add(this.TxtQuant);
            this.GbItens.Controls.Add(this.TxtNomeItem);
            this.GbItens.Location = new System.Drawing.Point(577, 12);
            this.GbItens.Name = "GbItens";
            this.GbItens.Size = new System.Drawing.Size(573, 535);
            this.GbItens.TabIndex = 47;
            this.GbItens.TabStop = false;
            this.GbItens.Text = "Itens por setor";
            // 
            // GbSetores
            // 
            this.GbSetores.Controls.Add(this.label2);
            this.GbSetores.Controls.Add(this.CbSetores);
            this.GbSetores.Controls.Add(this.TxtObsSetor);
            this.GbSetores.Controls.Add(this.label5);
            this.GbSetores.Location = new System.Drawing.Point(9, 11);
            this.GbSetores.Name = "GbSetores";
            this.GbSetores.Size = new System.Drawing.Size(371, 58);
            this.GbSetores.TabIndex = 52;
            this.GbSetores.TabStop = false;
            // 
            // BtEditaSetor
            // 
            this.BtEditaSetor.Image = global::GerenciadorEstoque.Properties.Resources.pencil2x;
            this.BtEditaSetor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtEditaSetor.Location = new System.Drawing.Point(386, 40);
            this.BtEditaSetor.Name = "BtEditaSetor";
            this.BtEditaSetor.Size = new System.Drawing.Size(26, 24);
            this.BtEditaSetor.TabIndex = 51;
            this.BtEditaSetor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtEditaSetor.UseVisualStyleBackColor = true;
            this.BtEditaSetor.Click += new System.EventHandler(this.BtEditaSetor_Click);
            // 
            // TxtIdMaterial
            // 
            this.TxtIdMaterial.Enabled = false;
            this.TxtIdMaterial.Location = new System.Drawing.Point(465, 67);
            this.TxtIdMaterial.Name = "TxtIdMaterial";
            this.TxtIdMaterial.Size = new System.Drawing.Size(68, 20);
            this.TxtIdMaterial.TabIndex = 50;
            this.TxtIdMaterial.Visible = false;
            // 
            // BtCancelar
            // 
            this.BtCancelar.Location = new System.Drawing.Point(411, 500);
            this.BtCancelar.Name = "BtCancelar";
            this.BtCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtCancelar.TabIndex = 8;
            this.BtCancelar.Text = "Cancelar";
            this.BtCancelar.UseVisualStyleBackColor = true;
            this.BtCancelar.Click += new System.EventHandler(this.BtCancelar_Click);
            // 
            // BtExcluir
            // 
            this.BtExcluir.Location = new System.Drawing.Point(9, 500);
            this.BtExcluir.Name = "BtExcluir";
            this.BtExcluir.Size = new System.Drawing.Size(75, 23);
            this.BtExcluir.TabIndex = 49;
            this.BtExcluir.Text = "Excluir";
            this.BtExcluir.UseVisualStyleBackColor = true;
            this.BtExcluir.Click += new System.EventHandler(this.BtExcluir_Click);
            // 
            // TxtItensACancelar
            // 
            this.TxtItensACancelar.Enabled = false;
            this.TxtItensACancelar.Location = new System.Drawing.Point(196, 497);
            this.TxtItensACancelar.Name = "TxtItensACancelar";
            this.TxtItensACancelar.Size = new System.Drawing.Size(197, 20);
            this.TxtItensACancelar.TabIndex = 48;
            this.TxtItensACancelar.Visible = false;
            // 
            // BtSalvarItensSetor
            // 
            this.BtSalvarItensSetor.Location = new System.Drawing.Point(492, 500);
            this.BtSalvarItensSetor.Name = "BtSalvarItensSetor";
            this.BtSalvarItensSetor.Size = new System.Drawing.Size(75, 23);
            this.BtSalvarItensSetor.TabIndex = 9;
            this.BtSalvarItensSetor.Text = "Salvar";
            this.BtSalvarItensSetor.UseVisualStyleBackColor = true;
            this.BtSalvarItensSetor.Click += new System.EventHandler(this.BtSalvarItensSetor_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(255, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Quantidade";
            // 
            // TxtQuant
            // 
            this.TxtQuant.Enabled = false;
            this.TxtQuant.Location = new System.Drawing.Point(258, 92);
            this.TxtQuant.MaxLength = 140;
            this.TxtQuant.Name = "TxtQuant";
            this.TxtQuant.Size = new System.Drawing.Size(68, 20);
            this.TxtQuant.TabIndex = 4;
            this.TxtQuant.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtObs_KeyDown);
            this.TxtQuant.Validating += new System.ComponentModel.CancelEventHandler(this.TxtQuant_Validating);
            // 
            // TxtIdPedido
            // 
            this.TxtIdPedido.Enabled = false;
            this.TxtIdPedido.Location = new System.Drawing.Point(9, 35);
            this.TxtIdPedido.Name = "TxtIdPedido";
            this.TxtIdPedido.Size = new System.Drawing.Size(76, 20);
            this.TxtIdPedido.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 46;
            this.label9.Text = "Nº cotação";
            // 
            // DgvSetores
            // 
            this.DgvSetores.AllowUserToAddRows = false;
            this.DgvSetores.AllowUserToDeleteRows = false;
            this.DgvSetores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSetores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewImageColumn2});
            this.DgvSetores.Location = new System.Drawing.Point(6, 114);
            this.DgvSetores.Name = "DgvSetores";
            this.DgvSetores.RowHeadersVisible = false;
            this.DgvSetores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvSetores.Size = new System.Drawing.Size(565, 495);
            this.DgvSetores.TabIndex = 48;
            this.DgvSetores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSetores_CellClick);
            this.DgvSetores.SelectionChanged += new System.EventHandler(this.DgvSetores_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "id_setor";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn2.Visible = false;
            this.dataGridViewTextBoxColumn2.Width = 40;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Setor";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn3.Width = 210;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "OBS";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn4.Width = 250;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Itens";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn5.Width = 60;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::GerenciadorEstoque.Properties.Resources.pencil2x;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn2.Width = 26;
            // 
            // BtAdicionaSetor
            // 
            this.BtAdicionaSetor.Location = new System.Drawing.Point(478, 90);
            this.BtAdicionaSetor.Name = "BtAdicionaSetor";
            this.BtAdicionaSetor.Size = new System.Drawing.Size(93, 23);
            this.BtAdicionaSetor.TabIndex = 5;
            this.BtAdicionaSetor.Text = "Adicionar setor";
            this.BtAdicionaSetor.UseVisualStyleBackColor = true;
            this.BtAdicionaSetor.Click += new System.EventHandler(this.BtAdicionaSetores);
            // 
            // BtCriarCotacao
            // 
            this.BtCriarCotacao.Image = global::GerenciadorEstoque.Properties.Resources.plus2x;
            this.BtCriarCotacao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtCriarCotacao.Location = new System.Drawing.Point(395, 12);
            this.BtCriarCotacao.Name = "BtCriarCotacao";
            this.BtCriarCotacao.Size = new System.Drawing.Size(77, 24);
            this.BtCriarCotacao.TabIndex = 4;
            this.BtCriarCotacao.Text = "Criar";
            this.BtCriarCotacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtCriarCotacao.UseVisualStyleBackColor = true;
            this.BtCriarCotacao.Click += new System.EventHandler(this.BtCriarCotacao_Click);
            // 
            // TxtObsPedido
            // 
            this.TxtObsPedido.Location = new System.Drawing.Point(41, 62);
            this.TxtObsPedido.MaxLength = 140;
            this.TxtObsPedido.Name = "TxtObsPedido";
            this.TxtObsPedido.Size = new System.Drawing.Size(330, 20);
            this.TxtObsPedido.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "OBS";
            // 
            // GbPedido
            // 
            this.GbPedido.Controls.Add(this.label9);
            this.GbPedido.Controls.Add(this.DtpDataEntrega);
            this.GbPedido.Controls.Add(this.label11);
            this.GbPedido.Controls.Add(this.TxtObsPedido);
            this.GbPedido.Controls.Add(this.TxtIdPedido);
            this.GbPedido.Controls.Add(this.label1);
            this.GbPedido.Controls.Add(this.CbUnidade);
            this.GbPedido.Controls.Add(this.label3);
            this.GbPedido.Location = new System.Drawing.Point(7, 1);
            this.GbPedido.Name = "GbPedido";
            this.GbPedido.Size = new System.Drawing.Size(377, 92);
            this.GbPedido.TabIndex = 49;
            this.GbPedido.TabStop = false;
            // 
            // BtEdita
            // 
            this.BtEdita.Image = global::GerenciadorEstoque.Properties.Resources.pencil2x;
            this.BtEdita.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtEdita.Location = new System.Drawing.Point(395, 42);
            this.BtEdita.Name = "BtEdita";
            this.BtEdita.Size = new System.Drawing.Size(77, 24);
            this.BtEdita.TabIndex = 4;
            this.BtEdita.Text = "Editar";
            this.BtEdita.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtEdita.UseVisualStyleBackColor = true;
            this.BtEdita.Click += new System.EventHandler(this.BtEdita_Click);
            // 
            // BtCancelarPedido
            // 
            this.BtCancelarPedido.Image = global::GerenciadorEstoque.Properties.Resources.x2x;
            this.BtCancelarPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtCancelarPedido.Location = new System.Drawing.Point(478, 43);
            this.BtCancelarPedido.Name = "BtCancelarPedido";
            this.BtCancelarPedido.Size = new System.Drawing.Size(77, 24);
            this.BtCancelarPedido.TabIndex = 4;
            this.BtCancelarPedido.Text = "Cancelar";
            this.BtCancelarPedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtCancelarPedido.UseVisualStyleBackColor = true;
            this.BtCancelarPedido.Click += new System.EventHandler(this.BtCriarCotacao_Click);
            // 
            // BtExcluirPedido
            // 
            this.BtExcluirPedido.Image = global::GerenciadorEstoque.Properties.Resources.trash2x;
            this.BtExcluirPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtExcluirPedido.Location = new System.Drawing.Point(478, 13);
            this.BtExcluirPedido.Name = "BtExcluirPedido";
            this.BtExcluirPedido.Size = new System.Drawing.Size(77, 24);
            this.BtExcluirPedido.TabIndex = 50;
            this.BtExcluirPedido.Text = "Excluir";
            this.BtExcluirPedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtExcluirPedido.UseVisualStyleBackColor = true;
            this.BtExcluirPedido.Click += new System.EventHandler(this.BtExcluirPedido_Click);
            // 
            // BtSalvar
            // 
            this.BtSalvar.Image = global::GerenciadorEstoque.Properties.Resources.circleCheck2x;
            this.BtSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtSalvar.Location = new System.Drawing.Point(395, 72);
            this.BtSalvar.Name = "BtSalvar";
            this.BtSalvar.Size = new System.Drawing.Size(77, 24);
            this.BtSalvar.TabIndex = 51;
            this.BtSalvar.Text = "Salvar";
            this.BtSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtSalvar.UseVisualStyleBackColor = true;
            this.BtSalvar.Click += new System.EventHandler(this.BtSalvar_Click);
            // 
            // FrmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 628);
            this.Controls.Add(this.BtSalvar);
            this.Controls.Add(this.GbItens);
            this.Controls.Add(this.BtExcluirPedido);
            this.Controls.Add(this.GbPedido);
            this.Controls.Add(this.BtCancelarPedido);
            this.Controls.Add(this.BtEdita);
            this.Controls.Add(this.BtCriarCotacao);
            this.Controls.Add(this.BtAdicionaSetor);
            this.Controls.Add(this.DgvSetores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedido Fruteira";
            this.Load += new System.EventHandler(this.FrmPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvItens)).EndInit();
            this.GbItens.ResumeLayout(false);
            this.GbItens.PerformLayout();
            this.GbSetores.ResumeLayout(false);
            this.GbSetores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSetores)).EndInit();
            this.GbPedido.ResumeLayout(false);
            this.GbPedido.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox TxtObs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CbUm;
        private System.Windows.Forms.DateTimePicker DtpDataEntrega;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtNomeItem;
        private System.Windows.Forms.MaskedTextBox TxtCodItem;
        private System.Windows.Forms.DataGridView DgvItens;
        private System.Windows.Forms.Button BtAddItem;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbUnidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbSetores;
        private System.Windows.Forms.TextBox TxtObsSetor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox GbItens;
        private System.Windows.Forms.TextBox TxtIdPedido;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView DgvSetores;
        private System.Windows.Forms.Button BtAdicionaSetor;
        private System.Windows.Forms.Button BtSalvarItensSetor;
        private System.Windows.Forms.TextBox TxtItensACancelar;
        private System.Windows.Forms.Button BtCancelar;
        private System.Windows.Forms.Button BtExcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtQuant;
        private System.Windows.Forms.TextBox TxtIdMaterial;
        private System.Windows.Forms.Button BtCriarCotacao;
        private System.Windows.Forms.TextBox TxtObsPedido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox GbPedido;
        private System.Windows.Forms.Button BtEdita;
        private System.Windows.Forms.Button BtCancelarPedido;
        private System.Windows.Forms.Button BtExcluirPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_itemPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDDer;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_um;
        private System.Windows.Forms.DataGridViewTextBoxColumn UM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewImageColumn Del;
        private System.Windows.Forms.Button BtEditaSetor;
        private System.Windows.Forms.GroupBox GbSetores;
        private System.Windows.Forms.Button BtSalvar;
    }
}