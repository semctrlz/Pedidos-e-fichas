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
    public partial class frmMarcasAprovadas : Form
    {

        DTOUsuarios usuarioLogado;

        int id = 0;

        public frmMarcasAprovadas(DTOUsuarios usu)
        {
            InitializeComponent();

            usuarioLogado = usu;
        }

        private void FrmMarcasAprovadas_Load(object sender, EventArgs e)
        {
            CarregaProdutos();
            CarregarNomes();
        }

        private void CarregaProdutos()
        {
            BLLMateriais bll = new BLLMateriais();
            DataTable tabela = bll.ListarProdutos(txtDescricao.Text.ToUpper().Trim());
            DTOCaminhos caminho = new DTOCaminhos();

            //this.dgvFichas.Columns[9].ValueType = typeof(double);

            DataTable dados = new DataTable();

            dados.Clear();
            dados.Columns.Add("ID");
            dados.Columns.Add("CODIGO");
            dados.Columns.Add("DESCRICAO");
            dados.Columns.Add("UM");
            dados.Columns.Add("QUANTMARCAS", typeof(Int32));

            DataRow _ravi = dados.NewRow();

            for (int i = 0; i < tabela.Rows.Count; i++)
            {

                dados.Rows.Add(new object[] { tabela.Rows[i][0].ToString(), tabela.Rows[i][1].ToString(), tabela.Rows[i][2].ToString(), tabela.Rows[i][3].ToString(), Convert.ToInt32(tabela.Rows[i][4].ToString()) });

            }

            dgvProdutos.DataSource = dados;

            FormatarDGV();
        }

        private void FormatarDGV()
        {
            dgvProdutos.Columns[0].Visible = false;
            dgvProdutos.Columns[1].HeaderText = "CÓDIGO";
            dgvProdutos.Columns[2].HeaderText = "DESCRIÇÃO";
            dgvProdutos.Columns[3].HeaderText = "U.M.";
            dgvProdutos.Columns[4].HeaderText = "QTD MARCAS";

            dgvProdutos.Columns[1].Width = 100;
            dgvProdutos.Columns[2].Width = 420;
            dgvProdutos.Columns[3].Width = 40;
            dgvProdutos.Columns[4].Width = 110;

        }

        public class Language
        {
            public string Nome { get; set; }            
        }

        private void CarregarNomes()
        {            
            BLLMarcasAprovadas bllma = new BLLMarcasAprovadas();
            DataTable nomesAprovados = bllma.ListarNomes();

            var dataSource = new List<Language>
            {
                new Language() { Nome = "" }
            };

            for (int i = 0; i < nomesAprovados.Rows.Count; i++)
            {
                dataSource.Add(new Language() { Nome = nomesAprovados.Rows[i][0].ToString()});
            }
            
            //Atualiza Combobox Setor
            this.cbAutorizadoPor.DataSource = dataSource;
            this.cbAutorizadoPor.DisplayMember = "Nome";
        }

        private void FormatarDGVMarcas()
        {
            dgvMarcasAprovadas.Columns[0].Visible = false;
            dgvMarcasAprovadas.Columns[0].HeaderText = "ID";
            dgvMarcasAprovadas.Columns[1].HeaderText = "MARCA";
            dgvMarcasAprovadas.Columns[2].HeaderText = "LIBERADO POR";
            dgvMarcasAprovadas.Columns[3].HeaderText = "DATA.";



            dgvMarcasAprovadas.Columns[1].Width = 150;
            dgvMarcasAprovadas.Columns[2].Width = 120;
            dgvMarcasAprovadas.Columns[3].Width = 75;
            dgvMarcasAprovadas.Columns[4].Width = 26;
            dgvMarcasAprovadas.Columns[5].Width = 26;


        }

        private void TxtDescricao_TextChanged(object sender, EventArgs e)
        {
            CarregaProdutos();
        }

        private void CarregaMarcasAprovadas()
        {
            BLLMarcasAprovadas bll = new BLLMarcasAprovadas();

            

            try
            {
                id = Convert.ToInt32(dgvProdutos.Rows[dgvProdutos.CurrentCell.RowIndex].Cells[0].Value);
            }
            catch
            {

            }

            DataTable tabela = bll.Localizar(id);

            //this.dgvFichas.Columns[9].ValueType = typeof(double);

            DataTable dados = new DataTable();
            DTOCaminhos caminho = new DTOCaminhos();

            Image edit = Image.FromFile(caminho.Icones + "pencil.png");
            Image del = Image.FromFile(caminho.Icones + "trash.png");

            dados.Clear();
            dados.Columns.Add("ID");
            dados.Columns.Add("MARCA");
            dados.Columns.Add("APROVADO POR");
            dados.Columns.Add("DATA", typeof(DateTime));
            dados.Columns.Add(" ", typeof(System.Drawing.Bitmap));
            dados.Columns.Add("  ", typeof(System.Drawing.Bitmap));

            DataRow _ravi = dados.NewRow();

            for (int i = 0; i < tabela.Rows.Count; i++)
            {
                dados.Rows.Add(new object[] { tabela.Rows[i][0].ToString(), tabela.Rows[i][1].ToString(), tabela.Rows[i][2].ToString(), tabela.Rows[i][3].ToString(), edit, del });
            }

            dgvMarcasAprovadas.DataSource = dados;
            FormatarDGVMarcas();

        }

        private void DgvProdutos_SelectionChanged(object sender, EventArgs e)
        {
            CarregaMarcasAprovadas();
        }

        private void DgvMarcasAprovadas_SelectionChanged(object sender, EventArgs e)
        {
            dgvMarcasAprovadas.ClearSelection();
        }

        private void DgvMarcasAprovadas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BLLMarcasAprovadas bll = new BLLMarcasAprovadas();
            DTOMarcasAprovadas dto = new DTOMarcasAprovadas();

            if (e.ColumnIndex == 5)
            {
                if (e.RowIndex >= 0)
                {
                    DialogResult d = MessageBox.Show("Deseja realmente excluir a marca " + dgvMarcasAprovadas.Rows[e.RowIndex].Cells[1].Value.ToString() + "?", "ATENÇÃO!", MessageBoxButtons.YesNo);
                    if (d.ToString() == "Yes")
                    {
                        bll.Excluir(Convert.ToInt32(dgvMarcasAprovadas.Rows[e.RowIndex].Cells[0].Value.ToString()));
                                                
                        CarregaMarcasAprovadas();
                        AtualizaQuantMarcas();
                    }

                }
            }else if (e.ColumnIndex == 4)
            {
                dto = bll.CarregaMarca(Convert.ToInt32(dgvMarcasAprovadas.Rows[e.RowIndex].Cells[0].Value.ToString()));

                txtMarca.Text = dto.Marca;
                txtOBS.Text = dto.ObsAprovacao;
                cbAutorizadoPor.Text = dto.AprovadoPor;
                cbxExibirNoEmail.Checked = dto.ExibirNoEmail;
                txtIdMarcasAprovadas.Text = dto.Id_marcas_aprovadas.ToString();
            }
        }

        private void BtAdd_Click(object sender, EventArgs e)
        {
            BLLMarcasAprovadas bll = new BLLMarcasAprovadas();
            DTOMarcasAprovadas dto = new DTOMarcasAprovadas()
            {
                AprovadoPor = cbAutorizadoPor.Text,
                ObsAprovacao = txtOBS.Text,
                Id_usuario = usuarioLogado.Id_usuario,
                Marca = txtMarca.Text,
                ExibirNoEmail = cbxExibirNoEmail.Checked,
                DataAprovacao = DateTime.Now,
                Id_material = id                
            };
            
            if (txtIdMarcasAprovadas.Text == "")
            {
                bll.Incluir(dto);
                CarregaMarcasAprovadas();
                AtualizaQuantMarcas();
            }
            else
            {
                dto.Id_marcas_aprovadas = Convert.ToInt32(txtIdMarcasAprovadas.Text);
                bll.Alterar(dto);
                CarregaMarcasAprovadas();
                AtualizaQuantMarcas();
            }

            LimpaCadastroMarcas();

        }

        private void AtualizaQuantMarcas()
        {
            BLLMarcasAprovadas bll = new BLLMarcasAprovadas();
            dgvProdutos.Rows[dgvProdutos.CurrentCell.RowIndex].Cells[4].Value = bll.ContarMarcas(Convert.ToInt32(dgvProdutos.Rows[dgvProdutos.CurrentCell.RowIndex].Cells[0].Value));

        }

        private void LimpaCadastroMarcas()
        {
            txtMarca.Clear();
            txtOBS.Clear();
            cbAutorizadoPor.Text = "";
            cbxExibirNoEmail.Checked = true;
            txtIdMarcasAprovadas.Clear();
        }

        private void Limpar()
        {
            LimpaCadastroMarcas();
            CarregaProdutos();
            CarregaMarcasAprovadas();
            CarregarNomes();
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            LimpaCadastroMarcas();
        }
    }
}
