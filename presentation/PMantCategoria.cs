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
    public partial class PMantCategoria : PMantBase
    {
        // overrides attributes
        public PMantCategoria()
        {
            InitializeComponent();
            this.ttpNotification.SetToolTip(txtnombre, "Inserte Nombre");
            this.ttpNotification.SetToolTip(rchdescripcion, "Ingrese Descripcion");
        }

        // fill datagrid method
        public override void fillDatagrid()
        {
            Categoria categoria = new Categoria();
            this.dgvData.DataSource = categoria.getCategoria().Tables[0];
        }

        // enable / disable Buttons
        public override void enable(bool cond)
        {
            this.txtidcategoria.ReadOnly = !cond;
            this.txtnombre.ReadOnly = !cond;
            this.rchdescripcion.ReadOnly = !cond;
        }

        // clear textBoxes
        public override void clearTextBoxes()
        {
            this.txtidcategoria.Text = string.Empty;
            this.txtnombre.Text = string.Empty;
            this.rchdescripcion.Text = string.Empty;
        }

        public override void searchByName()
        {
            Categoria categoria = new Categoria();
            this.dgvData.DataSource = categoria.searchCategoriaByName(this.txtbuscar.Text.Trim()).Tables[0];
        }

        public override void guardar()
        {
            string rpta = "";
            Categoria categoria = new Categoria();

            try
            {
                if (this.isNew)
                {
                    // creating new
                    categoria.Nombre = this.txtnombre.Text.Trim();
                    categoria.Descripcion = this.txtnombre.Text.Trim();
                    rpta = categoria.insertCategoria(categoria);
                }
                else
                {
                    // updating
                    categoria.Idcategoria = Convert.ToInt32(this.txtidcategoria.Text.Trim());
                    categoria.Nombre = this.txtnombre.Text.Trim();
                    categoria.Descripcion = this.txtnombre.Text.Trim();
                    rpta = categoria.updateCategoria(categoria);
                }

                if(rpta.Equals(configuration.db_ok))
                {
                    if(this.isNew)
                    {
                        messages.successMessage(configuration.insert_sucess);
                    }
                    else
                    {
                        messages.successMessage(configuration.update_success);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public override void fillTextBoxesFromDatagrid()
        {
            this.txtidcategoria.Text = Convert.ToString(this.dgvData.CurrentRow.Cells["idcategoria"].Value);
            this.txtnombre.Text = Convert.ToString(this.dgvData.CurrentRow.Cells["nombre"].Value);
            this.rchdescripcion.Text = Convert.ToString(this.dgvData.CurrentRow.Cells["descripcion"].Value);
            this.tabControl1.SelectedIndex = 0;
        }

        public override void setIdRecordToParent()
        {
            this.idrecord = this.txtidcategoria.Text.Trim();
        }

        // delete categoria individually override
        public override string deleteMultipleFromDatagridView(int codigo)
        {
            Categoria categoria = new Categoria();
            
            return categoria.deleteCategoria(codigo);
        }

        public override void deleteRecord()
        {
            Categoria categoria = new Categoria();
            string rpta = categoria.deleteCategoria(Convert.ToInt32(this.txtidcategoria.Text.Trim()));
            if(rpta.Equals(configuration.db_ok))
            {
                messages.successMessage(configuration.delete_success);
            }
            else
            {
                messages.errorMessage(rpta);
            }

        }

        private void PMantCategoria_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_buscar2_Click(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete2_Click(object sender, EventArgs e)
        {

        }
    }
}
