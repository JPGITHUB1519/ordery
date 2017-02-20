using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace utils
{
    /* Clase para cosas de seguridad como Encriptar / Desencriptar */
    public class Security
    {
        // Encrypt
        public static string Encrypt(string text)
        {
            string result = String.Empty;
            byte[] encrypted = System.Text.Encoding.Unicode.GetBytes(text);
            result = Convert.ToBase64String(encrypted);
            return result;
        }
        
        // Decrypting
        public static string decrypting(string encrypted)
        {
            string result = String.Empty;
            byte[] decrypted = Convert.FromBase64String(encrypted);
            result = System.Text.Encoding.Unicode.GetString(decrypted);
            return result;
        }
    }
}
