namespace GerenciadorEstoque.Forms.Configuracoes
{
    partial class FrmConfiguracoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfiguracoes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnDadosUsuario = new System.Windows.Forms.Panel();
            this.lbAlterarSenha = new System.Windows.Forms.LinkLabel();
            this.btCancelarUsuario = new System.Windows.Forms.Button();
            this.btSalvarUsuario = new System.Windows.Forms.Button();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pnServidoresEmail = new System.Windows.Forms.Panel();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btTestarConexao = new System.Windows.Forms.Button();
            this.cbxSSL = new System.Windows.Forms.CheckBox();
            this.txtPorta = new System.Windows.Forms.TextBox();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnMenus = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbServidorDeEmail = new System.Windows.Forms.LinkLabel();
            this.lbDadosUsuario = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.pnDadosUsuario.SuspendLayout();
            this.pnServidoresEmail.SuspendLayout();
            this.pnMenus.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnDadosUsuario);
            this.panel1.Controls.Add(this.pnServidoresEmail);
            this.panel1.Controls.Add(this.pnMenus);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(743, 592);
            this.panel1.TabIndex = 0;
            // 
            // pnDadosUsuario
            // 
            this.pnDadosUsuario.Controls.Add(this.lbAlterarSenha);
            this.pnDadosUsuario.Controls.Add(this.btCancelarUsuario);
            this.pnDadosUsuario.Controls.Add(this.btSalvarUsuario);
            this.pnDadosUsuario.Controls.Add(this.txtTelefone);
            this.pnDadosUsuario.Controls.Add(this.txtEmail);
            this.pnDadosUsuario.Controls.Add(this.txtNome);
            this.pnDadosUsuario.Controls.Add(this.label9);
            this.pnDadosUsuario.Controls.Add(this.label7);
            this.pnDadosUsuario.Controls.Add(this.label6);
            this.pnDadosUsuario.Controls.Add(this.label8);
            this.pnDadosUsuario.Location = new System.Drawing.Point(197, 9);
            this.pnDadosUsuario.Name = "pnDadosUsuario";
            this.pnDadosUsuario.Size = new System.Drawing.Size(534, 568);
            this.pnDadosUsuario.TabIndex = 2;
            // 
            // lbAlterarSenha
            // 
            this.lbAlterarSenha.AutoSize = true;
            this.lbAlterarSenha.Location = new System.Drawing.Point(73, 148);
            this.lbAlterarSenha.Name = "lbAlterarSenha";
            this.lbAlterarSenha.Size = new System.Drawing.Size(69, 13);
            this.lbAlterarSenha.TabIndex = 4;
            this.lbAlterarSenha.TabStop = true;
            this.lbAlterarSenha.Text = "Alterar senha";
            this.lbAlterarSenha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LbAlterarSenha_LinkClicked);
            // 
            // btCancelarUsuario
            // 
            this.btCancelarUsuario.Location = new System.Drawing.Point(76, 187);
            this.btCancelarUsuario.Name = "btCancelarUsuario";
            this.btCancelarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btCancelarUsuario.TabIndex = 3;
            this.btCancelarUsuario.Text = "Cacelar";
            this.btCancelarUsuario.UseVisualStyleBackColor = true;
            // 
            // btSalvarUsuario
            // 
            this.btSalvarUsuario.Location = new System.Drawing.Point(240, 187);
            this.btSalvarUsuario.Name = "btSalvarUsuario";
            this.btSalvarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btSalvarUsuario.TabIndex = 3;
            this.btSalvarUsuario.Text = "Salvar";
            this.btSalvarUsuario.UseVisualStyleBackColor = true;
            this.btSalvarUsuario.Click += new System.EventHandler(this.BtSalvarUsuario_Click);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(76, 112);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(102, 20);
            this.txtTelefone.TabIndex = 2;
            this.txtTelefone.Enter += new System.EventHandler(this.TxtTelefone_Enter);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(76, 86);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(239, 20);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.Enter += new System.EventHandler(this.TxtEmail_Enter);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(76, 60);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(239, 20);
            this.txtNome.TabIndex = 0;
            this.txtNome.Enter += new System.EventHandler(this.TxtNome_Enter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Telefone:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nome:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Dados do usuário";
            // 
            // pnServidoresEmail
            // 
            this.pnServidoresEmail.Controls.Add(this.btCancelar);
            this.pnServidoresEmail.Controls.Add(this.btSalvar);
            this.pnServidoresEmail.Controls.Add(this.btTestarConexao);
            this.pnServidoresEmail.Controls.Add(this.cbxSSL);
            this.pnServidoresEmail.Controls.Add(this.txtPorta);
            this.pnServidoresEmail.Controls.Add(this.txtServidor);
            this.pnServidoresEmail.Controls.Add(this.label4);
            this.pnServidoresEmail.Controls.Add(this.label3);
            this.pnServidoresEmail.Controls.Add(this.label2);
            this.pnServidoresEmail.Location = new System.Drawing.Point(699, 12);
            this.pnServidoresEmail.Name = "pnServidoresEmail";
            this.pnServidoresEmail.Size = new System.Drawing.Size(534, 568);
            this.pnServidoresEmail.TabIndex = 1;
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(33, 184);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(107, 23);
            this.btCancelar.TabIndex = 3;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.BtCancelar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(146, 184);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(107, 23);
            this.btSalvar.TabIndex = 3;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.BtSalvar_Click);
            // 
            // btTestarConexao
            // 
            this.btTestarConexao.Location = new System.Drawing.Point(146, 145);
            this.btTestarConexao.Name = "btTestarConexao";
            this.btTestarConexao.Size = new System.Drawing.Size(107, 23);
            this.btTestarConexao.TabIndex = 3;
            this.btTestarConexao.Text = "Testar conexão";
            this.btTestarConexao.UseVisualStyleBackColor = true;
            this.btTestarConexao.Click += new System.EventHandler(this.BtTestarConexao_Click);
            // 
            // cbxSSL
            // 
            this.cbxSSL.AutoSize = true;
            this.cbxSSL.Location = new System.Drawing.Point(72, 112);
            this.cbxSSL.Name = "cbxSSL";
            this.cbxSSL.Size = new System.Drawing.Size(101, 17);
            this.cbxSSL.TabIndex = 2;
            this.cbxSSL.Text = "Segurança SSL";
            this.cbxSSL.UseVisualStyleBackColor = true;
            // 
            // txtPorta
            // 
            this.txtPorta.Location = new System.Drawing.Point(73, 86);
            this.txtPorta.Name = "txtPorta";
            this.txtPorta.Size = new System.Drawing.Size(180, 20);
            this.txtPorta.TabIndex = 1;
            // 
            // txtServidor
            // 
            this.txtServidor.Location = new System.Drawing.Point(73, 60);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(180, 20);
            this.txtServidor.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Porta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Servidor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Configurar servidor de email";
            // 
            // pnMenus
            // 
            this.pnMenus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnMenus.Controls.Add(this.tableLayoutPanel1);
            this.pnMenus.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMenus.Location = new System.Drawing.Point(0, 0);
            this.pnMenus.Name = "pnMenus";
            this.pnMenus.Size = new System.Drawing.Size(191, 592);
            this.pnMenus.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbServidorDeEmail, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbDadosUsuario, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(191, 592);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 70);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 35);
            this.label5.TabIndex = 2;
            this.label5.Text = "Usuário";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbServidorDeEmail
            // 
            this.lbServidorDeEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbServidorDeEmail.Location = new System.Drawing.Point(0, 45);
            this.lbServidorDeEmail.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.lbServidorDeEmail.Name = "lbServidorDeEmail";
            this.lbServidorDeEmail.Size = new System.Drawing.Size(191, 15);
            this.lbServidorDeEmail.TabIndex = 1;
            this.lbServidorDeEmail.TabStop = true;
            this.lbServidorDeEmail.Text = "Servidor de email";
            this.lbServidorDeEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbServidorDeEmail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LbServidorDeEmail_LinkClicked);
            // 
            // lbDadosUsuario
            // 
            this.lbDadosUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDadosUsuario.Location = new System.Drawing.Point(0, 115);
            this.lbDadosUsuario.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.lbDadosUsuario.Name = "lbDadosUsuario";
            this.lbDadosUsuario.Size = new System.Drawing.Size(191, 15);
            this.lbDadosUsuario.TabIndex = 1;
            this.lbDadosUsuario.TabStop = true;
            this.lbDadosUsuario.Text = "Dados do usuário";
            this.lbDadosUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbDadosUsuario.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LbDadosUsuario_LinkClicked);
            // 
            // FrmConfiguracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 592);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmConfiguracoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurações";
            this.Load += new System.EventHandler(this.FrmConfiguracoes_Load);
            this.panel1.ResumeLayout(false);
            this.pnDadosUsuario.ResumeLayout(false);
            this.pnDadosUsuario.PerformLayout();
            this.pnServidoresEmail.ResumeLayout(false);
            this.pnServidoresEmail.PerformLayout();
            this.pnMenus.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnMenus;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lbServidorDeEmail;
        private System.Windows.Forms.Panel pnServidoresEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btTestarConexao;
        private System.Windows.Forms.CheckBox cbxSSL;
        private System.Windows.Forms.TextBox txtPorta;
        private System.Windows.Forms.TextBox txtServidor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel lbDadosUsuario;
        private System.Windows.Forms.Panel pnDadosUsuario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.LinkLabel lbAlterarSenha;
        private System.Windows.Forms.Button btCancelarUsuario;
        private System.Windows.Forms.Button btSalvarUsuario;
    }
}