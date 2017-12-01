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

namespace GerenciadorEstoque.Forms.Pedidos
{
    public partial class FrmPedido : Form
    {
        DTOUsuarios usuarioConectado;
        int numeroConsulta = 0;
        bool cancelar = false;
        int idSetorExc = 0;
        string obsSetorExc = "";

        private enum StatusJanela { Criando, Consultando, Editando, inserindo };

        StatusJanela status = StatusJanela.Criando;


        public FrmPedido(DTOUsuarios u)
        {
            usuarioConectado = u;

            InitializeComponent();
        }

        public FrmPedido(DTOUsuarios u, int numero)
        {
            usuarioConectado = u;

            numeroConsulta = numero;

            InitializeComponent();
        }

        private void FrmPedido_Load(object sender, EventArgs e)
        {
            CarregaValoresPadrao();

            ExibeAdicionarPorSetor(false);

            if(numeroConsulta > 0)
            {
                AbrePedido(numeroConsulta);
                status = StatusJanela.Consultando;
                AlteraBotoes();
            }
            else
            {                
                status = StatusJanela.Criando;
                AlteraBotoes();
            }

            AlteraBotoes();
        }

        private void AbrePedido(int n)
        {
            TxtIdPedido.Text = n.ToString("000000");

            //Criação dos objetos
            DTOPedidos dto = new DTOPedidos();
            BLLPedidos bll = new BLLPedidos();

            //Carregar dados do pedido
            dto = bll.Carregar(n);

            //Define Unidade
            BLLUnidade bllun = new BLLUnidade();
            CbUnidade.Text = bllun.RetornaNomeUnidade(dto.Id_unidade);

            //Define Data Entrega
            DtpDataEntrega.Value = dto.Data_entrega;

            //Define OBS
            TxtObsPedido.Text = dto.Obs;

            //Carrega DGV
            CarregaDGVSetores(n);
            
            //Bloqueia o botão de criar pedidos
            BtCriarCotacao.Enabled = false;
            GbPedido.Enabled = false;
        }

        private void AlteraBotoes()
        {
            GbPedido.Enabled = false;
            BtCriarCotacao.Enabled = false;
            BtEdita.Enabled = false;
            BtCancelarPedido.Enabled = false;
            BtExcluirPedido.Enabled = false;
            DgvSetores.Enabled = false;
            BtAdicionaSetor.Enabled = false;
            DgvSetores.Enabled = false;
            BtSalvar.Enabled = false;
                        
            if (status == StatusJanela.Criando)
            {
                GbPedido.Enabled = true;
                BtCriarCotacao.Enabled = true;
            }
            else if(status == StatusJanela.Consultando)
            {
                BtEdita.Enabled = true;
            }
            else if (status == StatusJanela.Editando)
            {
                GbPedido.Enabled = true;
                BtSalvar.Enabled = true;
                BtAdicionaSetor.Enabled = true;
            }
            else if (status == StatusJanela.inserindo)
            {
                GbPedido.Enabled = false;
                BtEdita.Enabled = true;
                BtExcluir.Enabled = true;
                BtAdicionaSetor.Enabled = true;
                DgvSetores.Enabled = true;
            }
        }

        private void AbrePedido()
        {
            DTOPedidos dto = new DTOPedidos();
            if(CbUnidade.Text != "")
            {
                dto.Id_unidade = Convert.ToInt32(CbUnidade.SelectedValue);
            }
            else
            {
                dto.Id_unidade = 0;
            }

            dto.Data_entrega = DtpDataEntrega.Value;
            dto.Id_ususario = usuarioConectado.Id_usuario;
            dto.Obs = TxtObsPedido.Text;

            BLLPedidos bll = new BLLPedidos();
            bll.Incluir(dto);

            TxtIdPedido.Text = dto.Id.ToString("000000");
            BtCriarCotacao.Enabled = true;
            BtCriarCotacao.Enabled = false;

            AlteraBotoes();
            
        }

        private void ExibeAdicionarPorSetor(bool exibe)
        {
            if (exibe)
            {
                GbItens.Location = new Point(6, 90);
                GbItens.Visible = true;
            }
            else
            {
                GbItens.Location = new Point(577, 9);
                GbItens.Visible = false;
            }
        }

