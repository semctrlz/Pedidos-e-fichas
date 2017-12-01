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

namespace GerenciadorEstoque.Forms.Ferramentas
{
    public partial class FrmBackupDatabase : Form
    {
        public FrmBackupDatabase()
        {
            InitializeComponent();
        }

        private void BtBackup_Click(object sender, EventArgs e)
        {
            try
            {

                DateTime dt = DateTime.Now;
                SaveFileDialog d = new SaveFileDialog()
                {
                    Filter = "Backup Files|*.bak",
                    FileName = $"Backup_{dt.ToString("dd")}-{dt.ToString("MM")}-{dt.ToString("yyyy")}"
                };
                d.ShowDialog();
                
                if (d.FileName != "")
                {
                    String nomeBanco = Properties.Settings.Default.Database;
                    String localBackup = d.FileName;
                    String conexao = DALDadosConexao.StringDaConexao;


                    SQLServerBackup.BackupDataBase(conexao, nomeBanco, d.FileName);


                    MessageBox.Show("Backup realizado com sucesso.");

                }

            }

            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void BtRestaurar_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog d = new OpenFileDialog()
                {
                    Filter = "Backup Files|*.bak"
                };
                d.ShowDialog();

                if (d.FileName != "")
                {
                    BLLBackupDataBase bll = new BLLBackupDataBase();
                    bll.Restaura(Properties.Settings.Default.Database, d.FileName);
                }
            }

            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}
