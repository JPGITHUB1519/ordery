using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using data;

namespace data
{
    public class Cliente
    {
        int _idcliente;
        string _nombre;
        string _apellido;
        string _direccion;
        string _telefono;
        string email;
        bool is_active;

        public int Idcliente
        {
            get { return _idcliente; }
            set { _idcliente = value; }
        }
        
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }

        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public bool Is_active
        {
            get { return is_active; }
            set { is_active = value; }
        }

       public string updateCliente(Cliente cliente)
       {
           string rpta = "";
            try
            {
                database.executeQuery("EXEC ACTCLIENTE @idcliente, @Nombre, @apellido, @direccion, @telefono, @email, @is_active",
                                        new KeyValuePair<string,object>("@idcliente", cliente.Idcliente),
                                        new KeyValuePair<string,object>("@Nombre", cliente.Nombre),
                                        new KeyValuePair<string,object>("@apellido", cliente.Apellido),
                                        new KeyValuePair<string,object>("@direccion", cliente.Direccion),
                                        new KeyValuePair<string,object>("@telefono", cliente.Telefono),
                                        new KeyValuePair<string,object>("@email", cliente.Email),
                                        new KeyValuePair<string,object>("@is_active", cliente.Is_active));
                rpta = "ok";
            }
           catch(Exception ex)
            {
                rpta = ex.Message.ToString();
            }
            return rpta;
       }

       public string deleteCliente(int idcliente)
       {
           string rpta = "ok";
           try
           {
               database.executeQuery("EXEC DELETE_CLIENTE @idcliente", new KeyValuePair<string, object>("@idcliente", idcliente.ToString()));
           }
           catch(Exception ex)
           {
               rpta = ex.Message.ToString(); ;
           }
           return rpta;
            
       }
       public DataSet getCliente()
        {
            string rpta = "ok";
            DataSet ds = new DataSet();
            try
            {
                ds = database.executeQuery("EXEC GET_CLIENTE");
            }
            catch(Exception ex)
            {
                ds = null;
            }

            return ds;
        }
        public DataSet filterByName(string name)
        {
            DataSet ds = new DataSet();
            try
            {
                ds = database.executeQuery("EXEC FILTERBYNAME_CLIENTE @Nombre",
                                            new KeyValuePair<string,object>("@Nombre", name));
            }
            catch(Exception ex)
            {
                ds = null;
            }
            return ds;
        }

        public DataSet filterById(int idcliente)
        {
            DataSet ds = new DataSet();
            try
            {
                ds = database.executeQuery("EXEC FILTERBYID_CLIENTE @idcliente",
                                            new KeyValuePair<string, object>("@idcliente", idcliente));
            }
            catch(Exception ex)
            {
                ds = null;
            }
            return ds;
        }
    }
}
