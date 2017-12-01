namespace GerenciadorEstoque.Forms.Empresas
{
    partial class FrmConsultaItens
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaItens));
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.pnDados = new System.Windows.Forms.Panel();
            this.btEsc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSubgrupo = new System.Windows.Forms.ComboBox();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.pnDados.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.AllowUserToDeleteRows = false;
            this.dgvItens.AllowUserToResizeColumns = false;
            this.dgvItens.AllowUserToResizeRows = false;
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItens.Location = new System.Drawing.Point(0, 0);
            this.dgvItens.MultiSelect = false;
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.RowHeadersVisible = false;
            this.dgvItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItens.Size = new System.Drawing.Size(781, 646);
            this.dgvItens.TabIndex = 0;
            this.dgvItens.TabStop = false;
            this.dgvItens.SelectionChanged += new System.EventHandler(this.DgvItens_SelectionChanged);
            // 
            // pnDados
            // 
            this.pnDados.Controls.Add(this.btEsc);
            this.pnDados.Controls.Add(this.label2);
            this.pnDados.Controls.Add(this.label1);
            this.pnDados.Controls.Add(this.cbSubgrupo);
            this.pnDados.Controls.Add(this.txtProduto);
            this.pnDados.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnDados.Location = new System.Drawing.Point(0, 0);
            this.pnDados.Name = "pnDados";
            this.pnDados.Size = new System.Drawing.Size(781, 86);
            this.pnDados.TabIndex = 1;
            // 
            // btEsc
            // 
            this.btEsc.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btEsc.Location = new System.Drawing.Point(694, 48);
            this.btEsc.Name = "btEsc";
            this.btEsc.Size = new System.Drawing.Size(75, 23);
            this.btEsc.TabIndex = 2;
            this.btEsc.Text = "Cancelar";
            this.btEsc.UseVisualStyleBackColor = true;
            this.btEsc.Click += new System.EventHandler(this.BtEsc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Subgrupo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Material";
            // 
            // cbSubgrupo
            // 
            this.cbSubgrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubgrupo.FormattingEnabled = true;
            this.cbSubgrupo.Location = new System.Drawing.Point(323, 50);
            this.cbSubgrupo.Name = "cbSubgrupo";
            this.cbSubgrupo.Size = new System.Drawing.Size(164, 21);
            this.cbSubgrupo.TabIndex = 1;
            this.cbSubgrupo.TextChanged += new System.EventHandler(this.CbSubgrupo_TextChanged);
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(12, 51);
            this.txtProduto.MaxLength = 60;
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(305, 20);
            this.txtProduto.TabIndex = 0;
            this.txtProduto.TextChanged += new System.EventHandler(this.TxtProduto_TextChanged);
            this.txtProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmConsultaItem_KeyDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvItens);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(781, 646);
            this.panel1.TabIndex = 2;
            // 
            // frmConsultaItem
            // 
            this.AcceptButton = this.btEsc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btEsc;
            this.ClientSize = new System.Drawing.Size(781, 732);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnDados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsultaItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Item";
            this.Load += new System.EventHandler(this.FrmConsultaItem_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmConsultaItem_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.Panel pnDados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSubgrupo;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btEsc;
    }
}