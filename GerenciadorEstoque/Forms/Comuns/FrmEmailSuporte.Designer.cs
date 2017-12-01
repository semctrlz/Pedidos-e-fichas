namespace GerenciadorEstoque.Forms.Comuns
{
    partial class FrmEmailSuporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmailSuporte));
            this.label1 = new System.Windows.Forms.Label();
            this.txtAssunto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtMensagem = new System.Windows.Forms.TextBox();
            this.BtEnviar = new System.Windows.Forms.Button();
            this.BtCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Assunto";
            // 
            // txtAssunto
            // 
            this.txtAssunto.Location = new System.Drawing.Point(16, 30);
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(337, 20);
            this.txtAssunto.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mensagem";
            // 
            // TxtMensagem
            // 
            this.TxtMensagem.Location = new System.Drawing.Point(15, 70);
            this.TxtMensagem.Multiline = true;
            this.TxtMensagem.Name = "TxtMensagem";
            this.TxtMensagem.Size = new System.Drawing.Size(337, 195);
            this.TxtMensagem.TabIndex = 1;
            // 
            // BtEnviar
            // 
            this.BtEnviar.Location = new System.Drawing.Point(276, 272);
            this.BtEnviar.Name = "BtEnviar";
            this.BtEnviar.Size = new System.Drawing.Size(75, 23);
            this.BtEnviar.TabIndex = 3;
            this.BtEnviar.Text = "Enviar";
            this.BtEnviar.UseVisualStyleBackColor = true;
            this.BtEnviar.Click += new System.EventHandler(this.BtEnviar_Click);
            // 
            // BtCancelar
            // 
            this.BtCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtCancelar.Location = new System.Drawing.Point(16, 271);
            this.BtCancelar.Name = "BtCancelar";
            this.BtCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtCancelar.TabIndex = 2;
            this.BtCancelar.Text = "Cancelar";
            this.BtCancelar.UseVisualStyleBackColor = true;
            this.BtCancelar.Click += new System.EventHandler(this.BtCancelar_Click);
            // 
            // FrmEmailSuporte
            // 
            this.AcceptButton = this.BtEnviar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtCancelar;
            this.ClientSize = new System.Drawing.Size(365, 307);
            this.Controls.Add(this.BtCancelar);
            this.Controls.Add(this.BtEnviar);
            this.Controls.Add(this.TxtMensagem);
            this.Controls.Add(this.txtAssunto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEmailSuporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Suporte";
            this.Load += new System.EventHandler(this.FrmEmailSuporte_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAssunto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtMensagem;
        private System.Windows.Forms.Button BtEnviar;
        private System.Windows.Forms.Button BtCancelar;
    }
}