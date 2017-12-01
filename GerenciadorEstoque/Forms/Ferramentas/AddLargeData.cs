using GerenciadorEstoque.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorEstoque
{
    public partial class AddLargeData : Form
    {
        public AddLargeData()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            DataObject o = (DataObject)Clipboard.GetDataObject();
            if (o.GetDataPresent(DataFormats.Text))
            {
                if (dgvExcel.RowCount > 0)
                    dgvExcel.Rows.Clear();

                if (dgvExcel.ColumnCount > 0)
                    dgvExcel.Columns.Clear();

                bool columnsAdded = false;
                string[] pastedRows = Regex.Split(o.GetData(DataFormats.Text).ToString().TrimEnd("\r\n".ToCharArray()), "\r\n");
                foreach (string pastedRow in pastedRows)
                {
                    string[] pastedRowCells = pastedRow.Split(new char[] { '\t' });

                    if (!columnsAdded)
                    {
                        for (int i = 0; i < pastedRowCells.Length; i++)
                            dgvExcel.Columns.Add("col" + i, pastedRowCells[i]);

                        columnsAdded = true;
                        continue;
                    }

                    dgvExcel.Rows.Add();
                    int myRowIndex = dgvExcel.Rows.Count - 1;

                    using (DataGridViewRow myDataGridViewRow = dgvExcel.Rows[myRowIndex])
                    {
                        for (int i = 0; i < pastedRowCells.Length; i++)
                            myDataGridViewRow.Cells[i].Value = pastedRowCells[i].Replace("R$", "").Trim();
                    }
                }
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {

            BLLMateriais bll = new BLLMateriais();

            DTOMateriais dto = new DTOMateriais();

            for (int i = 0; i < dgvExcel.Rows.Count; i++)
            {
                dto.CodigoCigam =                   dgvExcel.Rows[i].Cells[0].Value.ToString().Trim();
                dto.Subgrupo_id_subgrupo =                  Convert.ToInt32(dgvExcel.Rows[i].Cells[1].Value.ToString().Trim());
                dto.Descricao =                      Convert.ToString(dgvExcel.Rows[i].Cells[2].Value.ToString().Trim().ToUpper());                
                dto.Um =                    Convert.ToString(dgvExcel.Rows[i].Cells[3].Value.ToString().Trim().ToUpper());
                

        bll.Incluir(dto, "");
            }

            dgvExcel.Rows.Clear();
            MessageBox.Show("Feito!!!");

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Forms.Main main = new Forms.Main();
            main.ShowDialog();
            main.Dispose();
        }
    }


}
