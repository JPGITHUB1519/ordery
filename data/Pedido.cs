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

        // attributes for details
        int idcombo;
        int cantidad;
        double precio;

        // database Operations

        // create pedido
        public string createPedido(Pedido pedido)
        {
            return database.executeNonQuery("EXEC createPedido  @idcliente, @idusuario, @tipo_pedido",
                                                new KeyValuePair<string, object>("@idpedido", pedido.idpedido),
                                                new KeyValuePair<string, object>("@idusuario", pedido.idusuario),
                                                new KeyValuePair<string, object>("@tipo_pedido", pedido.tipo_pedido));
        }

        // insert a detail to a pedido
        public string insertDetailToPedido(Pedido pedido)
        {
            return database.executeNonQuery("EXEC insertDetailToPedido  @idpedido, @idcombo, @cantidad, @precio",
                                                new KeyValuePair<string, object>("@idpedido", pedido.idpedido),
                                                new KeyValuePair<string, object>("@idcombo", pedido.idcombo),
                                                new KeyValuePair<string, object>("@cantidad", pedido.cantidad),
                                                new KeyValuePair<string, object>("@precio", pedido.precio));
        }

        // get the pedido data
        public DataSet getPedidoDetailsById(int idpedido)
        {
            return database.executeQuery("EXEC getPedidosDetailsById @idpedido",
                new KeyValuePair<string, object>("@idpedido", idpedido));
        }
    }
}
