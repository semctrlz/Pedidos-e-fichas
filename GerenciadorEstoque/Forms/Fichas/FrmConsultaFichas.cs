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

namespace GerenciadorEstoque.Forms.Fichas
{
    public partial class FrmConsultaFichas : Form
    {
        DTOUsuarios usuarioConectado = new DTOUsuarios();
        public string codFicha = "";
        bool liberado = false;
        bool herdada = false;
        
        public FrmConsultaFichas(DTOUsuarios u, bool h)
        {
            InitializeComponent();
            usuarioConectado = u;
            herdada = h;
        }

        private void FrmConsultaFichas_Load(object sender, EventArgs e)
        {
            CarregaUnidade();
            CarregaCat();
            CarregaDgv();
            liberado = true;
        }

        private void CarregaUnidade()
        {
            BLLUnidade bllun = new BLLUnidade();

            cbUnidade.DataSource = bllun.Localizar();
            cbUnidade.DisplayMember = "nomeReduzido";
            cbUnidade.ValueMember = "id_unidade";
            cbUnidade.Text = "nomeReduzido";

            BLLPermissoes bllperm = new BLLPermissoes();
            if (bllperm.PermissaoPorLocal(Diversos.LocaisPermissoes.Fichas, usuarioConectado) >= 2)
            {
                cbUnidade.Enabled = true;
            }
            else
            {
                cbUnidade.Enabled = false;
            }
        }

        private void CarregaDgv()
        {
            string ativo = " ativo = 1 and ";

            if (CbxInativo.Checked)
            {
                ativo = "";
            }

            string busca = $"select p.cod_prato, p.nome_prato,  b.nome_buffet, c.nome_cat, s.nome_scat, " +
                            "p.peso_prato, p.rendimento_prato, Round((cp.valorTotal / nullif(p.rendimento_prato, 0)), 2) as custoPorcao, " +
                            "Round((cp.valorTotal / nullif(p.peso_prato, 0)), 2) as custoKg, Round(cp.valorTotal, 2) as CustoTotal, ativo from prato p " +
                            $"left join custosPratos cp on cp.codigocigam = p.cod_prato and cp.id_unidade = {Convert.ToInt32(cbUnidade.SelectedValue)} " +
                            "left join buffet b on p.id_setor = b.id_buffet " +
                            "left join categoria c on p.cat = c.id_cat " +
                            $"left join subcategoria s on p.subcat = s.id_scat where {ativo} nome_prato like '%{txtNome.Text}%'";

            if (cbSetor.Text != "")
            {
                busca += $" and id_setor = {Convert.ToInt32(cbSetor.SelectedValue)}";
            }

            if (cbCategoria.Text != "")
            {
                busca += $" and cat = {Convert.ToInt32(cbCategoria.SelectedValue)}";
            }

            if (cbSubCategoria.Text != "")
            {
                busca += $" and subcat = {Convert.ToInt32(cbSubCategoria.SelectedValue)}";
            }

            busca += "order by p.cod_prato;";
            
            BLLPratos bll = new BLLPratos();
            DataTable tabela = bll.BuscaFichas(busca);
            DTOCaminhos caminho = new DTOCaminhos();


            //this.dgvFichas.Columns[9].ValueType = typeof(double);

            DataTable dados = new DataTable();

            Image ver = new Bitmap(Properties.Resources.document);
            Image edit = new Bitmap(Properties.Resources.pencil2x);
            Image del = new Bitmap(Properties.Resources.trash2x);

           
            dados.Clear();
            dados.Columns.Add("CODIGO");
            dados.Columns.Add("NOME");
            dados.Columns.Add("SETOR");
            dados.Columns.Add("CAT");
            dados.Columns.Add("SCAT");
            dados.Columns.Add("PESO", typeof(double));
            dados.Columns.Add("RENDIMENTO", typeof(double));
            dados.Columns.Add("CUSTO/KG", typeof(double));
            dados.Columns.Add("CUSTO/PORCAO", typeof(double));
            dados.Columns.Add("TOTAL", typeof(double));
            dados.Columns.Add("ATIVO");
            dados.Columns.Add("VER", typeof(System.Drawing.Bitmap));
            dados.Columns.Add("EDT", typeof(System.Drawing.Bitmap));
            dados.Columns.Add("DEL", typeof(System.Drawing.Bitmap));



            DataRow _ravi = dados.NewRow();
            dgvFichas.Visible = false;
            for (int i = 0; i < tabela.Rows.Count; i++)
            {
                string categoria = "";
                string subcategoria = "";

                double peso = 0;
                double rendimento = 0;
                double custoPorcao = 0;
                double custoKg = 0;
                double custoTotal = 0;
                string estaAtivo = "Ativo";

                try
                {
                    peso = Convert.ToDouble(tabela.Rows[i][5].ToString());
                }
                catch {}

                try
                {
                    rendimento = Convert.ToDouble(tabela.Rows[i][6].ToString());
                }
                catch { }

                try
                {
                    custoPorcao = Convert.ToDouble(tabela.Rows[i][7].ToString());
                }
                catch { }

                try
                {
                    custoKg = Convert.ToDouble(tabela.Rows[i][8].ToString());
                }
                catch { }

                try
                {
                    custoTotal = Convert.ToDouble(tabela.Rows[i][9].ToString());
                }
                catch { }

                try
                {
                    estaAtivo = Convert.ToBoolean(tabela.Rows[i][10])?"Ativo":"Inativo";
                }
                catch { }


                if (!(string.IsNullOrEmpty(tabela.Rows[i][3].ToString())))
                {
                    categoria = tabela.Rows[i][3].ToString();
                }

                if (!(string.IsNullOrEmpty(tabela.Rows[i][4].ToString())))
                {
                    subcategoria = tabela.Rows[i][4].ToString();
                }

                dados.Rows.Add(new object[] { tabela.Rows[i][0].ToString(), tabela.Rows[i][1].ToString(), tabela.Rows[i][2].ToString(), categoria, subcategoria, peso, rendimento, custoKg, custoPorcao, custoTotal, estaAtivo, ver, edit, del });
            }

            dgvFichas.DataSource = dados;
            dgvFichas.Visible = true;
            FormatarDGV();

        }

