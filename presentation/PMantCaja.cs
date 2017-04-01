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
    public partial class PMantCaja : PMantBase
    {
        public PMantCaja()
        {
            InitializeComponent();
            this.ttpNotification.SetToolTip(this.txtidcaja, "Ingrese codigo de caja");
            this.ttpNotification.SetToolTip(this.txtdescripcion, "Ingrese Descripcion de la caja");
            this.ttpNotification.SetToolTip(this.chk_is_active, "Status de caja");
        }

        public override void fillDatagrid()
        {
            Caja caja = new Caja();
            this.dgvData.DataSource = caja.getCajas().Tables[0];
        }

        public override void enable(bool cond)
        {
            this.txtidcaja.ReadOnly = !cond;
            this.txtdescripcion.ReadOnly = !cond;
            this.chk_is_active.Enabled = cond;
        }

        public override void clearTextBoxes()
        {
            this.txtidcaja.Text = string.Empty;
            this.txtdescripcion.Text = string.Empty;
            this.chk_is_active.Enabled = true;
        }

        public override void searchByName()
        {
            Caja caja = new Caja();
            this.dgvData.DataSource = caja.searchCajaByDescripcion(this.txtbuscar.Text.Trim()).Tables[0];
        }

        public override void guardar()
        {
            string rpta = "";
            Caja caja = new Caja();
            try
            {
                caja.Descripcion = this.txtdescripcion.Text.Trim();
                caja.Status = this.chk_is_active.Checked;
                if(this.isNew)
                {
                    rpta = caja.insertCaja(caja);
                }
                else
                {
                    caja.Idcaja = Convert.ToInt32(this.txtidcaja.Text.Trim());
                    rpta = caja.updateCaja(caja);
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public override void fillTextBoxesFromDatagrid()
        {
            this.txtidcaja.Text = Convert.ToString(this.dgvData.CurrentRow.Cells["idcaja"].Value);
            this.txtdescripcion.Text = Convert.ToString(this.dgvData.CurrentRow.Cells["descripcion"].Value);
            this.tabControl1.SelectedIndex = 0;
        }

        public override void setIdRecordToParent()
        {
            this.idrecord = this.txtidcaja.Text.Trim();
        }

        public override string deleteMultipleFromDatagridView(int codigo)
        {
            Caja caja = new Caja();
            return caja.deleteCaja(codigo);
        }

        public override void deleteRecord()
        {
            Caja caja = new Caja();
            string rpta = caja.deleteCaja(Convert.ToInt32(this.txtidcaja.Text.Trim()));
            if (rpta.Equals(configuration.db_ok))
            {
                messages.successMessage(configuration.delete_success);
            }
            else
            {
                messages.errorMessage(rpta);
            }
        }

        private void PMantCaja_Load(object sender, EventArgs e)
        {

        }
    }
}
