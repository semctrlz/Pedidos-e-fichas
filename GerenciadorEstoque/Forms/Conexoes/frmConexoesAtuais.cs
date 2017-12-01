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

namespace GerenciadorEstoque.Forms.Conexoes
{
    public partial class frmConexoesAtuais : Form
    {
        DTOUsuarios usuarioLogado;

        public frmConexoesAtuais(DTOUsuarios user)
        {
            InitializeComponent();

            usuarioLogado = user;
        }

        private void FrmConexoesAtuais_Load(object sender, EventArgs e)
        {
            RecuperaDadosMaquina dados = new RecuperaDadosMaquina();
            lbNomePC.Text = dados.RecuperaNome();

            AdicionaPC();
        }

        void AdicionaPC()
        {
            BLLManterConectado bllMC = new BLLManterConectado();
            DataTable Tabela = new DataTable();
            Tabela = bllMC.Localizar(usuarioLogado.Id_usuario);

            String[] C = { "", "", "" };

            RecuperaDadosMaquina dados = new RecuperaDadosMaquina();

            string ip = dados.RecuperarIp();

            dgvCon.Rows.Clear();

            for (int i = 0; i < Tabela.Rows.Count; i++)
            {
                if (Tabela.Rows[i][1].ToString() != ip)
                {
                    C = new string[] { Tabela.Rows[i][0].ToString(), Tabela.Rows[i][2].ToString(), Tabela.Rows[i][4].ToString() };
                    dgvCon.Rows.Add(C);
                }
            }
        }

        private void DgvCon_SelectionChanged(object sender, EventArgs e)
        {
            dgvCon.ClearSelection();
        }

        private void DgvCon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                if (e.RowIndex >= 0)
                {
                    BLLManterConectado bll = new BLLManterConectado();

                    bll.Excluir(Convert.ToInt32(dgvCon.Rows[e.RowIndex].Cells[0].Value));
                    
                    AdicionaPC();

                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Deseja remover as conexões de todos os computadores com login automático?\nEssa remoção não afeta o computador atual.\nContinuar?", "Aviso", MessageBoxButtons.YesNo);
            if (d.ToString() == "Yes")
            {
                BLLManterConectado bll = new BLLManterConectado();
                for (int i = 0; i<dgvCon.Rows.Count; i++)
                {

                bll.Excluir(Convert.ToInt32(dgvCon.Rows[i].Cells[0].Value));

                }

                AdicionaPC();
            }
        }
    }
}
