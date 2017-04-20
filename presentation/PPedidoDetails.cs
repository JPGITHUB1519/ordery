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

namespace presentation
{
    public partial class PPedidoDetails : Form
    {
        public PPedidoDetails()
        {
            InitializeComponent();
        }

        private void PPedidoDetails_Load(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido();
            this.dataGridView1.DataSource = pedido.getPedidosDetails().Tables[0]; 
            // set by default pedidos todos
            this.cmbFiltrarStatus.SelectedIndex = 5;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int idpedido = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells["idpedido"].Value);
            PPedidoDetail doform = new PPedidoDetail(idpedido);
            doform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido();
            int idpedido = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells["idpedido"].Value);
            // actualizar status
            pedido.setPedidoStatusToEntregado(idpedido);
            // otro select de la base de datos
            this.dataGridView1.DataSource = pedido.getPedidosDetails().Tables[0];
        }

        private void cmbFiltrarStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
               0- Ordenado
               1- Cocinando
               2- Listo
               3- Entregando
               4 - Entregado
               5- Todos
           */           
            Pedido pedido = new Pedido();
            if (this.cmbFiltrarStatus.SelectedIndex == 0)
            {
                this.dataGridView1.DataSource = pedido.getPedidosDetailsByStatusOrdenado().Tables[0];
            }
            if (this.cmbFiltrarStatus.SelectedIndex == 1)
            {
                this.dataGridView1.DataSource = pedido.getPedidosDetailsByStatusCocinando().Tables[0];
            }
            if (this.cmbFiltrarStatus.SelectedIndex == 2)
            {
                this.dataGridView1.DataSource = pedido.getPedidosDetailsByStatusListo().Tables[0];
            }
            if (this.cmbFiltrarStatus.SelectedIndex == 3)
            {
                this.dataGridView1.DataSource = pedido.getPedidosDetailsByStatusEntregando().Tables[0];
            }
            if (this.cmbFiltrarStatus.SelectedIndex == 4)
            {
                this.dataGridView1.DataSource = pedido.getPedidosDetailsByStatusEntregado().Tables[0];
            }
            if (this.cmbFiltrarStatus.SelectedIndex == 5)
            {
                this.dataGridView1.DataSource = pedido.getPedidosDetails().Tables[0];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido();
            int idpedido = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells["idpedido"].Value);
            // actualizar status
            pedido.setPedidoStatusToEntregando(idpedido);
            // otro select de la base de datos
            this.dataGridView1.DataSource = pedido.getPedidosDetails().Tables[0];
        }

        private void txtcliente_TextChanged(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido();
            this.dataGridView1.DataSource = pedido.getPedidosDetailsByClienteNombre(this.txtcliente.Text.Trim()).Tables[0];
        }

        private void txtidcaja_TextChanged(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido();
            int idpedido;
            if(this.txtidpedido.Text == "")
            {
                idpedido = 0;
            }
            else
            {
                idpedido = Convert.ToInt32(this.txtidpedido.Text.Trim());
            }
            this.dataGridView1.DataSource = pedido.getPedidosDetailsByIdPedido(idpedido).Tables[0];
        }
    }
}
