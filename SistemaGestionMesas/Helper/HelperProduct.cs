using SistemaGestionMesas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionMesas.Helper
{
    internal class HelperProduct
    {
        public static Product GetProduct(List<Product> product)
        {
            Product result = default;
            string filter = Console.ReadLine();
            bool valid = false;

            while (!valid)
            {
                if (product.Any(x => x.Name.Equals(filter, StringComparison.OrdinalIgnoreCase)))
                {
                    result = product.Find(x => x.Name.ToUpper() == filter.ToUpper());
                    valid = true;
                }
                else
                {
                    Console.WriteLine("Elemento no encontrado. Por favor, escribalo nuevamente:");
                    filter = Console.ReadLine();
                }
            }
            return result;
        }

    }
}
