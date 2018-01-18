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
    public partial class FrmConsultaMateriaisEDerivados : Form
    {
        public int idMaterial = 0;
        public int idDerivado = 0;

        bool liberado = false;

        public FrmConsultaMateriaisEDerivados()
        {
            InitializeComponent();
        }

        private void FrmConsultaMateriaisEDerivados_Load(object sender, EventArgs e)
        {
            CarregaSubgrupos();
            CarregaProdutos();
            liberado = true;
        }

        public class Language
        {
            public string Nome { get; set; }
            public string Valor { get; set; }

        }

        private void CarregaSubgrupos()
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

        private void CarregaProdutos()
        {
            BLLMateriaisDerivados bll = new BLLMateriaisDerivados();

            DataTable tabela = new DataTable();

            if (Convert.ToInt32(cbSubgrupo.SelectedValue) == 0)
            {
                //tabela = bll.LocalizarMateriaisEDerivados(txtProduto.Text.ToUpper().Trim());
            }
            else
            {
                //tabela = bll.LocalizarMateriaisEDerivados(txtProduto.Text.ToUpper().Trim(), Convert.ToInt32(cbSubgrupo.SelectedValue.ToString()));
            }
            DataTable dados = new DataTable();

            dgvItens.DataSource = tabela;

            FormatarDGV();
        }

        private void CarregaProdutos(string t)
        {
            BLLMateriaisDerivados bll = new BLLMateriaisDerivados();

            DataTable tabela = new DataTable();

            if (Convert.ToInt32(cbSubgrupo.SelectedValue) == 0)
            {
                //tabela = bll.LocalizarMateriaisEDerivados(t.ToUpper().Trim());
            }
            else
            {
                //tabela = bll.LocalizarMateriaisEDerivados(t.ToUpper().Trim(), Convert.ToInt32(cbSubgrupo.SelectedValue.ToString()));
            }
            DataTable dados = new DataTable();

            dgvItens.DataSource = tabela;

            FormatarDGV();
        }

        private void FormatarDGV()
        {

            dgvItens.Columns[0].Visible = false;
            dgvItens.Columns[1].Visible = false;            
            dgvItens.Columns[2].HeaderText = "DESCRIÇÃO";
            dgvItens.Columns[3].HeaderText = "U.M.";
            dgvItens.Columns[4].Visible = false;

            dgvItens.Columns[2].Width = 420;
            dgvItens.Columns[3].Width = 40;
            dgvItens.Columns[4].Width = 200;

        }

        private void CbSubgrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (liberado)
            CarregaProdutos();
        }

        private void TxtProduto_TextChanged(object sender, EventArgs e)
        {
            if (liberado)
                CarregaProdutos();
        }

        private void DgvItens_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                idDerivado = Convert.ToInt32(dgvItens.Rows[dgvItens.CurrentCell.RowIndex].Cells[0].Value);
            }
            catch
            {
                idDerivado = 0;
            }

            try
            {
                idMaterial = Convert.ToInt32(dgvItens.Rows[dgvItens.CurrentCell.RowIndex].Cells[1].Value);
            }
            catch
            {
                idMaterial = 0;
            }
        }
    }
}
