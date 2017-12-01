namespace GerenciadorEstoque.Forms.Usuarios
{
    partial class FrmConsultaUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaUsuarios));
            this.PnSuperior = new System.Windows.Forms.Panel();
            this.CbxSomenteAtivos = new System.Windows.Forms.CheckBox();
            this.BtEditar = new System.Windows.Forms.Button();
            this.BtCancelar = new System.Windows.Forms.Button();
            this.CbUnidade = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.PnInferior = new System.Windows.Forms.Panel();
            this.DgvUsuarios = new System.Windows.Forms.DataGridView();
            this.PnSuperior.SuspendLayout();
            this.PnInferior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // PnSuperior
            // 
            this.PnSuperior.Controls.Add(this.CbxSomenteAtivos);
            this.PnSuperior.Controls.Add(this.BtEditar);
            this.PnSuperior.Controls.Add(this.BtCancelar);
            this.PnSuperior.Controls.Add(this.CbUnidade);
            this.PnSuperior.Controls.Add(this.label3);
            this.PnSuperior.Controls.Add(this.label2);
            this.PnSuperior.Controls.Add(this.label1);
            this.PnSuperior.Controls.Add(this.TxtUsuario);
            this.PnSuperior.Controls.Add(this.TxtNome);
            this.PnSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnSuperior.Location = new System.Drawing.Point(0, 0);
            this.PnSuperior.Name = "PnSuperior";
            this.PnSuperior.Size = new System.Drawing.Size(516, 105);
            this.PnSuperior.TabIndex = 1;
            // 
            // CbxSomenteAtivos
            // 
            this.CbxSomenteAtivos.AutoSize = true;
            this.CbxSomenteAtivos.Checked = true;
            this.CbxSomenteAtivos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbxSomenteAtivos.Location = new System.Drawing.Point(13, 80);
            this.CbxSomenteAtivos.Name = "CbxSomenteAtivos";
            this.CbxSomenteAtivos.Size = new System.Drawing.Size(99, 17);
            this.CbxSomenteAtivos.TabIndex = 3;
            this.CbxSomenteAtivos.Text = "Somente ativos";
            this.CbxSomenteAtivos.UseVisualStyleBackColor = true;
            this.CbxSomenteAtivos.CheckedChanged += new System.EventHandler(this.CbxSomenteAtivos_CheckedChanged);
            // 
            // BtEditar
            // 
            this.BtEditar.Location = new System.Drawing.Point(429, 76);
            this.BtEditar.Name = "BtEditar";
            this.BtEditar.Size = new System.Drawing.Size(75, 23);
            this.BtEditar.TabIndex = 5;
            this.BtEditar.Text = "Editar";
            this.BtEditar.UseVisualStyleBackColor = true;
            this.BtEditar.Click += new System.EventHandler(this.BtEditar_Click);
            // 
            // BtCancelar
            // 
            this.BtCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtCancelar.Location = new System.Drawing.Point(348, 76);
            this.BtCancelar.Name = "BtCancelar";
            this.BtCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtCancelar.TabIndex = 4;
            this.BtCancelar.Text = "Cancelar";
            this.BtCancelar.UseVisualStyleBackColor = true;
            this.BtCancelar.Click += new System.EventHandler(this.BtCancelar_Click);
            // 
            // CbUnidade
            // 
            this.CbUnidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbUnidade.FormattingEnabled = true;
            this.CbUnidade.Location = new System.Drawing.Point(363, 42);
            this.CbUnidade.Name = "CbUnidade";
            this.CbUnidade.Size = new System.Drawing.Size(141, 21);
            this.CbUnidade.TabIndex = 2;
            this.CbUnidade.SelectedIndexChanged += new System.EventHandler(this.CbUnidade_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(360, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Unidade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuário";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Location = new System.Drawing.Point(253, 43);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(104, 20);
            this.TxtUsuario.TabIndex = 1;
            this.TxtUsuario.TextChanged += new System.EventHandler(this.TxtUsuario_TextChanged);
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(13, 43);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(234, 20);
            this.TxtNome.TabIndex = 0;
            this.TxtNome.TextChanged += new System.EventHandler(this.TxtNome_TextChanged);
            // 
            // PnInferior
            // 
            this.PnInferior.Controls.Add(this.DgvUsuarios);
            this.PnInferior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnInferior.Location = new System.Drawing.Point(0, 105);
            this.PnInferior.Name = "PnInferior";
            this.PnInferior.Size = new System.Drawing.Size(516, 641);
            this.PnInferior.TabIndex = 1;
            // 
            // DgvUsuarios
            // 
            this.DgvUsuarios.AllowUserToAddRows = false;
            this.DgvUsuarios.AllowUserToDeleteRows = false;
            this.DgvUsuarios.AllowUserToResizeColumns = false;
            this.DgvUsuarios.AllowUserToResizeRows = false;
            this.DgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvUsuarios.Location = new System.Drawing.Point(0, 0);
            this.DgvUsuarios.Name = "DgvUsuarios";
            this.DgvUsuarios.ReadOnly = true;
            this.DgvUsuarios.RowHeadersVisible = false;
            this.DgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvUsuarios.Size = new System.Drawing.Size(516, 641);
            this.DgvUsuarios.TabIndex = 0;
            this.DgvUsuarios.TabStop = false;
            // 
            // FrmConsultaUsuarios
            // 
            this.AcceptButton = this.BtEditar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtCancelar;
            this.ClientSize = new System.Drawing.Size(516, 746);
            this.Controls.Add(this.PnInferior);
            this.Controls.Add(this.PnSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConsultaUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConsultaUsuarios";
            this.Load += new System.EventHandler(this.FrmConsultaUsuarios_Load);
            this.PnSuperior.ResumeLayout(false);
            this.PnSuperior.PerformLayout();
            this.PnInferior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnSuperior;
        private System.Windows.Forms.ComboBox CbUnidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Panel PnInferior;
        private System.Windows.Forms.DataGridView DgvUsuarios;
        private System.Windows.Forms.Button BtEditar;
        private System.Windows.Forms.Button BtCancelar;
        private System.Windows.Forms.CheckBox CbxSomenteAtivos;
    }
}