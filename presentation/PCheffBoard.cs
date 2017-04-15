using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using data;
using utils;

namespace presentation
{
    public partial class PCheffBoard : Form
    {
        public PCheffBoard()
        {
            InitializeComponent();
        }

        private void PCheffBoard_Load(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido();
            this.dataGridView1.DataSource = pedido.getPedidosByStatusOrdenadoAndConcinando().Tables[0];

            /*
            foreach(DataGridViewRow row in this.dataGridView1.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.Red;
            }
             * */
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idpedido = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells["idpedido"].Value);
            PPedidoDetail doform = new PPedidoDetail(idpedido);
            doform.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido();
            int idpedido = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells["idpedido"].Value);
            // actualizar status
            pedido.setPedidoStatusToListo(idpedido);
            // otro select de la base de datos
            this.dataGridView1.DataSource = pedido.getPedidosByStatusOrdenadoAndConcinando().Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido();
            // updating status to cocinando
            int idpedido = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells["idpedido"].Value);
            pedido.setPedidoStatusToCocinando(idpedido);
            // getting againg
            this.dataGridView1.DataSource = pedido.getPedidosByStatusOrdenadoAndConcinando().Tables[0];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int idpedido = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells["idpedido"].Value);
            PPedidoDetail doform = new PPedidoDetail(idpedido);
            doform.Show();
        }
    }
}
