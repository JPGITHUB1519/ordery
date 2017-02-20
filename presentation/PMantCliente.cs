using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using utils;
using data;

namespace presentation
{
    public partial class PMantCliente : PMantBase
    {
        public PMantCliente()
        {
            InitializeComponent();
            this.ttpNotification.SetToolTip(txtnombre, "Inserte Nombre");
            this.ttpNotification.SetToolTip(txtapellido, "Inserte Apellido");
            this.ttpNotification.SetToolTip(txttelefono, "Inserte Telefono");
            this.ttpNotification.SetToolTip(txtdireccion, "Inserte Direccion");
            this.ttpNotification.SetToolTip(txtemail, "Inserte Email");
            this.ttpNotification.SetToolTip(chkis_active, "Esta Activo?");
        }

        public override void fillDatagrid()
        {
            Cliente cliente = new Cliente();
            this.dgvData.DataSource = cliente.getClientes().Tables[0];
        }

        public override void enable(bool cond)
        {
            this.txtidcliente.ReadOnly = !cond;
            this.txtnombre.ReadOnly = !cond;
            this.txtapellido.ReadOnly = !cond;
            this.txttelefono.ReadOnly = !cond;
            this.txtdireccion.ReadOnly = !cond;
            this.txtemail.ReadOnly = !cond;
            this.chkis_active.Enabled = cond;
        }

        public override void clearTextBoxes()
        {
            this.txtidcliente.Text = string.Empty;
            this.txtnombre.Text = string.Empty;
            this.txtapellido.Text = string.Empty;
            this.txttelefono.Text = string.Empty;
            this.txtdireccion.Text = string.Empty;
            this.txtemail.Text = string.Empty;
            this.chkis_active.Checked = false;
        }

        public override void searchByName()
        {
            Cliente cliente = new Cliente();
            this.dgvData.DataSource = cliente.searchClienteByName(this.txtbuscar.Text.Trim()).Tables[0];
        }

        public override void guardar()
        {
            string rpta = "";
            Cliente cliente = new Cliente();

            try
            {
                if (this.isNew)
                {
                    // creating new
                    cliente.Nombre = this.txtnombre.Text.Trim();
                    cliente.Apellido = this.txtapellido.Text.Trim();
                    cliente.Telefono = this.txttelefono.Text.Trim();
                    cliente.Direccion = this.txtdireccion.Text.Trim();
                    cliente.Email = this.txtemail.Text.Trim();
                    cliente.Is_active = this.chkis_active.Checked;
                    rpta = cliente.insertCliente(cliente);
                }
                else
                {
                    // updating new
                    cliente.Idcliente = Convert.ToInt32(this.txtidcliente.Text.Trim());
                    cliente.Nombre = this.txtnombre.Text.Trim();
                    cliente.Apellido = this.txtapellido.Text.Trim();
                    cliente.Telefono = this.txttelefono.Text.Trim();
                    cliente.Direccion = this.txtdireccion.Text.Trim();
                    cliente.Email = this.txtemail.Text.Trim();
                    cliente.Is_active = this.chkis_active.Checked;
                    rpta = cliente.updateCliente(cliente);
                }


                if (rpta.Equals(configuration.db_ok))
                {
                    if (this.isNew)
                    {
                        messages.successMessage(configuration.insert_sucess);
                    }
                    else
                    {
                        messages.successMessage(configuration.update_success);
                    }
                }

                else
                {
                    messages.errorMessage(rpta);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // fill textboxes from datagrid
        public override void fillTextBoxesFromDatagrid()
        {
            this.txtidcliente.Text = Convert.ToString(this.dgvData.CurrentRow.Cells["idcliente"].Value);
            this.txtnombre.Text = Convert.ToString(this.dgvData.CurrentRow.Cells["nombre"].Value);
            this.txtapellido.Text = Convert.ToString(this.dgvData.CurrentRow.Cells["apellido"].Value);
            this.txttelefono.Text = Convert.ToString(this.dgvData.CurrentRow.Cells["telefono"].Value);
            this.txtdireccion.Text = Convert.ToString(this.dgvData.CurrentRow.Cells["direccion"].Value);
            this.txtemail.Text = Convert.ToString(this.dgvData.CurrentRow.Cells["email"].Value);
            this.chkis_active.Checked = Convert.ToBoolean(this.dgvData.CurrentRow.Cells["Is_active"].Value);
            this.tabControl1.SelectedIndex = 0;
        }

        public override void setIdRecordToParent()
        {
            this.idrecord = this.txtidcliente.Text.Trim();
        }

        // delete cliente individually override
        public override string deleteMultipleFromDatagridView(int codigo)
        {
            Cliente cliente = new Cliente();
            return cliente.deleteCliente(codigo);
        }

        public override void deleteRecord()
        {
            Cliente cliente = new Cliente();
            string rpta = cliente.deleteCliente(Convert.ToInt32(this.txtidcliente.Text.Trim()));
            if (rpta.Equals(configuration.db_ok))
            {
                messages.successMessage(configuration.delete_success);
            }
            else
            {
                messages.errorMessage(rpta);
            }

        }


        private void PMantCliente_Load(object sender, EventArgs e)
        {

        }

        private void PMantCliente_Load_1(object sender, EventArgs e)
        {

        }
    }
}
