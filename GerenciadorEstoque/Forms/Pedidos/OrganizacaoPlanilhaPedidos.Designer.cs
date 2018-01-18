namespace GerenciadorEstoque.Forms.Pedidos
{
    partial class OrganizacaoPlanilhaPedidos
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
            this.cbUnidade = new System.Windows.Forms.ComboBox();
            this.lbUnidade = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbUnidade
            // 
            this.cbUnidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUnidade.FormattingEnabled = true;
            this.cbUnidade.Location = new System.Drawing.Point(65, 22);
            this.cbUnidade.Name = "cbUnidade";
            this.cbUnidade.Size = new System.Drawing.Size(116, 21);
            this.cbUnidade.TabIndex = 14;
            this.cbUnidade.TabStop = false;
            // 
            // lbUnidade
            // 
            this.lbUnidade.AutoSize = true;
            this.lbUnidade.Location = new System.Drawing.Point(12, 25);
            this.lbUnidade.Name = "lbUnidade";
            this.lbUnidade.Size = new System.Drawing.Size(47, 13);
            this.lbUnidade.TabIndex = 13;
            this.lbUnidade.Text = "Unidade";
            // 
            // OrganizacaoPlanilhaPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 538);
            this.Controls.Add(this.cbUnidade);
            this.Controls.Add(this.lbUnidade);
            this.Name = "OrganizacaoPlanilhaPedidos";
            this.Text = "OrganizacaoPlanilhaPedidos";
            this.Load += new System.EventHandler(this.OrganizacaoPlanilhaPedidos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbUnidade;
        private System.Windows.Forms.Label lbUnidade;
    }
}