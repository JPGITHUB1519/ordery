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
    public partial class PVistaArticulos : PVistaBase
    {
        public PVistaArticulos()
        {
            InitializeComponent();
        }

        public override DataSet getAll()
        {
            Articulo articulo = new Articulo();
            return articulo.getArticulos();
        }

        public override DataSet getByName()
        {
            Articulo articulo = new Articulo();
            return articulo.searchArticuloByName(this.txtbuscar.Text.Trim());
        }

        public override void fillDatagrid()
        {
            this.dgvData.DataSource = this.getAll().Tables[0];
        }

        private void frmVistaArticulos_Load(object sender, EventArgs e)
        {
            
        }
    }
}
