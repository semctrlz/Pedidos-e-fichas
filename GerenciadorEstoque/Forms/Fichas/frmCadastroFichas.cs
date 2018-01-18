using GerenciadorEstoque.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorEstoque.Forms.Fichas
{
    public partial class frmCadastroFichas : Form
    {
        DTOUsuarios usuarioConectado = new DTOUsuarios();

        public string foto = "";
        int unidade;
        bool herdado = false;
        string operacao = "consultar";
        string CodigoEdicaoProduto = "";
        bool liberado = false;

        public frmCadastroFichas(DTOUsuarios dto, string cod, bool h)
        {
            InitializeComponent();
            usuarioConectado = dto;
            CodigoEdicaoProduto = cod;
            herdado = h;
        }

        public frmCadastroFichas(DTOUsuarios dto)
        {
            InitializeComponent();
            usuarioConectado = dto;            
        }

        private void FrmCadastroFichas_Load(object sender, EventArgs e)
        {
            this.Text = this.Text + " - " + usuarioConectado.Usuario.ToString();

            if (CodigoEdicaoProduto == "")
            {
                DefaultValues();
            }
            else
            {
                CarregaFicha(CodigoEdicaoProduto);
                operacao = "consultar";
            }
            
            AlteraBotoes();
            
            liberado = true;
        }

        private void DefaultValues()
        {
                BLLUnidade bllun = new BLLUnidade();

                cbUnidade.DataSource = bllun.Localizar();
                cbUnidade.DisplayMember = "nomeReduzido";
                cbUnidade.ValueMember = "id_unidade";
                cbUnidade.Text = "nomeReduzido";
            

                BLLPermissoes bllperm = new BLLPermissoes();

                if (bllperm.PermissaoPorLocal(Diversos.LocaisPermissoes.Usarios, usuarioConectado) >= 4)
                {
                    cbUnidade.Enabled = true;
                }

                else
                {
                    cbUnidade.Enabled = false;
                }

                unidade = Convert.ToInt32(cbUnidade.SelectedValue);
            CarregaCat();
            LimpaCampos();
            AlteraBotoes();
            dgvFicha.Rows.Clear();

            txtId.Clear();
        }

        private void LimpaCampos()
        {
            txtNome.Clear();
            txtPeso.Clear();
            txtRendimento.Text = "0,00";
            txtPeso.Text = "0,0000";
            TxtAtendePax.Text = "0";
            cbSetor.Text = "";
            cbCategoria.Text = "";
            cbSubCategoria.Text = "";
            
        }

        private void AlteraBotoes()
        {
            liberado = false;

            btNovo.Enabled = false;
            btEditar.Enabled = false;
            btSalvar.Enabled = false;
            BtLocalizar.Enabled = false;
            CbxAtivo.Enabled = false;

            if (txtCodigoPrato.Text.Replace(".", "").Trim().Length > 0)
            {
                btExcluir.Enabled = true;
            }

            else
            {
                btExcluir.Enabled = false;
            }

            txtNome.Enabled = false;
            txtPeso.Enabled = false;
            txtRendimento.Enabled = false;
            cbSetor.Enabled = false;
            cbSubCategoria.Enabled = false;
            cbCategoria.Enabled = false;
            txtQuant.Enabled = false;
            txtPreparo.Enabled = false;
            dgvFicha.Enabled = false;
            txtDescricao.Enabled = false;
            gbImagem.Enabled = false;
            TxtAtendePax.Enabled = false;
            



            if (operacao == "inserir")
            {
                btSalvar.Enabled = true;                
                gbFicha.Enabled = true;
                gbIngredientes.Enabled = true;
                txtNome.Enabled = true;
                txtPeso.Enabled = true;
                txtRendimento.Enabled = true;
                cbSetor.Enabled = true;
                cbSubCategoria.Enabled = true;
                cbCategoria.Enabled = true;
                txtPreparo.Enabled = true;
                dgvFicha.Enabled = true;
                txtDescricao.Enabled = true;
                gbImagem.Enabled = true;
                TxtAtendePax.Enabled = true;
                BtLocalizar.Enabled = false;
            }            
            else if (operacao == "editar")
            {
                btSalvar.Enabled = true;
                btNovo.Enabled = false;
                gbFicha.Enabled = true;
                gbIngredientes.Enabled = true;
                txtNome.Enabled = true;
                txtPeso.Enabled = true;
                txtRendimento.Enabled = true;
                cbSetor.Enabled = true;
                cbSubCategoria.Enabled = true;
                cbCategoria.Enabled = true;
                txtPreparo.Enabled = true;
                dgvFicha.Enabled = true;
                txtDescricao.Enabled = true;
                gbImagem.Enabled = true;
                TxtAtendePax.Enabled = true;
                CbxAtivo.Enabled = true;


            }
            else if (operacao == "consultar")
            {
                btExcluir.Enabled = true;
                BtLocalizar.Enabled = true;

                if(CodigoEdicaoProduto == "")
                {
                    btEditar.Enabled = false;
                }
                else{

                    btEditar.Enabled = true;
                }                
                btNovo.Enabled = true;
            }
            else
            {

            }

            liberado = true;
        }

        public class Language
        {
            public string Setor { get; set; }
            public string Value { get; set; }
            public string Cat { get; set; }
            public string Value1 { get; set; }
            public string Scat { get; set; }
            public string Value2 { get; set; }
        }

        private void CarregaCat()
        {
            
            BLLBuffet bllsetor = new BLLBuffet();
            DataTable tabelaSetor = bllsetor.Listar();

            BLLCategoria bllCat = new BLLCategoria();
            DataTable tabelaCat = bllCat.Listar();

            BLLSubCategoria bllSCat = new BLLSubCategoria();
            DataTable tabelaSCat = bllSCat.Listar();

            var dataSource1 = new List<Language>();
            
            for (int i = 0; i < tabelaSetor.Rows.Count; i++)
            {
                dataSource1.Add(new Language() { Setor = tabelaSetor.Rows[i][1].ToString(), Value = Convert.ToInt32(tabelaSetor.Rows[i][0]).ToString() });
            }                        

            var dataSource2 = new List<Language>();
            
            for (int i = 0; i < tabelaCat.Rows.Count; i++)
            {
                dataSource2.Add(new Language() { Cat = tabelaCat.Rows[i][1].ToString(), Value1 = Convert.ToInt32(tabelaCat.Rows[i][0]).ToString() });
            }            

            var dataSource3 = new List<Language>();
           
            for (int i = 0; i < tabelaSCat.Rows.Count; i++)
            {
                dataSource3.Add(new Language() { Scat = tabelaSCat.Rows[i][1].ToString(), Value2 = Convert.ToInt32(tabelaSCat.Rows[i][0]).ToString() });
            }
            
            //Atualiza Combobox Setor
            this.cbSetor.DataSource = dataSource1;
            this.cbSetor.DisplayMember = "setor";
            this.cbSetor.ValueMember = "Value";

            //Atualiza Combobox Categoria
            this.cbCategoria.DataSource = dataSource2;
            this.cbCategoria.DisplayMember = "cat";
            this.cbCategoria.ValueMember = "Value1";

            //Atualiza Combobox Subcategoria
            this.cbSubCategoria.DataSource = dataSource3;
            this.cbSubCategoria.DisplayMember = "scat";
            this.cbSubCategoria.ValueMember = "Value2";

        }

        private void BtNovo_Click(object sender, EventArgs e)
        {
            operacao = "inserir";
            ZerarPagina();
            txtNome.Focus();
            txtNome.Select();
        }

        private void ZerarPagina()
        {
            DTOCaminhos dto = new DTOCaminhos();

            liberado = false;
            Image defaultFoto = new Bitmap(Properties.Resources.DefaultImage);
            pbFoto.Image = defaultFoto;
            txtCodItem.Clear();
            txtNomeItem.Clear();
            txtQuant.Clear();
            txtPreparo.Clear();
            txtUm.Clear();
            txtFc.Clear();
            txtCodItem.Focus();
            txtDescricao.Clear();
            dgvFicha.Rows.Clear();
            lbCustoKg2.Text = "0,00";
            LbCustoPax.Text = "0,00";
            lbCustoPorcao2.Text = "0,00";
            lbCustoTotal2.Text = "0,00";
            txtCodigoPrato.Clear();
            gbFicha.Enabled = true;
            gbIngredientes.Enabled = false;
            DefaultValues();
            txtDescricao.Clear();
            AlteraBotoes();
            liberado = true;
        }

        private void BtLocalizar_Click(object sender, EventArgs e)
        {
            operacao = "consultar";
            
            AlteraBotoes();
            string CodFicha = "";
            FrmConsultaFichas frm = new FrmConsultaFichas(usuarioConectado, true);
            frm.ShowDialog();
            CodFicha = frm.codFicha;

            if (CodFicha != "" && !string.IsNullOrEmpty(CodFicha))
            {
                CarregaFicha(CodFicha);
                CodigoEdicaoProduto = CodFicha;
                AlteraBotoes();
            }
            
            frm.Dispose();
        }

        private void CarregaFicha(string cod)
        {
            DefaultValues();

            
            BLLPratos bllp = new BLLPratos();
            DataTable tabela = bllp.LocalizarPorCod(cod);

            string nomePrato, codigo, desc, preparo;
            double rendimento, peso;
            int setor, cat, subcat, quantPax;

            int ativo = 1;

            if (tabela.Rows.Count == 0)
            {
                MessageBox.Show("Não foi possível Localizar a ficha técnica selecionada.");
            }
            else
            {
                // Preenche dados da Ficha
                codigo = cod;
                nomePrato = tabela.Rows[0][1].ToString();
                desc = tabela.Rows[0][8].ToString();
                preparo = tabela.Rows[0][6].ToString();
                rendimento = Convert.ToDouble(tabela.Rows[0][5]);
                peso = Convert.ToDouble(tabela.Rows[0][7]);
                setor = Convert.ToInt32(tabela.Rows[0][2]);
                cat = Convert.ToInt32(tabela.Rows[0][3]);
                subcat = Convert.ToInt32(tabela.Rows[0][4]);
                quantPax = Convert.ToInt32(tabela.Rows[0][10]);
                ativo = Convert.ToInt32(tabela.Rows[0][11]);

                txtCodigoPrato.Text = cod;
                txtNome.Text = nomePrato;
                TxtAtendePax.Text = quantPax.ToString();


                if (string.IsNullOrEmpty(desc))
                {
                    txtDescricao.Text = "";
                }
                else
                {
                    txtDescricao.Text = desc;
                }

                if (string.IsNullOrEmpty(preparo))
                {
                    txtPreparo.Text = "";
                }
                else
                {
                    txtPreparo.Text = preparo;
                }

                if (string.IsNullOrEmpty(peso.ToString()))
                {
                    txtPeso.Text = "0,0000";
                }
                else
                {
                    txtPeso.Text = peso.ToString("#,0.0000");
                }

                if (ativo == 1)
                {
                    CbxAtivo.Checked = true;
                }
                else
                {
                    CbxAtivo.Checked = false;
                }

                txtRendimento.Text = rendimento.ToString("#,0.00");


                //Carrega setor, categoria e subcategoria

                BLLBuffet bllsetor = new BLLBuffet();
                DataTable tabelasetor = bllsetor.LocalizarPorId(setor);

                cbSetor.Text = tabelasetor.Rows[0][0].ToString();

                BLLCategoria bllcat = new BLLCategoria();
                DataTable tabelacat = bllcat.LocalizarPorId(cat);

                if (tabelacat.Rows.Count > 0)
                {
                    cbCategoria.Text = tabelacat.Rows[0][0].ToString();
                }

                BLLSubCategoria bllscat = new BLLSubCategoria();
                DataTable tabelascat = bllscat.LocalizarPorId(subcat);

                if (tabelascat.Rows.Count > 0)
                {
                    cbSubCategoria.Text = tabelascat.Rows[0][0].ToString();
                }

                DTOCaminhos dtocaminhos = new DTOCaminhos();

                if (File.Exists(dtocaminhos.FT + cod + ".jpg"))
                {
                    pbFoto.Load(dtocaminhos.FT + cod + ".jpg");
                    BtDeletaFoto.Enabled = true;
                }
                else
                {
                    Image defaultImage = new Bitmap(Properties.Resources.DefaultImage);

                    pbFoto.Image = defaultImage;
                    BtDeletaFoto.Enabled = false;
                }

                CarregarIngredientesPorCodigo(cod);
            }
        }

        private void CarregarIngredientesPorCodigo(string cod)
        {
            dgvFicha.Rows.Clear();

            //Linha por linha busca ingrediente com custo
            
            BLLPratos bll = new BLLPratos();
            DataTable tabelaIngredientes = bll.ListarIngredientes(txtCodigoPrato.Text);

            BLLMateriais bllaeb = new BLLMateriais();
            DataTable tabelaAeb;

            FichasTecnicas a = new FichasTecnicas();


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

                    custoUnit = a.CustoIngrediente(codIngrediente, Convert.ToInt32(cbUnidade.SelectedValue));
                    custoTotal = custoUnit * quant;


                    String[] V = new string[] { codIngrediente, nomeingrediente, quant.ToString("#,0.0000"), um, fc.ToString("#,0.0000"), custoUnit.ToString("#,0.00"), custoTotal.ToString("#,0.00") };
                    dgvFicha.Rows.Add(V);

                }
                RecalcularCusto();

            }


        }

        private void BtSalvar_Click(object sender, EventArgs e)
        {
            if (txtPeso.Text.Trim() == "")
            {
                txtPeso.Text = 0.00.ToString("#,0.0000");
            }

            if (txtRendimento.Text.Trim() == "")
            {
                txtPeso.Text = 0.00.ToString("#,0.00");
            }

            if (txtNome.Text.Trim() != "" && cbSetor.Text != "" && txtCodigoPrato.Text.Trim() != ".  .")
            {

                if (dgvFicha.Rows.Count > 0)
                {
                    Salvar();
                }
                else
                {
                    MessageBox.Show("Atenção! Insira pelo menos um ingrediente na ficha técnica para salvá-la.");

                }
            }
            else
            {
                MessageBox.Show("Atenção! Todos os campos com asterisco (*) são de preenchimento obrigatório.");
            }
        }

        private void Salvar()
        {
            DTOPratos dto = new DTOPratos();

            // Salvar dados da ficha

            //Verificar se o setor selecionado existe, se não, cadastrar e retornar o index
            BLLBuffet bllbuff = new BLLBuffet();
            if (cbSetor.Text.Trim() != "")
            {
                dto.IdSetor = bllbuff.CadastrarSeNaoExiste(cbSetor.Text);
            }
            //Verificar se a categoria selecionada existe, se não, cadastrar e retornar o index
            BLLCategoria bllcat = new BLLCategoria();
            if (cbCategoria.Text.Trim() != "")
            {
                dto.Cat = bllcat.CadastrarSeNaoExiste(cbCategoria.Text);
            }

            //Verificar se o sub categoria cadastrada existe, se não, cadastrar e retornar o index
            BLLSubCategoria bllscat = new BLLSubCategoria();
            if (cbSubCategoria.Text.Trim() != "")
            {
                dto.SubCat = bllscat.CadastrarSeNaoExiste(cbSubCategoria.Text);
            }

            FichasTecnicas fichas = new FichasTecnicas();

            BLLPratos bll = new BLLPratos();

            dto.CodPrato = txtCodigoPrato.Text;
            dto.NomePrato = txtNome.Text.Trim().ToUpper();
            dto.RendimentoPrato = Convert.ToDouble(txtRendimento.Text);
            dto.ModoPreparoPrato = txtPreparo.Text.Trim();
            dto.PesoPrato = Convert.ToDouble(txtPeso.Text);
            dto.IdUsuario = usuarioConectado.Id_usuario;
            dto.DescPrato = txtDescricao.Text.Trim().ToUpper();
            dto.Ativo = CbxAtivo.Checked ? 1 : 0;

            try
            {
                dto.IdPrato = Convert.ToInt32(txtId.Text);
            }
            catch
            {

            }

            //Dados de AEB

            DTOMateriais dtoaeb = new DTOMateriais();           
            
            dtoaeb.CodigoCigam = Convert.ToString(dto.CodPrato);
            dtoaeb.Descricao = dto.NomePrato;
            dtoaeb.Subgrupo_id_subgrupo = 27;
            dtoaeb.Um = "KG";
            dtoaeb.Fc = 0;           

            if (operacao == "inserir")
            {
                try
                {
                    bll.Incluir(dto);
                   
                    SalvarIngredientes();

                    fichas.IncluiFoto(txtCodigoPrato.Text, foto);

                    fichas.AtualizaCustosFicha(dto.CodPrato);

                    MessageBox.Show($"Ficha técnica {dto.CodPrato} - {dto.NomePrato} salva com sucesso.");

                    ZerarPagina();

                    operacao = "consultar";
                    AlteraBotoes();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Erro ao salvar a ficha.\n" + e.ToString());
                }
            }

            else if (operacao == "editar")
            {
                try
                {
                    bll.Alterar(dto);                    
                    SalvarIngredientes();

                    fichas.IncluiFoto(txtCodigoPrato.Text, foto);

                    fichas.AtualizaCustosFicha(dto.CodPrato);

                    MessageBox.Show($"Ficha técnica {dto.CodPrato} - {dto.NomePrato} alterada com sucesso.");

                    ZerarPagina();

                    operacao = "consultar";
                    AlteraBotoes();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Erro ao alterar a ficha.\n" + e.ToString());
                }
            }

            
        }

        private void SalvarIngredientes()
        {
            if (dgvFicha.Rows.Count > 0)
            {
                DTOIngredientes dto = new DTOIngredientes();

                BLLIngredientes bll = new BLLIngredientes();

                //Excluir ingredientes salvos no prato
                bll.ExcluirPorPrato(txtCodigoPrato.Text);

                for (int i = 0; i < dgvFicha.Rows.Count; i++)
                {
                    dto.CodItem = dgvFicha.Rows[i].Cells[0].Value.ToString();

                    dto.CodPrato = txtCodigoPrato.Text;

                    dto.QuantIngrediente = Convert.ToDouble(dgvFicha.Rows[i].Cells[2].Value);

                    bll.Incluir(dto);
                }
            }
        }

        private void BtCarregaFoto_Click(object sender, EventArgs e)
        {
            // Mostra uma caixa de diálogo para salvar a imagem

            OpenFileDialog saveFileDialog1 = new OpenFileDialog()
            {
                Filter = "JPeg Image|*.jpg",
                Title = "Salvar uma imagem."
            };
            saveFileDialog1.ShowDialog();

            foto = saveFileDialog1.FileName;
            if (foto != "")
            {
                pbFoto.Load(foto);


            }
            // If the file name is not an empty string open it for saving.
            BtDeletaFoto.Enabled = true;
        }

        private void BtDeletaFoto_Click(object sender, EventArgs e)
        {
            DTOCaminhos dto = new DTOCaminhos();
            pbFoto.Load(dto.Produtos + "0.jpg");
            foto = "del";

            BtDeletaFoto.Enabled = false;
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
                        txtFc.Text = dto.Fc.ToString();
                        txtUm.Text = dto.Um.ToString();
                        txtQuant.Enabled = true;
                        BtAddIngrediente.Enabled = true;

                        txtQuant.Focus();
                    }
                    catch
                    {
                        MessageBox.Show("Código inválido. Por favor selecione um código existente");
                        BtAddIngrediente.Enabled = false;
                    }
                }
                else
                {

                }

            }

        }
        
        private void BtAddIngrediente_Click(object sender, EventArgs e)
        {
            FichasTecnicas ft = new FichasTecnicas();

            if (ft.Redundancia(txtCodigoPrato.Text, txtCodItem.Text))
            {
                MessageBox.Show("Impossível adicinar este item. Geraria uma redundância.");
                txtNomeItem.Clear();
                txtUm.Clear();
                txtFc.Clear();
                txtQuant.Clear();
                txtCodItem.Clear();
                txtCodItem.Focus();
                txtCodItem.Select();
            }
            else
            {
                if (txtCodigoPrato.Text.Trim() == ".  .")
                {
                    MessageBox.Show("Antes de acrescentar o ingrediente, determine um nome para o prato.");
                    txtNome.Focus();
                    txtNome.Select();
                }
                else
                {
                    AddIngrediente();
                }
            }
        }

        #region Voids

        private void AddIngrediente()
        {

            double custoUnit = 0;
            double custoTotal = 0;

            BLLIngredientes bll = new BLLIngredientes();

            FichasTecnicas fc = new FichasTecnicas();

            custoUnit = fc.CustoIngrediente(txtCodItem.Text, Convert.ToInt32(cbUnidade.SelectedValue));

            custoTotal = custoUnit * Convert.ToDouble(txtQuant.Text);

            String[] V = new string[] { txtCodItem.Text, txtNomeItem.Text, txtQuant.Text, txtUm.Text, txtFc.Text, custoUnit.ToString("#,0.00"), custoTotal.ToString("#,0.00") };
            dgvFicha.Rows.Add(V);

            RecalcularCusto();
            txtCodItem.Clear();
            txtNomeItem.Clear();
            txtQuant.Clear();
            txtUm.Clear();
            txtFc.Clear();
            txtCodItem.Focus();
            BtAddIngrediente.Enabled = false;
            txtQuant.Enabled = false;

        }

        private void RecalcularCusto()
        {
            double total = 0;
            double peso = 0;
            double porcao = 0;
            int atendePax = 0;

            if (dgvFicha.Rows.Count > 0)
            {
                for (int i = 0; i < dgvFicha.Rows.Count; i++)
                {
                    total += Convert.ToDouble(dgvFicha.Rows[i].Cells[6].Value);
                }
            }
            if (txtPeso.Text.Trim() != "")
            {
                peso = Convert.ToDouble(txtPeso.Text);

            }
            if (txtRendimento.Text.Trim() != "")
            {
                porcao = Convert.ToDouble(txtRendimento.Text);
            }
            if (TxtAtendePax.Text.Trim() != "")
            {
                atendePax = Convert.ToInt32(TxtAtendePax.Text);
            }


            if (peso > 0)
            {
                lbCustoKg2.Text = (total / peso).ToString("#,0.00");
            }
            else
            {
                lbCustoKg2.Text = 0.ToString("#,0.00");
            }

            if (porcao > 0)
            {
                lbCustoPorcao2.Text = (total / porcao).ToString("#,0.00");
            }
            else
            {
                lbCustoPorcao2.Text = 0.ToString("#,0.00");
            }

            if (atendePax > 0)
            {
                LbCustoPax.Text = (total / atendePax).ToString("#,0.00");
            }
            else
            {
                LbCustoPax.Text = 0.ToString("#,0.00");
            }

            lbCustoTotal2.Text = total.ToString("#,0.00");           

        }

        private string CodigoNovo()
        {
            
            BLLPratos bllCod = new BLLPratos();

            DataTable tabela = bllCod.ListarCodigos();

            string codigo = "";
            string prefixo = "20.01.";

            for (int i = 0; i < tabela.Rows.Count + 1; i++)
            {

                try
                {
                    codigo = prefixo + (i + 1).ToString("0000");
                    string CodigoProdutoE = tabela.Rows[i][0].ToString();

                    if (codigo != CodigoProdutoE)
                    {
                        i = tabela.Rows.Count + 1;
                    }
                }
                catch
                {

                    i = tabela.Rows.Count + 1;
                }

            }

            return codigo;
        }

        #endregion
        
        #region Enter/Leave/Validating

        private void TxtNome_Leave(object sender, EventArgs e)
        {
            if (txtNome.Text.Trim() != "")
            {
                
                BLLPratos bll = new BLLPratos();

                DataTable tabela = bll.LocalizarNome(txtNome.Text.Trim());

                if (tabela.Rows.Count == 0)
                {

                    txtNome.Text = txtNome.Text.Trim().ToUpper();
                    if (txtCodigoPrato.Text.Trim() == ".  .")
                    {
                        txtCodigoPrato.Text = CodigoNovo();

                    }
                }
                else
                {
                    if (liberado && tabela.Rows[0][0].ToString() != txtCodigoPrato.Text)
                    {
                        MessageBox.Show($"Já existe um prato chamado {txtNome.Text}.");
                        txtNome.Focus();
                        txtNome.Select();
                    }
                    else
                    {

                    }
                }

            }
            else
            {
            }


        }

        private void TxtCodItem_Leave(object sender, EventArgs e)
        {

            if (txtCodItem.Text.Trim() != ".  .")
            {

                try
                {
                   
                    BLLMateriais bll = new BLLMateriais();

                    DTOMateriais modelo = bll.CarregaModeloMateriais(txtCodItem.Text);

                    txtCodItem.Text = modelo.CodigoCigam.ToString();
                    txtNomeItem.Text = modelo.Descricao.ToString();
                    txtFc.Text = modelo.Fc.ToString();
                    txtUm.Text = modelo.Um.ToString();

                    BtAddIngrediente.Enabled = true;
                    txtQuant.Enabled = true;

                    txtQuant.Focus();
                }
                catch
                {
                    MessageBox.Show("Código inválido. Por favor selecione um código existente");
                    BtAddIngrediente.Enabled = false;
                    txtQuant.Enabled = false;
                }
            }

        }

        private void TxtCodItem_Enter(object sender, EventArgs e)
        {
            if (txtNome.Text.Trim() == "" && liberado)
            {
                MessageBox.Show("Antes de escolher o ingrediente defina um nome para a ficha técnica!", "IMPORTANTE");
                txtNome.Focus();
                txtNome.Select();
            }
        }

        private void TxtRendimento_Validating(object sender, CancelEventArgs e)
        {
            if (txtRendimento.Text == "")
            {
                txtRendimento.Text = "0,00";
                RecalcularCusto();
            }
            string txt = txtRendimento.Text;

            if (Double.TryParse(txt, out double doubleValue))
            {
                txtRendimento.Text = doubleValue.ToString("#,0.00");
                RecalcularCusto();
            }

            else if (txtRendimento.Text == "")
            {
            }
            else
            {
                e.Cancel = true;
                MessageBox.Show("Digite um valor numérico com até duas casas decimais.");
            }
        }

        private void TxtAtendePax_Validating(object sender, CancelEventArgs e)
        {
            if (TxtAtendePax.Text == "")
            {
                TxtAtendePax.Text = "0,00";
                RecalcularCusto();
            }
            string txt = TxtAtendePax.Text;

            if (Int32.TryParse(txt, out Int32 intValue))
            {
                TxtAtendePax.Text = intValue.ToString("0");
                RecalcularCusto();
            }

            else if (TxtAtendePax.Text == "")
            {
            }
            else
            {
                e.Cancel = true;
                MessageBox.Show("Digite um valor numérico inteiro.");
            }
        }

        private void TxtPeso_Validating(object sender, CancelEventArgs e)
        {
            if (txtRendimento.Text == "")
            {
                txtRendimento.Text = "0,0000";
                RecalcularCusto();
            }
            string txt = txtPeso.Text;

            if (Double.TryParse(txt, out double doubleValue))
            {
                txtPeso.Text = doubleValue.ToString("#,0.0000");
                RecalcularCusto();
            }

            else if (txtPeso.Text == "")
            {
            }
            else
            {
                e.Cancel = true;
                MessageBox.Show("Digite um valor numérico com até quatro casas decimais.");
            }
        }

        #endregion

        private void DgvFicha_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7 && operacao != "consultar")
            {
                if (e.RowIndex >= 0)
                {

                    txtCodItem.Text = Convert.ToString(dgvFicha.Rows[e.RowIndex].Cells[0].Value);
                    txtQuant.Text = Convert.ToDouble(dgvFicha.Rows[e.RowIndex].Cells[2].Value).ToString("#,0.0000");
                    txtNomeItem.Text = Convert.ToString(dgvFicha.Rows[e.RowIndex].Cells[1].Value);
                    txtUm.Text = Convert.ToString(dgvFicha.Rows[e.RowIndex].Cells[3].Value);
                    txtFc.Text = Convert.ToString(dgvFicha.Rows[e.RowIndex].Cells[4].Value);
                    txtQuant.Enabled = true;
                    BtAddIngrediente.Enabled = true;

                    dgvFicha.Rows.RemoveAt(e.RowIndex);

                    RecalcularCusto();

                    txtCodItem.Focus();

                }
            }
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("ATENÇÃO! Ao cancelar esta operação os dados não salvos serão perdidos. Continuar?", "Aviso", MessageBoxButtons.YesNo);
            if (d.ToString() == "Yes")
            {
                operacao = "inicial";
                ZerarPagina();
                liberado = true;
                if (herdado)
                {
                    this.Close();
                }

            }
        }

        private void BtEditar_Click(object sender, EventArgs e)
        {
            operacao = "editar";
            AlteraBotoes();
        }

        private void BtExcluir_Click(object sender, EventArgs e)
        {
            DialogResult DR = MessageBox.Show("Deseja realmente excluir esta ficha técnica?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DR == DialogResult.Yes)
            {

                string codigo = txtCodigoPrato.Text;
                ZerarPagina();
                FichasTecnicas FT = new FichasTecnicas();
                FT.ExcluirPrato(codigo);
            }
        }

        private void DgvFicha_SelectionChanged(object sender, EventArgs e)
        {
            dgvFicha.ClearSelection();

        }
    }
}
