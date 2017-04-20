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

        // get todays open cajas
        public DataSet getOpenCajasToday()
        {
            return database.executeQuery("EXEC getOpenCajasToday");
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

        // abrir caja
        // return a int with the number of control of the caja
        public int openCaja(int idcaja, int idusuario)
        {
            return Convert.ToInt32(database.executeQuery("EXEC openCaja @idcaja, @idusuario",
                                                new KeyValuePair<string, object>("@idcaja", idcaja),
                                                new KeyValuePair<string, object>("@idusuario", idusuario)
                                                ).Tables[0].Rows[0]["idcontrol_caja"]);
        }

        // close caja
        public string closeCaja(int idcaja, DateTime fecha_cierre)
        {
            return database.executeNonQuery("EXEC closeCaja @idcaja, @fecha_cierre",
                                                new KeyValuePair<string, object>("@idcaja", idcaja),
                                                new KeyValuePair<string, object>("@fecha_cierre", fecha_cierre));
        }

        // return the idcontrol_caja to an specified caja
        public int getOpenControlByIdcaja(int idcaja)
        {
            return Convert.ToInt32(database.executeQuery("EXEC getOpenControlsByCaja @idcaja",
                                            new KeyValuePair<string, object>("@idcaja", idcaja)
                                        ).Tables[0].Rows[0]["idcontrol_caja"]);
        }

        // check if the caja is already open
        public bool checkIfOpen(int idcaja)
        {
            bool isOpen;
            DataTable dt = database.executeQuery("EXEC getOpenControlsByCaja @idcaja",
                                            new KeyValuePair<string, object>("@idcaja", idcaja)
                                           ).Tables[0];
            if (dt.Rows.Count > 0 && dt != null)
                isOpen = true;
            else
                isOpen = false;
            return isOpen;
        }

    }
}
