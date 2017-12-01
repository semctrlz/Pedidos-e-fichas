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
    public partial class FrmCadastroProdutos : Form
    {
        Estados EstadoJanela = Estados.Inicial;

        DTOUsuarios usuarioLogado = new DTOUsuarios();
        DTOMateriais materialSelecionado = new DTOMateriais();

        public FrmCadastroProdutos(DTOUsuarios usu)
        {
            InitializeComponent();
            usuarioLogado = usu;
        }

        enum Estados { Inicial, Criar, Editar, Localizar };

        private void FrmCadastroProdutos_Load(object sender, EventArgs e)
        {
            ResetaJanela();
            CarregarNomes();
        }

        private void ResetaJanela()
        {
            Formatar form = new Formatar();
            lbNomeUser.Text = form.PrimeirasLetrasMaiusculas(usuarioLogado.Nome.Trim().ToUpper(), true);

            lbOperacao.Text = EstadoJanela.ToString().ToUpper();

            btSavar.Enabled = false;

            btCriar.Enabled = false;
            btLocalizar.Enabled = false;
            btExcluir.Enabled = false;
            btEditar.Enabled = false;

            txtCod.Enabled = false;
            txtNome.Enabled = false;
            CbUm.Enabled = false;
            cbSubgrupo.Enabled = false;

            if (EstadoJanela == Estados.Inicial)
            {
                btCriar.Enabled = true;
                btLocalizar.Enabled = true;

                LimparCampos();

            }

            else if (EstadoJanela == Estados.Criar)
            {                
                txtNome.Enabled = true;
                CbUm.Enabled = true;
                cbSubgrupo.Enabled = true;

                LimparCampos();

                btSavar.Enabled = true;

            }

            else if (EstadoJanela == Estados.Editar)
            {                
                txtNome.Enabled = true;
                CbUm.Enabled = true;
                cbSubgrupo.Enabled = true;

                btSavar.Enabled = true;
                btExcluir.Enabled = true;
            }
            else
            {
                LimparCampos();

                btEditar.Enabled = true;
                btLocalizar.Enabled = true;
                btExcluir.Enabled = true;
                btCriar.Enabled = true;
            }
            CarregaUm();

        }

        private void LimparCampos()
        {
            txtCod.Clear();
            txtNome.Clear();
            CbUm.Text = "";
            cbSubgrupo.Text = "";
            txtId.Clear();

        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            if (EstadoJanela == Estados.Inicial)
            {
                this.Close();
            }
            else
            {
                EstadoJanela = Estados.Inicial;
                ResetaJanela();
            }
        }

        private void BtCriar_Click(object sender, EventArgs e)
        {
            EstadoJanela = Estados.Criar;
            ResetaJanela();
            txtNome.Focus();

        }

        private void BtLocalizar_Click(object sender, EventArgs e)
        {
            FrmConsultaItens frm = new FrmConsultaItens();
            frm.ShowDialog();

            EstadoJanela = Estados.Localizar;
            ResetaJanela();


            materialSelecionado = frm.material;

            if (materialSelecionado.Id_material > 0)
            {
                CarregaMaterial();
            }

            frm.Dispose();

        }

        private void CarregaMaterial()
        {
            txtId.Text = materialSelecionado.Id_material.ToString();
            txtNome.Text = materialSelecionado.Descricao;
            BLLSubgrupo bllsg = new BLLSubgrupo();

            DTOSubgrupo sub = new DTOSubgrupo();
            sub = bllsg.Carrega(materialSelecionado.Subgrupo_id_subgrupo);

            cbSubgrupo.Text = sub.Nome;
            txtCod.Text = materialSelecionado.CodigoCigam.ToString();
            CbUm.Text = materialSelecionado.Um;

        }

        private void BtEditar_Click(object sender, EventArgs e)
        {
            EstadoJanela = Estados.Editar;
            ResetaJanela();
        }

        private void BtExcluir_Click(object sender, EventArgs e)
        {
            BLLMateriais bll = new BLLMateriais();

            DialogResult d = MessageBox.Show("Deseja realmente excluir o produto " + txtNome.Text.ToUpper() + "?", "ATENÇÃO!", MessageBoxButtons.YesNo);
            if (d.ToString() == "Yes")
            {
                bll.Excluir(Convert.ToInt32(txtId.Text));
                MessageBox.Show("Produto excluído com sucesso!");
                EstadoJanela = Estados.Inicial;
                ResetaJanela();
            }
        }

        private void BtSavar_Click(object sender, EventArgs e)
        {
            DTOMateriais dto = new DTOMateriais()
            {

                Descricao = txtNome.Text,
                Um = CbUm.Text,
                Subgrupo_id_subgrupo = Convert.ToInt32(cbSubgrupo.SelectedValue.ToString())
            };

            if (txtCod.Text.Replace(".", "").Trim() == "")
            {
                dto.CodigoCigam = "";
            }
            else
            {
                dto.CodigoCigam = txtCod.Text;
            }

            BLLMateriais bll = new BLLMateriais();

            if (txtId.Text != "")
            {
                dto.Id_material = Convert.ToInt32(txtId.Text);
                bll.Alterar(dto, "");
                MessageBox.Show("Produto alterado com sucesso!");
                EstadoJanela = Estados.Inicial;
                ResetaJanela();
            }
            else
            {
                bll.Incluir(dto, "");
                MessageBox.Show("Produto cadastrado com sucesso!");
                EstadoJanela = Estados.Inicial;
                ResetaJanela();
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

        private void CbUm_Leave(object sender, EventArgs e)
        {
            //Verifica se o valor incluído existe no banco de dados

            BLLUnidadeMedida bllUm = new BLLUnidadeMedida();

            if (!bllUm.ExisteUm(CbUm.Text))
            {
                //Caso não exista, inclui
                string nome = CbUm.Text.Trim().ToUpper();
                bllUm.Incluir(CbUm.Text);

                //Atualiza o Combo box e deixa o valor digitado como ativo
                CarregaUm(nome);
            }
            else
            {
                CbUm.Text = CbUm.Text.Trim().ToUpper();
            }
        }

        private void CarregaUm(string um)
        {
            //Carregar todas as unidades de medida cadastradas
            BLLUnidadeMedida BLLUm = new BLLUnidadeMedida();

            CbUm.DataSource = BLLUm.Listar();
            CbUm.DisplayMember = "um";
            CbUm.ValueMember = "id_um";
            CbUm.Text = um.Trim().ToUpper();
        }

        private void CarregaUm()
        {
            //Carregar todas as unidades de medida cadastradas
            BLLUnidadeMedida BLLUm = new BLLUnidadeMedida();

            CbUm.DataSource = BLLUm.Listar();
            CbUm.DisplayMember = "um";
            CbUm.ValueMember = "id_um";
            CbUm.Text = "";
        }

    }
}
