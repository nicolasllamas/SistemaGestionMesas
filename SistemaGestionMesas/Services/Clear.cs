using SistemaGestionMesas.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionMesas.Services
{
    public class Clear
    {
        public static void ClearTable(Dictionary<int, List<Product>> productByTable, int numberOfTables)
        {
            Console.WriteLine("Indique la mesa que desea liberar:");
            int selectedTableClear = HelperValidInt.GetValidInt(1, numberOfTables);
            if (productByTable[selectedTableClear].Count == 0)
            {
                Console.WriteLine("La mesa seleccionada no posee productos");
            }
            else
            {
                Console.WriteLine($"La mesa {selectedTableClear} posee los siguientes productos:");
                foreach (var item in productByTable[selectedTableClear]) 
                {
                    Console.WriteLine($"- {item.Name} (${item.Price})");
                }
                decimal total = productByTable[selectedTableClear].Sum(item => item.Price);
                Console.WriteLine($"El total es ${total}.\n");
                productByTable[selectedTableClear].Clear();
                Console.WriteLine($"La mesa ha sido liberada");
            }
            Console.ReadLine();
        }

    }
}
