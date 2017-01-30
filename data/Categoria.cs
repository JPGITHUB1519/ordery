using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using data;
using utils;

namespace data
{
    public class Categoria
    {
        int _idcategoria;
        string _nombre;
        string _descripcion;

        public int Idcategoria
        {
            get { return _idcategoria; }
            set { _idcategoria = value; }
        }   

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        
        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public string insertCategoria(Categoria categoria)
        {
   
           return  database.executeNonQuery("EXEC InsertCategoria @nombre, @descripcion",
                                    new KeyValuePair<string, object>("@nombre", categoria.Nombre),
                                    new KeyValuePair<string, object>("@descripcion", categoria.Descripcion));
        }

        public string updateCategoria(Categoria categoria)
        {

            return database.executeNonQuery("EXEC updateCategoria @idcategoria, @nombre, @descripcion",
                new KeyValuePair<string, object>("@idcategoria", categoria.Idcategoria),
                new KeyValuePair<string, object>("@nombre", categoria.Nombre),
                new KeyValuePair<string, object>("@descripcion", categoria.Descripcion));
                 
        }

        public string deleteCategoria(int idcategoria)
        {
            return database.executeNonQuery("EXEC deleteCategoria @idcategoria",
                                        new KeyValuePair<string, object>("@idcategoria", idcategoria));
        }

        public DataSet getCategoria()
        {
            DataSet ds = new DataSet();
            try
            {
                ds = database.executeQuery("EXEC getCategorias");
            }
            catch(Exception ex)
            {
                ds = null;
            }
            return ds;
        }

        public DataSet getCategoriaById(int idcategoria)
        {
            DataSet ds = new DataSet();
            try
            {
                ds = database.executeQuery("EXEC getCategoriaById",
                                            new KeyValuePair<string, object>("@idcategoria", idcategoria));
            }
            catch(Exception ex)
            {
                ds = null;
            }
            return ds;
        }

        public DataSet searchCategoriaByName(string nombre)
        {
            DataSet ds = new DataSet();
            try
            {
                ds = database.executeQuery("EXEC searchCategoriaByname @nombre",
                                            new KeyValuePair<string, object>("@nombre", nombre));
            }
            catch(Exception ex)
            {
                ds = null;
            }
            return ds;
        }

    }
}
