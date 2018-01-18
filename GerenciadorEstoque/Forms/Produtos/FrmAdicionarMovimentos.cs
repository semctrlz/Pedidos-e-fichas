using GerenciadorEstoque.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;

namespace GerenciadorEstoque.Forms.Empresas
{
    public partial class FrmAdicionarMovimentos : Form
    {
        DTOUsuarios usuarioLogado;
        string estado = "inicial";        

        public object AdicionaAoBanco { get; private set; }

        public FrmAdicionarMovimentos(DTOUsuarios dto)
        {
            InitializeComponent();
            usuarioLogado = dto;
        }

        private void FrmAdicionarMovimentos_Load(object sender, EventArgs e)
        {           
            AtualizaUnidades();
            estado = "inicial";
            AlteraEstado();
        }

        private void BtColarDados_Click(object sender, EventArgs e)
        {
            estado = "adicionar";
            AtualizaDGV();
            AlteraEstado();

        }

        private void AtualizaDGV()
        {
            //Rotina para colar dados da área de transferência oriundos do Excel para o DataGridView
            ColarDoExcel();

            //Verifica se há configuração salva para os combo box
            //Carrega os Combobox de acordo com as colunas recém coladas
            AtualizaCb();
                    //Caso não haja pré configuração Combo box e checkbox, abre as configurações padrão.
                    //Caso haja carrega os nomes das colunas com os index salvos e se o checkbox está marcado ou não

        }

        private void ColarDoExcel()
        {

            #region colar dados do excel

            DataObject o = (DataObject)Clipboard.GetDataObject();

            if (o.GetDataPresent(DataFormats.Text))
            {
                if (DgvDados.RowCount > 0)
                    DgvDados.Rows.Clear();

                if (DgvDados.ColumnCount > 0)
                    DgvDados.Columns.Clear();

                bool columnsAdded = false;
                string[] pastedRows = Regex.Split(o.GetData(DataFormats.Text).ToString().TrimEnd("\r\n".ToCharArray()), "\r\n");
                foreach (string pastedRow in pastedRows)
                {
                    string[] pastedRowCells = pastedRow.Split(new char[] { '\t' });

                    if (!columnsAdded)
                    {
                        for (int i = 0; i < pastedRowCells.Length; i++)
                            DgvDados.Columns.Add("col" + i, pastedRowCells[i]);

                        columnsAdded = true;
                        continue;
                    }

                    DgvDados.Rows.Add();
                    int myRowIndex = DgvDados.Rows.Count - 1;
                    using (DataGridViewRow myDataGridViewRow = DgvDados.Rows[myRowIndex])
                    {
                        for (int i = 0; i < pastedRowCells.Length; i++)
                            myDataGridViewRow.Cells[i].Value = pastedRowCells[i].Trim();
                    }
                }
            }

            #endregion
        }

        public class Language
        {
            public string Nome { get; set; }
            public string Valor { get; set; }

            public string NUnidade { get; set; }
            public string VUnidade { get; set; }
        }
     
