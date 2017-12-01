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

namespace GerenciadorEstoque.Forms.Ferramentas
{
    public partial class FrmInserirDadosEmLote : Form
    {
        public FrmInserirDadosEmLote()
        {
            InitializeComponent();
        }

        private void FrmInserirDadosEmLote_Load(object sender, EventArgs e)
        {
            DadosPadrao();
        }

        public class Language
        {
            public string Name { get; set; }
            public string Value { get; set; }
            public string Name2 { get; set; }
            public string Value2 { get; set; }
        }

        private void DadosPadrao()
        {

        }

        private void CarregarUnidades()
        {

            /*
            DataTable tabela = bll.LocalizarGrupo(unidade);

            var dataSource = new List<Language>();

            dataSource.Add(new Language() { Name = "", Value = "" });

            for (int i = 0; i < tabela.Rows.Count; i++)
            {
                dataSource.Add(new Language() { Name = tabela.Rows[i][1].ToString(), Value = Convert.ToInt32(tabela.Rows[i][0]).ToString() });
            }

            dataSource.Add(new Language() { Name = "**Adicionar Grupo**", Value = "-1" });

            //Setup data binding
            this.cbGrupos.DataSource = dataSource;
            this.cbGrupos.DisplayMember = "Name";
            this.cbGrupos.ValueMember = "Value";
            this.cbGrupos.Text = "";

            dgvAdmin.Rows.Clear();
            dgvContas.Rows.Clear();
            txtMEtaPercentual1.Clear();
            txtmetaValor1.Clear();
            cbGrupoAdmin.Text = "";
            cbConta.Text = "";

    */
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            DataObject o = (DataObject)Clipboard.GetDataObject();
            if (o.GetDataPresent(DataFormats.Text))
            {
                if (dgvItens.RowCount > 0)
                    dgvItens.Rows.Clear();

                if (dgvItens.ColumnCount > 0)
                    dgvItens.Columns.Clear();

                bool columnsAdded = false;
                string[] pastedRows = Regex.Split(o.GetData(DataFormats.Text).ToString().TrimEnd("\r\n".ToCharArray()), "\r\n");
                foreach (string pastedRow in pastedRows)
                {
                    string[] pastedRowCells = pastedRow.Split(new char[] { '\t' });

                    if (!columnsAdded)
                    {
                        for (int i = 0; i < pastedRowCells.Length; i++)
                            dgvItens.Columns.Add("col" + i, pastedRowCells[i]);

                        columnsAdded = true;
                        continue;
                    }

                    dgvItens.Rows.Add();
                    int myRowIndex = dgvItens.Rows.Count - 1;

                    using (DataGridViewRow myDataGridViewRow = dgvItens.Rows[myRowIndex])
                    {
                        for (int i = 0; i < pastedRowCells.Length; i++)
                            myDataGridViewRow.Cells[i].Value = pastedRowCells[i].Trim();
                    }
                }
            }                        
            
        }


    }
}
