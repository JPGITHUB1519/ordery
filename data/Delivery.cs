using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace data
{
    public class Delivery
    {
        public DataSet getDeliverys()
        {
            return database.executeQuery("EXEC getDeliverys");
        }

        public DataSet searchDeliveryByName(string name)
        {
            return database.executeQuery("EXEC searchDeliveryByName @name",
                                            new KeyValuePair<string, object>("@name", name));
        }
    }
}
