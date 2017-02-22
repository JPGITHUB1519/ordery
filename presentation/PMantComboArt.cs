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
    public partial class PMantComboArt : Form
    {
        private int idcombo;
        public PMantComboArt()
        {
            InitializeComponent();
        }

        // new constructor to set the Idcombo property
        public PMantComboArt(int idcombo)
        {
            this.idcombo = idcombo;
            InitializeComponent();
        }

        public void fillArticulosDatagrid()
        {
            Articulo articulo = new Articulo();
            this.dgvArticulos.DataSource = articulo.getArticulos().Tables[0];
        }

        public void fillComboDatagrid()
        {
            Combo combo = new Combo();
            this.dgvArticulosCombo.DataSource = combo.getComboDetails(this.idcombo).Tables[0];
        }

        // insertar articulo in combo
        public void insertArticuloInCombo()
        {
            // insertando articulo en combo
            Combo combo = new Combo();
            int idarticulo = idarticulo = Convert.ToInt32(this.dgvArticulos.CurrentRow.Cells["idarticulo"].Value);
            combo.insertArticuloToCombo(this.idcombo, idarticulo);
            // actualizar tabla
            this.fillComboDatagrid();
        }

        // eliminar articulo de combo
        public void deleteArticuloFromCombo()
        {
            Combo combo = new Combo();
            int idarticulo = idarticulo = Convert.ToInt32(this.dgvArticulosCombo.CurrentRow.Cells["idarticulo"].Value);
            combo.deleteArticuloFromCombo(this.idcombo, idarticulo);
            // actualizar tabla
            this.fillComboDatagrid();
        }

        private void PMantComboArt_Load(object sender, EventArgs e)
        {
            // fill datagridses
            this.fillArticulosDatagrid();
            this.fillComboDatagrid();
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo();
            this.dgvArticulos.DataSource = articulo.searchArticuloByName(this.txtbuscar.Text.Trim()).Tables[0];
        }

        private void txtBuscarComboArt_TextChanged(object sender, EventArgs e)
        {
            Combo combo = new Combo();
            this.dgvArticulosCombo.DataSource = combo.searchArticulosFromComboByName(this.idcombo, this.txtBuscarComboArt.Text.Trim()).Tables[0];
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.insertArticuloInCombo();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.deleteArticuloFromCombo();
        }

        private void txtbuscar_TextChanged_1(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo();
            this.dgvArticulos.DataSource = articulo.searchArticuloByName(this.txtbuscar.Text.Trim()).Tables[0];
        }
    }
}
