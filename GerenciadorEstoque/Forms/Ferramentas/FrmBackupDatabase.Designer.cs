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
            this.BtRestaurar.Location = new System.Drawing.Point(194, 75);
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
            this.BtBackup.Location = new System.Drawing.Point(110, 75);
            this.BtBackup.Name = "BtBackup";
            this.BtBackup.Size = new System.Drawing.Size(78, 23);
            this.BtBackup.TabIndex = 0;
            this.BtBackup.Text = "Backup";
            this.BtBackup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtBackup.UseVisualStyleBackColor = true;
            this.BtBackup.Click += new System.EventHandler(this.BtBackup_Click);
            // 
            // FrmBackupDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 110);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtRestaurar);
            this.Controls.Add(this.BtBackup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBackupDatabase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup do banco de dados";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtBackup;
        private System.Windows.Forms.Button BtRestaurar;
        private System.Windows.Forms.Label label1;
    }
}