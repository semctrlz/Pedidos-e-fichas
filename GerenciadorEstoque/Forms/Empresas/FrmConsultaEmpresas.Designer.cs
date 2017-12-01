namespace GerenciadorEstoque.Forms.Empresas
{
    partial class FrmConsultaEmpresas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaEmpresas));
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.pnDados = new System.Windows.Forms.Panel();
            this.TxtCnpj = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btEsc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtFantasiaERazao = new System.Windows.Forms.TextBox();
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
            this.dgvItens.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvItens.Location = new System.Drawing.Point(0, 92);
            this.dgvItens.MultiSelect = false;
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.RowHeadersVisible = false;
            this.dgvItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItens.Size = new System.Drawing.Size(781, 640);
            this.dgvItens.TabIndex = 0;
            this.dgvItens.TabStop = false;
            this.dgvItens.SelectionChanged += new System.EventHandler(this.DgvItens_SelectionChanged);
            // 
            // pnDados
            // 
            this.pnDados.Controls.Add(this.TxtCnpj);
            this.pnDados.Controls.Add(this.label2);
            this.pnDados.Controls.Add(this.btEsc);
            this.pnDados.Controls.Add(this.label1);
            this.pnDados.Controls.Add(this.TxtFantasiaERazao);
            this.pnDados.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnDados.Location = new System.Drawing.Point(0, 0);
            this.pnDados.Name = "pnDados";
            this.pnDados.Size = new System.Drawing.Size(781, 86);
            this.pnDados.TabIndex = 3;
            // 
            // TxtCnpj
            // 
            this.TxtCnpj.Location = new System.Drawing.Point(323, 51);
            this.TxtCnpj.Mask = "00\\.000\\.000\\/0000\\-00";
            this.TxtCnpj.Name = "TxtCnpj";
            this.TxtCnpj.Size = new System.Drawing.Size(119, 20);
            this.TxtCnpj.TabIndex = 1;
            this.TxtCnpj.TextChanged += new System.EventHandler(this.TxtCnpj_TextChanged);
            this.TxtCnpj.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmConsultaEmpresas_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "CNPJ";
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
            this.btEsc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmConsultaEmpresas_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fantasia e Razão Social";
            // 
            // TxtFantasiaERazao
            // 
            this.TxtFantasiaERazao.Location = new System.Drawing.Point(12, 51);
            this.TxtFantasiaERazao.MaxLength = 60;
            this.TxtFantasiaERazao.Name = "TxtFantasiaERazao";
            this.TxtFantasiaERazao.Size = new System.Drawing.Size(305, 20);
            this.TxtFantasiaERazao.TabIndex = 0;
            this.TxtFantasiaERazao.TextChanged += new System.EventHandler(this.TxtFantasiaERazao_TextChanged);
            this.TxtFantasiaERazao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmConsultaEmpresas_KeyDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvItens);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(781, 732);
            this.panel1.TabIndex = 4;
            // 
            // FrmConsultaEmpresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 732);
            this.Controls.Add(this.pnDados);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmConsultaEmpresas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta empresas";
            this.Load += new System.EventHandler(this.FrmConsultaEmpresas_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmConsultaEmpresas_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.Panel pnDados;
        private System.Windows.Forms.Button btEsc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtFantasiaERazao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox TxtCnpj;
        private System.Windows.Forms.Label label2;
    }
}