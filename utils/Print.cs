using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace utils
{
    public class print
    {
        public static void printDictionary(Dictionary<string, int> dic)
        {
            string data = "";
            foreach(KeyValuePair<string ,int> kvp in dic)
            {
                data += kvp.Key + "   " + kvp.Value;
                data += "\n";
            }
            MessageBox.Show(data);
        }
    }
}
