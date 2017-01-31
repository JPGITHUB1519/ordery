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
   
           return  database.executeNonQuery("EXEC InsertCategoria @Nombre, @Descripcion",
                                    new KeyValuePair<string, object>("@Nombre", categoria.Nombre),
                                    new KeyValuePair<string, object>("@Descripcion", categoria.Descripcion));
        }

        public string updateCategoria(Categoria categoria)
        {

            return database.executeNonQuery("EXEC updateCategoria @Idcategoria, @Nombre, @Descripcion",
                new KeyValuePair<string, object>("@Idcategoria", categoria.Idcategoria),
                new KeyValuePair<string, object>("@Nombre", categoria.Nombre),
                new KeyValuePair<string, object>("@Descripcion", categoria.Descripcion));
                 
        }

        public string deleteCategoria(int idcategoria)
        {
            return database.executeNonQuery("EXEC deleteCategoria @Idcategoria",
                                        new KeyValuePair<string, object>("@Idcategoria", idcategoria));
        }

        public DataSet getCategorias()
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
            return database.executeQuery("EXEC getCategoriaById",
                                            new KeyValuePair<string, object>("@Idcategoria", idcategoria));
        }

        public DataSet searchCategoriaByName(string nombre)
        {
            return database.executeQuery("EXEC searchCategoriaByname @Nombre",
                                            new KeyValuePair<string, object>("@Nombre", nombre));
        }

    }
}