        private void AtualizaCb()
        {
            if (DgvDados.Rows.Count > 0)
            {
                DateTime data = DateTime.Today;
                int mesAtual = data.Month;

                var DSDataMov = new List<Language>();
                var DSTipoMov = new List<Language>();
                var DSTipoOp = new List<Language>();
                var DSCodItem = new List<Language>();
                var DSContaGer = new List<Language>();
                var DSNumeroMov = new List<Language>();
                var DSQuant = new List<Language>();
                var DSValorUnit = new List<Language>();
                var DSTipoDoc = new List<Language>();
                var DSDocumento = new List<Language>();
               
                for (int i = 0; i < DgvDados.Columns.Count; i++)
                {
                    DSDataMov.Add(new Language() { Nome = DgvDados.Columns[i].HeaderText, Valor = i.ToString() });
                }

                for (int i = 0; i < DgvDados.Columns.Count; i++)
                {
                    DSTipoMov.Add(new Language() { Nome = DgvDados.Columns[i].HeaderText, Valor = i.ToString() });
                }

                for (int i = 0; i < DgvDados.Columns.Count; i++)
                {
                    DSTipoOp.Add(new Language() { Nome = DgvDados.Columns[i].HeaderText, Valor = i.ToString() });
                }

                for (int i = 0; i < DgvDados.Columns.Count; i++)
                {
                    DSCodItem.Add(new Language() { Nome = DgvDados.Columns[i].HeaderText, Valor = i.ToString() });
                }

                for (int i = 0; i < DgvDados.Columns.Count; i++)
                {
                    DSContaGer.Add(new Language() { Nome = DgvDados.Columns[i].HeaderText, Valor = i.ToString() });
                }

                for (int i = 0; i < DgvDados.Columns.Count; i++)
                {
                    DSNumeroMov.Add(new Language() { Nome = DgvDados.Columns[i].HeaderText, Valor = i.ToString() });
                }

                for (int i = 0; i < DgvDados.Columns.Count; i++)
                {
                    DSQuant.Add(new Language() { Nome = DgvDados.Columns[i].HeaderText, Valor = i.ToString() });
                }

                for (int i = 0; i < DgvDados.Columns.Count; i++)
                {
                    DSValorUnit.Add(new Language() { Nome = DgvDados.Columns[i].HeaderText, Valor = i.ToString() });
                }

                for (int i = 0; i < DgvDados.Columns.Count; i++)
                {
                    DSTipoDoc.Add(new Language() { Nome = DgvDados.Columns[i].HeaderText, Valor = i.ToString() });
                }

                for (int i = 0; i < DgvDados.Columns.Count; i++)
                {
                    DSDocumento.Add(new Language() { Nome = DgvDados.Columns[i].HeaderText, Valor = i.ToString() });
                }             
                
                for (int i = 0; i < DgvDados.Columns.Count; i++)
                {
                    DSDataMov.Add(new Language() { Nome = DgvDados.Columns[i].HeaderText, Valor = i.ToString() });
                }

                //Adicionar ao ComboBox
                this.CbDataMov.DataSource = DSDataMov;
                this.CbDataMov.DisplayMember = "Nome";
                this.CbDataMov.ValueMember = "Valor";
                try
                {
                    this.CbDataMov.SelectedIndex = Properties.Settings.Default.CbDataMov;
                }
                catch
                {
                    this.CbDataMov.SelectedIndex = 0;
                }
                //Adicionar ao ComboBox
                this.CbTipoMov.DataSource = DSTipoMov;
                this.CbTipoMov.DisplayMember = "Nome";
                this.CbTipoMov.ValueMember = "Valor";
                try
                {
                    this.CbTipoMov.SelectedIndex = Properties.Settings.Default.CbTipoMov;
                }
                catch
                {
                    this.CbTipoMov.SelectedIndex = 0;
                }

                //Adicionar ao ComboBox
                this.CbTipoOp.DataSource = DSTipoOp;
                this.CbTipoOp.DisplayMember = "Nome";
                this.CbTipoOp.ValueMember = "Valor";
                try
                {
                    this.CbTipoOp.SelectedIndex = Properties.Settings.Default.CbTipoOp;
                }
                catch
                {
                    this.CbTipoOp.SelectedIndex = 0;
                }

                //Adicionar ao ComboBox
                this.CbCodItem.DataSource = DSCodItem;
                this.CbCodItem.DisplayMember = "Nome";
                this.CbCodItem.ValueMember = "Valor";
                try
                {
                    this.CbCodItem.SelectedIndex = Properties.Settings.Default.CbCodItem;
                }
                catch
                {
                    this.CbCodItem.SelectedIndex = 0;
                }

                //Adicionar ao ComboBox
                this.CbContaGer.DataSource = DSContaGer;
                this.CbContaGer.DisplayMember = "Nome";
                this.CbContaGer.ValueMember = "Valor";
                try
                {
                    this.CbContaGer.SelectedIndex = Properties.Settings.Default.CbContaGer;
                }
                catch
                {
                    this.CbContaGer.SelectedIndex = 0;
                }

                //Adicionar ao ComboBox
                this.CbNumeroMov.DataSource = DSNumeroMov;
                this.CbNumeroMov.DisplayMember = "Nome";
                this.CbNumeroMov.ValueMember = "Valor";
                try
                {
                    this.CbNumeroMov.SelectedIndex = Properties.Settings.Default.CbNumeroMov;
                }
                catch
                {
                    this.CbNumeroMov.SelectedIndex = 0;
                }

                //Adicionar ao ComboBox
                this.CbQuantidade.DataSource = DSQuant;
                this.CbQuantidade.DisplayMember = "Nome";
                this.CbQuantidade.ValueMember = "Valor";
                try
                {
                    this.CbQuantidade.SelectedIndex = Properties.Settings.Default.CbQuant;
                }
                catch
                {
                    this.CbQuantidade.SelectedIndex = 0;
                }

                //Adicionar ao ComboBox
                this.CbValorUnit.DataSource = DSValorUnit;
                this.CbValorUnit.DisplayMember = "Nome";
                this.CbValorUnit.ValueMember = "Valor";
                try
                {
                    this.CbValorUnit.SelectedIndex = Properties.Settings.Default.CbValorUnit;
                }
                catch
                {
                    this.CbValorUnit.SelectedIndex = 0;
                }

                //Adicionar ao ComboBox
                this.CbTipoDocumento.DataSource = DSTipoDoc;
                this.CbTipoDocumento.DisplayMember = "Nome";
                this.CbTipoDocumento.ValueMember = "Valor";
                try
                {
                    this.CbTipoDocumento.SelectedIndex = Properties.Settings.Default.CbTipoDoc;
                }
                catch
                {
                    this.CbTipoDocumento.SelectedIndex = 0;
                }

                //Adicionar ao ComboBox
                this.CbDocumento.DataSource = DSDocumento;
                this.CbDocumento.DisplayMember = "Nome";
                this.CbDocumento.ValueMember = "Valor";
                try
                {
                    this.CbDocumento.SelectedIndex = Properties.Settings.Default.CbDocumento;
                }
                catch
                {
                    this.CbDocumento.SelectedIndex = 0;
                }

                CbxIgnorarErros.Checked = Properties.Settings.Default.CbxIgnorarErros;
                CbxDivideQuant.Checked = Properties.Settings.Default.CbxDividePelaQuantidade;
                CbxInverterSinal.Checked = Properties.Settings.Default.CbxInverterSinal;
            }
        }

