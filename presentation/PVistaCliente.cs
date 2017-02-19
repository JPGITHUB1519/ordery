using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using data;

namespace presentation
{
    public partial class PVistaCliente : PVistaBase
    {
        public PVistaCliente()
        {
            InitializeComponent();
        }

        private void PVistaCliente_Load(object sender, EventArgs e)
        {

        }
        public override DataSet getAll()
        {
            Cliente cliente = new Cliente();
            return cliente.getClientes();
        }

        public override System.Data.DataSet getByName()
        {
            Cliente cliente = new Cliente();
            return cliente.searchClienteByName(this.txtbuscar.Text.Trim());
        }

        public override void fillDatagrid()
        {
            this.dgvData.DataSource = this.getAll().Tables[0];
        }

    }
}
