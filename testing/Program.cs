using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using utils;
namespace testing
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = "hola";
            string encriptado = Security.Encrypt(texto);
            string desencriptado = Security.decrypting(encriptado);

            Console.WriteLine("Encriptado : " + encriptado);
            Console.WriteLine("Desencriptado : " + desencriptado);
            Console.ReadKey();

        }
    }
}
