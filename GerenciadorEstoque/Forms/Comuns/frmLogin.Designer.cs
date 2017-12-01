namespace GerenciadorEstoque.Forms.Comuns
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lbNome = new System.Windows.Forms.Label();
            this.lbSenha = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btLogin = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbxPermanecerLogado = new System.Windows.Forms.CheckBox();
            this.lbEsqueceuASenha = new System.Windows.Forms.LinkLabel();
            this.pnEsqueciSenha = new System.Windows.Forms.Panel();
            this.btOk = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.btEnvia = new System.Windows.Forms.Button();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnEsqueciSenha.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(120, 15);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(46, 13);
            this.lbNome.TabIndex = 0;
            this.lbNome.Text = "Usuário:";
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.Location = new System.Drawing.Point(125, 41);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(41, 13);
            this.lbSenha.TabIndex = 1;
            this.lbSenha.Text = "Senha:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(172, 12);
            this.txtUsuario.MaxLength = 10;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 0;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(172, 38);
            this.txtSenha.MaxLength = 10;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(100, 20);
            this.txtSenha.TabIndex = 1;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(205, 105);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(67, 23);
            this.btLogin.TabIndex = 4;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.BtLogin_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancelar.Location = new System.Drawing.Point(132, 105);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(67, 23);
            this.btCancelar.TabIndex = 3;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.BtCancelar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // cbxPermanecerLogado
            // 
            this.cbxPermanecerLogado.AutoSize = true;
            this.cbxPermanecerLogado.Location = new System.Drawing.Point(132, 64);
            this.cbxPermanecerLogado.Name = "cbxPermanecerLogado";
            this.cbxPermanecerLogado.Size = new System.Drawing.Size(137, 17);
            this.cbxPermanecerLogado.TabIndex = 2;
            this.cbxPermanecerLogado.Text = "Permanecer conectado";
            this.cbxPermanecerLogado.UseVisualStyleBackColor = true;
            // 
            // lbEsqueceuASenha
            // 
            this.lbEsqueceuASenha.AutoSize = true;
            this.lbEsqueceuASenha.Location = new System.Drawing.Point(156, 84);
            this.lbEsqueceuASenha.Name = "lbEsqueceuASenha";
            this.lbEsqueceuASenha.Size = new System.Drawing.Size(113, 13);
            this.lbEsqueceuASenha.TabIndex = 5;
            this.lbEsqueceuASenha.TabStop = true;
            this.lbEsqueceuASenha.Text = "Esqueceu sua senha?";
            this.lbEsqueceuASenha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LbEsqueceuASenha_LinkClicked);
            // 
            // pnEsqueciSenha
            // 
            this.pnEsqueciSenha.Controls.Add(this.btOk);
            this.pnEsqueciSenha.Controls.Add(this.btCancel);
            this.pnEsqueciSenha.Controls.Add(this.btEnvia);
            this.pnEsqueciSenha.Controls.Add(this.lbCodigo);
            this.pnEsqueciSenha.Controls.Add(this.txtCod);
            this.pnEsqueciSenha.Location = new System.Drawing.Point(1, 1);
            this.pnEsqueciSenha.Name = "pnEsqueciSenha";
            this.pnEsqueciSenha.Size = new System.Drawing.Size(283, 138);
            this.pnEsqueciSenha.TabIndex = 6;
            this.pnEsqueciSenha.Visible = false;
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(139, 59);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(86, 23);
            this.btOk.TabIndex = 2;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.BtOk_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(47, 59);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(86, 23);
            this.btCancel.TabIndex = 2;
            this.btCancel.Text = "Cancelar";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.BtCancel_Click);
            // 
            // btEnvia
            // 
            this.btEnvia.Location = new System.Drawing.Point(76, 99);
            this.btEnvia.Name = "btEnvia";
            this.btEnvia.Size = new System.Drawing.Size(123, 23);
            this.btEnvia.TabIndex = 2;
            this.btEnvia.Text = "Enviar  novo código";
            this.btEnvia.UseVisualStyleBackColor = true;
            this.btEnvia.Click += new System.EventHandler(this.BtEnvia_Click);
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Location = new System.Drawing.Point(80, 11);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(118, 13);
            this.lbCodigo.TabIndex = 1;
            this.lbCodigo.Text = "Código de recuperação";
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(88, 30);
            this.txtCod.MaxLength = 6;
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(100, 20);
            this.txtCod.TabIndex = 0;
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancelar;
            this.ClientSize = new System.Drawing.Size(284, 140);
            this.Controls.Add(this.pnEsqueciSenha);
            this.Controls.Add(this.lbEsqueceuASenha);
            this.Controls.Add(this.cbxPermanecerLogado);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lbSenha);
            this.Controls.Add(this.lbNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnEsqueciSenha.ResumeLayout(false);
            this.pnEsqueciSenha.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox cbxPermanecerLogado;
        private System.Windows.Forms.LinkLabel lbEsqueceuASenha;
        private System.Windows.Forms.Panel pnEsqueciSenha;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btEnvia;
        private System.Windows.Forms.Button btOk;
    }
}