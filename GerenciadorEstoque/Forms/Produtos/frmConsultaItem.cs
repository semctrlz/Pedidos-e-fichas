using GerenciadorEstoque.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorEstoque.Forms.Empresas
{
    public partial class FrmConsultaItens : Form
    {
        public DTOMateriais material = new DTOMateriais();        
        int linha = 0;
        bool liberado = false;
        
        public FrmConsultaItens()
        {
            InitializeComponent();
        }

        private void FrmConsultaItem_Load(object sender, EventArgs e)
        {
            CarregarNomes();
            CarregaProdutos();
            liberado = true;
            
        }

        private void CarregaProdutos()
        {
            BLLMateriais bll = new BLLMateriais();
            DataTable tabela = bll.Localizar(txtProduto.Text.ToUpper().Trim(), Convert.ToInt32(cbSubgrupo.SelectedValue.ToString()));
            
            DataTable dados = new DataTable();
            
            dgvItens.DataSource = tabela;

            FormatarDGV();
        }

        private void FormatarDGV()
        {

            dgvItens.Columns[0].Visible = false;
            dgvItens.Columns[1].HeaderText = "CÓDIGO";
            dgvItens.Columns[2].HeaderText = "DESCRIÇÃO";
            dgvItens.Columns[3].HeaderText = "U.M.";
            dgvItens.Columns[4].HeaderText = "SUBGRUPO";

            dgvItens.Columns[1].Width = 100;
            dgvItens.Columns[2].Width = 420;
            dgvItens.Columns[3].Width = 40;
            dgvItens.Columns[4].Width = 200;

        }

        private void TxtProduto_TextChanged(object sender, EventArgs e)
        {
            CarregaProdutos();
            SelecionaMaterial();
        }

        private void CbSubgrupo_TextChanged(object sender, EventArgs e)
        {
            if (liberado)
            {
                CarregaProdutos();
                SelecionaMaterial();
            }
        }

        public class Language
        {
            public string Nome { get; set; }
            public string Valor { get; set; }

        }

        private void CarregarNomes()
        {
            BLLSubgrupo bll = new BLLSubgrupo();
            DataTable nomesAprovados = bll.Listar();

            var dataSource = new List<Language>
            {
                new Language() { Nome = "", Valor = "0" }
            };

            for (int i = 0; i < nomesAprovados.Rows.Count; i++)
            {
                dataSource.Add(new Language() { Valor = nomesAprovados.Rows[i][0].ToString(), Nome = nomesAprovados.Rows[i][1].ToString() });
            }

            this.cbSubgrupo.DataSource = dataSource;
            this.cbSubgrupo.DisplayMember = "Nome";
            this.cbSubgrupo.ValueMember = "Valor";
            
        }

        private void DgvItens_SelectionChanged(object sender, EventArgs e)
        {
            SelecionaMaterial();
        }

        private void SelecionaMaterial()
        {
            try
            {
                BLLMateriais bll = new BLLMateriais();
                material = bll.CarregaModeloMateriais(Convert.ToInt32(dgvItens.Rows[dgvItens.CurrentCell.RowIndex].Cells[0].Value));
                
            }
            catch
            {
                material.Id_material = 0;
                
            }
        }

        private void BtEsc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmConsultaItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                if ((linha + 1) < dgvItens.Rows.Count)
                {
                    linha++;
                    AtualizaSelecao();
                }
            }

            if (e.KeyCode == Keys.Up)
            {
                if (linha > 0)
                {
                    linha--;
                    AtualizaSelecao();
                }
            }

            if (e.KeyCode == Keys.Escape)
            {

                material = null;
                this.Close();
            }

            if (e.KeyCode == Keys.Enter)
            {
                SelecionaMaterial();
                this.Close();
            }

        }

        private void AtualizaSelecao()
        {
            dgvItens.Rows[linha].Selected = true;
            try
            {
                BLLMateriais bll = new BLLMateriais();
                material = bll.CarregaModeloMateriais(Convert.ToInt32(dgvItens.Rows[linha].Cells[0].Value));

            }
            catch
            {
                material.Id_material = 0;

            }
        }
        
    }
}
