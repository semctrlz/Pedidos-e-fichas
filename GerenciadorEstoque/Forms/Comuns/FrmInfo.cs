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
using System.Diagnostics;

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
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            string version = fvi.FileVersion;

            LbVersao.Text = version;

            lbData.Text = File.GetCreationTime(Assembly.GetExecutingAssembly().Location).ToShortDateString();
            lbObs.Text = fvi.FileDescription;
        }

        private void BtVerificarAtualizacao_Click(object sender, EventArgs e)
        {
            
        }

        private void LbZware_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.zware.com.br");
        }
    }
}
