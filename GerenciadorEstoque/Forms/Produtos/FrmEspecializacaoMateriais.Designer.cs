namespace GerenciadorEstoque.Forms.Produtos
{
    partial class FrmEspecializacaoMateriais
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEspecializacaoMateriais));
            this.txtCodItem = new System.Windows.Forms.MaskedTextBox();
            this.txtNomeItem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtUm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DgvItens = new System.Windows.Forms.DataGridView();
            this.TxtNomeItemNovo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CbxUm = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtAdicionar = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.um = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.del = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvItens)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodItem
            // 
            this.txtCodItem.Location = new System.Drawing.Point(13, 30);
            this.txtCodItem.Mask = "00\\.00\\.0000";
            this.txtCodItem.Name = "txtCodItem";
            this.txtCodItem.PromptChar = ' ';
            this.txtCodItem.Size = new System.Drawing.Size(68, 20);
            this.txtCodItem.TabIndex = 8;
            this.txtCodItem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCodItem_KeyDown);
            // 
            // txtNomeItem
            // 
            this.txtNomeItem.Enabled = false;
            this.txtNomeItem.Location = new System.Drawing.Point(87, 30);
            this.txtNomeItem.Name = "txtNomeItem";
            this.txtNomeItem.Size = new System.Drawing.Size(346, 20);
            this.txtNomeItem.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nome Item base";
            // 
            // TxtUm
            // 
            this.TxtUm.Enabled = false;
            this.TxtUm.Location = new System.Drawing.Point(439, 30);
            this.TxtUm.Name = "TxtUm";
            this.TxtUm.Size = new System.Drawing.Size(43, 20);
            this.TxtUm.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(436, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "U.M.";
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
            this.um,
            this.del});
            this.DgvItens.Location = new System.Drawing.Point(13, 116);
            this.DgvItens.Name = "DgvItens";
            this.DgvItens.ReadOnly = true;
            this.DgvItens.RowHeadersVisible = false;
            this.DgvItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvItens.Size = new System.Drawing.Size(469, 242);
            this.DgvItens.TabIndex = 11;
            this.DgvItens.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvItens_CellClick);
            this.DgvItens.SelectionChanged += new System.EventHandler(this.DgvItens_SelectionChanged);
            // 
            // TxtNomeItemNovo
            // 
            this.TxtNomeItemNovo.Enabled = false;
            this.TxtNomeItemNovo.Location = new System.Drawing.Point(13, 88);
            this.TxtNomeItemNovo.Name = "TxtNomeItemNovo";
            this.TxtNomeItemNovo.Size = new System.Drawing.Size(346, 20);
            this.TxtNomeItemNovo.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nome Item";
            // 
            // CbxUm
            // 
            this.CbxUm.FormattingEnabled = true;
            this.CbxUm.Location = new System.Drawing.Point(365, 87);
            this.CbxUm.Name = "CbxUm";
            this.CbxUm.Size = new System.Drawing.Size(55, 21);
            this.CbxUm.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(362, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "U.M.";
            // 
            // BtAdicionar
            // 
            this.BtAdicionar.Image = global::GerenciadorEstoque.Properties.Resources.arrowCircleBottom2x;
            this.BtAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtAdicionar.Location = new System.Drawing.Point(426, 84);
            this.BtAdicionar.Name = "BtAdicionar";
            this.BtAdicionar.Size = new System.Drawing.Size(56, 26);
            this.BtAdicionar.TabIndex = 13;
            this.BtAdicionar.Text = "Adic.";
            this.BtAdicionar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtAdicionar.UseVisualStyleBackColor = true;
            this.BtAdicionar.Click += new System.EventHandler(this.BtAdicionar_Click);
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
            this.nome.Width = 360;
            // 
            // um
            // 
            this.um.HeaderText = "U.M.";
            this.um.Name = "um";
            this.um.ReadOnly = true;
            this.um.Width = 60;
            // 
            // del
            // 
            this.del.HeaderText = "DEL";
            this.del.Image = global::GerenciadorEstoque.Properties.Resources.trash2x;
            this.del.Name = "del";
            this.del.ReadOnly = true;
            this.del.Width = 30;
            // 
            // FrmEspecializacaoMateriais
            // 
            this.AcceptButton = this.BtAdicionar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 370);
            this.Controls.Add(this.BtAdicionar);
            this.Controls.Add(this.CbxUm);
            this.Controls.Add(this.DgvItens);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodItem);
            this.Controls.Add(this.TxtUm);
            this.Controls.Add(this.TxtNomeItemNovo);
            this.Controls.Add(this.txtNomeItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmEspecializacaoMateriais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Especialização de materiais";
            this.Load += new System.EventHandler(this.FrmEspecializacaoMateriais_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvItens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtCodItem;
        private System.Windows.Forms.TextBox txtNomeItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtUm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DgvItens;
        private System.Windows.Forms.TextBox TxtNomeItemNovo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CbxUm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtAdicionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn um;
        private System.Windows.Forms.DataGridViewImageColumn del;
    }
}