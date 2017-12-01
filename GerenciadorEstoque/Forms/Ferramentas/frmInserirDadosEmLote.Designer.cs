namespace GerenciadorEstoque.Forms.Ferramentas
{
    partial class FrmInserirDadosEmLote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInserirDadosEmLote));
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btAddBd = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxCelulasUnicasRepetidas = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.NomeColunaDb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaDgv = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvItens
            // 
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItens.Location = new System.Drawing.Point(0, 0);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.Size = new System.Drawing.Size(783, 600);
            this.dgvItens.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btAddBd);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbxCelulasUnicasRepetidas);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 208);
            this.panel1.TabIndex = 1;
            // 
            // btAddBd
            // 
            this.btAddBd.Location = new System.Drawing.Point(179, 171);
            this.btAddBd.Name = "btAddBd";
            this.btAddBd.Size = new System.Drawing.Size(166, 23);
            this.btAddBd.TabIndex = 7;
            this.btAddBd.Text = "Adicionar ao banco de dados";
            this.btAddBd.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(16, 140);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(244, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Gerar relatório de itens renomeados/ignorados";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Células únicas repetidas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Banco de dados";
            // 
            // cbxCelulasUnicasRepetidas
            // 
            this.cbxCelulasUnicasRepetidas.AutoCompleteCustomSource.AddRange(new string[] {
            "Ignorar",
            "Renomear"});
            this.cbxCelulasUnicasRepetidas.FormattingEnabled = true;
            this.cbxCelulasUnicasRepetidas.Location = new System.Drawing.Point(139, 113);
            this.cbxCelulasUnicasRepetidas.Name = "cbxCelulasUnicasRepetidas";
            this.cbxCelulasUnicasRepetidas.Size = new System.Drawing.Size(207, 21);
            this.cbxCelulasUnicasRepetidas.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(93, 75);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(253, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 58);
            this.label1.TabIndex = 2;
            this.label1.Text = "Copie seus dados do excel, escolha para que banco de dados vai essas informações " +
    "e selecione na lista ao lado a referencia de cada coluna.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Colar dados";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeColunaDb,
            this.ColunaDgv});
            this.dataGridView2.Location = new System.Drawing.Point(352, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(419, 183);
            this.dataGridView2.TabIndex = 0;
            // 
            // NomeColunaDb
            // 
            this.NomeColunaDb.HeaderText = "Coluna Banco de dados";
            this.NomeColunaDb.Name = "NomeColunaDb";
            this.NomeColunaDb.Width = 200;
            // 
            // ColunaDgv
            // 
            this.ColunaDgv.HeaderText = "Coluna copiada";
            this.ColunaDgv.Name = "ColunaDgv";
            this.ColunaDgv.Width = 200;
            // 
            // FrmInserirDadosEmLote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvItens);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmInserirDadosEmLote";
            this.Text = "Inserir dados em lote";
            this.Load += new System.EventHandler(this.FrmInserirDadosEmLote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btAddBd;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxCelulasUnicasRepetidas;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeColunaDb;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColunaDgv;
    }
}