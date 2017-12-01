namespace GerenciadorEstoque.Forms.Empresas
{
    partial class frmMarcasAprovadas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMarcasAprovadas));
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIdMarcasAprovadas = new System.Windows.Forms.TextBox();
            this.cbxExibirNoEmail = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.dgvMarcasAprovadas = new System.Windows.Forms.DataGridView();
            this.cbAutorizadoPor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOBS = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcasAprovadas)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AllowUserToResizeColumns = false;
            this.dgvProdutos.AllowUserToResizeRows = false;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvProdutos.Location = new System.Drawing.Point(0, 0);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.RowHeadersVisible = false;
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(692, 645);
            this.dgvProdutos.TabIndex = 0;
            this.dgvProdutos.SelectionChanged += new System.EventHandler(this.DgvProdutos_SelectionChanged);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(13, 29);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(367, 20);
            this.txtDescricao.TabIndex = 0;
            this.txtDescricao.TextChanged += new System.EventHandler(this.TxtDescricao_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filtrar item";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtIdMarcasAprovadas);
            this.groupBox1.Controls.Add(this.cbxExibirNoEmail);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btCancelar);
            this.groupBox1.Controls.Add(this.btAdd);
            this.groupBox1.Controls.Add(this.dgvMarcasAprovadas);
            this.groupBox1.Controls.Add(this.cbAutorizadoPor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtOBS);
            this.groupBox1.Controls.Add(this.txtMarca);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 559);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Autorizar marca";
            // 
            // txtIdMarcasAprovadas
            // 
            this.txtIdMarcasAprovadas.Location = new System.Drawing.Point(318, 103);
            this.txtIdMarcasAprovadas.Name = "txtIdMarcasAprovadas";
            this.txtIdMarcasAprovadas.Size = new System.Drawing.Size(100, 20);
            this.txtIdMarcasAprovadas.TabIndex = 7;
            this.txtIdMarcasAprovadas.Visible = false;
            // 
            // cbxExibirNoEmail
            // 
            this.cbxExibirNoEmail.AutoSize = true;
            this.cbxExibirNoEmail.Checked = true;
            this.cbxExibirNoEmail.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxExibirNoEmail.Location = new System.Drawing.Point(10, 103);
            this.cbxExibirNoEmail.Name = "cbxExibirNoEmail";
            this.cbxExibirNoEmail.Size = new System.Drawing.Size(125, 17);
            this.cbxExibirNoEmail.TabIndex = 3;
            this.cbxExibirNoEmail.Text = "Exibir marca no email";
            this.cbxExibirNoEmail.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Item";
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(150, 129);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 4;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.BtCancelar_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(343, 129);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 5;
            this.btAdd.Text = "Adicionar";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.BtAdd_Click);
            // 
            // dgvMarcasAprovadas
            // 
            this.dgvMarcasAprovadas.AllowUserToAddRows = false;
            this.dgvMarcasAprovadas.AllowUserToDeleteRows = false;
            this.dgvMarcasAprovadas.AllowUserToResizeColumns = false;
            this.dgvMarcasAprovadas.AllowUserToResizeRows = false;
            this.dgvMarcasAprovadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarcasAprovadas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvMarcasAprovadas.Location = new System.Drawing.Point(3, 158);
            this.dgvMarcasAprovadas.Name = "dgvMarcasAprovadas";
            this.dgvMarcasAprovadas.ReadOnly = true;
            this.dgvMarcasAprovadas.RowHeadersVisible = false;
            this.dgvMarcasAprovadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMarcasAprovadas.Size = new System.Drawing.Size(418, 398);
            this.dgvMarcasAprovadas.TabIndex = 3;
            this.dgvMarcasAprovadas.TabStop = false;
            this.dgvMarcasAprovadas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvMarcasAprovadas_CellClick);
            this.dgvMarcasAprovadas.SelectionChanged += new System.EventHandler(this.DgvMarcasAprovadas_SelectionChanged);
            // 
            // cbAutorizadoPor
            // 
            this.cbAutorizadoPor.FormattingEnabled = true;
            this.cbAutorizadoPor.Location = new System.Drawing.Point(10, 76);
            this.cbAutorizadoPor.Name = "cbAutorizadoPor";
            this.cbAutorizadoPor.Size = new System.Drawing.Size(134, 21);
            this.cbAutorizadoPor.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Autorizado por";
            // 
            // txtOBS
            // 
            this.txtOBS.Location = new System.Drawing.Point(150, 37);
            this.txtOBS.MaxLength = 250;
            this.txtOBS.Multiline = true;
            this.txtOBS.Name = "txtOBS";
            this.txtOBS.Size = new System.Drawing.Size(268, 60);
            this.txtOBS.TabIndex = 2;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(10, 37);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(134, 20);
            this.txtMarca.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(147, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "OBS:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Marca";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.txtDescricao);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(692, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(449, 645);
            this.panel1.TabIndex = 5;
            // 
            // frmMarcasAprovadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 645);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvProdutos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMarcasAprovadas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marcas autorizadas";
            this.Load += new System.EventHandler(this.FrmMarcasAprovadas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcasAprovadas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.DataGridView dgvMarcasAprovadas;
        private System.Windows.Forms.ComboBox cbAutorizadoPor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbxExibirNoEmail;
        private System.Windows.Forms.TextBox txtOBS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIdMarcasAprovadas;
    }
}