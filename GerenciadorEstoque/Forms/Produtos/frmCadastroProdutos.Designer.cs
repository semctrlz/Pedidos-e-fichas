namespace GerenciadorEstoque.Forms.Empresas
{
    partial class FrmCadastroProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroProdutos));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btCriar = new System.Windows.Forms.ToolStripButton();
            this.btLocalizar = new System.Windows.Forms.ToolStripButton();
            this.btEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btExcluir = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbNomeUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbOperacao = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSubgrupo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.MaskedTextBox();
            this.btSavar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.CbUm = new System.Windows.Forms.ComboBox();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btCriar,
            this.btLocalizar,
            this.btEditar,
            this.toolStripSeparator1,
            this.btExcluir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(442, 28);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btCriar
            // 
            this.btCriar.AutoSize = false;
            this.btCriar.BackgroundImage = global::GerenciadorEstoque.Properties.Resources.plus2x;
            this.btCriar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btCriar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btCriar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btCriar.Name = "btCriar";
            this.btCriar.Size = new System.Drawing.Size(25, 25);
            this.btCriar.Text = "Criar produto";
            this.btCriar.Click += new System.EventHandler(this.BtCriar_Click);
            // 
            // btLocalizar
            // 
            this.btLocalizar.AutoSize = false;
            this.btLocalizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btLocalizar.Image = global::GerenciadorEstoque.Properties.Resources.magnifyingGlass2x;
            this.btLocalizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btLocalizar.Name = "btLocalizar";
            this.btLocalizar.Size = new System.Drawing.Size(25, 25);
            this.btLocalizar.Text = "Localizar produto";
            this.btLocalizar.Click += new System.EventHandler(this.BtLocalizar_Click);
            // 
            // btEditar
            // 
            this.btEditar.AutoSize = false;
            this.btEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btEditar.Image = global::GerenciadorEstoque.Properties.Resources.pencil2x;
            this.btEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(25, 25);
            this.btEditar.Text = "Editar produto";
            this.btEditar.Click += new System.EventHandler(this.BtEditar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // btExcluir
            // 
            this.btExcluir.AutoSize = false;
            this.btExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btExcluir.Image = global::GerenciadorEstoque.Properties.Resources.trash2x;
            this.btExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(25, 25);
            this.btExcluir.Text = "Excluir produto";
            this.btExcluir.Click += new System.EventHandler(this.BtExcluir_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbNomeUser,
            this.lbOperacao});
            this.statusStrip1.Location = new System.Drawing.Point(0, 189);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(442, 24);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbNomeUser
            // 
            this.lbNomeUser.AutoSize = false;
            this.lbNomeUser.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lbNomeUser.Name = "lbNomeUser";
            this.lbNomeUser.Size = new System.Drawing.Size(352, 19);
            this.lbNomeUser.Spring = true;
            this.lbNomeUser.Text = "USER";
            this.lbNomeUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbOperacao
            // 
            this.lbOperacao.AutoSize = false;
            this.lbOperacao.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lbOperacao.Name = "lbOperacao";
            this.lbOperacao.Size = new System.Drawing.Size(75, 19);
            this.lbOperacao.Text = "CRIAR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Código cigam";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(128, 66);
            this.txtNome.MaxLength = 60;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(296, 20);
            this.txtNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome item";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Unidade de medida";
            // 
            // cbSubgrupo
            // 
            this.cbSubgrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubgrupo.FormattingEnabled = true;
            this.cbSubgrupo.Location = new System.Drawing.Point(131, 106);
            this.cbSubgrupo.Name = "cbSubgrupo";
            this.cbSubgrupo.Size = new System.Drawing.Size(216, 21);
            this.cbSubgrupo.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Subgrupo";
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(22, 66);
            this.txtCod.Mask = "00\\.00\\.0000";
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(71, 20);
            this.txtCod.TabIndex = 0;
            // 
            // btSavar
            // 
            this.btSavar.Location = new System.Drawing.Point(348, 145);
            this.btSavar.Name = "btSavar";
            this.btSavar.Size = new System.Drawing.Size(75, 23);
            this.btSavar.TabIndex = 4;
            this.btSavar.Text = "Salvar";
            this.btSavar.UseVisualStyleBackColor = true;
            this.btSavar.Click += new System.EventHandler(this.BtSavar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCancelar.Location = new System.Drawing.Point(22, 145);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 4;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.BtCancelar_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(353, 106);
            this.txtId.MaxLength = 60;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(70, 20);
            this.txtId.TabIndex = 1;
            this.txtId.Visible = false;
            // 
            // CbUm
            // 
            this.CbUm.FormattingEnabled = true;
            this.CbUm.Location = new System.Drawing.Point(25, 106);
            this.CbUm.Name = "CbUm";
            this.CbUm.Size = new System.Drawing.Size(51, 21);
            this.CbUm.TabIndex = 2;
            this.CbUm.Leave += new System.EventHandler(this.CbUm_Leave);
            // 
            // FrmCadastroProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 213);
            this.Controls.Add(this.CbUm);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btSavar);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.cbSubgrupo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadastroProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de produtos";
            this.Load += new System.EventHandler(this.FrmCadastroProdutos_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btCriar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripButton btLocalizar;
        private System.Windows.Forms.ToolStripButton btEditar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btExcluir;
        private System.Windows.Forms.ToolStripStatusLabel lbNomeUser;
        private System.Windows.Forms.ToolStripStatusLabel lbOperacao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbSubgrupo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtCod;
        private System.Windows.Forms.Button btSavar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ComboBox CbUm;
    }
}