using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace data
{
    public class Combo
    {
        int idcombo;
        string nombre;
        double precio;
        string descripcion;
        byte[] image;

        

        public int Idcombo
        {
            get { return idcombo; }
            set { idcombo = value; }
        }
        
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        
        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public byte[] Image
        {
            get { return image; }
            set { image = value; }
        }

        // database operations
        public string insertCombo(Combo combo)
        {
            return database.executeNonQuery("EXEC insertCombo @nombre, @precio, @descripcion, @image",
                new KeyValuePair<string, object>("@nombre", combo.nombre),
                new KeyValuePair<string, object>("@precio", combo.precio),
                new KeyValuePair<string, object>("@descripcion", combo.descripcion),
                new KeyValuePair<string, object>("@image", combo.image));
        }

        // insertar articulo a combo
        public string insertArticuloToCombo(int idcombo, int idarticulo)
        {
            return database.executeNonQuery("EXEC InsertArticuloToCombo @idcombo, @idarticulo",
                                                new KeyValuePair<string, object>("@idcombo", idcombo),
                                                new KeyValuePair<string, object>("@idarticulo", idarticulo));
        }

        public string updateCombo(Combo combo)
        {
            return database.executeNonQuery("EXEC updateCombo @idcombo, @nombre, @precio, @descripcion, @image",
                new KeyValuePair<string, object>("@idcombo", combo.idcombo),
                new KeyValuePair<string, object>("@nombre", combo.nombre),
                new KeyValuePair<string, object>("@precio", combo.precio),
                new KeyValuePair<string, object>("@descripcion", combo.descripcion),
                new KeyValuePair<string, object>("@image", combo.image));
        }

        public string deleteCombo(int idcombo)
        {
            return database.executeNonQuery("EXEC deleteCombo @idcombo",
                                                new KeyValuePair<string, object>("@idcombo", idcombo));
        }

        public string deleteArticuloFromCombo(int idcombo, int idarticulo)
        {
            return database.executeNonQuery("EXEC DeleteArticuloFromCombo @idcombo, @idarticulo",
                                                new KeyValuePair<string, object>("@idcombo", idcombo),
                                                new KeyValuePair<string, object>("@idarticulo", idarticulo));
        }

        public DataSet getCombos()
        {
            return database.executeQuery("EXEC getCombos");
        }

        public DataSet getComboById(int idcombo)
        {
            return database.executeQuery("EXEC getComboById @idcombo",
                                            new KeyValuePair<string, object>("@idcombo", idcombo));
        }

        // get the articulos from the combo
        public DataSet getComboDetails(int idcombo)
        {
            return database.executeQuery("EXEC GetCombosDetailsByCombo @idcombo",
                                            new KeyValuePair<String, object>("@idcombo", idcombo));
        }

        public DataSet searchComboByName(string nombre)
        {
            return database.executeQuery("EXEC searchComboByName @nombre",
                                            new KeyValuePair<string, object>("@nombre", nombre));
        }

        public DataSet searchArticulosFromComboByName(int idcombo, string nombre_articulo)
        {
            return database.executeQuery("EXEC SearchArticuloFromComboByName @idcombo, @nombre_articulo",
                                            new KeyValuePair<string, object>("@idcombo", idcombo),
                                            new KeyValuePair<string, object>("@nombre_articulo", nombre_articulo));
        }

       
    }
}
