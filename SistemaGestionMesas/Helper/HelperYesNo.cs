using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionMesas.Helper
{
    internal class HelperYesNo
    {
        public static string GetYesNo(string y, string n)
        {
            string result = Console.ReadLine();
            bool valid = false;

            while (!valid)
            {
                if (result.ToUpper() == "Y" || result.ToUpper() == "N")
                {
                    result = result.ToUpper();
                    valid = true;
                }
                else
                {
                    Console.WriteLine("Por favor, escriba solamente 'Y' o 'N' para continuar:");
                    result = Console.ReadLine();
                }
            }
            return result;
        }

    }
}
