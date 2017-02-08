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
    public partial class PMantArticulo : PMantBase
    {
        public PMantArticulo()
        {
            InitializeComponent();
            this.ttpNotification.SetToolTip(this.txtidcategoria, "Ingrese Categoria");
            this.ttpNotification.SetToolTip(this.txtnombre, "Ingrese Nombre");
            this.ttpNotification.SetToolTip(this.txtprecio, "Ingrese Precio");
            this.ttpNotification.SetToolTip(this.txtunidad, "Ingrese Unidad");
            this.ttpNotification.SetToolTip(this.rchdescripcion, "Ingrese Descripcion");
        }

        // fill datagrid
        public override void fillDatagrid()
        {
            Articulo articulo = new Articulo();
            this.dgvData.DataSource = articulo.getArticulos().Tables[0];
        }

        // enable / disable methods
        public override void enable(bool cond)
        {
            this.txtidarticulo.ReadOnly = !cond;
            this.txtidcategoria.ReadOnly = !cond;
            this.txtnombre.ReadOnly = !cond;
            this.txtprecio.ReadOnly = !cond;
            this.txtunidad.ReadOnly = !cond;
            this.rchdescripcion.ReadOnly = !cond;
        }

        // clearTextBoxes
        public override void clearTextBoxes()
        {
            this.txtidarticulo.Text = string.Empty;
            this.txtidcategoria.Text = string.Empty;
            this.txtnombre.Text = string.Empty;
            this.txtprecio.Text = string.Empty;
            this.txtunidad.Text = string.Empty;
            this.rchdescripcion.Text = string.Empty;
        }

        // searchByName Override
        public override void searchByName()
        {
            Articulo articulo = new Articulo();
            this.dgvData.DataSource = articulo.searchArticuloByName(this.txtbuscar.Text.Trim()).Tables[0];
        }

        // save method
        public override void guardar()
        {
            string rpta = "";
            Articulo articulo = new Articulo();
            try
            {
                if(this.isNew)
                {
                    // creating new articulo
                    articulo.Idcategoria = Convert.ToInt32(this.txtidcategoria.Text.Trim());
                    articulo.Nombre = this.txtnombre.Text.Trim();
                    articulo.Precio = Convert.ToDouble(this.txtprecio.Text.Trim());
                    articulo.Unidad = Convert.ToDouble(this.txtunidad.Text.Trim());
                    articulo.Descripcion = this.rchdescripcion.Text.Trim();
                    rpta = articulo.insertArticulo(articulo);
                }
                else
                {
                    // updating
                    articulo.Idarticulo = Convert.ToInt32(this.txtidarticulo.Text.Trim());
                    articulo.Idcategoria = Convert.ToInt32(this.txtidcategoria.Text.Trim());
                    articulo.Nombre = this.txtnombre.Text.Trim();
                    articulo.Precio = Convert.ToDouble(this.txtprecio.Text.Trim());
                    articulo.Unidad = Convert.ToDouble(this.txtunidad.Text.Trim());
                    articulo.Descripcion = this.rchdescripcion.Text.Trim();
                    rpta = articulo.updateArticulo(articulo);
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
                MessageBox.Show(ex.Message);
            }
        }

        // fill textboxes on doubleClickDatgrid
        public override void fillTextBoxesFromDatagrid()
        {
            this.txtidarticulo.Text = Convert.ToString(this.dgvData.CurrentRow.Cells["idarticulo"].Value);
            this.txtidcategoria.Text = Convert.ToString(this.dgvData.CurrentRow.Cells["idcategoria"].Value);
            this.txtnombre.Text = Convert.ToString(this.dgvData.CurrentRow.Cells["Nombre"].Value);
            this.txtprecio.Text = Convert.ToString(this.dgvData.CurrentRow.Cells["Precio"].Value);
            this.txtunidad.Text = Convert.ToString(this.dgvData.CurrentRow.Cells["unidad"].Value);
            this.rchdescripcion.Text = Convert.ToString(this.dgvData.CurrentRow.Cells["Descripcion"].Value);
            this.tabControl1.SelectedIndex = 0;
        }

        // set idRecort To ParentBase
        public override void setIdRecordToParent()
        {
            this.idrecord = this.txtidarticulo.Text.Trim();
        }

        // delete categoria individually override
        public override string deleteMultipleFromDatagridView(int codigo)
        {
            Articulo articulo = new Articulo();
            return articulo.deleteArticulo(codigo);
        }

        public override void deleteRecord()
        {
            Articulo articulo = new Articulo();
            string rpta = articulo.deleteArticulo(Convert.ToInt32(this.txtidarticulo.Text.Trim()));
            if (rpta.Equals(configuration.db_ok))
            {
                messages.successMessage(configuration.delete_success);
            }
            else
            {
                messages.errorMessage(rpta);
            }
        }

        private void PMantArticulo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PVistaCategoria doform = new PVistaCategoria();
            if(doform.ShowDialog() == DialogResult.OK)
            {
                int pos = doform.dgvData.CurrentCell.RowIndex;
                this.txtidcategoria.Text = doform.dgvData.Rows[pos].Cells["idcategoria"].Value.ToString();
            }
        }
    }
}
