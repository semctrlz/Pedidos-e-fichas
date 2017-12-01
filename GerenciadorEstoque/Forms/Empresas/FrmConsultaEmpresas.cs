using GerenciadorEstoque.Code;
using System.Windows.Forms;
using System;
using System.Data;

namespace GerenciadorEstoque.Forms.Empresas
{
    public partial class FrmConsultaEmpresas : Form
    {
        public DTOEmpresas empresa = new DTOEmpresas();
        int linha = 0;
        bool liberado = false;

        public FrmConsultaEmpresas()
        {
            InitializeComponent();
        }

        private void FrmConsultaEmpresas_Load(object sender, System.EventArgs e)
        {
            
            CarregaEmpresas();
            liberado = true;
        }

        private void CarregaEmpresas()
        {
            BLLEmpresa bll = new BLLEmpresa();
            DataTable tabela = bll.Localizar(TxtFantasiaERazao.Text.ToUpper().Trim(), TxtCnpj.Text.Replace(".","").Replace("-", "").Replace("/", "").Replace("_", "").Replace(" ", ""));

            DataTable dados = new DataTable();

            dgvItens.DataSource = tabela;

            FormatarDGV();
        }

        private void FormatarDGV()
        {

            dgvItens.Columns[0].Visible = false;
            dgvItens.Columns[1].HeaderText = "CÓDIGO";
            dgvItens.Columns[2].HeaderText = "FANTAZIA";
            dgvItens.Columns[3].HeaderText = "RAZÃO";
            dgvItens.Columns[4].HeaderText = "CNPJ";

            dgvItens.Columns[1].Width = 60;
            dgvItens.Columns[2].Width = 320;
            dgvItens.Columns[3].Width = 250;
            dgvItens.Columns[4].Width = 130;

        }

        private void TxtFantasiaERazao_TextChanged(object sender, EventArgs e)
        {
            CarregaEmpresas();
        }

        private void TxtCnpj_TextChanged(object sender, EventArgs e)
        {
            CarregaEmpresas();
        }

        private void BtEsc_Click(object sender, EventArgs e)
        {
            
           
        }

        private void FrmConsultaEmpresas_KeyDown(object sender, KeyEventArgs e)
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
                empresa = null;
                this.Close();
            }

            if (e.KeyCode == Keys.Enter)
            {
                SelecionaEmpresa();
                this.Close();
            }
        }

        private void SelecionaEmpresa()
        {
            try
            {
                BLLEmpresa bll = new BLLEmpresa();
                empresa = bll.CarregaModelo(Convert.ToInt32(dgvItens.Rows[dgvItens.CurrentCell.RowIndex].Cells[0].Value));
            }
            catch
            {
                empresa.Id_empresa = 0;
            }
        }


        private void AtualizaSelecao()
        {
            dgvItens.Rows[linha].Selected = true;            
            
        }

        private void DgvItens_SelectionChanged(object sender, EventArgs e)
        {
            SelecionaEmpresa();
        }
        
    }
}
