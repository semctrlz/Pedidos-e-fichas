using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using GerenciadorEstoque.Code;

namespace GerenciadorEstoque.Forms.Comuns
{
    public partial class FrmInfo : Form
    {
        public bool atualizar;

        public FrmInfo()
        {
            InitializeComponent();
        }        

        private void FrmInfo_Load(object sender, EventArgs e)
        {
            DTOAssemblyInfo info = new DTOAssemblyInfo();

            LbVersao.Text = info.Versao;
            lbData.Text = info.DataVersao;
            lbObs.Text = info.ObsVersao;
        }

        private void BtVerificarAtualizacao_Click(object sender, EventArgs e)
        {
            Update update = new Update();

            atualizar = false;

            if (update.ChecarAtualizacao())
            {
                DialogResult dr = MessageBox.Show("Existe uma atualização disponível.\n\nAtualizar agora?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if(dr == DialogResult.Yes)
                {
                    atualizar = true;
                    this.Close();
                }

            }
            else
            {
                MessageBox.Show("Seu sistema está com a última atualização disponível!!");
            }

        }

        private void LbZware_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.zware.com.br");
        }
    }
}
