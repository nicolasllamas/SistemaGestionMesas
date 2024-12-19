using SistemaGestionMesas.Helper;

namespace SistemaGestionMesas.Services
{
    public class ProductToTable
    {
        public static void Add(List<Product> drinkList, List<Menu> menuList, Dictionary<int, List<Product>> productByTable, int numberOfTables)
        {
            bool isAdding = true;

            Console.WriteLine($"Indique la mesa que desea operar (1 a {numberOfTables})");
            int selectorTable = HelperValidInt.GetValidInt(1, numberOfTables);
            while (isAdding)
            {
                Console.WriteLine($"Indique que desea agrear a la mesa");
                Console.WriteLine($"1) Agregar una bebida");
                Console.WriteLine($"2) Agregar un menu");
                int drinkOrMenu = HelperValidInt.GetValidInt(1, 2);

                switch (drinkOrMenu)
                {
                    case 1:
                        AddDrink(drinkList, productByTable, selectorTable);
                        break;
                    case 2:
                        AddMenu(menuList, productByTable, selectorTable);
                        break;
                    default:
                        throw new Exception("Error en el selector");
                }

                Console.WriteLine($"¿Desea agregar otro producto en esta mesa? (Y/N)");
                string selection = HelperYesNo.GetYesNo("Y", "N");
                if (selection == "Y") { isAdding = true; }
                else if (selection == "N") { isAdding = false; }
                else { throw new Exception("Error en el verificador"); }
            }
        }

        public static void AddDrink(List<Product> drinkList, Dictionary<int, List<Product>> productByTable, int selectorTable)
        {
            Console.WriteLine("Escriba el nombre de la bebida que desea agregar:");
            foreach (var item in drinkList)
            {
                Console.WriteLine(item.ToString());
            }
            productByTable[selectorTable].Add(HelperProduct.GetProduct(drinkList));
            Console.WriteLine($"Bebida agregada.");
        }

        public static void AddMenu(List<Menu> menuList, Dictionary<int, List<Product>> productByTable, int selectorTable)
        {
            Console.WriteLine("Escriba el nombre del platillo que desea agregar:");
            foreach (var item in menuList)
            {
                Console.WriteLine(item.ToString());
            }
            productByTable[selectorTable].Add(HelperProduct.GetProduct(menuList.Cast<Product>().ToList()));
            Console.WriteLine($"Platillo agregado.");
            int delay = productByTable[selectorTable].OfType<Menu>().
                Select(x => x.MinuteToCook).DefaultIfEmpty(0).Max();
            Console.WriteLine($"La demora total es {delay} minutos.");
        }
    }
}
