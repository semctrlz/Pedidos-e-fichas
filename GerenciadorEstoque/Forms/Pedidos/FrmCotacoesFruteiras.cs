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
    public partial class FrmCotacoesFruteiras : Form
    {
        DTOUsuarios usuarioConectado;
        
        public FrmCotacoesFruteiras( DTOUsuarios u)
        {
            InitializeComponent();
            usuarioConectado = u;

        }

        private void FrmCotacoesFruteiras_Load(object sender, EventArgs e)
        {
            DefaultValues();            
        }

        private void CarregaComboBoxes()
        {
            CarregaUnidade();
            CarregaUm();
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

        private void DefaultValues()
        {
            CarregaComboBoxes();
            AlteraTodasUnidades();
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

        private void BtPreencher_Click(object sender, EventArgs e)
        {            
            if(DgvItens.Rows.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Deseja sobrescrever os itens da lista?\nIsso irá apagar os dados inseridos.", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(dr == DialogResult.Yes)
                {
                    CarregaDGV();
                }
            }
            else
            {
                CarregaDGV();
            }

            
        }

        private void CarregaDGV()
        {            
            
        }

        private void TxtCodItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                DTOMateriais dto = new DTOMateriais();

                Empresas.FrmConsultaItens frm = new Empresas.FrmConsultaItens();
                frm.ShowDialog();

                if (frm.material.Id_material > 0)
                {
                    dto = frm.material;
                }

                frm.Dispose();

                if (dto.Id_material > 0)
                {
                    TxtCodItem.Text = dto.CodigoCigam;
                    TxtNomeItem.Text = dto.Descricao;
                    CbUm.Text = dto.Um;
                    CbUm.Focus();                    
                }

                else
                {
                    TxtCodItem.Clear();
                    TxtNomeItem.Clear();
                    CbUm.Text = "";                    
                }

                TxtCusto.Enabled = true;
            }
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

        private void CbxTodasUnidades_CheckedChanged(object sender, EventArgs e)
        {
            AlteraTodasUnidades();
        }

        private void AlteraTodasUnidades()
        {
            if (CbxTodasUnidades.Checked)
            {
                CbUnidade.Enabled = false;
            }
            else
            {
                CbUnidade.Enabled = true;
            }
        }

        private void TxtCusto_Validating(object sender, CancelEventArgs e)
        {
            if (TxtCusto.Text == "")
            {
                TxtCusto.Text = "0.00";                
            }

            string txt = TxtCusto.Text;

            if (float.TryParse(txt, out float floatValue))
            {
                TxtCusto.Text = floatValue.ToString("0.00");               
            }
            
            else
            {
                e.Cancel = true;
                MessageBox.Show("Digite um valor decimal.");
            }
        }

        private void TxtCodFornecedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                DTOEmpresas dto = new DTOEmpresas();

                Empresas.FrmConsultaEmpresas frm = new Empresas.FrmConsultaEmpresas();
                frm.ShowDialog();
                try
                {
                    if (frm.empresa.Id_empresa > 0)
                    {
                        dto = frm.empresa;
                    }
                }
                catch
                {

                }

                frm.Dispose();

                if (dto.Id_empresa > 0)
                {
                    txtNomeForn.Text = dto.NomeCompleto;
                    TxtCodFornecedor.Text = dto.CodigoCIGAM.ToString("000000");
                    DtpData.Focus();
                    BtClonarCotacao.Enabled = true;
                    GbItens.Enabled = true;
                }
                else
                {
                    txtNomeForn.Clear();
                    TxtCodFornecedor.Clear();
                    BtClonarCotacao.Enabled = false;
                    GbItens.Enabled = false;
                }
            }
        }

        private void BtAddItem_Click(object sender, EventArgs e)
        {
            AdicionaItem();
        }

        private void AdicionaItem()
        {
            //Lê e passa os fafos para uma array de string

            string[] V = { "0", TxtCodItem.Text, TxtNomeItem.Text, CbUm.Text, Convert.ToDouble(TxtCusto.Text).ToString("0.00")};
            //Passa a Array para o DataGridView
            DgvItens.Rows.Add(V);

            TxtCodItem.Clear();
            TxtNomeItem.Clear();
            CbUm.Text = "";
            TxtCusto.Text = "0,00";
            TxtCodItem.Focus();


        }

        private void CbUm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AdicionaItem();
            }
        }

        private void DgvItens_SelectionChanged(object sender, EventArgs e)
        {
            DgvItens.ClearSelection();
        }

        private void DgvItens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                if (e.RowIndex >= 0)
                {
                    if (Convert.ToString(DgvItens.Rows[e.RowIndex].Cells[0].Value) != "")
                    {
                        TxtCodItem.Text = Convert.ToString(DgvItens.Rows[e.RowIndex].Cells[1].Value);
                        TxtNomeItem.Text = Convert.ToString(DgvItens.Rows[e.RowIndex].Cells[2].Value);
                        CbUm.Text = Convert.ToString(DgvItens.Rows[e.RowIndex].Cells[3].Value);
                        TxtCusto.Text = Convert.ToDouble(DgvItens.Rows[e.RowIndex].Cells[4].Value).ToString("0.00");
                        
                        if(Convert.ToInt32(DgvItens.Rows[e.RowIndex].Cells[0].Value) > 0)
                        {
                            TxtItensAExcluir.Text += $"{Convert.ToString(DgvItens.Rows[e.RowIndex].Cells[0].Value)};";
                        }

                        DgvItens.Rows.RemoveAt(e.RowIndex);


                        TxtCodItem.Focus();
                    }
                }
            }
        }

        private void BtSalvar_Click(object sender, EventArgs e)
        {
            SalvarCotacao();
        }

        private void SalvarCotacao()
        {
            //Verificar se o DGV está vazio

            if(DgvItens.Rows.Count == 0)
            {
                //Caso esteja uma mensagem é mostrada
                MessageBox.Show("Para salvar insira itens na cotação!", "Aviso!");
                






                TxtCodItem.Focus();
            }
            //Caso não esteja, continua com o salvamento
            else
            {
                //Caso o número da cotação não exista, cria uma nota cotação.
                if (TxtNumeroCotacao.Text.Length == 0)
                {
                    DTOCotacao dto = new DTOCotacao();
                    dto.IdEmpresa = Convert.ToInt32(TxtCodFornecedor.Text);
                    dto.DataInicioVigencia = DtpInicio.Value;
                    dto.DataFimVigencia = DtpFim.Value;
                    if (!CbxTodasUnidades.Checked)
                    {
                        dto.Id_unidade = Convert.ToInt32(CbUnidade.SelectedValue);
                    }
                    else
                    {
                        dto.Id_unidade = 0;
                    }

                    dto.Id_ususario = usuarioConectado.Id_usuario;

                    BLLCotacao bll = new BLLCotacao();
                    bll.Incluir(dto);
                    TxtNumeroCotacao.Text = dto.Id.ToString("000000");
                }

                //excluir todos as cotações com o Id no TxtItensAExcluir

                string[] IdsExclusao;

                if(TxtItensAExcluir.Text.Length > 0)
                {
                    IdsExclusao = TxtItensAExcluir.Text.PadLeft(TxtItensAExcluir.Text.Length - 1).Split(';');

                    for(int i = 0; i<IdsExclusao.Length; i++)
                    {
                        
                    }
                }



            //Faz um loop pelo DGV incluindo itens com Id 0 e ignorando itens com Id > 0

            }

        }

        private void BtCriar_Click(object sender, EventArgs e)
        {
            //Gera um número novo de cotação. OBS. a cotação só será criada quando clicarmos em salvar na base da tela.
            //

        }
    }
}
