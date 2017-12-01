namespace GerenciadorEstoque.Forms.Pedidos
{
    partial class FrmPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPedidos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LbCriarCotacao = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CbxCancelados = new System.Windows.Forms.CheckBox();
            this.CbxSolicitados = new System.Windows.Forms.CheckBox();
            this.CbxAbertos = new System.Windows.Forms.CheckBox();
            this.DgvPedidos = new System.Windows.Forms.DataGridView();
            this.id_pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario_pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edita = new System.Windows.Forms.DataGridViewImageColumn();
            this.deleta = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.LbCriarCotacao);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 69);
            this.panel1.TabIndex = 0;
            // 
            // LbCriarCotacao
            // 
            this.LbCriarCotacao.AutoSize = true;
            this.LbCriarCotacao.Location = new System.Drawing.Point(401, 50);
            this.LbCriarCotacao.Name = "LbCriarCotacao";
            this.LbCriarCotacao.Size = new System.Drawing.Size(68, 13);
            this.LbCriarCotacao.TabIndex = 2;
            this.LbCriarCotacao.TabStop = true;
            this.LbCriarCotacao.Text = "Novo pedido";
            this.LbCriarCotacao.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LbCriarCotacao_LinkClicked);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.38461F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.61539F));
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(475, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(138, 60);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightCoral;
            this.panel4.Location = new System.Drawing.Point(3, 43);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(15, 14);
            this.panel4.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGreen;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(15, 14);
            this.panel3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Aberto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cancelado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Solicitado";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gold;
            this.panel6.Location = new System.Drawing.Point(3, 23);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(15, 14);
            this.panel6.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pedidos";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.CbxCancelados);
            this.panel2.Controls.Add(this.CbxSolicitados);
            this.panel2.Controls.Add(this.CbxAbertos);
            this.panel2.Controls.Add(this.DgvPedidos);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(595, 321);
            this.panel2.TabIndex = 2;
            // 
            // CbxCancelados
            // 
            this.CbxCancelados.AutoSize = true;
            this.CbxCancelados.Checked = true;
            this.CbxCancelados.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbxCancelados.Location = new System.Drawing.Point(12, 52);
            this.CbxCancelados.Name = "CbxCancelados";
            this.CbxCancelados.Size = new System.Drawing.Size(82, 17);
            this.CbxCancelados.TabIndex = 3;
            this.CbxCancelados.Text = "Cancelados";
            this.CbxCancelados.UseVisualStyleBackColor = true;
            this.CbxCancelados.CheckedChanged += new System.EventHandler(this.CbxAbertos_CheckedChanged);
            // 
            // CbxSolicitados
            // 
            this.CbxSolicitados.AutoSize = true;
            this.CbxSolicitados.Checked = true;
            this.CbxSolicitados.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbxSolicitados.Location = new System.Drawing.Point(12, 29);
            this.CbxSolicitados.Name = "CbxSolicitados";
            this.CbxSolicitados.Size = new System.Drawing.Size(77, 17);
            this.CbxSolicitados.TabIndex = 2;
            this.CbxSolicitados.Text = "Solicitados";
            this.CbxSolicitados.UseVisualStyleBackColor = true;
            this.CbxSolicitados.CheckedChanged += new System.EventHandler(this.CbxAbertos_CheckedChanged);
            // 
            // CbxAbertos
            // 
            this.CbxAbertos.AutoSize = true;
            this.CbxAbertos.Checked = true;
            this.CbxAbertos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbxAbertos.Location = new System.Drawing.Point(12, 6);
            this.CbxAbertos.Name = "CbxAbertos";
            this.CbxAbertos.Size = new System.Drawing.Size(62, 17);
            this.CbxAbertos.TabIndex = 1;
            this.CbxAbertos.Text = "Abertos";
            this.CbxAbertos.UseVisualStyleBackColor = true;
            this.CbxAbertos.CheckedChanged += new System.EventHandler(this.CbxAbertos_CheckedChanged);
            // 
            // DgvPedidos
            // 
            this.DgvPedidos.AllowUserToAddRows = false;
            this.DgvPedidos.AllowUserToDeleteRows = false;
            this.DgvPedidos.AllowUserToResizeColumns = false;
            this.DgvPedidos.AllowUserToResizeRows = false;
            this.DgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_pedido,
            this.Status,
            this.data_pedido,
            this.entrega,
            this.usuario_pedido,
            this.edita,
            this.deleta});
            this.DgvPedidos.Location = new System.Drawing.Point(100, 0);
            this.DgvPedidos.Name = "DgvPedidos";
            this.DgvPedidos.ReadOnly = true;
            this.DgvPedidos.RowHeadersVisible = false;
            this.DgvPedidos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgvPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvPedidos.ShowRowErrors = false;
            this.DgvPedidos.Size = new System.Drawing.Size(494, 321);
            this.DgvPedidos.TabIndex = 0;
            this.DgvPedidos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPedidos_CellClick);
            this.DgvPedidos.SelectionChanged += new System.EventHandler(this.DgvPedidos_SelectionChanged);
            // 
            // id_pedido
            // 
            this.id_pedido.HeaderText = "Numero";
            this.id_pedido.Name = "id_pedido";
            this.id_pedido.ReadOnly = true;
            this.id_pedido.Width = 60;
            // 
            // Status
            // 
            this.Status.HeaderText = "status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Visible = false;
            // 
            // data_pedido
            // 
            this.data_pedido.HeaderText = "Data";
            this.data_pedido.Name = "data_pedido";
            this.data_pedido.ReadOnly = true;
            this.data_pedido.Width = 120;
            // 
            // entrega
            // 
            this.entrega.HeaderText = "Previsao entrega";
            this.entrega.Name = "entrega";
            this.entrega.ReadOnly = true;
            this.entrega.Width = 120;
            // 
            // usuario_pedido
            // 
            this.usuario_pedido.HeaderText = "Usuario";
            this.usuario_pedido.Name = "usuario_pedido";
            this.usuario_pedido.ReadOnly = true;
            this.usuario_pedido.Width = 120;
            // 
            // edita
            // 
            this.edita.HeaderText = "";
            this.edita.Image = global::GerenciadorEstoque.Properties.Resources.pencil2x;
            this.edita.Name = "edita";
            this.edita.ReadOnly = true;
            this.edita.Width = 26;
            // 
            // deleta
            // 
            this.deleta.HeaderText = "";
            this.deleta.Image = global::GerenciadorEstoque.Properties.Resources.trash2x;
            this.deleta.Name = "deleta";
            this.deleta.ReadOnly = true;
            this.deleta.Width = 26;
            // 
            // FrmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 390);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.FrmPedidos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPedidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel LbCriarCotacao;
        private System.Windows.Forms.DataGridView DgvPedidos;
        private System.Windows.Forms.CheckBox CbxCancelados;
        private System.Windows.Forms.CheckBox CbxSolicitados;
        private System.Windows.Forms.CheckBox CbxAbertos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn entrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario_pedido;
        private System.Windows.Forms.DataGridViewImageColumn edita;
        private System.Windows.Forms.DataGridViewImageColumn deleta;
    }
}