namespace GerenciadorEstoque.Forms.Usuarios
{
    partial class FrmCadastroUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroUsuarios));
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.BtSalvar = new System.Windows.Forms.Button();
            this.BtCancelar = new System.Windows.Forms.Button();
            this.CbxAtivo = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GbAcessos = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CbFichas = new System.Windows.Forms.ComboBox();
            this.CbCadastro = new System.Windows.Forms.ComboBox();
            this.CbUsuarios = new System.Windows.Forms.ComboBox();
            this.CbCompras = new System.Windows.Forms.ComboBox();
            this.CbUnidade = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BtBuscar = new System.Windows.Forms.Button();
            this.BtEditar = new System.Windows.Forms.Button();
            this.BtExcluir = new System.Windows.Forms.Button();
            this.GbDados = new System.Windows.Forms.GroupBox();
            this.TxtTelefone = new System.Windows.Forms.TextBox();
            this.GbAcessos.SuspendLayout();
            this.GbDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(9, 32);
            this.TxtNome.MaxLength = 60;
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(228, 20);
            this.TxtNome.TabIndex = 0;
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Location = new System.Drawing.Point(9, 79);
            this.TxtUsuario.MaxLength = 10;
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(127, 20);
            this.TxtUsuario.TabIndex = 2;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(9, 126);
            this.TxtEmail.MaxLength = 100;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(260, 20);
            this.TxtEmail.TabIndex = 4;
            // 
            // BtSalvar
            // 
            this.BtSalvar.Location = new System.Drawing.Point(216, 443);
            this.BtSalvar.Name = "BtSalvar";
            this.BtSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtSalvar.TabIndex = 5;
            this.BtSalvar.Text = "Salvar";
            this.BtSalvar.UseVisualStyleBackColor = true;
            this.BtSalvar.Click += new System.EventHandler(this.BtSalvar_Click);
            // 
            // BtCancelar
            // 
            this.BtCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtCancelar.Location = new System.Drawing.Point(12, 443);
            this.BtCancelar.Name = "BtCancelar";
            this.BtCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtCancelar.TabIndex = 4;
            this.BtCancelar.Text = "Cancelar";
            this.BtCancelar.UseVisualStyleBackColor = true;
            // 
            // CbxAtivo
            // 
            this.CbxAtivo.AutoSize = true;
            this.CbxAtivo.Checked = true;
            this.CbxAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbxAtivo.Location = new System.Drawing.Point(185, 175);
            this.CbxAtivo.Name = "CbxAtivo";
            this.CbxAtivo.Size = new System.Drawing.Size(89, 17);
            this.CbxAtivo.TabIndex = 6;
            this.CbxAtivo.Text = "Usuário Ativo";
            this.CbxAtivo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Usuário";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefone";
            // 
            // GbAcessos
            // 
            this.GbAcessos.Controls.Add(this.label8);
            this.GbAcessos.Controls.Add(this.label7);
            this.GbAcessos.Controls.Add(this.label6);
            this.GbAcessos.Controls.Add(this.label5);
            this.GbAcessos.Controls.Add(this.CbFichas);
            this.GbAcessos.Controls.Add(this.CbCadastro);
            this.GbAcessos.Controls.Add(this.CbUsuarios);
            this.GbAcessos.Controls.Add(this.CbCompras);
            this.GbAcessos.Location = new System.Drawing.Point(12, 223);
            this.GbAcessos.Name = "GbAcessos";
            this.GbAcessos.Size = new System.Drawing.Size(279, 125);
            this.GbAcessos.TabIndex = 1;
            this.GbAcessos.TabStop = false;
            this.GbAcessos.Text = "Acessos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(142, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Fichas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(142, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Usuarios";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Cadastros";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Compras";
            // 
            // CbFichas
            // 
            this.CbFichas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbFichas.FormattingEnabled = true;
            this.CbFichas.Items.AddRange(new object[] {
            "Nenhum",
            "Visualiza",
            "Cria",
            "Exclui",
            "Admin"});
            this.CbFichas.Location = new System.Drawing.Point(142, 84);
            this.CbFichas.Name = "CbFichas";
            this.CbFichas.Size = new System.Drawing.Size(131, 21);
            this.CbFichas.TabIndex = 3;
            // 
            // CbCadastro
            // 
            this.CbCadastro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbCadastro.FormattingEnabled = true;
            this.CbCadastro.Items.AddRange(new object[] {
            "Nenhum",
            "Visualiza",
            "Cria",
            "Exclui",
            "Admin"});
            this.CbCadastro.Location = new System.Drawing.Point(6, 84);
            this.CbCadastro.Name = "CbCadastro";
            this.CbCadastro.Size = new System.Drawing.Size(131, 21);
            this.CbCadastro.TabIndex = 2;
            // 
            // CbUsuarios
            // 
            this.CbUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbUsuarios.FormattingEnabled = true;
            this.CbUsuarios.Items.AddRange(new object[] {
            "Nenhum",
            "Visualiza",
            "Cria",
            "Exclui",
            "Admin"});
            this.CbUsuarios.Location = new System.Drawing.Point(142, 41);
            this.CbUsuarios.Name = "CbUsuarios";
            this.CbUsuarios.Size = new System.Drawing.Size(131, 21);
            this.CbUsuarios.TabIndex = 1;
            // 
            // CbCompras
            // 
            this.CbCompras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbCompras.FormattingEnabled = true;
            this.CbCompras.Items.AddRange(new object[] {
            "Nenhum",
            "Visualiza",
            "Cria",
            "Exclui",
            "Admin"});
            this.CbCompras.Location = new System.Drawing.Point(6, 41);
            this.CbCompras.Name = "CbCompras";
            this.CbCompras.Size = new System.Drawing.Size(131, 21);
            this.CbCompras.TabIndex = 0;
            // 
            // CbUnidade
            // 
            this.CbUnidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbUnidade.FormattingEnabled = true;
            this.CbUnidade.Location = new System.Drawing.Point(142, 79);
            this.CbUnidade.Name = "CbUnidade";
            this.CbUnidade.Size = new System.Drawing.Size(127, 21);
            this.CbUnidade.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(141, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Unidade";
            // 
            // BtBuscar
            // 
            this.BtBuscar.Image = global::GerenciadorEstoque.Properties.Resources.magnifyingGlass2x;
            this.BtBuscar.Location = new System.Drawing.Point(242, 28);
            this.BtBuscar.Name = "BtBuscar";
            this.BtBuscar.Size = new System.Drawing.Size(26, 26);
            this.BtBuscar.TabIndex = 1;
            this.BtBuscar.UseVisualStyleBackColor = true;
            this.BtBuscar.Click += new System.EventHandler(this.BtBuscar_Click);
            // 
            // BtEditar
            // 
            this.BtEditar.Image = global::GerenciadorEstoque.Properties.Resources.pencil2x;
            this.BtEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtEditar.Location = new System.Drawing.Point(12, 366);
            this.BtEditar.Name = "BtEditar";
            this.BtEditar.Size = new System.Drawing.Size(66, 23);
            this.BtEditar.TabIndex = 2;
            this.BtEditar.Text = "Editar";
            this.BtEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtEditar.UseVisualStyleBackColor = true;
            this.BtEditar.Click += new System.EventHandler(this.BtEditar_Click);
            // 
            // BtExcluir
            // 
            this.BtExcluir.Image = global::GerenciadorEstoque.Properties.Resources.trash2x;
            this.BtExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtExcluir.Location = new System.Drawing.Point(225, 366);
            this.BtExcluir.Name = "BtExcluir";
            this.BtExcluir.Size = new System.Drawing.Size(66, 23);
            this.BtExcluir.TabIndex = 3;
            this.BtExcluir.Text = "Excluir";
            this.BtExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtExcluir.UseVisualStyleBackColor = true;
            this.BtExcluir.Click += new System.EventHandler(this.BtExcluir_Click);
            // 
            // GbDados
            // 
            this.GbDados.Controls.Add(this.label1);
            this.GbDados.Controls.Add(this.TxtNome);
            this.GbDados.Controls.Add(this.TxtUsuario);
            this.GbDados.Controls.Add(this.TxtTelefone);
            this.GbDados.Controls.Add(this.TxtEmail);
            this.GbDados.Controls.Add(this.BtBuscar);
            this.GbDados.Controls.Add(this.label9);
            this.GbDados.Controls.Add(this.CbUnidade);
            this.GbDados.Controls.Add(this.label3);
            this.GbDados.Controls.Add(this.CbxAtivo);
            this.GbDados.Controls.Add(this.label4);
            this.GbDados.Controls.Add(this.label2);
            this.GbDados.Location = new System.Drawing.Point(12, 8);
            this.GbDados.Name = "GbDados";
            this.GbDados.Size = new System.Drawing.Size(279, 209);
            this.GbDados.TabIndex = 0;
            this.GbDados.TabStop = false;
            // 
            // TxtTelefone
            // 
            this.TxtTelefone.Location = new System.Drawing.Point(9, 173);
            this.TxtTelefone.MaxLength = 35;
            this.TxtTelefone.Name = "TxtTelefone";
            this.TxtTelefone.Size = new System.Drawing.Size(170, 20);
            this.TxtTelefone.TabIndex = 5;
            // 
            // FrmCadastroUsuarios
            // 
            this.AcceptButton = this.BtSalvar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtCancelar;
            this.ClientSize = new System.Drawing.Size(301, 486);
            this.Controls.Add(this.GbDados);
            this.Controls.Add(this.BtExcluir);
            this.Controls.Add(this.BtEditar);
            this.Controls.Add(this.GbAcessos);
            this.Controls.Add(this.BtCancelar);
            this.Controls.Add(this.BtSalvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadastroUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastros de usuários";
            this.Load += new System.EventHandler(this.FrmCadastroUsuarios_Load);
            this.GbAcessos.ResumeLayout(false);
            this.GbAcessos.PerformLayout();
            this.GbDados.ResumeLayout(false);
            this.GbDados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Button BtSalvar;
        private System.Windows.Forms.Button BtCancelar;
        private System.Windows.Forms.CheckBox CbxAtivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox GbAcessos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CbCompras;
        private System.Windows.Forms.ComboBox CbUsuarios;
        private System.Windows.Forms.ComboBox CbFichas;
        private System.Windows.Forms.ComboBox CbCadastro;
        private System.Windows.Forms.ComboBox CbUnidade;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtBuscar;
        private System.Windows.Forms.Button BtEditar;
        private System.Windows.Forms.Button BtExcluir;
        private System.Windows.Forms.GroupBox GbDados;
        private System.Windows.Forms.TextBox TxtTelefone;
    }
}