        private void AtualizaUnidades()
        {
            var DSUnidade = new List<Language>();

            BLLUnidade bll = new BLLUnidade();
            DataTable TabelaUnidade = bll.Localizar();

            for (int i = 0; i < TabelaUnidade.Rows.Count; i++)
            {
                DSUnidade.Add(new Language() { NUnidade = TabelaUnidade.Rows[i][7].ToString(), VUnidade = TabelaUnidade.Rows[i][0].ToString() });
            }

            DTOUnidade dtoun = new DTOUnidade();
            BLLUnidade bllun = new BLLUnidade();
            dtoun = bllun.CarregaModelo(usuarioLogado.IdUnidade);

            //Adicionar ao ComboBox
            this.CbUnidade.DataSource = DSUnidade;
            this.CbUnidade.DisplayMember = "NUnidade";
            this.CbUnidade.ValueMember = "VUnidade";
            try
            {
                this.CbUnidade.Text = dtoun.NomeReduzido;
            }
            catch
            {
                this.CbUnidade.SelectedIndex = 0;
            }


        }

        private void SalvaConfigs()
        {
            Properties.Settings.Default.CbCodItem = CbCodItem.SelectedIndex;
            Properties.Settings.Default.CbContaGer = CbContaGer.SelectedIndex;
            Properties.Settings.Default.CbDataMov = CbDataMov.SelectedIndex;
            Properties.Settings.Default.CbDocumento = CbDocumento.SelectedIndex;
            Properties.Settings.Default.CbNumeroMov = CbNumeroMov.SelectedIndex;
            Properties.Settings.Default.CbQuant = CbQuantidade.SelectedIndex;
            Properties.Settings.Default.CbTipoDoc = CbTipoDocumento.SelectedIndex;
            Properties.Settings.Default.CbTipoMov = CbTipoMov.SelectedIndex;
            Properties.Settings.Default.CbTipoOp = CbTipoOp.SelectedIndex;
            Properties.Settings.Default.CbValorUnit = CbValorUnit.SelectedIndex;
            Properties.Settings.Default.CbxDividePelaQuantidade = CbxDivideQuant.Checked;
            Properties.Settings.Default.CbxIgnorarErros = CbxIgnorarErros.Checked;
            Properties.Settings.Default.CbxInverterSinal = CbxInverterSinal.Checked;

            Properties.Settings.Default.Save();
        }

        private void AlteraEstado()
        {
            if(estado == "inicial")
            {
                gbColunas.Enabled = false;
                BtAdicionarDB.Enabled = false;
            }
            else
            {
                gbColunas.Enabled = true;
                BtAdicionarDB.Enabled = true;
            }
        }                
        
        private void BtAdicionarDB_Click(object sender, EventArgs e)
        {
           IncluirCusto();            
        }

