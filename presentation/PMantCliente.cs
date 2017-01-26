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
    public partial class PMantCliente : PMantBase
    {
        public PMantCliente()
        {
            InitializeComponent();
        }

        private void PMantCliente_Load(object sender, EventArgs e)
        {
            fillDatagrid();
        }

        public void fillDatagrid()
        {
            Cliente cliente = new Cliente();
            this.dataGridView1.DataSource = cliente.getCliente().Tables[0];
        }

        public void clearTextBoxes()
        {
            this.txtidcliente.Text = string.Empty;
            this.txtnombre.Text = string.Empty;
            this.txtapellido.Text = string.Empty;
            this.txttelefono.Text = string.Empty;
            this.txtemail.Text = string.Empty;
            this.txtdireccion.Text = string.Empty;
            this.chkis_active.Checked = false;
            this.txtidcliente.Focus();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Idcliente = Convert.ToInt32(txtidcliente.Text.Trim());
            cliente.Nombre = txtnombre.Text.Trim();
            cliente.Apellido = txtapellido.Text.Trim();
            cliente.Direccion = txtdireccion.Text.Trim();
            cliente.Telefono = txttelefono.Text.Trim();
            cliente.Email = txtemail.Text.Trim();
            cliente.Is_active = chkis_active.Checked;
            if(cliente.updateCliente(cliente) == "ok")
            {
                messages.successMessage("OK");
            }
            else
            {
                messages.errorMessage("Error");
            }
                
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            if (cliente.deleteCliente(Convert.ToInt32(txtidcliente.Text.Trim())) == "ok")
            {
                messages.successMessage("OK");
            }
            else
            {
                messages.errorMessage("Error");
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            clearTextBoxes();
        }
    }
}
