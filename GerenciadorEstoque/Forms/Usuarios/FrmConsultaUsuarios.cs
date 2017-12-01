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

namespace GerenciadorEstoque.Forms.Usuarios
{
    public partial class FrmConsultaUsuarios : Form
    {
        public int idUsuario = 0;
        bool liberado = false;

        public FrmConsultaUsuarios()
        {
            InitializeComponent();
        }

        private void FrmConsultaUsuarios_Load(object sender, EventArgs e)
        {
            AtualizaUnidades();
            CarregaDGV();
            liberado = true;
        }

        public class Language
        {
            public string NUnidade { get; set; }
            public string VUnidade { get; set; }
        }

        private void AtualizaUnidades()
        {
            var DSUnidade = new List<Language>();

            BLLUnidade bll = new BLLUnidade();
            DataTable TabelaUnidade = bll.Localizar();
            
            DSUnidade.Add(new Language() { NUnidade = "TODAS", VUnidade = "0" });

            for (int i = 0; i < TabelaUnidade.Rows.Count; i++)
            {
                DSUnidade.Add(new Language() { NUnidade = TabelaUnidade.Rows[i][7].ToString(), VUnidade = TabelaUnidade.Rows[i][0].ToString() });
            }

            DTOUnidade dtoun = new DTOUnidade();
            BLLUnidade bllun = new BLLUnidade();

            //Adicionar ao ComboBox
            this.CbUnidade.DataSource = DSUnidade;
            this.CbUnidade.DisplayMember = "NUnidade";
            this.CbUnidade.ValueMember = "VUnidade";
            this.CbUnidade.SelectedIndex = 0;
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            idUsuario = 0;
            this.Close();
        }

        private void BtEditar_Click(object sender, EventArgs e)
        {
            SelecionaUsuario();
            this.Close();
        }

        private void CarregaDGV()
        {
            BLLUSuarios bll = new BLLUSuarios();
            DataTable Usuario = new DataTable();

            if (CbxSomenteAtivos.Checked)
            {
                if (Convert.ToInt32(CbUnidade.SelectedValue.ToString()) > 0)
                {
                    Usuario = bll.Consulta(TxtNome.Text.Trim(), TxtUsuario.Text.Trim(), Convert.ToInt32(CbUnidade.SelectedValue.ToString()), CbxSomenteAtivos.Checked);
                }
                else
                {
                    Usuario = bll.Consulta(TxtNome.Text.Trim(), TxtUsuario.Text.Trim(), CbxSomenteAtivos.Checked);
                }
            }
            else
            {
                if (Convert.ToInt32(CbUnidade.SelectedValue.ToString()) > 0)
                {
                    Usuario = bll.Consulta(TxtNome.Text.Trim(), TxtUsuario.Text.Trim(), Convert.ToInt32(CbUnidade.SelectedValue.ToString()));
                }
                else
                {
                    Usuario = bll.Consulta(TxtNome.Text.Trim(), TxtUsuario.Text.Trim());
                }
            }

            

            DgvUsuarios.DataSource = Usuario;

            FormataDGV();
        }

        private void FormataDGV()
        {
            DgvUsuarios.Columns[0].Visible = false;
            DgvUsuarios.Columns[1].HeaderText = "ATIVO";
            DgvUsuarios.Columns[2].HeaderText = "NOME";
            DgvUsuarios.Columns[3].HeaderText = "USUÁRIO";
            DgvUsuarios.Columns[4].HeaderText = "UNIDADE";

            DgvUsuarios.Columns[1].Width = 60;
            DgvUsuarios.Columns[2].Width = 240;
            DgvUsuarios.Columns[3].Width = 100;
            DgvUsuarios.Columns[4].Width = 100;
            
        }

        private void TxtNome_TextChanged(object sender, EventArgs e)
        {
            CarregaDGV();
        }

        private void TxtUsuario_TextChanged(object sender, EventArgs e)
        {
            CarregaDGV();
        }

        private void CbUnidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (liberado)
            {
                CarregaDGV();
            }
        }

        private void CbxSomenteAtivos_CheckedChanged(object sender, EventArgs e)
        {
            CarregaDGV();
        }

        private void SelecionaUsuario()
        {
            try
            {
                DgvUsuarios.Focus();                
                idUsuario = Convert.ToInt32(DgvUsuarios.Rows[DgvUsuarios.CurrentCell.RowIndex].Cells[0].Value);
            }
            catch
            {
                idUsuario = 0;
            }
        }
    }
}
