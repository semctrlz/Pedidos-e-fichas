namespace GerenciadorEstoque.Forms.Fichas
{
    partial class FrmConsultaFichas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaFichas));
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.cbUnidade = new System.Windows.Forms.ComboBox();
            this.lbUnidade = new System.Windows.Forms.Label();
            this.lbSetor = new System.Windows.Forms.Label();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.lbSubCategoria = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvFichas = new System.Windows.Forms.DataGridView();
            this.bgDados = new System.Windows.Forms.GroupBox();
            this.cbSetor = new System.Windows.Forms.ComboBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.cbSubCategoria = new System.Windows.Forms.ComboBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.btPdf = new System.Windows.Forms.Button();
            this.CbxInativo = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFichas)).BeginInit();
            this.bgDados.SuspendLayout();
            this.gbFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.HeaderText = "";
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.Width = 26;
            // 
            // cbUnidade
            // 
            this.cbUnidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUnidade.FormattingEnabled = true;
            this.cbUnidade.Location = new System.Drawing.Point(62, 19);
            this.cbUnidade.Name = "cbUnidade";
            this.cbUnidade.Size = new System.Drawing.Size(116, 21);
            this.cbUnidade.TabIndex = 12;
            this.cbUnidade.TabStop = false;
            this.cbUnidade.SelectedIndexChanged += new System.EventHandler(this.CbUnidade_SelectedIndexChanged);
            // 
            // lbUnidade
            // 
            this.lbUnidade.AutoSize = true;
            this.lbUnidade.Location = new System.Drawing.Point(9, 22);
            this.lbUnidade.Name = "lbUnidade";
            this.lbUnidade.Size = new System.Drawing.Size(47, 13);
            this.lbUnidade.TabIndex = 11;
            this.lbUnidade.Text = "Unidade";
            // 
            // lbSetor
            // 
            this.lbSetor.AutoSize = true;
            this.lbSetor.Location = new System.Drawing.Point(288, 71);
            this.lbSetor.Name = "lbSetor";
            this.lbSetor.Size = new System.Drawing.Size(32, 13);
            this.lbSetor.TabIndex = 4;
            this.lbSetor.Text = "Setor";
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Location = new System.Drawing.Point(497, 71);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(55, 13);
            this.lbCategoria.TabIndex = 5;
            this.lbCategoria.Text = "Categoria ";
            // 
            // lbSubCategoria
            // 
            this.lbSubCategoria.AutoSize = true;
            this.lbSubCategoria.Location = new System.Drawing.Point(729, 71);
            this.lbSubCategoria.Name = "lbSubCategoria";
            this.lbSubCategoria.Size = new System.Drawing.Size(70, 13);
            this.lbSubCategoria.TabIndex = 6;
            this.lbSubCategoria.Text = "Subcategoria";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 26;
            // 
            // dgvFichas
            // 
            this.dgvFichas.AllowUserToAddRows = false;
            this.dgvFichas.AllowUserToDeleteRows = false;
            this.dgvFichas.AllowUserToResizeColumns = false;
            this.dgvFichas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.dgvFichas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvFichas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFichas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFichas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFichas.Location = new System.Drawing.Point(3, 16);
            this.dgvFichas.Name = "dgvFichas";
            this.dgvFichas.ReadOnly = true;
            this.dgvFichas.RowHeadersVisible = false;
            this.dgvFichas.Size = new System.Drawing.Size(1036, 656);
            this.dgvFichas.TabIndex = 0;
            this.dgvFichas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvFichas_CellClick);
            this.dgvFichas.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DgvFichas_CellPainting);
            this.dgvFichas.SelectionChanged += new System.EventHandler(this.DgvFichas_SelectionChanged);
            // 
            // bgDados
            // 
            this.bgDados.Controls.Add(this.dgvFichas);
            this.bgDados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bgDados.Location = new System.Drawing.Point(0, 94);
            this.bgDados.Name = "bgDados";
            this.bgDados.Size = new System.Drawing.Size(1042, 675);
            this.bgDados.TabIndex = 3;
            this.bgDados.TabStop = false;
            // 
            // cbSetor
            // 
            this.cbSetor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSetor.FormattingEnabled = true;
            this.cbSetor.Location = new System.Drawing.Point(326, 68);
            this.cbSetor.Name = "cbSetor";
            this.cbSetor.Size = new System.Drawing.Size(165, 21);
            this.cbSetor.TabIndex = 7;
            this.cbSetor.SelectedIndexChanged += new System.EventHandler(this.CbSetor_SelectedIndexChanged);
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(558, 67);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(165, 21);
            this.cbCategoria.TabIndex = 8;
            this.cbCategoria.SelectedIndexChanged += new System.EventHandler(this.CbCategoria_SelectedIndexChanged);
            // 
            // cbSubCategoria
            // 
            this.cbSubCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubCategoria.FormattingEnabled = true;
            this.cbSubCategoria.Location = new System.Drawing.Point(805, 68);
            this.cbSubCategoria.Name = "cbSubCategoria";
            this.cbSubCategoria.Size = new System.Drawing.Size(165, 21);
            this.cbSubCategoria.TabIndex = 9;
            this.cbSubCategoria.SelectedIndexChanged += new System.EventHandler(this.CbSubCategoria_SelectedIndexChanged);
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(9, 51);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(114, 13);
            this.lbNome.TabIndex = 0;
            this.lbNome.Text = "Nome da ficha técnica";
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 26;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 68);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(270, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.TextChanged += new System.EventHandler(this.TxtNome_TextChanged);
            // 
            // gbFiltros
            // 
            this.gbFiltros.Controls.Add(this.CbxInativo);
            this.gbFiltros.Controls.Add(this.btPdf);
            this.gbFiltros.Controls.Add(this.cbUnidade);
            this.gbFiltros.Controls.Add(this.lbUnidade);
            this.gbFiltros.Controls.Add(this.lbSetor);
            this.gbFiltros.Controls.Add(this.lbCategoria);
            this.gbFiltros.Controls.Add(this.lbSubCategoria);
            this.gbFiltros.Controls.Add(this.cbSetor);
            this.gbFiltros.Controls.Add(this.cbCategoria);
            this.gbFiltros.Controls.Add(this.cbSubCategoria);
            this.gbFiltros.Controls.Add(this.txtNome);
            this.gbFiltros.Controls.Add(this.lbNome);
            this.gbFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbFiltros.Location = new System.Drawing.Point(0, 0);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(1042, 94);
            this.gbFiltros.TabIndex = 2;
            this.gbFiltros.TabStop = false;
            // 
            // btPdf
            // 
            this.btPdf.Image = global::GerenciadorEstoque.Properties.Resources.exportPdfx48;
            this.btPdf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPdf.Location = new System.Drawing.Point(976, 36);
            this.btPdf.Name = "btPdf";
            this.btPdf.Size = new System.Drawing.Size(54, 54);
            this.btPdf.TabIndex = 13;
            this.btPdf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btPdf.UseVisualStyleBackColor = true;
            this.btPdf.Click += new System.EventHandler(this.BtPdf_Click);
            // 
            // CbxInativo
            // 
            this.CbxInativo.AutoSize = true;
            this.CbxInativo.Location = new System.Drawing.Point(326, 36);
            this.CbxInativo.Name = "CbxInativo";
            this.CbxInativo.Size = new System.Drawing.Size(174, 17);
            this.CbxInativo.TabIndex = 14;
            this.CbxInativo.Text = "Mostrar fichas técnicas inativas";
            this.CbxInativo.UseVisualStyleBackColor = true;
            this.CbxInativo.CheckedChanged += new System.EventHandler(this.CbxInativo_CheckedChanged);
            // 
            // FrmConsultaFichas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 769);
            this.Controls.Add(this.bgDados);
            this.Controls.Add(this.gbFiltros);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmConsultaFichas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta fichas técnicas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmConsultaFichas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFichas)).EndInit();
            this.bgDados.ResumeLayout(false);
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.Button btPdf;
        private System.Windows.Forms.ComboBox cbUnidade;
        private System.Windows.Forms.Label lbUnidade;
        private System.Windows.Forms.Label lbSetor;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.Label lbSubCategoria;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridView dgvFichas;
        private System.Windows.Forms.GroupBox bgDados;
        private System.Windows.Forms.ComboBox cbSetor;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.ComboBox cbSubCategoria;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.CheckBox CbxInativo;
    }
}