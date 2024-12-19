using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionMesas.Services
{
    public class ShowTable
    {
        public static void ShowFreeTable(Dictionary<int, List<Product>> productByTable)
        {
            int order = 1;
            bool anyTableFree = false; // Bandera para verificar mesas libres.

            foreach (var table in productByTable)
            {
                if (table.Value.Count == 0)
                {
                    Console.WriteLine($"La mesa {order} esta libre.");
                    anyTableFree = true;
                }
                order++;
            }
            if (!anyTableFree) Console.WriteLine("No hay mesas libres.");
            Console.ReadLine();
        }

        public static void ShowTableProduct(Dictionary<int, List<Product>> productByTable)
        {
            int order = 1;
            foreach (var table in productByTable)
            {
                if (table.Value.Count == 0)
                {
                    Console.WriteLine($"La mesa {order} no posee productos.");
                }

                else
                {
                    Console.WriteLine($"La mesa {order} posee los siguientes productos:");
                    foreach (var item in table.Value)
                    {
                        Console.WriteLine($"- {item.Name} (${item.Price})");
                    }
                    decimal subTotal = table.Value.Sum(item => item.Price);
                    Console.WriteLine($"El subtotal es ${subTotal}.\n");
                }
                order++;
            }
            Console.ReadLine();
        }
    }
}
