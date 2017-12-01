namespace GerenciadorEstoque.Forms.Empresas
{
    partial class FrmAdicionarMovimentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdicionarMovimentos));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CbDataMov = new System.Windows.Forms.ComboBox();
            this.CbTipoMov = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CbCodItem = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CbContaGer = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CbNumeroMov = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CbQuantidade = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CbValorUnit = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.CbDocumento = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.CbTipoOp = new System.Windows.Forms.ComboBox();
            this.gbColunas = new System.Windows.Forms.GroupBox();
            this.PnAguardar = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PbMovimentos = new System.Windows.Forms.ProgressBar();
            this.label12 = new System.Windows.Forms.Label();
            this.LbMovimento = new System.Windows.Forms.Label();
            this.CbxIgnorarErros = new System.Windows.Forms.CheckBox();
            this.CbxInverterSinal = new System.Windows.Forms.CheckBox();
            this.CbxDivideQuant = new System.Windows.Forms.CheckBox();
            this.DgvDados = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtAtualiza = new System.Windows.Forms.Button();
            this.BtAdicionarDB = new System.Windows.Forms.Button();
            this.BtColarDados = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.CbUnidade = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gbColunas.SuspendLayout();
            this.PnAguardar.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDados)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data do Movimento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tipo de movimento";
            // 
            // CbDataMov
            // 
            this.CbDataMov.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbDataMov.FormattingEnabled = true;
            this.CbDataMov.Location = new System.Drawing.Point(112, 25);
            this.CbDataMov.Name = "CbDataMov";
            this.CbDataMov.Size = new System.Drawing.Size(190, 21);
            this.CbDataMov.TabIndex = 1;
            // 
            // CbTipoMov
            // 
            this.CbTipoMov.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbTipoMov.FormattingEnabled = true;
            this.CbTipoMov.Location = new System.Drawing.Point(112, 51);
            this.CbTipoMov.Name = "CbTipoMov";
            this.CbTipoMov.Size = new System.Drawing.Size(190, 21);
            this.CbTipoMov.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Codigo do item";
            // 
            // CbCodItem
            // 
            this.CbCodItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbCodItem.FormattingEnabled = true;
            this.CbCodItem.Location = new System.Drawing.Point(112, 105);
            this.CbCodItem.Name = "CbCodItem";
            this.CbCodItem.Size = new System.Drawing.Size(190, 21);
            this.CbCodItem.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Conta gerencial";
            // 
            // CbContaGer
            // 
            this.CbContaGer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbContaGer.FormattingEnabled = true;
            this.CbContaGer.Location = new System.Drawing.Point(112, 132);
            this.CbContaGer.Name = "CbContaGer";
            this.CbContaGer.Size = new System.Drawing.Size(190, 21);
            this.CbContaGer.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(338, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nº do movimento";
            // 
            // CbNumeroMov
            // 
            this.CbNumeroMov.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbNumeroMov.FormattingEnabled = true;
            this.CbNumeroMov.Location = new System.Drawing.Point(444, 25);
            this.CbNumeroMov.Name = "CbNumeroMov";
            this.CbNumeroMov.Size = new System.Drawing.Size(190, 21);
            this.CbNumeroMov.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(338, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Quantidade";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(338, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Valor unitário";
            // 
            // CbQuantidade
            // 
            this.CbQuantidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbQuantidade.FormattingEnabled = true;
            this.CbQuantidade.Location = new System.Drawing.Point(444, 52);
            this.CbQuantidade.Name = "CbQuantidade";
            this.CbQuantidade.Size = new System.Drawing.Size(190, 21);
            this.CbQuantidade.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(338, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tipo de documento";
            // 
            // CbValorUnit
            // 
            this.CbValorUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbValorUnit.FormattingEnabled = true;
            this.CbValorUnit.Location = new System.Drawing.Point(444, 88);
            this.CbValorUnit.Name = "CbValorUnit";
            this.CbValorUnit.Size = new System.Drawing.Size(190, 21);
            this.CbValorUnit.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(338, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Documento";
            // 
            // CbTipoDocumento
            // 
            this.CbTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbTipoDocumento.FormattingEnabled = true;
            this.CbTipoDocumento.Location = new System.Drawing.Point(444, 120);
            this.CbTipoDocumento.Name = "CbTipoDocumento";
            this.CbTipoDocumento.Size = new System.Drawing.Size(190, 21);
            this.CbTipoDocumento.TabIndex = 1;
            // 
            // CbDocumento
            // 
            this.CbDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbDocumento.FormattingEnabled = true;
            this.CbDocumento.Location = new System.Drawing.Point(444, 147);
            this.CbDocumento.Name = "CbDocumento";
            this.CbDocumento.Size = new System.Drawing.Size(190, 21);
            this.CbDocumento.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Tipo de operação";
            // 
            // CbTipoOp
            // 
            this.CbTipoOp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbTipoOp.FormattingEnabled = true;
            this.CbTipoOp.Location = new System.Drawing.Point(112, 78);
            this.CbTipoOp.Name = "CbTipoOp";
            this.CbTipoOp.Size = new System.Drawing.Size(190, 21);
            this.CbTipoOp.TabIndex = 1;
            // 
            // gbColunas
            // 
            this.gbColunas.Controls.Add(this.PnAguardar);
            this.gbColunas.Controls.Add(this.CbxIgnorarErros);
            this.gbColunas.Controls.Add(this.CbxInverterSinal);
            this.gbColunas.Controls.Add(this.CbxDivideQuant);
            this.gbColunas.Controls.Add(this.label1);
            this.gbColunas.Controls.Add(this.CbNumeroMov);
            this.gbColunas.Controls.Add(this.label6);
            this.gbColunas.Controls.Add(this.CbDocumento);
            this.gbColunas.Controls.Add(this.label2);
            this.gbColunas.Controls.Add(this.CbContaGer);
            this.gbColunas.Controls.Add(this.label7);
            this.gbColunas.Controls.Add(this.label5);
            this.gbColunas.Controls.Add(this.label11);
            this.gbColunas.Controls.Add(this.CbTipoDocumento);
            this.gbColunas.Controls.Add(this.CbDataMov);
            this.gbColunas.Controls.Add(this.CbCodItem);
            this.gbColunas.Controls.Add(this.CbQuantidade);
            this.gbColunas.Controls.Add(this.label9);
            this.gbColunas.Controls.Add(this.label3);
            this.gbColunas.Controls.Add(this.label4);
            this.gbColunas.Controls.Add(this.label8);
            this.gbColunas.Controls.Add(this.CbValorUnit);
            this.gbColunas.Controls.Add(this.CbTipoMov);
            this.gbColunas.Controls.Add(this.CbTipoOp);
            this.gbColunas.Location = new System.Drawing.Point(12, 47);
            this.gbColunas.Name = "gbColunas";
            this.gbColunas.Size = new System.Drawing.Size(782, 205);
            this.gbColunas.TabIndex = 2;
            this.gbColunas.TabStop = false;
            this.gbColunas.Text = "Colunas";
            // 
            // PnAguardar
            // 
            this.PnAguardar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnAguardar.BackColor = System.Drawing.Color.Black;
            this.PnAguardar.Controls.Add(this.panel3);
            this.PnAguardar.Location = new System.Drawing.Point(242, 25);
            this.PnAguardar.Name = "PnAguardar";
            this.PnAguardar.Size = new System.Drawing.Size(323, 148);
            this.PnAguardar.TabIndex = 4;
            this.PnAguardar.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.PbMovimentos);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.LbMovimento);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(317, 142);
            this.panel3.TabIndex = 2;
            // 
            // PbMovimentos
            // 
            this.PbMovimentos.Location = new System.Drawing.Point(27, 68);
            this.PbMovimentos.Name = "PbMovimentos";
            this.PbMovimentos.Size = new System.Drawing.Size(263, 18);
            this.PbMovimentos.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(70, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Adicionando movimento:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LbMovimento
            // 
            this.LbMovimento.AutoSize = true;
            this.LbMovimento.Location = new System.Drawing.Point(199, 33);
            this.LbMovimento.Name = "LbMovimento";
            this.LbMovimento.Size = new System.Drawing.Size(49, 13);
            this.LbMovimento.TabIndex = 0;
            this.LbMovimento.Text = "2300661";
            this.LbMovimento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CbxIgnorarErros
            // 
            this.CbxIgnorarErros.AutoSize = true;
            this.CbxIgnorarErros.Location = new System.Drawing.Point(9, 170);
            this.CbxIgnorarErros.Name = "CbxIgnorarErros";
            this.CbxIgnorarErros.Size = new System.Drawing.Size(147, 17);
            this.CbxIgnorarErros.TabIndex = 4;
            this.CbxIgnorarErros.Text = "Ignorar erros encontrados";
            this.CbxIgnorarErros.UseVisualStyleBackColor = true;
            // 
            // CbxInverterSinal
            // 
            this.CbxInverterSinal.AutoSize = true;
            this.CbxInverterSinal.Location = new System.Drawing.Point(640, 104);
            this.CbxInverterSinal.Name = "CbxInverterSinal";
            this.CbxInverterSinal.Size = new System.Drawing.Size(86, 17);
            this.CbxInverterSinal.TabIndex = 4;
            this.CbxInverterSinal.Text = "Inverter sinal";
            this.CbxInverterSinal.UseVisualStyleBackColor = true;
            // 
            // CbxDivideQuant
            // 
            this.CbxDivideQuant.AutoSize = true;
            this.CbxDivideQuant.Location = new System.Drawing.Point(640, 82);
            this.CbxDivideQuant.Name = "CbxDivideQuant";
            this.CbxDivideQuant.Size = new System.Drawing.Size(134, 17);
            this.CbxDivideQuant.TabIndex = 4;
            this.CbxDivideQuant.Text = "Dividir pela quantidade";
            this.CbxDivideQuant.UseVisualStyleBackColor = true;
            // 
            // DgvDados
            // 
            this.DgvDados.AllowUserToAddRows = false;
            this.DgvDados.AllowUserToDeleteRows = false;
            this.DgvDados.AllowUserToResizeColumns = false;
            this.DgvDados.AllowUserToResizeRows = false;
            this.DgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvDados.Location = new System.Drawing.Point(0, 0);
            this.DgvDados.Name = "DgvDados";
            this.DgvDados.RowHeadersVisible = false;
            this.DgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvDados.Size = new System.Drawing.Size(806, 302);
            this.DgvDados.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtAtualiza);
            this.panel1.Controls.Add(this.BtAdicionarDB);
            this.panel1.Controls.Add(this.BtColarDados);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.gbColunas);
            this.panel1.Controls.Add(this.CbUnidade);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 291);
            this.panel1.TabIndex = 4;
            // 
            // BtAtualiza
            // 
            this.BtAtualiza.Location = new System.Drawing.Point(652, 14);
            this.BtAtualiza.Name = "BtAtualiza";
            this.BtAtualiza.Size = new System.Drawing.Size(142, 23);
            this.BtAtualiza.TabIndex = 4;
            this.BtAtualiza.Text = "Atualiza custos das fichas";
            this.BtAtualiza.UseVisualStyleBackColor = true;
            this.BtAtualiza.Click += new System.EventHandler(this.BtAtualiza_Click);
            // 
            // BtAdicionarDB
            // 
            this.BtAdicionarDB.Location = new System.Drawing.Point(629, 258);
            this.BtAdicionarDB.Name = "BtAdicionarDB";
            this.BtAdicionarDB.Size = new System.Drawing.Size(165, 23);
            this.BtAdicionarDB.TabIndex = 3;
            this.BtAdicionarDB.Text = "Adicionar ao Banco de dados";
            this.BtAdicionarDB.UseVisualStyleBackColor = true;
            this.BtAdicionarDB.Click += new System.EventHandler(this.BtAdicionarDB_Click);
            // 
            // BtColarDados
            // 
            this.BtColarDados.Location = new System.Drawing.Point(12, 258);
            this.BtColarDados.Name = "BtColarDados";
            this.BtColarDados.Size = new System.Drawing.Size(75, 23);
            this.BtColarDados.TabIndex = 3;
            this.BtColarDados.Text = "Colar dados";
            this.BtColarDados.UseVisualStyleBackColor = true;
            this.BtColarDados.Click += new System.EventHandler(this.BtColarDados_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Unidade";
            // 
            // CbUnidade
            // 
            this.CbUnidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbUnidade.FormattingEnabled = true;
            this.CbUnidade.Location = new System.Drawing.Point(65, 16);
            this.CbUnidade.Name = "CbUnidade";
            this.CbUnidade.Size = new System.Drawing.Size(154, 21);
            this.CbUnidade.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DgvDados);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 291);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(806, 302);
            this.panel2.TabIndex = 5;
            // 
            // FrmAdicionarMovimentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 593);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAdicionarMovimentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar movimentos de estoque";
            this.Load += new System.EventHandler(this.FrmAdicionarMovimentos_Load);
            this.gbColunas.ResumeLayout(false);
            this.gbColunas.PerformLayout();
            this.PnAguardar.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDados)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbDataMov;
        private System.Windows.Forms.ComboBox CbTipoMov;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CbCodItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CbContaGer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CbNumeroMov;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CbQuantidade;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CbValorUnit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CbTipoDocumento;
        private System.Windows.Forms.ComboBox CbDocumento;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox CbTipoOp;
        private System.Windows.Forms.GroupBox gbColunas;
        private System.Windows.Forms.DataGridView DgvDados;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox CbxIgnorarErros;
        private System.Windows.Forms.Button BtColarDados;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox CbUnidade;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtAdicionarDB;
        private System.Windows.Forms.CheckBox CbxDivideQuant;
        private System.Windows.Forms.CheckBox CbxInverterSinal;
        private System.Windows.Forms.Panel PnAguardar;
        private System.Windows.Forms.ProgressBar PbMovimentos;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label LbMovimento;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtAtualiza;
    }
}