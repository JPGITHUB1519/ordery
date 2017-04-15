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
    public partial class PPedidoDetail : Form
    {
        public PPedidoDetail()
        {
            InitializeComponent();
        }

        public PPedidoDetail(int idpedido)
        {
            // the error was that i was not initialize the component
            // when you override the constructor always, always put Initialize Component
            InitializeComponent();
            Pedido pedido = new Pedido();
            DataTable dt = pedido.getPedidoDetailsById(idpedido).Tables[0];
            this.txtidpedido.Text = dt.Rows[0]["pedido_id"].ToString();
            this.txtcliente.Text = dt.Rows[0]["cliente_nombre"].ToString();
            this.txtusername.Text = dt.Rows[0]["username"].ToString();
            foreach(DataRow row in dt.Rows)
            {
                listBox1.Items.Add(row["combo_nombre"].ToString());
            }
        }

        private void PPedidoDetail_Load(object sender, EventArgs e)
        {

        }

        private void txtidpedido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtidcliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtidusuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
