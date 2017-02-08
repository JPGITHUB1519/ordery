using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentation
{
    public partial class PVistaBase : Form
    {
        public PVistaBase()
        {
            InitializeComponent();

        }

        // get all records
        public virtual DataSet getAll() { return null; }
        // get record by name
        public virtual DataSet getByName() { return null; }

        private void PConsBase_Load(object sender, EventArgs e)
        {
            //this.dgvData.DataSource = this.getAll().Tables[0];
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            this.dgvData.DataSource =  this.getByName().Tables[0];
        }

        private void btn_buscar2_Click(object sender, EventArgs e)
        {
            this.dgvData.DataSource = this.getByName().Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvData.Rows.Count == 0 || dgvData.Rows[0].Cells[0].Value == null)
            {
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
