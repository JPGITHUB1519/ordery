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

       // DATABASE OPERATIONS
        public string insertCliente(Cliente cliente)
        {
            return database.executeNonQuery("EXEC insertCliente @nombre, @apellido, @direccion, @telefono, @email, @Is_active",
                new KeyValuePair<string, object>("@nombre", cliente.Nombre),
                new KeyValuePair<string, object>("@apellido", cliente.Apellido),
                new KeyValuePair<string, object>("@direccion", cliente.Direccion),
                new KeyValuePair<string, object>("@telefono", cliente.Telefono),
                new KeyValuePair<string, object>("@email", cliente.Email),
                new KeyValuePair<string, object>("@Is_active", cliente.Is_active));
        }

        public string updateCliente(Cliente cliente)
        {
            return database.executeNonQuery("EXEC updateCliente @idcliente, @nombre, @apellido, @direccion, @telefono, @email, @Is_active",
                new KeyValuePair<string, object>("@idcliente", cliente.Idcliente),
                new KeyValuePair<string, object>("@nombre", cliente.Nombre),
                new KeyValuePair<string, object>("@apellido", cliente.Apellido),
                new KeyValuePair<string, object>("@direccion", cliente.Direccion),
                new KeyValuePair<string, object>("@telefono", cliente.Telefono),
                new KeyValuePair<string, object>("@email", cliente.Email),
                new KeyValuePair<string, object>("@Is_active", cliente.Is_active));
        }

        public string deleteCliente(int idcliente)
        {
            return database.executeNonQuery("EXEC deleteCliente @idcliente",
                new KeyValuePair<string, object>("@idcliente", idcliente));
        }

        public DataSet getClientes()
        {
            return database.executeQuery("EXEC getClientes");
        }

        public DataSet searchClienteByName(string nombre)
        {
            return database.executeQuery("EXEC searchClienteByname @nombre",
                                            new KeyValuePair<string, object>("@nombre", nombre));
        }
    }
}
