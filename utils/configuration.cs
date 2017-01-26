using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace utils
{
    /* configuration class */
    public class configuration
    {
        public static string system_name = "Ordery";
        public static string version = "V1.0";
        public static List<string> developers = new List<string>()
        {
            "Jean Ureña",
            "Milton Grullon",
            "Adelson Diaz"
        };
        public static string success_message = "OK";
        public static string error_message = "Error";

    }
}
