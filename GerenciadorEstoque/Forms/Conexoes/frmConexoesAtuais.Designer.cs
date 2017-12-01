namespace GerenciadorEstoque.Forms.Conexoes
{
    partial class frmConexoesAtuais
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConexoesAtuais));
            this.label1 = new System.Windows.Forms.Label();
            this.lbNomePC = new System.Windows.Forms.Label();
            this.dgvCon = new System.Windows.Forms.DataGridView();
            this.idCon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomePC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatqaCon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.excluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Computador local:";
            // 
            // lbNomePC
            // 
            this.lbNomePC.AutoSize = true;
            this.lbNomePC.Location = new System.Drawing.Point(110, 20);
            this.lbNomePC.Name = "lbNomePC";
            this.lbNomePC.Size = new System.Drawing.Size(0, 13);
            this.lbNomePC.TabIndex = 2;
            // 
            // dgvCon
            // 
            this.dgvCon.AllowUserToAddRows = false;
            this.dgvCon.AllowUserToDeleteRows = false;
            this.dgvCon.AllowUserToResizeColumns = false;
            this.dgvCon.AllowUserToResizeRows = false;
            this.dgvCon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCon,
            this.nomePC,
            this.DatqaCon,
            this.excluir});
            this.dgvCon.Location = new System.Drawing.Point(12, 52);
            this.dgvCon.Name = "dgvCon";
            this.dgvCon.ReadOnly = true;
            this.dgvCon.RowHeadersVisible = false;
            this.dgvCon.Size = new System.Drawing.Size(270, 365);
            this.dgvCon.TabIndex = 3;
            this.dgvCon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCon_CellClick);
            this.dgvCon.SelectionChanged += new System.EventHandler(this.DgvCon_SelectionChanged);
            // 
            // idCon
            // 
            this.idCon.HeaderText = "ID";
            this.idCon.Name = "idCon";
            this.idCon.ReadOnly = true;
            this.idCon.Visible = false;
            // 
            // nomePC
            // 
            this.nomePC.HeaderText = "NOME PC";
            this.nomePC.Name = "nomePC";
            this.nomePC.ReadOnly = true;
            this.nomePC.Width = 120;
            // 
            // DatqaCon
            // 
            this.DatqaCon.HeaderText = "ÚLTIMO LOGIN";
            this.DatqaCon.Name = "DatqaCon";
            this.DatqaCon.ReadOnly = true;
            this.DatqaCon.Width = 120;
            // 
            // excluir
            // 
            this.excluir.HeaderText = "";
            this.excluir.Image = global::GerenciadorEstoque.Properties.Resources.trash2x;
            this.excluir.Name = "excluir";
            this.excluir.ReadOnly = true;
            this.excluir.Width = 26;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::GerenciadorEstoque.Properties.Resources.trash2x;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 26;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(269, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Remover todas as conexões automáticas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // frmConexoesAtuais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 455);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvCon);
            this.Controls.Add(this.lbNomePC);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConexoesAtuais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar conexões";
            this.Load += new System.EventHandler(this.FrmConexoesAtuais_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNomePC;
        private System.Windows.Forms.DataGridView dgvCon;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCon;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomePC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatqaCon;
        private System.Windows.Forms.DataGridViewImageColumn excluir;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Button button1;
    }
}