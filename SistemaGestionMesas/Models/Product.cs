using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionMesas
{
    public class Product
    {
        public string Name { get; protected set; }
        public decimal Price { get; protected set; }

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
        public override string ToString()
        {
            return $"{Name}, ${Price:F2}";
        }

    }
}
