using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace data
{
    public class Pedido
    {
        int idpedido;
        int idcliente;
        int idusuario;
        string tipo_pedido;

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

        // database Operations

        // create pedido
        // return the id of the created pedido to take it in the facturation time
        public int createPedido(Pedido pedido)
        {
            DataTable dt = new DataTable();
            dt = database.executeQuery("EXEC createPedido  @idcliente, @idusuario, @tipo_pedido",
                                                new KeyValuePair<string, object>("@idcliente", pedido.idcliente),
                                                new KeyValuePair<string, object>("@idusuario", pedido.idusuario),
                                                new KeyValuePair<string, object>("@tipo_pedido", pedido.tipo_pedido)).Tables[0];
            // return the id of the created pedido
            return Convert.ToInt32(dt.Rows[0]["idpedido"]);
        }

        // insert a detail to a pedido
        public string insertDetailToPedido(Pedido pedido)
        {
            return database.executeNonQuery("EXEC insertDetailToPedido  @Idpedido, @Idcombo, @Cantidad, @Precio",
                                                new KeyValuePair<string, object>("@Idpedido", pedido.idpedido),
                                                new KeyValuePair<string, object>("@Idcombo", pedido.idcombo),
                                                new KeyValuePair<string, object>("@Cantidad", pedido.cantidad),
                                                new KeyValuePair<string, object>("@Precio", pedido.precio));
        }

        // get the pedido data
        public DataSet getPedidoDetailsById(int idpedido)
        {
            return database.executeQuery("EXEC getPedidosDetailsById @Idpedido",
                                            new KeyValuePair<string, object>("@Idpedido", idpedido));
        }
    }
}
