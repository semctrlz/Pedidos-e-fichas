using GerenciadorEstoque.Code;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace GerenciadorEstoque.Forms.Produtos
{
    public partial class FrmValorExterno : Form
    {
        string codItem;

        DTOUsuarios UsuarioLogado;

        public FrmValorExterno(DTOUsuarios u)
        {
            UsuarioLogado = u;

            InitializeComponent();
        }

        private void FrmValorExterno_Load(object sender, EventArgs e)
        {

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
                        txtCodItem.Text = dto.CodigoCigam;
                        codItem = dto.CodigoCigam;
                        LbNomeMaterial.Text = dto.Descricao.ToString().ToUpper();
                        LbUm.Text = $"Valor ({dto.Um})";
                        BtSalvar.Enabled = true;
                        TxtValor.Enabled = true;
                        TxtValor.Focus();                        
                    }
                    catch
                    {
                        MessageBox.Show("Código inválido. Por favor selecione um código existente");
                        BtSalvar.Enabled = false;
                        TxtValor.Enabled = false;
                        codItem = null;
                    }
                }
                else
                {

                }
            }
        }
        
        private void TxtValor_Validating(object sender, CancelEventArgs e)
        {
            if (TxtValor.Text == "")
            {
                TxtValor.Text = "0,00";

            }
            string txt = TxtValor.Text;

            if (Double.TryParse(txt, out double doubleValue))
            {
                TxtValor.Text = doubleValue.ToString("#,0.00");

            }

            else if (TxtValor.Text == "")
            {
            }
            else
            {
                e.Cancel = true;
                MessageBox.Show("Digite um valor numérico com até duas casas decimais.");
            }
        }

        private void BtSalvar_Click(object sender, EventArgs e)
        {
            BLLMateriais bll = new BLLMateriais();
            bll.CriarValorExterno(codItem, Convert.ToDouble(TxtValor.Text));
            txtCodItem.Clear();
            TxtValor.Clear();
            LbNomeMaterial.Text = "";
            codItem = null;
            LbUm.Text = "Valor";
            MessageBox.Show("Valor criado com sucesso.");
        }
    }
}