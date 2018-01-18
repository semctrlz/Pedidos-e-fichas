namespace GerenciadorEstoque.Forms.Produtos
{
    partial class FrmCadastraProdutosEmLote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastraProdutosEmLote));
            this.PnTopo = new System.Windows.Forms.Panel();
            this.BtFormatarParaAjuste = new System.Windows.Forms.Button();
            this.CbNome = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CbCodCigam = new System.Windows.Forms.ComboBox();
            this.LbCodCigam = new System.Windows.Forms.Label();
            this.BtnColar = new System.Windows.Forms.Button();
            this.PnDados = new System.Windows.Forms.Panel();
            this.DgvDados = new System.Windows.Forms.DataGridView();
            this.PnBase = new System.Windows.Forms.Panel();
            this.BtSalvar = new System.Windows.Forms.Button();
            this.CbxIgnorarErros = new System.Windows.Forms.CheckBox();
            this.PnTopo.SuspendLayout();
            this.PnDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDados)).BeginInit();
            this.PnBase.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnTopo
            // 
            this.PnTopo.Controls.Add(this.BtFormatarParaAjuste);
            this.PnTopo.Controls.Add(this.CbNome);
            this.PnTopo.Controls.Add(this.label2);
            this.PnTopo.Controls.Add(this.CbCodCigam);
            this.PnTopo.Controls.Add(this.LbCodCigam);
            this.PnTopo.Controls.Add(this.BtnColar);
            this.PnTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnTopo.Location = new System.Drawing.Point(0, 0);
            this.PnTopo.Name = "PnTopo";
            this.PnTopo.Size = new System.Drawing.Size(506, 136);
            this.PnTopo.TabIndex = 0;
            // 
            // BtFormatarParaAjuste
            // 
            this.BtFormatarParaAjuste.Enabled = false;
            this.BtFormatarParaAjuste.Location = new System.Drawing.Point(119, 99);
            this.BtFormatarParaAjuste.Name = "BtFormatarParaAjuste";
            this.BtFormatarParaAjuste.Size = new System.Drawing.Size(127, 23);
            this.BtFormatarParaAjuste.TabIndex = 8;
            this.BtFormatarParaAjuste.Text = "Formatar para ajuste";
            this.BtFormatarParaAjuste.UseVisualStyleBackColor = true;
            this.BtFormatarParaAjuste.Click += new System.EventHandler(this.BtFormatarParaAjuste_Click);
            // 
            // CbNome
            // 
            this.CbNome.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbNome.Enabled = false;
            this.CbNome.FormattingEnabled = true;
            this.CbNome.Location = new System.Drawing.Point(87, 72);
            this.CbNome.Name = "CbNome";
            this.CbNome.Size = new System.Drawing.Size(159, 21);
            this.CbNome.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome";
            // 
            // CbCodCigam
            // 
            this.CbCodCigam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbCodCigam.Enabled = false;
            this.CbCodCigam.FormattingEnabled = true;
            this.CbCodCigam.Location = new System.Drawing.Point(87, 45);
            this.CbCodCigam.Name = "CbCodCigam";
            this.CbCodCigam.Size = new System.Drawing.Size(159, 21);
            this.CbCodCigam.TabIndex = 2;
            // 
            // LbCodCigam
            // 
            this.LbCodCigam.AutoSize = true;
            this.LbCodCigam.Location = new System.Drawing.Point(9, 48);
            this.LbCodCigam.Name = "LbCodCigam";
            this.LbCodCigam.Size = new System.Drawing.Size(72, 13);
            this.LbCodCigam.TabIndex = 1;
            this.LbCodCigam.Text = "Código Cigam";
            // 
            // BtnColar
            // 
            this.BtnColar.Location = new System.Drawing.Point(87, 12);
            this.BtnColar.Name = "BtnColar";
            this.BtnColar.Size = new System.Drawing.Size(108, 23);
            this.BtnColar.TabIndex = 0;
            this.BtnColar.Text = "Colar do Excel";
            this.BtnColar.UseVisualStyleBackColor = true;
            this.BtnColar.Click += new System.EventHandler(this.BtnColar_Click);
            // 
            // PnDados
            // 
            this.PnDados.Controls.Add(this.DgvDados);
            this.PnDados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnDados.Location = new System.Drawing.Point(0, 136);
            this.PnDados.Name = "PnDados";
            this.PnDados.Size = new System.Drawing.Size(506, 406);
            this.PnDados.TabIndex = 1;
            // 
            // DgvDados
            // 
            this.DgvDados.AllowUserToAddRows = false;
            this.DgvDados.AllowUserToDeleteRows = false;
            this.DgvDados.AllowUserToResizeColumns = false;
            this.DgvDados.AllowUserToResizeRows = false;
            this.DgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvDados.Location = new System.Drawing.Point(0, 0);
            this.DgvDados.Name = "DgvDados";
            this.DgvDados.RowHeadersVisible = false;
            this.DgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DgvDados.Size = new System.Drawing.Size(506, 406);
            this.DgvDados.TabIndex = 0;
            // 
            // PnBase
            // 
            this.PnBase.Controls.Add(this.BtSalvar);
            this.PnBase.Controls.Add(this.CbxIgnorarErros);
            this.PnBase.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnBase.Location = new System.Drawing.Point(0, 542);
            this.PnBase.Name = "PnBase";
            this.PnBase.Size = new System.Drawing.Size(506, 44);
            this.PnBase.TabIndex = 2;
            // 
            // BtSalvar
            // 
            this.BtSalvar.Enabled = false;
            this.BtSalvar.Location = new System.Drawing.Point(395, 9);
            this.BtSalvar.Name = "BtSalvar";
            this.BtSalvar.Size = new System.Drawing.Size(108, 23);
            this.BtSalvar.TabIndex = 9;
            this.BtSalvar.Text = "Salvar";
            this.BtSalvar.UseVisualStyleBackColor = true;
            this.BtSalvar.Click += new System.EventHandler(this.BtSalvar_Click);
            // 
            // CbxIgnorarErros
            // 
            this.CbxIgnorarErros.AutoSize = true;
            this.CbxIgnorarErros.Checked = true;
            this.CbxIgnorarErros.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbxIgnorarErros.Enabled = false;
            this.CbxIgnorarErros.Location = new System.Drawing.Point(304, 13);
            this.CbxIgnorarErros.Name = "CbxIgnorarErros";
            this.CbxIgnorarErros.Size = new System.Drawing.Size(85, 17);
            this.CbxIgnorarErros.TabIndex = 8;
            this.CbxIgnorarErros.Text = "Ignorar erros";
            this.CbxIgnorarErros.UseVisualStyleBackColor = true;
            // 
            // FrmCadastraProdutosEmLote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 586);
            this.Controls.Add(this.PnDados);
            this.Controls.Add(this.PnTopo);
            this.Controls.Add(this.PnBase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmCadastraProdutosEmLote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar produtos em lote";
            this.Load += new System.EventHandler(this.FrmCadastraProdutosEmLote_Load);
            this.PnTopo.ResumeLayout(false);
            this.PnTopo.PerformLayout();
            this.PnDados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDados)).EndInit();
            this.PnBase.ResumeLayout(false);
            this.PnBase.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnTopo;
        private System.Windows.Forms.Button BtnColar;
        private System.Windows.Forms.Panel PnDados;
        private System.Windows.Forms.Panel PnBase;
        private System.Windows.Forms.ComboBox CbNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbCodCigam;
        private System.Windows.Forms.Label LbCodCigam;
        private System.Windows.Forms.CheckBox CbxIgnorarErros;
        private System.Windows.Forms.Button BtSalvar;
        private System.Windows.Forms.Button BtFormatarParaAjuste;
        private System.Windows.Forms.DataGridView DgvDados;
    }
}