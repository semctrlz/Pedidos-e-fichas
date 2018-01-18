using GerenciadorEstoque.Code;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorEstoque.Forms.Produtos
{
    public partial class FrmCadastraProdutosEmLote : Form
    {
        DTOUsuarios usuarioLogado = new DTOUsuarios();

        private enum StatusJanela { inicial, dados, formatado };

        StatusJanela Status = StatusJanela.inicial;

        SortedList Format;

        public FrmCadastraProdutosEmLote(DTOUsuarios u)
        {
            usuarioLogado = u;
            InitializeComponent();
        }

        private void FrmCadastraProdutosEmLote_Load(object sender, EventArgs e)
        {

        }

        private void AtualizaWindowState()
        {
            BtFormatarParaAjuste.Enabled = false;
            BtSalvar.Enabled = false;
            CbCodCigam.Enabled = false;
            CbNome.Enabled = false;            
            CbxIgnorarErros.Enabled = false;
            DgvDados.Enabled = false;
            
            if (Status == StatusJanela.inicial)
            {
                
            }
            else if (Status == StatusJanela.dados)
            {
                BtFormatarParaAjuste.Enabled = true;
                CbCodCigam.Enabled = true;
                CbNome.Enabled = true;
                
            }
            else
            {
                BtSalvar.Enabled = true;                
                CbxIgnorarErros.Enabled = true;
                DgvDados.Enabled = true;
            }
        }

        private void BtnColar_Click(object sender, EventArgs e)
        {
            AtualizaDGVBase();
            Status = StatusJanela.dados;
            AtualizaWindowState();
        }

        private void AtualizaDGVBase()
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

                var DSCodigoCigam = new List<Language>();
                var DSNome = new List<Language>();
                
                for (int i = 0; i < DgvDados.Columns.Count; i++)
                {
                    DSCodigoCigam.Add(new Language() { Nome = DgvDados.Columns[i].HeaderText, Valor = i.ToString() });
                }

                for (int i = 0; i < DgvDados.Columns.Count; i++)
                {
                    DSNome.Add(new Language() { Nome = DgvDados.Columns[i].HeaderText, Valor = i.ToString() });
                }
                

                //Adicionar ao ComboBox
                this.CbCodCigam.DataSource = DSCodigoCigam;
                this.CbCodCigam.DisplayMember = "Nome";
                this.CbCodCigam.ValueMember = "Valor";
                try
                {
                    this.CbCodCigam.SelectedIndex = Properties.Settings.Default.ItensLoteCbCodigoCigam;
                }
                catch
                {
                    this.CbCodCigam.SelectedIndex = 0;
                }
                //Adicionar ao ComboBox
                this.CbNome.DataSource = DSNome;
                this.CbNome.DisplayMember = "Nome";
                this.CbNome.ValueMember = "Valor";
                try
                {
                    this.CbNome.SelectedIndex = Properties.Settings.Default.itensLoteCbNome;
                }
                catch
                {
                    this.CbNome.SelectedIndex = 0;
                }                

            }
        }

        private void BtFormatarParaAjuste_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.itensLoteCbNome = CbNome.SelectedIndex;
            Properties.Settings.Default.ItensLoteCbCodigoCigam = CbCodCigam.SelectedIndex;
            Properties.Settings.Default.Save();

            SortedList Base = new SortedList();
            SortedList Incluir = new SortedList();
            SortedList Alterar = new SortedList();

            //Loop que formata e salva em uma array os códigos e nomes.
            if (DgvDados.Rows.Count > 0)
            {
                string CodTemp = "";
                BLLMateriais bll = new BLLMateriais();                
                
                

                for(int i = 0; i < DgvDados.Rows.Count; i++)
                {
                    CodTemp = Convert.ToInt32(DgvDados.Rows[i].Cells[0].Value).ToString(@"00\.00\.0000");

                    if (Convert.ToString(DgvDados.Rows[i].Cells[1].Value) != "")
                    {
                        if (bll.ExisteCodigo(CodTemp))
                        {
                            if (bll.NomePeloCodigo(CodTemp) != Convert.ToString(DgvDados.Rows[i].Cells[1].Value))
                            {
                                Alterar.Add(CodTemp, Convert.ToString(DgvDados.Rows[i].Cells[1].Value));
                            }
                        }
                        else
                        {
                            Incluir.Add(CodTemp, Convert.ToString(DgvDados.Rows[i].Cells[1].Value));
                        }
                    }
                }
            }

            Format = Incluir;
            ColaDadosFormatados();
            //Loop que verifica se existem os códigos inseridos.
                //Se existirem, verifica se o nome é diferente do que está na tabela, se for coloca em uma array chamada alterar.

                //Se não existir coloca os códigos em uma array chamada inserir.

            //Roda a array alterar fazendo as alterações necessárias.
            //Coloca a array inserir no DataGridView para o usuário preencher os campos de UM e FC.
            
        }
        

        private void ColaDadosFormatados()
        {
            DgvDados.Rows.Clear();
            DgvDados.Columns.Clear();

            DgvDados.ColumnCount = 3;
            DgvDados.Columns[0].Name = "COD";
            DgvDados.Columns[1].Name = "NOME";
            DgvDados.Columns[2].Name = "FC";

            BLLUnidadeMedida bllum = new BLLUnidadeMedida();
            DataTable um = bllum.Listar();

            DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
            cmb.HeaderText = "UM";
            cmb.Name = "um";
          
            cmb.Items.Add("CX");
            cmb.Items.Add("UN");
            cmb.Items.Add("L");
            cmb.Items.Add("LT");
            cmb.Items.Add("DZ");
            cmb.Items.Add("BDJ");
            cmb.Items.Add("BD");
            
            DgvDados.Columns.Add(cmb);
            
            DgvDados.Columns[0].Width = 80;
            DgvDados.Columns[1].Width = 250;
            DgvDados.Columns[2].Width = 60;
            DgvDados.Columns[3].Width = 90;


            for (int i = 0; i< Format.Count; i++)
            {
                string[] V = new string[] {Format.GetKey(i).ToString(), Format.GetByIndex(i).ToString(), "","" };
                DgvDados.Rows.Add(V);
            }
              
            Status = StatusJanela.formatado;
            AtualizaWindowState();


        }

        private void BtSalvar_Click(object sender, EventArgs e)
        {

            DTOMateriais dto = new DTOMateriais();
            BLLMateriais bll = new BLLMateriais();
            if(DgvDados.Rows.Count > 0)
            {
                for (int i = 0; i < DgvDados.Rows.Count; i++)
                {
                    try
                    {
                        dto.CodigoCigam = (string)DgvDados.Rows[i].Cells[0].Value;
                        dto.Descricao = (string)DgvDados.Rows[i].Cells[1].Value;
                        dto.Fc = 0;
                        dto.Um = "KG";
                        dto.Subgrupo_id_subgrupo = Convert.ToInt32(dto.CodigoCigam.Substring(3, 2));

                        if ((string)DgvDados.Rows[i].Cells[2].Value != "")
                        {
                            dto.Fc = Convert.ToInt32(DgvDados.Rows[i].Cells[2].Value);
                        }
                        if ((string)DgvDados.Rows[i].Cells[3].Value != "")
                        {
                            dto.Um = Convert.ToString(DgvDados.Rows[i].Cells[3].Value);
                        }

                        bll.Incluir(dto, "");
                    }
                    catch
                    {
                        if (!CbxIgnorarErros.Checked)
                        {
                            MessageBox.Show("Erro ao salvar. O processo será interrompido!");
                            break;
                        }
                    }
                }
                    
                DgvDados.Rows.Clear();
                DgvDados.Columns.Clear();
                MessageBox.Show("Materiais incluídos com sucesso!");
                Status = StatusJanela.inicial;
                AtualizaWindowState();


            }
            
        }
    }
}