        private void FormatarDGV()
        {
            dgvFichas.AutoResizeColumns();          

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

        private static List<Language> NewMethod()
        {
            return new List<Language>();
        }

        private void CarregaCat()
        {

            BLLBuffet bllsetor = new BLLBuffet();
            DataTable tabelaSetor = bllsetor.Listar();

            BLLCategoria bllCat = new BLLCategoria();
            DataTable tabelaCat = bllCat.Listar();

            BLLSubCategoria bllSCat = new BLLSubCategoria();
            DataTable tabelaSCat = bllSCat.Listar();

            List<Language> dataSource1 = NewMethod();
            dataSource1.Add(new Language() { Setor = "", Value = "0" });

            for (int i = 0; i < tabelaSetor.Rows.Count; i++)
            {
                dataSource1.Add(new Language() { Setor = tabelaSetor.Rows[i][1].ToString(), Value = Convert.ToInt32(tabelaSetor.Rows[i][0]).ToString() });
            }
            var dataSource2 = new List<Language>();
            dataSource2.Add(new Language() { Cat = "", Value1 = "0" });

            for (int i = 0; i < tabelaCat.Rows.Count; i++)
            {
                dataSource2.Add(new Language() { Cat = tabelaCat.Rows[i][1].ToString(), Value1 = Convert.ToInt32(tabelaCat.Rows[i][0]).ToString() });
            }
            var dataSource3 = new List<Language>();
            dataSource3.Add(new Language() { Scat = "", Value2 = "0" });
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

        private void TxtNome_TextChanged(object sender, EventArgs e)
        {
            if (liberado)
            {
                CarregaDgv();
            }
        }

        private void CbSetor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (liberado)
            {
                CarregaDgv();
            }
        }

        private void CbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (liberado)
            {
                CarregaDgv();
            }
        }

        private void CbSubCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (liberado)
            {
                CarregaDgv();
            }
        }

