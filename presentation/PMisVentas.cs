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
    public partial class PMisVentas : Form
    {
        public PMisVentas()
        {
            InitializeComponent();
        }

        private void PMisVentas_Load(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido();
            this.dgvMisVentas.DataSource = pedido.getMisVentas(session.idControlTurno).Tables[0];

            // fill totales
            int total_pedidos_locales = 0;
            int total_pedidos_domicilio = 0;
            foreach(DataGridViewRow row in this.dgvMisVentas.Rows)
            {
                if (row.Cells["tipo_pedido"].Value.ToString() == "local")
                    total_pedidos_locales++;
                if (row.Cells["tipo_pedido"].Value.ToString() == "domicilio")
                    total_pedidos_domicilio++;
            }
            this.txtTotalPedDom.Text = total_pedidos_domicilio.ToString();
            this.txtTotalPedLocal.Text = total_pedidos_locales.ToString();
            this.txtTotalPedidos.Text = (total_pedidos_locales + total_pedidos_domicilio).ToString();
            this.txtTotalVentas.Text = DGV.sumColumnFromDatagridView(this.dgvMisVentas, "total").ToString();
        }
    }
}
