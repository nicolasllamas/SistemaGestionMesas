using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionMesas
{
    public class Generator
    {
        public static List<Menu> CreateMenuList()
        {
            return new List<Menu>()
            {
            new Menu("Pizza", 400, 20),
            new Menu("Hamburguesa", 250, 30), //si no viene con papas, es una estafa
            new Menu("Ensalada", 200, 5),
            new Menu("Docena de empanadas", 800, 25),
            };
        }
        public static List<Product> CreateDrinkList()
        {
            return new List<Product>
            {
            new Product("Agua", 80),
            new Product("Cerveza", 150),
            new Product("Vino", 250),
            new Product("Coca Cola", 200),
            new Product("Cafe", 100)
            };
        }

    }
}
