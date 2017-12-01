using GerenciadorEstoque.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorEstoque.Forms.Conexoes
{
    public partial class FrmConfigDBConection : Form
    {
        public bool sucesso = false;

        public FrmConfigDBConection()
        {
            InitializeComponent();
        }

        private void FrmConfigDBConection_Load(object sender, EventArgs e)
        {
            CarregaConfigs();

            if (TestaConexao())
            {
                sucesso = true;
            }
        }

        private void CarregaConfigs()
        {
            txtServidor.Text = Properties.Settings.Default.server;
            //txtBanco.Text = Properties.Settings.Default.db;
            //txtUsuario.Text = Properties.Settings.Default.user;
            //txtServidor.Text = Properties.Settings.Default.pass;
        }

        private void SalvaConfigs()
        {            
            if (TestaConexao())
            {
                Properties.Settings.Default.server = txtServidor.Text;
                //Properties.Settings.Default.db = txtBanco.Text;
                //Properties.Settings.Default.user = txtUsuario.Text;
                //Properties.Settings.Default.pass = txtSenha.Text;

                Properties.Settings.Default.Save();
                sucesso = true;

                MessageBox.Show("Conexão salva com sucesso!");
            }

            else
            {
                MessageBox.Show("Dados de conexão incorretos\nContate o administrador do sistema!");
            }
        }

        private bool TestaConexao()
        {
            bool result = false;
            
            SqlConnection con = new SqlConnection()
            {
                ConnectionString = $"Data Source={txtServidor.Text};Initial Catalog={Properties.Settings.Default.Database};Persist Security Info=True;User ID={Properties.Settings.Default.UserDB};Password={Properties.Settings.Default.senhaDB}"
            };
            
            try
            {
                con.Open();
                con.Close();
                result = true;
            }
            catch
            {
                result = false;
            }

            return result;
        }

        private void BtSalvar_Click(object sender, EventArgs e)
        {
            SalvaConfigs();
        }

        private void BtTestar_Click(object sender, EventArgs e)
        {
            if (TestaConexao())
            {
                MessageBox.Show("Conexão estabelecida com sucesso!");
            }
            else
            {
                MessageBox.Show("Dados de conexão incorretos\nContate o administrador do sistema!");
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
