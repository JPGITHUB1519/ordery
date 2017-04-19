using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using utils;

namespace data
{
    public class Pedido
    {
        int idpedido;
        int idcliente;
        int idusuario;
        int control_turno;
        string tipo_pedido;
        double pago_con;
        string status;
        int iddelivery;

        public int Idpedido
        {
            get { return idpedido; }
            set { idpedido = value; }
        }
       
        public int Idcliente
        {
            get { return idcliente; }
            set { idcliente = value; }
        }
       
        public int Idusuario
        {
            get { return idusuario; }
            set { idusuario = value; }
        }
        
        public string Tipo_pedido
        {
            get { return tipo_pedido; }
            set { tipo_pedido = value; }
        }
        public double Pago_con
        {
            get { return pago_con; }
            set { pago_con = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public int Iddelivery
        {
            get { return iddelivery; }
            set { iddelivery = value; }
        }

        // attributes for details
        int idcombo;
        double precio;
        int cantidad;
        public int Idcombo
        {
            get { return idcombo; }
            set { idcombo = value; }
        }

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public int Control_turno
        {
            get { return control_turno; }
            set { control_turno = value; }
        }

        // database Operations

        // create pedido
        // return the id of the created pedido to take it in the facturation time
        public int createPedido(Pedido pedido)
        {
            DataTable dt = new DataTable();
            dt = database.executeQuery("EXEC createPedido  @idcliente, @idcontrol_pedido, @idusuario, @tipo_pedido, @pago_con, @status, @iddelivery",
                                                new KeyValuePair<string, object>("@idcliente", pedido.idcliente),
                                                new KeyValuePair<string, object>("@idcontrol_pedido", pedido.control_turno),
                                                new KeyValuePair<string, object>("@idusuario", pedido.idusuario),
                                                new KeyValuePair<string, object>("@tipo_pedido", pedido.tipo_pedido),
                                                new KeyValuePair<string, object>("@pago_con", pedido.pago_con),
                                                new KeyValuePair<string, object>("@status", pedido.status),
                                                new KeyValuePair<string, object>("@iddelivery", pedido.iddelivery)).Tables[0];
            // return the id of the created pedido
            return Convert.ToInt32(dt.Rows[0]["idpedido"]);
        }

        // insert a detail to a pedido
        public string insertDetailToPedidoCombo(Pedido pedido)
        {
            return database.executeNonQuery("EXEC insertDetailToPedidoCombo  @Idpedido, @Idcombo, @Cantidad, @Precio",
                                                new KeyValuePair<string, object>("@Idpedido", pedido.idpedido),
                                                new KeyValuePair<string, object>("@Idcombo", pedido.idcombo),
                                                new KeyValuePair<string, object>("@Cantidad", pedido.cantidad),
                                                new KeyValuePair<string, object>("@Precio", pedido.precio));
        }


        public DataSet getPedidos()
        {
            return database.executeQuery("EXEC getPedidos");
        }

        // get pedidos with status ordenado
        public DataSet getPedidosByStatusOrdenado()
        {
            return database.executeQuery("EXEC getPedidosByStatusOrdenado");
        }

        public DataSet getPedidosByStatusOrdenadoAndConcinando()
        {
            return database.executeQuery("EXEC getPedidosByStatusOrdenadoAndConcinando");
        }

        // get the pedido data
        public DataSet getPedidoDetailsById(int idpedido)
        {
            return database.executeQuery("EXEC getPedidosDetailsById @Idpedido",
                                            new KeyValuePair<string, object>("@Idpedido", idpedido));
        }

        /* obtiene las ventas de un usuario en un turno en especifico */
        public DataSet getMisVentas(int idcontrol_turno)
        {
            return database.executeQuery("EXEC getMisVentas @idcontrol_turno",
                                            new KeyValuePair<string, object>("@idcontrol_turno", idcontrol_turno));
        }

        // set status to cocinando
        public string setPedidoStatusToCocinando(int idpedido)
        {
            return database.executeNonQuery("EXEC setPedidoStatusToCocinando @idpedido",
                                                new KeyValuePair<string, object>("@idpedido", idpedido));
        }

        // set status to listo(cuando ya esta cocinado)
        public string setPedidoStatusToListo(int idpedido)
        {
            return database.executeNonQuery("EXEC setPedidoStatusToListo @idpedido", 
                                                new KeyValuePair<string, object>("@idpedido", idpedido));
        }


        
    }
}