        private void CbUnidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (liberado)
            {
                CarregaDgv();
            }
        }

        private void DgvFichas_SelectionChanged(object sender, EventArgs e)
        {
            dgvFichas.ClearSelection();
        }

        private void DgvFichas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FichasTecnicas ft = new FichasTecnicas();
            BLLPermissoes bllperm = new BLLPermissoes();            

            if (e.ColumnIndex == 13)
            {
                if (e.RowIndex >= 0)
                {
                    if (bllperm.PermissaoPorLocal(Diversos.LocaisPermissoes.Fichas, usuarioConectado) >= 4)
                    {
                        DialogResult d = MessageBox.Show("Deseja realmente excluir a ficha técnica de " + dgvFichas.Rows[e.RowIndex].Cells[1].Value.ToString() + "?", "ATENÇÃO!", MessageBoxButtons.YesNo);
                        if (d.ToString() == "Yes")
                        {
                            ft.ExcluirPrato(dgvFichas.Rows[e.RowIndex].Cells[0].Value.ToString());
                            CarregaDgv();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Você não tem permissões necessárias para deletar esta ficha técnica.");
                    }
                }
            }

            if (e.ColumnIndex == 12)
            {
                if (e.RowIndex >= 0)
                {
                    if (herdada)
                    {
                        this.codFicha = dgvFichas.Rows[e.RowIndex].Cells[0].Value.ToString();
                        this.Close();
                    }
                    else
                    {
                        if (bllperm.PermissaoPorLocal(Diversos.LocaisPermissoes.Fichas, usuarioConectado) >= 3)
                        {
                            frmCadastroFichas cf = new frmCadastroFichas(usuarioConectado, dgvFichas.Rows[e.RowIndex].Cells[0].Value.ToString(), true);
                            cf.ShowDialog();
                            cf.Dispose();
                            CarregaDgv();

                        }
                        else
                        {
                            MessageBox.Show("Você não tem permissões necessárias para editar esta ficha técnica.");

                        }

                    }
                }
            }

            if (e.ColumnIndex == 11)
            {
                if (e.RowIndex >= 0)
                {

                    FrmVisualizaFichaTecnica vf = new FrmVisualizaFichaTecnica(usuarioConectado, Convert.ToInt32(cbUnidade.SelectedValue), dgvFichas.Rows[e.RowIndex].Cells[0].Value.ToString());
                    vf.ShowDialog();
                    vf.Dispose();

                }
            }

        }

        private void BtPdf_Click(object sender, EventArgs e)
        {

            DialogResult d = MessageBox.Show("Deseja exportar TODAS as fichas técnicas listadas abaixo?", "ATENÇÃO!", MessageBoxButtons.YesNo);
            if (d.ToString() == "Yes")
            {
                DialogResult c = MessageBox.Show("Caso alguma ficha contenha imagem deseja exportá-la também?", "ATENÇÃO!", MessageBoxButtons.YesNo);
                if (c.ToString() == "Yes")
                {
                    ExportarPdf(true);
                }
                else
                {
                    ExportarPdf(false);
                }
            }
        }

        private void ExportarPdf(bool img)
        {
            FolderBrowserDialog fd = new FolderBrowserDialog();
            
            try
            {

                if (fd.ShowDialog() == DialogResult.OK)
                {
                    
                    FichasTecnicas FT = new FichasTecnicas();

                    for (int i = 0; i < dgvFichas.Rows.Count; i++)
                    {
                        FT.ParaPDF(img, dgvFichas.Rows[i].Cells[0].Value.ToString(), fd.SelectedPath.ToString() + "\\" + dgvFichas.Rows[i].Cells[1].Value.ToString() + ".pdf", Convert.ToInt32(cbUnidade.SelectedValue));
                    }

                    MessageBox.Show($"Fichas técnicas exportadas com sucesso!");

                }
            }
            catch
            {
                
                MessageBox.Show($"Erro ao exportar as fichas técnicas.\nVerifique se não tem algum documento de PDF Aberto ou se a pasta selecionada não está protegida.");

            }


        }

        private void CbxInativo_CheckedChanged(object sender, EventArgs e)
        {
            if (liberado)
            {
                CarregaDgv();
            }
        }

        private void DgvFichas_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

            if (e.RowIndex != -1)
            {
                if (dgvFichas.Rows[e.RowIndex].Cells[10].Value.ToString() == "Inativo" && e.ColumnIndex < 11)
                {
                    e.Paint(e.CellBounds, e.PaintParts);  // This will paint the cell for you
                    e.Graphics.DrawLine(new Pen(Color.Black, 1), new Point(e.CellBounds.Left, e.CellBounds.Top), new Point(e.CellBounds.Right, e.CellBounds.Bottom));

                    e.Graphics.DrawLine(new Pen(Color.Black, 1), new Point(e.CellBounds.Right, e.CellBounds.Top), new Point(e.CellBounds.Left, e.CellBounds.Bottom));

                    e.Handled = true;
                }
            }

        }
    }
}
