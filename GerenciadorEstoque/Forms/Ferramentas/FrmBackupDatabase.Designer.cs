namespace GerenciadorEstoque.Forms.Ferramentas
{
    partial class FrmBackupDatabase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBackupDatabase));
            this.label1 = new System.Windows.Forms.Label();
            this.BtRestaurar = new System.Windows.Forms.Button();
            this.BtBackup = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtBackupImagens = new System.Windows.Forms.Button();
            this.BtRestauraImagens = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "Faça backup e restaure o banco de da\r\ndos do sistema diretamente do programa.";
            // 
            // BtRestaurar
            // 
            this.BtRestaurar.Image = global::GerenciadorEstoque.Properties.Resources.clouddownload2x;
            this.BtRestaurar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtRestaurar.Location = new System.Drawing.Point(172, 27);
            this.BtRestaurar.Name = "BtRestaurar";
            this.BtRestaurar.Size = new System.Drawing.Size(78, 23);
            this.BtRestaurar.TabIndex = 0;
            this.BtRestaurar.Text = "Restaurar";
            this.BtRestaurar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtRestaurar.UseVisualStyleBackColor = true;
            this.BtRestaurar.Click += new System.EventHandler(this.BtRestaurar_Click);
            // 
            // BtBackup
            // 
            this.BtBackup.Image = global::GerenciadorEstoque.Properties.Resources.cloudupload2x;
            this.BtBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtBackup.Location = new System.Drawing.Point(6, 27);
            this.BtBackup.Name = "BtBackup";
            this.BtBackup.Size = new System.Drawing.Size(78, 23);
            this.BtBackup.TabIndex = 0;
            this.BtBackup.Text = "Backup";
            this.BtBackup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtBackup.UseVisualStyleBackColor = true;
            this.BtBackup.Click += new System.EventHandler(this.BtBackup_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtBackup);
            this.groupBox1.Controls.Add(this.BtRestaurar);
            this.groupBox1.Location = new System.Drawing.Point(16, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 70);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Banco de dados";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtBackupImagens);
            this.groupBox2.Controls.Add(this.BtRestauraImagens);
            this.groupBox2.Location = new System.Drawing.Point(16, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 79);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Imagens";
            // 
            // BtBackupImagens
            // 
            this.BtBackupImagens.Image = global::GerenciadorEstoque.Properties.Resources.cloudupload2x;
            this.BtBackupImagens.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtBackupImagens.Location = new System.Drawing.Point(6, 33);
            this.BtBackupImagens.Name = "BtBackupImagens";
            this.BtBackupImagens.Size = new System.Drawing.Size(78, 23);
            this.BtBackupImagens.TabIndex = 0;
            this.BtBackupImagens.Text = "Backup";
            this.BtBackupImagens.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtBackupImagens.UseVisualStyleBackColor = true;
            this.BtBackupImagens.Click += new System.EventHandler(this.BtBackupImagens_Click);
            // 
            // BtRestauraImagens
            // 
            this.BtRestauraImagens.Image = global::GerenciadorEstoque.Properties.Resources.clouddownload2x;
            this.BtRestauraImagens.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtRestauraImagens.Location = new System.Drawing.Point(172, 33);
            this.BtRestauraImagens.Name = "BtRestauraImagens";
            this.BtRestauraImagens.Size = new System.Drawing.Size(78, 23);
            this.BtRestauraImagens.TabIndex = 0;
            this.BtRestauraImagens.Text = "Restaurar";
            this.BtRestauraImagens.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtRestauraImagens.UseVisualStyleBackColor = true;
            this.BtRestauraImagens.Click += new System.EventHandler(this.BtRestauraImagens_Click);
            // 
            // FrmBackupDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 217);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBackupDatabase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup do banco de dados";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtBackup;
        private System.Windows.Forms.Button BtRestaurar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtBackupImagens;
        private System.Windows.Forms.Button BtRestauraImagens;
    }
}