using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using utils;

namespace data
{
    public class Usuario
    {
        int idusuario;
        string username;
        string password;
        bool is_active;

        
        //DateTime created_date;

        public int Idusuario
        {
            get { return idusuario; }
            set { idusuario = value; }
        }
        
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
       
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public bool Is_active
        {
            get { return is_active; }
            set { is_active = value; }
        }

        // database operations
        public string insertUsuario(Usuario usuario)
        {
            return database.executeNonQuery("EXEC insertUsuario @username, @password, @is_active",
                                                new KeyValuePair<string, object>("@username", usuario.username),
                                                new KeyValuePair<string, object>("@password", Security.Encrypt(usuario.Password)),
                                                new KeyValuePair<string, object>("@is_active", usuario.is_active));
        }

        public string updateUsuario(Usuario usuario)
        {
            return database.executeNonQuery("EXEC updateUsuario @Idusuario, @username, @password, @is_active",
                                                new KeyValuePair<string, object>("@Idusuario", usuario.Idusuario),
                                                new KeyValuePair<string, object>("@username", usuario.username),
                                                new KeyValuePair<string, object>("@password", Security.Encrypt(usuario.Password)),
                                                new KeyValuePair<string, object>("@is_active", usuario.is_active));
        }

        public string deleteUsuario(int idusuario)
        {
            return database.executeNonQuery("EXEC deleteUsuario @Idusuario",
                                                new KeyValuePair<string, object>("@Idusuario", idusuario));
        }

        public DataSet getUsuarios()
        {
            return database.executeQuery("EXEC getUsuarios");
        }

        public DataSet getUsuarioById(int idusuario)
        {
            return database.executeQuery("EXEC getUsuariosById @Idusuario",
                                            new KeyValuePair<string, object>("@Idusuario", idusuario));
        }

        public DataSet getUsuarioByName(string username)
        {
            return database.executeQuery("EXEC getUsuarioByName @username",
                                            new KeyValuePair<string, object>("@username", username));
        }

        public DataSet searchUsuarioByName(string username)
        {
            return database.executeQuery("EXEC searchUsuarioByName @username",
                                            new KeyValuePair<string, object>("@username", username));
        }

        public bool authenticateUsuario(Usuario usuario)
        {
            DataSet ds = database.executeQuery("EXEC authenticateUsuario @username, @password",
                                                    new KeyValuePair<string, object>("@username", usuario.Username),
                                                    new KeyValuePair<string, object>("@password", Security.Encrypt(usuario.Password)));
            if (ds.Tables[0].Rows.Count == 0) return false;
            return true;
        }


        
    }
}