        private void CarregaPedidosSetor(int id_setor, string obs)
        {
            BLLItensPedido bll = new BLLItensPedido();
            DataTable tabela = bll.ListarItensSetor(id_setor, obs);
            
            if(tabela.Rows.Count > 0)
            {
                BLLSetores blls = new BLLSetores();
                CbSetores.Text = blls.NomeSetor(id_setor);
                TxtObsSetor.Text = obs;
                BtEditaSetor.Enabled = true;
                GbSetores.Enabled = false;
                
                for(int i = 0; i<tabela.Rows.Count; i++)
                {
                    String[] V = new string[] { tabela.Rows[i][0].ToString(), tabela.Rows[i][1].ToString(), tabela.Rows[i][2].ToString(), tabela.Rows[i][3].ToString(), tabela.Rows[i][4].ToString(), tabela.Rows[i][5].ToString(), tabela.Rows[i][6].ToString(), tabela.Rows[i][7].ToString() };
                    DgvItens.Rows.Add(V);
                }
            }

            TxtCodItem.Select();
        }

        private void BtAdicionaSetores(object sender, EventArgs e)
        {
            ExibeAdicionarPorSetor(true);
            GbSetores.Enabled = true;
            BtEditaSetor.Enabled = false;
            CbSetores.Focus();

            SalvaDadosPedido();
            
        }

        private void SalvaDadosPedido()
        {
            //TODO Criar salvamento;
            status = StatusJanela.inserindo;
            AlteraBotoes();
        }

        private void BtSalvarItensSetor_Click(object sender, EventArgs e)
        {
            idSetorExc = 0;
            obsSetorExc = "";

            //Eclui os registros removidos do pedido
            BLLItensPedido bll = new BLLItensPedido();

            String[] arrayItensAExcluir = TxtItensACancelar.Text.Split(';');

            //Loop para excluir os itens retirados da tabela
            for (int i = 0; i < arrayItensAExcluir.Length; i++)
            {
                try
                {
                    //Exluir o registro com o id                
                    int id = Convert.ToInt32(arrayItensAExcluir[i]);
                    if (id > 0)
                    {
                        bll.Excluir(id);
                    }
                }
                catch { }

            }

            //Preenche os dados de acordo com a linha do DGV

            DTOItensPedido dtopedido = new DTOItensPedido();

            //Faz o looping pelos registros
            for (int i = 0; i < DgvItens.Rows.Count; i++)
            {
                dtopedido.Cod_item = Convert.ToString(DgvItens.Rows[i].Cells[2].Value);
                dtopedido.Id_um = Convert.ToInt32(DgvItens.Rows[i].Cells[4].Value);
                dtopedido.Quant = Convert.ToDouble(DgvItens.Rows[i].Cells[6].Value);
                dtopedido.Obs = Convert.ToString(DgvItens.Rows[i].Cells[7].Value);
                dtopedido.Id_usuario = usuarioConectado.Id_usuario;
                dtopedido.Id_setor = Convert.ToInt32(CbSetores.SelectedValue);
                dtopedido.Obs_setor = TxtObsSetor.Text;
                dtopedido.Solicitado = false;
                dtopedido.Id_pedido = Convert.ToInt32(TxtIdPedido.Text);

                //Caso o registro tenha ID, o mesmo é editado
                if (Convert.ToInt32(DgvItens.Rows[i].Cells[0].Value) > 0)
                {
                    dtopedido.Id_item_pedido = Convert.ToInt32(DgvItens.Rows[i].Cells[0].Value);
                    bll.Alterar(dtopedido);
                }

                //caso não tenha, o item é adicionado.
                else
                {
                    bll.Incluir(dtopedido);
                }
            }

            ValoresPadroesSetores();
            ExibeAdicionarPorSetor(false);
            CarregaDGVSetores(Convert.ToInt32(TxtIdPedido.Text));

        }

        private void ValoresPadroesSetores()
        {
            TxtObs.Clear();
            CbSetores.Text = "";
            TxtIdMaterial.Clear();
            TxtCodItem.Clear();
            TxtNomeItem.Clear();
            TxtQuant.Clear();
            CbUm.Text = "";
            TxtObsSetor.Clear();
            TxtItensACancelar.Clear();
            DgvItens.Rows.Clear();
            idSetorExc = 0;
            obsSetorExc = "";
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            cancelar = true;

            ValoreSetoresPadrao();
            ExibeAdicionarPorSetor(false);
            idSetorExc = 0;
            obsSetorExc = "";
            cancelar = false;
        }

        private void ValoreSetoresPadrao()
        {
            LimpaDgvItens();
            TxtCodItem.Clear();
            TxtNomeItem.Clear();
            TxtQuant.Clear();
            CbUm.Text = "";
            CbSetores.Text = "";
            TxtObs.Clear();
            TxtIdMaterial.Clear();            
            TxtItensACancelar.Clear();
            
        }

        private void LimpaDgvItens()
        {
            DgvItens.Rows.Clear();
        }

