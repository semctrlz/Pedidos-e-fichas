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

namespace GerenciadorEstoque.Forms.Produtos
{
    public partial class FrmEspecializacaoMateriais : Form
    {
        DTOUsuarios usuarioLocado = new DTOUsuarios();

        string codigoAtual, umBase;

        public FrmEspecializacaoMateriais(DTOUsuarios u)
        {
            usuarioLocado = u;
            InitializeComponent();
        }

        public enum Statusjanela {Inicial, Inserindo};

        Statusjanela Status;

        private void FrmEspecializacaoMateriais_Load(object sender, EventArgs e)
        {
            Status = Statusjanela.Inicial;
            AtualizaStatus();

            Diversos d = new Diversos();

            CbxUm.DataSource = Enum.GetValues(typeof(UniadesMedida));


            txtCodItem.Focus();
        }

        private void AtualizaStatus()
        {
            if(Status == Statusjanela.Inserindo)
            {
                TxtNomeItemNovo.Enabled = true;
                CbxUm.Enabled = true;
                BtAdicionar.Enabled = true;
                DgvItens.Enabled = true;
            }
            else
            {
                TxtNomeItemNovo.Enabled = false;
                CbxUm.Enabled = false;
                BtAdicionar.Enabled = false;
                DgvItens.Enabled = false;
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

                        txtCodItem.Text = dto.CodigoCigam.ToString();
                        txtNomeItem.Text = dto.Descricao.ToString();                        
                        TxtUm.Text = dto.Um.ToString();
                        codigoAtual = dto.CodigoCigam;
                        umBase = dto.Um;

                        try
                        {
                            CbxUm.Text = dto.Um;
                        }
                        catch
                        {
                            CbxUm.Text = "Kg";
                        }

                        CarregarDgv();

                        Status = Statusjanela.Inserindo;
                        AtualizaStatus();

                        TxtNomeItemNovo.Focus();
                    }
                    catch
                    {
                        MessageBox.Show("Código inválido. Por favor selecione um código existente");
                        Status = Statusjanela.Inicial;
                        AtualizaStatus();
                        codigoAtual = "";
                        umBase = "";
                    }
                }
                else
                {

                }

            }
        }

        private void CarregarDgv()
        {
            //Carrega todos os materiais derivados do codigo que está na variavel 'codigoAtual'
                   
                DgvItens.Rows.Clear();                     

            BLLMateriaisDerivados bll = new BLLMateriaisDerivados();
            DataTable materiais = bll.Listar(codigoAtual);
            
            if (materiais.Rows.Count > 0)
            {
                string idMaterialDerivado, nomeingrediente, um;

                for (int i = 0; i < materiais.Rows.Count; i++)
                {                    
                    idMaterialDerivado = materiais.Rows[i][0].ToString();                    
                    nomeingrediente = materiais.Rows[i][2].ToString();
                    um = materiais.Rows[i][3].ToString();
                    
                    String[] V = new string[] { idMaterialDerivado, nomeingrediente, um};
                    DgvItens.Rows.Add(V);

                }                

            }

        }

        private void DgvItens_SelectionChanged(object sender, EventArgs e)
        {
            DgvItens.ClearSelection();
        }

        private void DgvItens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                if (e.RowIndex >= 0 && Convert.ToInt32(DgvItens.Rows[e.RowIndex].Cells[0].Value) > 0)
                {
                    TxtNomeItemNovo.Text = Convert.ToString(DgvItens.Rows[e.RowIndex].Cells[1].Value);
                    CbxUm.Text = Convert.ToString(DgvItens.Rows[e.RowIndex].Cells[2].Value);

                    BLLMateriaisDerivados bll = new BLLMateriaisDerivados();
                    bll.Excluir(Convert.ToInt32(DgvItens.Rows[e.RowIndex].Cells[0].Value));
                    CarregarDgv();
                }
            }
        }

        private void BtAdicionar_Click(object sender, EventArgs e)
        {
            BLLMateriaisDerivados bll = new BLLMateriaisDerivados();
            DTOMateriaisDerivados dto = new DTOMateriaisDerivados();

            dto.CodigoCigam = codigoAtual;
            dto.Descricao = TxtNomeItemNovo.Text;
            dto.Um = CbxUm.Text;

            bll.Incluir(dto);

            TxtNomeItemNovo.Clear();
            CbxUm.Text = umBase;

            CarregarDgv();

            TxtNomeItemNovo.Focus();

        }
    }
}
