﻿using System;
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

        // database operations
        public string insertArticulo(Articulo articulo)
        {
            return database.executeNonQuery("EXEC InsertArticulo @idcategoria, @nombre, @descripcion, @precio, @unidad",
                                                new KeyValuePair<string, object>("@idcategoria", articulo.Idcategoria),
                                                new KeyValuePair<string, object>("@nombre", articulo.Nombre),
                                                new KeyValuePair<string, object>("@descripcion", articulo.Descripcion),
                                                new KeyValuePair<string, object>("@precio", articulo.Precio),
                                                new KeyValuePair<string, object>("@unidad", articulo.Unidad));
        }

        public string updateArticulo(Articulo articulo)
        {
            return database.executeNonQuery("EXEC updateArticulo @idarticulo, @idcategoria, @nombre, @descripcion, @precio, @unidad",
                                                new KeyValuePair<string, object>("@idarticulo", articulo.Idarticulo),
                                                new KeyValuePair<string, object>("@idcategoria", articulo.Idcategoria),
                                                new KeyValuePair<string, object>("@nombre", articulo.Nombre),
                                                new KeyValuePair<string, object>("@descripcion", articulo.Descripcion),
                                                new KeyValuePair<string, object>("@precio", articulo.Precio),
                                                new KeyValuePair<string, object>("@unidad", articulo.Unidad));
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
            return database.executeQuery("EXEC searchArticuloByName @nombre",
                                            new KeyValuePair<string, object>("@nombre", nombre));
        }
    }
}
