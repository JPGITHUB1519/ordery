using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace utils
{
    public class DGV
    {
        // sum the column values and return a ints
        public  static double sumColumnFromDatagridView(DataGridView data, string column)
        {
            double total = 0;
            foreach(DataGridViewRow row in data.Rows)
            {
                total += Convert.ToDouble(row.Cells[column].Value);
            }
            return total;
        }

        // delete selected item FROM DATAGRIDview
        public static void deleteSelectedRowFromDatagridView(DataGridView dgv)
        {
            if (dgv.Rows.Count != 0)
            {
                dgv.Rows.Remove(dgv.CurrentRow);

            }
        }

        // check if a datagridview is empty. return True if so
        public static bool checkIfEmptyDgv(DataGridView dgv)
        {
            if (dgv.Rows.Count != 0 && dgv.Rows != null)
            {
                return false;
            }
            return true;
        }
    }
}
