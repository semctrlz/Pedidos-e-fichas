using GerenciadorEstoque.Code;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GerenciadorEstoque.Forms.Fichas
{
    public partial class FrmVisualizaFichaTecnica : Form
    {
        DTOUsuarios usuarioLogado;
        int idUnidade = 0;
        string codFicha = "";

        public FrmVisualizaFichaTecnica(DTOUsuarios u, int i, string c)
        {
            idUnidade = i;
            usuarioLogado = u;
            codFicha = c;
            
            InitializeComponent();
        }

        private void FrmVisualizaFichaTecnica_Load(object sender, EventArgs e)
        {
            pnImagem.Location = new Point(5, 96);
            pbImagem.Visible = false;

            CarregaFicha();
            CarregarIngredientesPorCodigo();
        }

        private void CarregaFicha()
        {
            BLLPratos bllp = new BLLPratos();
            DataTable tabela = bllp.LocalizarPorCod(codFicha);

            DTOCaminhos dto = new DTOCaminhos();

            string nomePrato, codigo, desc, preparo;
            double rendimento, peso;
            int setor, cat, subcat, atendePax;

            // Preenche dados da Ficha
            codigo = codFicha;
            nomePrato = tabela.Rows[0][1].ToString();
            desc = tabela.Rows[0][8].ToString();
            preparo = tabela.Rows[0][6].ToString();
            rendimento = Convert.ToDouble(tabela.Rows[0][5]);
            peso = Convert.ToDouble(tabela.Rows[0][7]);
            atendePax = Convert.ToInt32(tabela.Rows[0][10]);
            setor = Convert.ToInt32(tabela.Rows[0][2]);
            cat = Convert.ToInt32(tabela.Rows[0][3]);
            subcat = Convert.ToInt32(tabela.Rows[0][4]);

            lbTitulo.Text = $"{nomePrato} ({codFicha})";


            if (string.IsNullOrEmpty(preparo))
            {
                lbPreparo.Text = "";
            }
            else
            {
                lbPreparo.Text = preparo;
            }

            if (string.IsNullOrEmpty(peso.ToString()))
            {
                lbPeso.Text = "0,0000";
            }
            else
            {
                lbPeso.Text = peso.ToString("#,0.0000");
            }

            if (string.IsNullOrEmpty(atendePax.ToString()))
            {
                LbAtendePax.Text = "0,0000";
            }
            else
            {
                LbAtendePax.Text = atendePax.ToString("#,0.0000");
            }

            lbRendimento.Text = rendimento.ToString("#,0.00");

            //Carrega setor, categoria e subcategoria

            BLLBuffet bllsetor = new BLLBuffet();
            DataTable tabelasetor = bllsetor.LocalizarPorId(setor);

            lbSetor.Text = tabelasetor.Rows[0][0].ToString();

            BLLCategoria bllcat = new BLLCategoria();
            DataTable tabelacat = bllcat.LocalizarPorId(cat);

            if (tabelacat.Rows.Count > 0)
            {
                lbCat.Text = tabelacat.Rows[0][0].ToString();
            }
            else
            {
                lbCat.Text = "";
            }

            BLLSubCategoria bllscat = new BLLSubCategoria();
            DataTable tabelascat = bllscat.LocalizarPorId(subcat);

            if (tabelascat.Rows.Count > 0)
            {
                lbSubcat.Text = tabelascat.Rows[0][0].ToString();
            }
            else
            {
                lbSubcat.Text = "";
            }

            //Verifica se existe foto

            if (File.Exists(dto.FT + codFicha + ".jpg"))
            {
                pbImagem.Visible = true;
                pbimagem1.Load(dto.FT + codFicha + ".jpg");
            }
            else
            {
                pbImagem.Visible = false;
            }
        }

        private void DgvDados_SelectionChanged(object sender, EventArgs e)
        {
            dgvDados.ClearSelection();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            pnImagem.Visible = false;
        }

        private void PbImagem_Click(object sender, EventArgs e)
        {
            if (pnImagem.Visible)
            {
                pnImagem.Visible = false;
            }
            else
            {
                pnImagem.Visible = true;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            pnImagem.Visible = false;
        }

        private void PbPrint_Click(object sender, EventArgs e)
        {
            DTOCaminhos dto = new DTOCaminhos();
            bool img = false;
            if (File.Exists(dto.FT + codFicha + ".jpg"))
            {
                DialogResult d = MessageBox.Show("Esta ficha contém uma imagem anexada. Deseja exportar a imagem para PDF também?", "ATENÇÃO!", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    img = true;
                }
            }
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog()
                {
                    Filter = "Arquivos PDF (*.pdf)|*.pdf",
                    FilterIndex = 2,
                    FileName = lbTitulo.Text,
                    RestoreDirectory = true
                };
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    ExportaPdf(img, codFicha, saveFileDialog1.FileName, idUnidade);
                }
            }
            catch
            {
                MessageBox.Show("Impossível exportar a ficha técnica para PDF. Verifique se não exite um arquivo em PDF aberto que esteja impedindo esta operação.");
            }
        }

        private void ExportaPdf(bool imagem, string cod, string caminho, int unidade)
        {
            FichasTecnicas au = new FichasTecnicas();

            au.ParaPDF(imagem, cod, caminho, unidade);

            System.Diagnostics.Process.Start($"{caminho}");

        }

        private void CarregarIngredientesPorCodigo()
        {
            dgvDados.Rows.Clear();

            //Linha por linha busca ingrediente com custo
            BLLPratos bll = new BLLPratos();
            DataTable tabelaIngredientes = bll.ListarIngredientes(codFicha);

            BLLMateriais bllaeb = new BLLMateriais();
            DataTable tabelaAeb;

            FichasTecnicas a = new FichasTecnicas();

            double TotalFicha = 0;

            if (tabelaIngredientes.Rows.Count > 0)
            {
                for (int i = 0; i < tabelaIngredientes.Rows.Count; i++)
                {
                    //cod_item, quant_ingrediente

                    tabelaAeb = bllaeb.LocalizarPorCod(tabelaIngredientes.Rows[i][0].ToString());

                    string codIngrediente, nomeingrediente, um;
                    double quant, custoUnit, custoTotal, fc;

                    codIngrediente = tabelaIngredientes.Rows[i][0].ToString();
                    nomeingrediente = tabelaAeb.Rows[0][0].ToString();
                    um = tabelaAeb.Rows[0][1].ToString();
                    if (string.IsNullOrEmpty(tabelaAeb.Rows[0][2].ToString()))
                    {
                        fc = 0;
                    }
                    else
                    {
                        fc = Convert.ToDouble(tabelaAeb.Rows[0][2]);
                    }

                    quant = Convert.ToDouble(tabelaIngredientes.Rows[i][1]);

                    custoUnit = a.CustoIngrediente(codIngrediente, idUnidade);
                    custoTotal = custoUnit * quant;


                    String[] V = new string[] { codIngrediente, nomeingrediente, um, fc.ToString("#,0.0000"), quant.ToString("#,0.0000"), custoUnit.ToString("#,0.00"), custoTotal.ToString("#,0.00") };
                    dgvDados.Rows.Add(V);

                    TotalFicha += custoTotal;
                }

                lbTotal.Text = TotalFicha.ToString("#,0.00");

                if (Convert.ToDouble(lbPeso.Text) > 0)
                {
                    lbTotalKg.Text = (TotalFicha / Convert.ToDouble(lbPeso.Text)).ToString("#,0.00");
                }
                else
                {
                    lbTotalKg.Text = "0,00";
                }

                if (Convert.ToDouble(lbRendimento.Text) > 0)
                {
                    lbcustoPorcao.Text = (TotalFicha / Convert.ToDouble(lbRendimento.Text)).ToString("#,0.00");
                }
                else
                {
                    lbcustoPorcao.Text = "0,00";
                }
                
                if (Convert.ToDouble(LbAtendePax.Text) > 0)
                {
                    LbCustoPax.Text = (TotalFicha / Convert.ToDouble(LbAtendePax.Text)).ToString("#,0.00");
                }
                else
                {
                    LbCustoPax.Text = 0.ToString("#,0.00");
                }
            }
        }

        private void Pbimagem1_Click(object sender, EventArgs e)
        {
            pnImagem.Visible = false;

        }
    }
}
