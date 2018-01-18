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
using static GerenciadorEstoque.Code.Diversos;

namespace GerenciadorEstoque.Forms.Pedidos
{
    public partial class FrmLevantamento : Form
    {

        bool liberado = false;
        DTOUsuarios usuarioLogado;
        int unidade;
        StatusJanela Status;        

        public enum StatusJanela {inicial, criacao };

        public FrmLevantamento(DTOUsuarios u)
        {
            usuarioLogado = u;
            InitializeComponent();
        }

        private void FrmLevantamento_Load(object sender, EventArgs e)
        {
            CbUm.DataSource = Enum.GetValues(typeof(UniadesMedida));

            Status = StatusJanela.inicial;
            CarregaPagina();
            TxtObs.Focus();
            
            PnItensDerivadosV(false);

            liberado = true;
        }

        private void CarregaPagina()
        {
            CarregaUnidades();

            AtualizaBotoes();
        }

        private void AtualizaLv(string cod)
        {
            LvMatDer.Items.Clear();

            BLLMateriaisDerivados bll = new BLLMateriaisDerivados();


            if (bll.QuantMateriaisDerivados(cod) == 1)
            {
                DataTable lista = bll.Listar(cod);

            }
            else if (bll.QuantMateriaisDerivados(cod) > 1)
            {
                DataTable lista = bll.Listar(cod);                

                for (int i =0; i<lista.Rows.Count; i++)
                {
                    LvMatDer.Items.Add(lista.Rows[i][2].ToString());
                }

                PnItensDerivadosV(true);
            }
            else
            {

            }
        }

        private void AdicionarRegistro(string codItem, int idDerivados, string um, double quant)
        {
            BLLItensLevantamentos bll = new BLLItensLevantamentos();
            DTOItensLevantamento dto = new DTOItensLevantamento
            {
                IdLevantamento = Convert.ToInt32(TxtNumeroLevantamento.Text),
                CodItem = codItem,
                IdDerivados = idDerivados,
                Um = um,
                Quant = quant
            };

            bll.Incluir(dto);

            txtCodItem.Clear();
            txtNomeItem.Clear();
            CbUm.Text = "KG";
            txtQuant.Clear();
            txtCodItem.Focus();

            CarregarDgv();
        }

        private void CarregarDgv()
        {
            //Carrega todos os materiais derivados do codigo que está na variavel 'codigoAtual'

            DgvItens.Rows.Clear();

            BLLItensLevantamentos bll = new BLLItensLevantamentos();
            DataTable materiais = bll.Listar(Convert.ToInt32(TxtNumeroLevantamento.Text));

            if (materiais.Rows.Count > 0)
            {
                string idMaterialDerivado, nomeItem, um;
                double quant;

                for (int i = 0; i < materiais.Rows.Count; i++)
                {
                    idMaterialDerivado = materiais.Rows[i][0].ToString();
                    nomeItem = materiais.Rows[i][1].ToString();
                    um = materiais.Rows[i][2].ToString();
                    quant = Convert.ToDouble(materiais.Rows[i][3].ToString());

                    String[] V = new string[] { idMaterialDerivado, nomeItem, um, quant.ToString("#.0,00") };
                    DgvItens.Rows.Add(V);

                }

            }

        }

        private void PnItensDerivadosV(bool visivel)
        {
            if (visivel)
            {
                PnItensDerivados.Location = new Point(9, 59);
                PnItensDerivados.Visible = true;
            }
            else
            {
                PnItensDerivados.Location = new Point(576, 59);
                PnItensDerivados.Visible = false;
            }
        }

        private void AtualizaBotoes()
        {
            GbBase.Enabled = false;
            GbItens.Enabled = false;

            if(Status == StatusJanela.inicial)
            {
                GbBase.Enabled = true;
            }
            else
            {
                GbItens.Enabled = true;
            }



        }

        private void CarregaUnidades()
        {
            BLLUnidade bllun = new BLLUnidade();

            cbUnidade.DataSource = bllun.Localizar();
            cbUnidade.DisplayMember = "nomeReduzido";
            cbUnidade.ValueMember = "id_unidade";
            cbUnidade.Text = "nomeReduzido";


            BLLPermissoes bllperm = new BLLPermissoes();

            if (bllperm.PermissaoPorLocal(Diversos.LocaisPermissoes.Usarios, usuarioLogado) >= 4)
            {
                cbUnidade.Enabled = true;
            }

            else
            {
                cbUnidade.Enabled = false;
            }

            unidade = Convert.ToInt32(cbUnidade.SelectedValue);
        }

        private void TxtCodItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                DTOMateriais dto = new DTOMateriais();

                Empresas.FrmConsultaItens f = new Empresas.FrmConsultaItens(true);
                f.ShowDialog();
                dto = f.material;
                f.Dispose();

                if (dto.CodigoCigam != null)
                {
                    try
                    {
                        txtCodItem.Text = dto.CodigoCigam.ToString();
                        txtNomeItem.Text = dto.Descricao.ToString();                        
                        CbUm.Text = dto.Um.ToString();
                        txtQuant.Enabled = true;
                        BtAddItem.Enabled = true;                        

                        txtQuant.Focus();
                    }
                    catch
                    {
                        MessageBox.Show("Código inválido. Por favor selecione um código existente");
                        BtAddItem.Enabled = false;
                        txtQuant.Enabled = false;
                    }
                }
                else
                {

                }

            }
        }

        private void BtCriar_Click(object sender, EventArgs e)
        {
            Status = StatusJanela.criacao;
            DTOLevantamentos dto = new DTOLevantamentos();
            BLLLevantamentos bll = new BLLLevantamentos();

            dto.IdUsuario = usuarioLogado.Id_usuario;
            dto.Id_unidade = Convert.ToInt32(cbUnidade.SelectedValue);
            dto.Obs = TxtObs.Text;


            bll.Incluir(dto);
            TxtNumeroLevantamento.Text = dto.Id.ToString("000000");

            Status = StatusJanela.criacao;

            AtualizaBotoes();

            txtCodItem.Focus();
        }

        private void BtAddItem_Click(object sender, EventArgs e)
        {
            //faz verificações

            AtualizaLv(txtCodItem.Text);
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {

            if (LvMatDer.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione uma derivação do material.");
            }
            else {

                int intselectedindex = LvMatDer.SelectedIndices[0];

                string nome = LvMatDer.Items[intselectedindex].Text;

                BLLMateriaisDerivados bll = new BLLMateriaisDerivados();

                int idDer = bll.IdMaterialDerivado(nome);
                AdicionarRegistro(txtCodItem.Text, idDer, CbUm.Text, Convert.ToDouble(txtQuant.Text));
                PnItensDerivadosV(false);


            }

        }

        private void DgvItens_SelectionChanged(object sender, EventArgs e)
        {
            DgvItens.ClearSelection();
        }

        private void BtBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