        private void CarregaUnidade()
        {
            BLLUnidade bllun = new BLLUnidade();

            CbUnidade.DataSource = bllun.Localizar();
            CbUnidade.DisplayMember = "nomeReduzido";
            CbUnidade.ValueMember = "id_unidade";
            CbUnidade.Text = "nomeReduzido";

            BLLPermissoes bllperm = new BLLPermissoes();

            if (bllperm.PermissaoPorLocal(Diversos.LocaisPermissoes.Usarios, usuarioConectado) >= 4)
            {
                CbUnidade.Enabled = true;
            }

            else
            {
                CbUnidade.Enabled = false;
            }
        }

        private void CarregaSetores()
        {
            //Carregar todas as unidades de medida cadastradas
            BLLSetores BLLSetores = new BLLSetores();

            CbSetores.DataSource = BLLSetores.Listar();
            CbSetores.DisplayMember = "nome";
            CbSetores.ValueMember = "id";
            CbSetores.Text = "";
        }

        private void CarregaSetores(string setor)
        {
            //Carregar todas as unidades de medida cadastradas
            BLLSetores BLLSetores = new BLLSetores();

            CbSetores.DataSource = BLLSetores.Listar();
            CbSetores.DisplayMember = "nome";
            CbSetores.ValueMember = "id";
            CbSetores.Text = setor.Trim().ToUpper();
        }

        private void CarregaValoresPadrao()
        {
            CarregaUnidade();
            CarregaSetores();
            CarregaUm();            
        }

        private void CbSetores_Leave(object sender, EventArgs e)
        {
            if (!cancelar)
            {

                //Verifica se o valor incluído existe no banco de dados

                BLLSetores bll = new BLLSetores();

                DTOSetores dto = new DTOSetores();


                if (!bll.ExisteSetor(CbSetores.Text))
                {
                    //Caso não exista, inclui
                    string nome = CbSetores.Text.Trim().ToUpper();

                    dto.Nome = nome;
                    dto.Id_ususario = usuarioConectado.Id_usuario;

                    bll.Incluir(dto);

                    //Atualiza o Combo box e deixa o valor digitado como ativo
                    CarregaSetores(nome);
                }
                else if (CbSetores.Text.Trim().Replace(" ", "") != "")
                {
                    CbSetores.Text = CbSetores.Text.Trim().ToUpper();
                }
                else
                {

                }
            }
        }

        private void TxtCodItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                DTOMateriais dto = new DTOMateriais();

                Empresas.FrmConsultaItens f = new Empresas.FrmConsultaItens();
                f.ShowDialog();
                dto = f.material;
                f.Dispose();

