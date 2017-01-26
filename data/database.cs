using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace data
{
    public class database
    {
        public static string connection_string = data.Properties.Settings.Default.connection_string;

        // execute a sql to database but vulnerable to sqlinjections
        public static DataSet ejecuta(string query)
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connection_string;
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                ds = null;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }

            return ds;
        }

        // check if a dataset is empty. returns True if yes
        public static bool checkEmptyDataset(DataSet ds)
        {
            if (ds == null || ds.Tables[0].Rows.Count == 0)
            {
                return true;
            }
            return false;
        }

        /* 
         * Execute Parametized Query sending a dictionary
         * from http://codereview.stackexchange.com/questions/56025/passing-parameters-to-a-query
         * this method take string and a dictionary[parameter_name, values] and return
         a dataset with the result of the query 
         */
        /*
        public static DataSet executeQuery(string query, Dictionary<String, object> parameters = null)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connection_string;
            DataSet ds = new DataSet();

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                if(parameters != null)
                {
                    // adding parameters to the commans
                    foreach(KeyValuePair<string,object> kvp in parameters)
                    {
                        cmd.Parameters.Add(new SqlParameter(kvp.Key, kvp.Value));
                    }
                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
            }
            catch(Exception ex)
            {
                ds = null;
            }
            finally
            {
                if(con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }

            return ds;
        }
         * */

        // Using params allows you to call the function with no arguments.
        /*
         * Execute Parametized Query sending KeyValuePar array
         * from http://codereview.stackexchange.com/questions/56025/passing-parameters-to-a-query
         * if the params is not set it execute the query whatever
        */
        public static DataSet executeQuery(string query, params KeyValuePair<String, object>[] parameters)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connection_string;
            DataSet ds = new DataSet();

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                // adding parameters to the commands
                foreach (KeyValuePair<string, object> kvp in parameters)
                {
                    cmd.Parameters.Add(new SqlParameter(kvp.Key, kvp.Value));
                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                ds = null;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }

            return ds;
        }

        // print a dataset for console stuffs and line separate
        public static void printDataset(DataSet ds)
        {
            int cont = 0;
            string line = "";
            foreach (DataTable table in ds.Tables)
            {
                foreach (DataRow row in table.Rows)
                {
                    foreach (DataColumn column in table.Columns)
                    {
                        object item = row[column];
                        if (cont == 0)
                        {
                            line += item;
                        }
                        else
                        {
                            line += "," + item;
                        }
                        cont++;
                    }
                    cont = 0;
                    Console.WriteLine(line);
                }
            }
        }
    }
}
