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
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void Test_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = database.executeQuery("EXEC sptest").Tables[0];

            // totales

            this.txttotal_venta.Text = DGV.sumColumnFromDatagridView(this.dataGridView1, "venta").ToString();
            this.txt_costo.Text = DGV.sumColumnFromDatagridView(this.dataGridView1, "costo").ToString();
            this.txttotal_diff.Text = DGV.sumColumnFromDatagridView(this.dataGridView1, "dif").ToString();
            this.txt_total_porcentaje.Text = DGV.sumColumnFromDatagridView(this.dataGridView1, "porcentaje").ToString();
            this.txtrentabilidad.Text = (Convert.ToDouble(this.txttotal_diff.Text) / Convert.ToDouble(this.txttotal_venta.Text)).ToString();
        }
    }
}