                if (dto.CodigoCigam != null)
                {

                    try
                    {
                        TxtIdMaterial.Text = dto.Id_material.ToString();
                        TxtCodItem.Text = dto.CodigoCigam.ToString();
                        TxtNomeItem.Text = dto.Descricao.ToString();
                        CbUm.Text = dto.Um.ToString();
                        
                        TxtQuant.Enabled = true;
                        TxtQuant.Text = "0,00";
                        BtAddItem.Enabled = true;

                        TxtQuant.Focus();
                    }
                    catch
                    {
                        MessageBox.Show("Código inválido. Por favor selecione um código existente");
                        BtAddItem.Enabled = false;
                    }
                }
                else
                {

                }

            }
        }

        private void BtAddItem_Click(object sender, EventArgs e)
        {
            AdicionaItem();
        }

        private void AdicionaItem()
        {
            double qtd = Convert.ToDouble(TxtQuant.Text);

            String[] V = new string[] { "0", TxtIdMaterial.Text, TxtCodItem.Text, TxtNomeItem.Text, CbUm.SelectedValue.ToString(), CbUm.Text, TxtQuant.Text, TxtObs.Text };
            DgvItens.Rows.Add(V);

            TxtNomeItem.Clear();
            TxtCodItem.Clear();
            TxtQuant.Clear();
            CbUm.Text = "";
            TxtObs.Clear();
            TxtIdMaterial.Clear();
            TxtCodItem.Focus();
            BtAddItem.Enabled = false;
            TxtQuant.Enabled = false;
        }

        private void CarregaDGVSetores(int id)
        {
            DgvSetores.Rows.Clear();

            BLLItensPedido bll = new BLLItensPedido();
            DataTable tabela = bll.AgruparPedidosSetores(id);

            if (tabela.Rows.Count > 0)
            {
                for(int i = 0; i<tabela.Rows.Count; i++)
                {
                    String[] V = new string[] { tabela.Rows[i][0].ToString() , tabela.Rows[i][1].ToString(), tabela.Rows[i][2].ToString(), tabela.Rows[i][3].ToString() };
                    DgvSetores.Rows.Add(V);
                }
            }
        }

        private void DgvItens_SelectionChanged(object sender, EventArgs e)
        {
            DgvItens.ClearSelection();
        }

        private void TxtQuant_Validating(object sender, CancelEventArgs e)
        {
            if (TxtQuant.Text == "")
            {
                TxtQuant.Text = "0,00";                
            }

            string txt = TxtQuant.Text;

            if (Double.TryParse(txt, out double doubleValue))
            {
                TxtQuant.Text = doubleValue.ToString("#,0.00");                
            }

            else if (TxtQuant.Text == "")
            {
            }

            else
            {
                e.Cancel = true;
                MessageBox.Show("Digite um valor numérico com até duas casas decimais.");
            }
        }

        private void DgvItens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                if (e.RowIndex >= 0)
                {
                    if (Convert.ToInt32(DgvItens.Rows[e.RowIndex].Cells[0].Value) > 0)
                    {
                        TxtItensACancelar.Text += Convert.ToString(DgvItens.Rows[e.RowIndex].Cells[0].Value)+";";
                    }
                    TxtIdMaterial.Text = Convert.ToString(DgvItens.Rows[e.RowIndex].Cells[1].Value);
                    TxtCodItem.Text = Convert.ToString(DgvItens.Rows[e.RowIndex].Cells[2].Value);
                    TxtNomeItem.Text = Convert.ToString(DgvItens.Rows[e.RowIndex].Cells[3].Value);
                    CbUm.Text = Convert.ToString(DgvItens.Rows[e.RowIndex].Cells[5].Value);
                    TxtQuant.Text = Convert.ToString(DgvItens.Rows[e.RowIndex].Cells[6].Value);
                    TxtObs.Text = Convert.ToString(DgvItens.Rows[e.RowIndex].Cells[7].Value);
                    TxtQuant.Enabled = true;
                    BtAddItem.Enabled = true;
                    
                    DgvItens.Rows.RemoveAt(e.RowIndex);
                    
                    TxtCodItem.Focus();

                }
            }
        }

        private void TxtObs_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                AdicionaItem();
            }
        }

        private void BtCriarCotacao_Click(object sender, EventArgs e)
        {
            AbrePedido();
            status = StatusJanela.inserindo;
            AlteraBotoes();
        }

        private void BtEdita_Click(object sender, EventArgs e)
        {
            AbrePedido(Convert.ToInt32(TxtIdPedido.Text));
            status = StatusJanela.Editando;
            AlteraBotoes();
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

        private void CarregaUm()
        {
            //Carregar todas as unidades de medida cadastradas
            BLLUnidadeMedida BLLUm = new BLLUnidadeMedida();

            CbUm.DataSource = BLLUm.Listar();
            CbUm.DisplayMember = "um";
            CbUm.ValueMember = "id_um";
            CbUm.Text = "";
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

        private void DgvSetores_SelectionChanged(object sender, EventArgs e)
        {
            DgvSetores.ClearSelection();
        }

        private void DgvSetores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                if (e.RowIndex >= 0)
                {
                    if (Convert.ToInt32(DgvSetores.Rows[e.RowIndex].Cells[0].Value) > 0)
                    {
                        CarregaPedidosSetor(Convert.ToInt32(DgvSetores.Rows[e.RowIndex].Cells[0].Value), Convert.ToString(DgvSetores.Rows[e.RowIndex].Cells[2].Value));

                        ExibeAdicionarPorSetor(true);
                        GbItens.Focus();

                        idSetorExc = Convert.ToInt32(DgvSetores.Rows[e.RowIndex].Cells[0].Value);
                        obsSetorExc = Convert.ToString(DgvSetores.Rows[e.RowIndex].Cells[2].Value);

                        TxtIdMaterial.Select();
                    }
                }
            }
        }

        private void BtEditaSetor_Click(object sender, EventArgs e)
        {
            GbSetores.Enabled = true;
        }

        private void BtExcluir_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deseja mesmo apagar todos os itens deste setor? Essa ação não terá como desfazer.", "Atenção!", MessageBoxButtons.YesNo);

            if(dr == DialogResult.Yes)
            {
                BLLItensPedido bll = new BLLItensPedido();
                bll.Excluir(idSetorExc, obsSetorExc, Convert.ToInt32(TxtIdPedido.Text));
                ValoresPadroesSetores();
                ExibeAdicionarPorSetor(false);
                CarregaDGVSetores(Convert.ToInt32(TxtIdPedido.Text));
            }
        }

        private void BtExcluirPedido_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deseja mesmo apagar o pedido de todos os setores desse pedido? Essa ação não terá como desfazer.", "Atenção!", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                BLLPedidos bll = new BLLPedidos();
                bll.Excluir(Convert.ToInt32(TxtIdPedido.Text));
                MessageBox.Show("Pedido excluído!");
                this.Close();
            }
        }

        private void BtSalvar_Click(object sender, EventArgs e)
        {
            SalvaDadosPedido();
        }
    }
    
}
