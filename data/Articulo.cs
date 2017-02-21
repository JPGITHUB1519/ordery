using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace data
{
    public class Articulo
    {
        int idarticulo;
        int idcategoria;
        string nombre;
        string descripcion;
        double precio;
        double unidad;
        int stock;

        public int Idarticulo
        {
            get { return idarticulo; }
            set { idarticulo = value; }
        }
       
        public int Idcategoria
        {
            get { return idcategoria; }
            set { idcategoria = value; }
        }
        
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
       }
        
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        
        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        
        public double Unidad
        {
            get { return unidad; }
            set { unidad = value; }
        }
        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        // database operations
        public string insertArticulo(Articulo articulo)
        {
            return database.executeNonQuery("EXEC InsertArticulo @idcategoria, @Nombre, @Descripcion, @Precio, @unidad, @stock",
                                                new KeyValuePair<string, object>("@idcategoria", articulo.Idcategoria),
                                                new KeyValuePair<string, object>("@Nombre", articulo.Nombre),
                                                new KeyValuePair<string, object>("@Descripcion", articulo.Descripcion),
                                                new KeyValuePair<string, object>("@Precio", articulo.Precio),
                                                new KeyValuePair<string, object>("@unidad", articulo.Unidad),
                                                new KeyValuePair<string, object>("@stock", articulo.stock));
        }

        public string updateArticulo(Articulo articulo)
        {
            return database.executeNonQuery("EXEC updateArticulo @idarticulo, @idcategoria, @Nombre, @Descripcion, @Precio, @unidad, @stock",
                                                new KeyValuePair<string, object>("@idarticulo", articulo.Idarticulo),
                                                new KeyValuePair<string, object>("@idcategoria", articulo.Idcategoria),
                                                new KeyValuePair<string, object>("@Nombre", articulo.Nombre),
                                                new KeyValuePair<string, object>("@Descripcion", articulo.Descripcion),
                                                new KeyValuePair<string, object>("@Precio", articulo.Precio),
                                                new KeyValuePair<string, object>("@unidad", articulo.Unidad),
                                                new KeyValuePair<string, object>("@stock", articulo.stock));
        }

        public string deleteArticulo(int idarticulo)
        {
            return database.executeNonQuery("EXEC deleteArticulo @idarticulo",
                                            new KeyValuePair<string, object>("@idarticulo", idarticulo));
        }

        public DataSet getArticulos()
        {
            return database.executeQuery("EXEC getArticulos");
        }

        public DataSet getArticuloById(int idarticulo)
        {
            return database.executeQuery("EXEC getArticuloById @idarticulo",
                                            new KeyValuePair<string, object>("@idarticulo", idarticulo));
        }

        public DataSet searchArticuloByName(string nombre)
        {
            return database.executeQuery("EXEC searchArticuloByName @Nombre",
                                            new KeyValuePair<string, object>("@Nombre", nombre));
        }
    }
}
