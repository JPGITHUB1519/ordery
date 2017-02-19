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
    public partial class PVistaCategoria : PVistaBase
    {
        public PVistaCategoria()
        {
            InitializeComponent();
        }

        public override DataSet getAll()
        {
            Categoria categoria = new Categoria();
            return categoria.getCategorias();
        }

        public override DataSet getByName()
        {
            Categoria categoria = new Categoria();
            return categoria.searchCategoriaByName(this.txtbuscar.Text.Trim());
        }
        public override void fillDatagrid()
        {
            this.dgvData.DataSource = this.getAll().Tables[0];
        }
        private void PVistaCategoria_Load(object sender, EventArgs e)
        {
            
        }
    }
}
