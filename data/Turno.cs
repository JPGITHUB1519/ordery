using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace data
{
    public class Turno
    {
        public DataSet getTurnos()
        {
            return database.executeQuery("EXEC getTurnos");
        }

        // open a turno to a caja
        // return the idcontrol of the turno abierto to save in cache
        public int openTurno(int idturno, int idcaja, int idusuario, double monto_inicial)
        {
            Caja caja = new Caja();
            // get the openControl for a caja
            int idcontrol_caja = caja.getOpenControlByIdcaja(idcaja);
            return Convert.ToInt32(database.executeQuery("EXEC openTurno @idturno, @idcontrol_caja, @idusuario, @monto_inicial",
                                            new KeyValuePair<string, object>("@idturno", idturno),
                                            new KeyValuePair<string, object>("@idcontrol_caja", idcontrol_caja),
                                            new KeyValuePair<string, object>("@idusuario", @idusuario),
                                            new KeyValuePair<string, object>("@monto_inicial", @monto_inicial)
                                        ).Tables[0].Rows[0]["idcontrol_turno"]);

        }

        // Close Turno
        /*
            CERRAR TURNO
	        Implica asignar el total de la caja al final del turno y asignarle una fecha de cierre
        */

        public string closeTurno(int idcontrol_turno, double total, DateTime fecha_cierre)
        {
            return database.executeNonQuery("EXEC closeTurno @idcontrol_turno, @total, @fecha_cierre",
                                                new KeyValuePair<string, object>("@idcontrol_turno", idcontrol_turno),
                                                new KeyValuePair<string, object>("@total", total),
                                                new KeyValuePair<string, object>("@fecha_cierre", fecha_cierre));
        }

        // get a control_turno by id
        public DataSet getControlTurnoById(int idcontrol_turno)
        {
            return database.executeQuery("EXEC getControlTurnoById @idcontrol_turno",
                                            new KeyValuePair<string, object>("@idcontrol_turno", idcontrol_turno));
        }

        // get all joined data from a controlturno
        public DataSet getAllInfoControlTurnoById(int idcontrol_turno)
        {
            return database.executeQuery("EXEC getAllInfoControlTurnoById @idcontrol_turno",
                                            new KeyValuePair<string, object>("@idcontrol_turno", idcontrol_turno));
        }

        // get open Control to a Turno
        public int getOpenControlByTurno(int idturno)
        {

            return Convert.ToInt32(database.executeQuery("EXEC getOpenControlByTurno @idturno, @date",
                                                            new KeyValuePair<string, object>("@idturno", idturno),
                                                            new KeyValuePair<string, object>("@date", DateTime.Now)
                                                         ).Tables[0].Rows[0]["idcontrol_turno"]);
        }
        
        // check if one turn was already open today
        public bool checkIfOpen(int idturno)
        {
            DataTable dt;
            dt = database.executeQuery("EXEC getOpenControlByTurno @idturno, @date",
                                                            new KeyValuePair<string, object>("@idturno", idturno),
                                                            new KeyValuePair<string, object>("@date", DateTime.Now)
                                                         ).Tables[0];
            if(dt != null && dt.Rows.Count > 0)
                return true;
            return false;
        }

        // get the turno descripcion by the control idControlTurno
        public string getTurnoDescripcionByControlTurno(int idcontrol_turno)
        {
            return database.executeQuery("EXEC getTurnoDescripcionByControlTurno @idcontrol_turno",
                                            new KeyValuePair<string, object>("@idcontrol_turno", idcontrol_turno)
                                        ).Tables[0].Rows[0]["turno_descripcion"].ToString();
        }

        // GET THE TOTAL IN CAJA BY CONTROL TURNO
        public double getTotalInCajaByControlTurno(int idcontrol_turno)
        {
            return Convert.ToDouble(database.executeQuery("EXEC getTotalInCajaByControlTurno @idcontrol_turno",
                                            new KeyValuePair<string, object>("@idcontrol_turno", idcontrol_turno)
                                        ).Tables[0].Rows[0]["total_in_caja_by_control_turno"]);
        }
    }
}
