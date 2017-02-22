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
        //double Precio;
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
        
        /*
        public double Precio
        {
            get { return Precio; }
            set { Precio = value; }
        }
        */

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
            return database.executeNonQuery("EXEC insertCombo @nombre, @descripcion, @image",
                new KeyValuePair<string, object>("@nombre", combo.nombre),
                //new KeyValuePair<string, object>("@Precio", combo.Precio),
                new KeyValuePair<string, object>("@descripcion", combo.descripcion),
                new KeyValuePair<string, object>("@image", combo.image));
        }

        // insertar articulo a combo
        public string insertArticuloToCombo(int idcombo, int idarticulo)
        {
            return database.executeNonQuery("EXEC InsertArticuloToCombo @Idcombo, @idarticulo",
                                                new KeyValuePair<string, object>("@Idcombo", idcombo),
                                                new KeyValuePair<string, object>("@idarticulo", idarticulo));
        }

        public string updateCombo(Combo combo)
        {
            return database.executeNonQuery("EXEC updateCombo @Idcombo, @nombre,  @descripcion, @image",
                new KeyValuePair<string, object>("@Idcombo", combo.idcombo),
                new KeyValuePair<string, object>("@nombre", combo.nombre),
                //new KeyValuePair<string, object>("@Precio", combo.Precio),
                new KeyValuePair<string, object>("@descripcion", combo.descripcion),
                new KeyValuePair<string, object>("@image", combo.image));
        }

        public string deleteCombo(int idcombo)
        {
            return database.executeNonQuery("EXEC deleteCombo @Idcombo",
                                                new KeyValuePair<string, object>("@Idcombo", idcombo));
        }

        public string deleteArticuloFromCombo(int idcombo, int idarticulo)
        {
            return database.executeNonQuery("EXEC DeleteArticuloFromCombo @Idcombo, @idarticulo",
                                                new KeyValuePair<string, object>("@Idcombo", idcombo),
                                                new KeyValuePair<string, object>("@idarticulo", idarticulo));
        }

        public DataSet getCombos()
        {
            return database.executeQuery("EXEC getCombos");
        }

        public DataSet getComboById(int idcombo)
        {
            return database.executeQuery("EXEC getComboById @Idcombo",
                                            new KeyValuePair<string, object>("@Idcombo", idcombo));
        }

        // get the articulos from the combo
        public DataSet getComboDetails(int idcombo)
        {
            return database.executeQuery("EXEC GetCombosDetailsByCombo @Idcombo",
                                            new KeyValuePair<String, object>("@Idcombo", idcombo));
        }

        // get the Todays Combos
        public DataSet getCombosTodays()
        {
            return database.executeQuery("EXEC getCombosToday");
        }

        public DataSet searchComboByName(string nombre)
        {
            return database.executeQuery("EXEC searchComboByName @nombre",
                                            new KeyValuePair<string, object>("@nombre", nombre));
        }

        public DataSet searchArticulosFromComboByName(int idcombo, string nombre_articulo)
        {
            return database.executeQuery("EXEC SearchArticuloFromComboByName @Idcombo, @nombre_articulo",
                                            new KeyValuePair<string, object>("@Idcombo", idcombo),
                                            new KeyValuePair<string, object>("@nombre_articulo", nombre_articulo));
        }

        public double getPrice(int idcombo)
        {
            double precio = -1;
            DataTable dt = database.executeQuery("EXEC getPriceOfCombo @Idcombo",
                                                    new KeyValuePair<string, object>("@Idcombo", idcombo)).Tables[0];
            
            if(dt != null && dt.Rows.Count != 0)
            {
                precio = Convert.ToDouble(dt.Rows[0]["Precio"]);
            }
            return precio;
        }

       
    }
}
