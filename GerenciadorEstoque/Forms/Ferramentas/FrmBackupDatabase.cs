using GerenciadorEstoque.Code;
using Ionic.Zip;
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
                
                if (d.ShowDialog() == DialogResult.OK)
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

        private void BtBackupImagens_Click(object sender, EventArgs e)
        {
            //Cria um arquivo Zipado com a data e as imagens

            FolderBrowserDialog fd = new FolderBrowserDialog();

            DTOCaminhos caminhos = new DTOCaminhos();

            if (fd.ShowDialog() == DialogResult.OK)
            {
                string pastaDestino = fd.SelectedPath;

                try
                {
                    ZipFile zip = new ZipFile();

                    zip.AddDirectory(caminhos.Imagem, "Imagens");
                    zip.Save(pastaDestino + "\\Backup imagens " + DateTime.Now.ToString("dd-MM-yyyy") + ".zip");
                }
                catch
                {
                    MessageBox.Show($"Erro ao exportar as imagens.\nVerifique a pasta informada.");
                }

                MessageBox.Show("Imagens salvas com sucesso!");
            }
        }

        private void BtRestauraImagens_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidade desabilitada por hora.");
        }
    }
}
