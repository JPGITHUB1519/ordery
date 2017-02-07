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
    }
}
