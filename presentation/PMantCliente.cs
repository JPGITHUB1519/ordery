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
        /* clear Textboxes but not the idtextbox */
        public void clearTextBoxesExceptId()
        {
            this.txtnombre.Text = string.Empty;
            this.txtapellido.Text = string.Empty;
            this.txttelefono.Text = string.Empty;
            this.txtemail.Text = string.Empty;
            this.txtdireccion.Text = string.Empty;
            this.chkis_active.Checked = false;
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

        private void btn_buscar2_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            Cliente cliente = new Cliente();
            ds = cliente.filterByName(this.txtbuscar.Text.Trim());
            this.dataGridView1.DataSource = ds.Tables[0];
        }

        private void txtidcliente_Validating(object sender, CancelEventArgs e)
        {
            DataSet ds = new DataSet();
            Cliente cliente = new Cliente();
            if(this.txtidcliente.Text != string.Empty)
            {
                ds = cliente.filterById(Convert.ToInt32(this.txtidcliente.Text.Trim()));
                if (database.checkEmptyDataset(ds) == true)
                {
                    clearTextBoxesExceptId();
                }
                else
                {
                    this.txtidcliente.Text = ds.Tables[0].Rows[0]["idcliente"].ToString();
                    this.txtnombre.Text = ds.Tables[0].Rows[0]["nombre"].ToString();
                    this.txtapellido.Text = ds.Tables[0].Rows[0]["apellido"].ToString();
                    this.txtdireccion.Text = ds.Tables[0].Rows[0]["direccion"].ToString();
                    this.txttelefono.Text = ds.Tables[0].Rows[0]["telefono"].ToString();
                    this.txtemail.Text = ds.Tables[0].Rows[0]["email"].ToString();
                    this.chkis_active.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["is_active"]);
                }
            }
            else
            {
                clearTextBoxesExceptId();
            }    
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex = 1;
            this.txtbuscar.Focus();
        }
    }
}
