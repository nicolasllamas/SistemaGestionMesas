using SistemaGestionMesas;
using SistemaGestionMesas.Helper;
using SistemaGestionMesas.Services;
public class Program
{
    public static void Main(string[] args)
    {
        var drinkList = Generator.CreateDrinkList();
        var menuList = Generator.CreateMenuList();
        Dictionary<int, List<Product>> productByTable = new Dictionary<int, List<Product>>();
        int numberOfTables = 6; // se deja como variable por posibles futuros cambios
        for (int i = 1; i <= numberOfTables; i++) { productByTable[i] = new List<Product>(); }
        bool isWorking = true;
        while (isWorking)
        {
            Console.Clear();
            Console.WriteLine("Bienvenido al Sistema de Gestion de Mesas\n");
            Console.WriteLine("Indique que desea hacer:");
            Console.WriteLine("1) Agregar un producto a una mesa");
            Console.WriteLine("2) Consultar que mesas estan libres");
            Console.WriteLine("3) Consultar los productos de cada mesa");
            Console.WriteLine("4) Liberar una mesa");
            Console.WriteLine("5) Cerrar el programa");
            int selector = HelperValidInt.GetValidInt(1, 4);

            switch (selector)
            {
                case 1:
                    ProductToTable.Add(drinkList, menuList, productByTable, numberOfTables);
                    break;
                case 2:
                    ShowTable.ShowFreeTable(productByTable);
                    break;
                case 3:
                    ShowTable.ShowTableProduct(productByTable);
                    break;
                case 4:
                    Clear.ClearTable(productByTable, numberOfTables);
                    break;
                case 5:
                    isWorking = false;
                    Console.WriteLine("Saliendo...");
                    break;
            }
        }
    }

}

