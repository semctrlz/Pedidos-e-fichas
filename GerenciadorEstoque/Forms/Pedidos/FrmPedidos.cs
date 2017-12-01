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

namespace GerenciadorEstoque.Forms.Pedidos
{
    public partial class FrmPedidos : Form
    {
        DTOUsuarios usuarioConectado;

        public FrmPedidos(DTOUsuarios u)
        {
            usuarioConectado = u;
            InitializeComponent();
        }
        
        private int[] Cor (Diversos.StatusPedido status)
        {
            int[] selecionaCor = {0,0,0 };

            switch (status)
            {
                case Diversos.StatusPedido.Aberto:
                    selecionaCor[0] = 144;
                    selecionaCor[1] = 238;
                    selecionaCor[2] = 144;
                    break;
                case Diversos.StatusPedido.Solicitado:
                    selecionaCor[0] = 255;
                    selecionaCor[1] = 215;
                    selecionaCor[2] = 0;                    
                    break;
                case Diversos.StatusPedido.Cancelado:
                    selecionaCor[0] = 240;
                    selecionaCor[1] = 128;
                    selecionaCor[2] = 128;                    
                    break;
            }

            return selecionaCor;
        }

        private void FrmPedidos_Load(object sender, EventArgs e)
        {
            CarregarPedidos();
        }

        private void LbCriarCotacao_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Pedidos.FrmPedido f = new FrmPedido(usuarioConectado);
            f.ShowDialog();
            CarregarPedidos();
            f.Dispose();
        }

        private void CarregarPedidos()
        {
            BLLPedidos bll = new BLLPedidos();

            DataTable tabela = bll.Listar(CbxAbertos.Checked, CbxSolicitados.Checked, CbxCancelados.Checked);

            DgvPedidos.Rows.Clear();

            for(int i=0; i< tabela.Rows.Count; i++)
            {
                String[] V = new string[] { Convert.ToInt32(tabela.Rows[i][0]).ToString("000000"), tabela.Rows[i][6].ToString(), Convert.ToDateTime(tabela.Rows[i][1]).ToString("d"), Convert.ToDateTime(tabela.Rows[i][2]).ToString("d"), tabela.Rows[i][4].ToString()  };
                DgvPedidos.Rows.Add(V);
            }

            FormatarDGV();
        }

        private void CbxAbertos_CheckedChanged(object sender, EventArgs e)
        {
            CarregarPedidos();
        }

        private void FormatarDGV()
        {
            int[] Corselecionada = { 0, 0, 0 };

            Diversos.StatusPedido pedido = Diversos.StatusPedido.Aberto;

            for (int i = 0; i < DgvPedidos.Rows.Count; i++)
            {
                switch (DgvPedidos.Rows[i].Cells[1].Value.ToString())
                {
                    case "Aberto":
                        pedido = Diversos.StatusPedido.Aberto;
                        break;
                    case "Solicitado":
                        pedido = Diversos.StatusPedido.Solicitado;
                        break;
                    case "Cancelado":
                        pedido = Diversos.StatusPedido.Cancelado;
                        break;
                }

                //Colorir
                Corselecionada = Cor(pedido);
                DgvPedidos.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(Corselecionada[0], Corselecionada[1], Corselecionada[2]);


            }
        }

        private void DgvPedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                if (e.RowIndex >= 0)
                {
                    FrmPedido pedido = new FrmPedido(usuarioConectado, Convert.ToInt32(DgvPedidos.Rows[e.RowIndex].Cells[0].Value));
                    pedido.ShowDialog();
                    pedido.Dispose();
                    CarregarPedidos();
                }
            }
            else if (e.ColumnIndex == 6)
            {
                MessageBox.Show("Excluindo!");
            }
        }

        private void DgvPedidos_SelectionChanged(object sender, EventArgs e)
        {
            DgvPedidos.ClearSelection();
        }
    }
}
