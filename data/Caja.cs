using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace data
{
    public class Caja
    {
        int idcaja;
        string descripcion;
        bool status;

        public int Idcaja
        {
            get { return idcaja; }
            set { idcaja = value; }
        }
       
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        
        public bool Status
        {
            get { return status; }
            set { status = value; }
        }

        // database operations

        public string insertCaja(Caja caja)
        {
            return database.executeNonQuery("EXEC insertCaja @descripcion, @status",
                                                new KeyValuePair<string, object>("descripcion", caja.descripcion),
                                                new KeyValuePair<string, object>("status", caja.status));
        }

        public string updateCaja(Caja caja)
        {
            return database.executeNonQuery("EXEC updateCaja @idcaja, @descripcion, @status",
                                                new KeyValuePair<string, object>("@idcaja", caja.idcaja),
                                                new KeyValuePair<string, object>("@descripcion", caja.descripcion),
                                                new KeyValuePair<string, object>("@status", caja.status));
        }

        public string deleteCaja(int idcaja)
        {
            return database.executeNonQuery("EXEC deleteCaja @idcaja",
                                                new KeyValuePair<string, object>("@idcaja", idcaja));
        }

        public DataSet getCajas()
        {
            return database.executeQuery("EXEC getCajas");
        }

        public DataSet getCajasById(int idcaja)
        {
            return database.executeQuery("EXEC getCajasById @idcajas",
                                            new KeyValuePair<string, object>("@idcaja", idcaja));
        }

        public DataSet searchCajaByDescripcion(string descripcion)
        {
            return database.executeQuery("EXEC searchCajaByDescripcion @descripcion",
                                            new KeyValuePair<string, object>("@descripcion", descripcion));
        }

       

    }
}
