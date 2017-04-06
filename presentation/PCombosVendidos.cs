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
    public partial class PCombosVendidos : Form
    {
        public PCombosVendidos()
        {
            InitializeComponent();
        }


        private void PCombosVendidos_Load(object sender, EventArgs e)
        {
            // DatagridView Calculado
            this.dataGridView1.DataSource = database.executeQuery("SELECT * FROM cantidad_combos_vendidos").Tables[0];
            dataGridView1.Columns.Add("Porcentaje", "Porcentaje");
            int total_articulos_vendidos = Convert.ToInt32(DGV.sumColumnFromDatagridView(dataGridView1, "cantidad_vendida"));
            // formula_porcentaje = cantidad_vendida / total 
;            foreach(DataGridViewRow row in this.dataGridView1.Rows)
            {
                row.Cells["porcentaje"].Value = (Convert.ToDouble(row.Cells["cantidad_vendida"].Value) / Convert.ToDouble(total_articulos_vendidos)) * 100;

            }

            // datagridView From database
            //this.dataGridView2.DataSource = database.executeQuery("EXEC getPercentajeSaledCombos").Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dataGridView2.DataSource = database.executeQuery("EXEC getPercentajeSaledCombosByFecha @fecha_inicio, @fecha_final",
                                                                    new KeyValuePair<string, object>("@fecha_inicio", dateTimePicker1.Value),
                                                                    new KeyValuePair<string, object>("@fecha_final", dateTimePicker2.Value)
                                                                  ).Tables[0];
        }
    }
}