        private void IncluirCusto()
        {
            SalvaConfigs();

            int totalItens = DgvDados.Rows.Count;

            PnAguardar.Visible = true;            

            DateTime dataTemp = DateTime.MinValue;

            //Salva configurações das escolhas de campos
            SalvaConfigs();

            DTOCusto dto = new DTOCusto();
            BLLCusto bll = new BLLCusto();
            BLLMateriais bllM = new BLLMateriais();

            int Sucesso = 0;
            //Faz o looping para adicionar os itens da tabela no DB
            for (int i = 0; i < DgvDados.Rows.Count; i++)
            {
                try
                {
                    //1º Verifica se a data da primeira linha já existe no banco de dados para a aunidade atual
                    if (dataTemp != Convert.ToDateTime(DgvDados.Rows[i].Cells[Properties.Settings.Default.CbDataMov].Value.ToString()))
                    {
                        //Caso sim, exlui todos os lançamentos com a mesma data e unidade
                        dataTemp = Convert.ToDateTime(DgvDados.Rows[i].Cells[Properties.Settings.Default.CbDataMov].Value.ToString());
                        int unidade = Convert.ToInt32(CbUnidade.SelectedValue);
                        bll.ExcluirCusto(dataTemp, Convert.ToInt32(CbUnidade.SelectedValue));
                    }

                    dto.DataCusto = Convert.ToDateTime(DgvDados.Rows[i].Cells[Properties.Settings.Default.CbDataMov].Value.ToString());
                    dto.TipoMovCusto = DgvDados.Rows[i].Cells[Properties.Settings.Default.CbTipoMov].Value.ToString();
                    dto.TipoOperacaoCusto = DgvDados.Rows[i].Cells[Properties.Settings.Default.CbTipoOp].Value.ToString().Replace(",", ".");

                    //2º Na coluna do Cod item, utilizar os 10 primeiros caracteres (deixando os pontos).
                    dto.CodItemCusto = DgvDados.Rows[i].Cells[Properties.Settings.Default.CbCodItem].Value.ToString();
                    dto.CodItemCusto = dto.CodItemCusto.Trim().Substring(0, 10);

                    dto.ContaGerencialCusto = DgvDados.Rows[i].Cells[Properties.Settings.Default.CbContaGer].Value.ToString().Substring(0, 10);
                    dto.MovimentoCusto = Convert.ToInt32(DgvDados.Rows[i].Cells[Properties.Settings.Default.CbNumeroMov].Value.ToString());
                    dto.QuantMovCusto = Convert.ToDouble(DgvDados.Rows[i].Cells[Properties.Settings.Default.CbQuant].Value.ToString());
                    dto.ValorUnitarioCusto = Convert.ToDouble(DgvDados.Rows[i].Cells[Properties.Settings.Default.CbValorUnit].Value.ToString());

                    if (Properties.Settings.Default.CbxDividePelaQuantidade)
                    {
                        dto.ValorUnitarioCusto /= dto.QuantMovCusto;
                    }

                    if (Properties.Settings.Default.CbxInverterSinal)
                    {
                        dto.ValorUnitarioCusto *= -1;
                    }

                    dto.TipoDocCusto = DgvDados.Rows[i].Cells[Properties.Settings.Default.CbTipoDoc].Value.ToString();
                    dto.DocumentoCusto = DgvDados.Rows[i].Cells[Properties.Settings.Default.CbDocumento].Value.ToString();
                    dto.IdUsuario = usuarioLogado.Id_usuario;
                    dto.IdUnidade = Convert.ToInt32(CbUnidade.SelectedValue);
                    dto.Grupo = dto.CodItemCusto.Substring(3, 2);

                    if (dto.TipoMovCusto.Substring(0, 1).ToUpper() == "S" && dto.ContaGerencialCusto != "")
                    {

                        bllM.DeletarValorExternoPorCod(dto.CodItemCusto);

                        bll.IncluirCusto(dto);
                        PbMovimentos.Value = Convert.ToInt32(((Convert.ToDouble(i + 1) / Convert.ToDouble(totalItens)) * 100));
                        LbMovimento.Text = dto.MovimentoCusto.ToString();
                        Application.DoEvents();
                        Sucesso++;
                    }

                }
                catch (Exception ex)
                {

                    if (!CbxIgnorarErros.Checked)
                    {
                        DialogResult dr = MessageBox.Show($"Erro ao inserir dados! Deseja continuar?\nDetalhes: {ex.ToString()}", "Erro!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                        if (dr == DialogResult.No)
                        {
                            break;
                        }
                    }

                }

            }

            FichasTecnicas ft = new FichasTecnicas();
            ft.AtualizaTodosOsCustos();

            PbMovimentos.Value = 0;
            LbMovimento.Text = "";
            PnAguardar.Visible = false;

            MessageBox.Show($"{Sucesso.ToString()} movimentos incluídos com sucesso!", "Aviso");

            LimparTela();


        }

        private void LimparTela()
        {
            DgvDados.Rows.Clear();
            DgvDados.Columns.Clear();
            AtualizaCb();
        }

        private void BtAtualiza_Click(object sender, EventArgs e)
        {
            FichasTecnicas Ft = new FichasTecnicas();
            Ft.AtualizaTodosOsCustos();
            MessageBox.Show("Custos atualizados!", "Aviso");
        }

    }
}
