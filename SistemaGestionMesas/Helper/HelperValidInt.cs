using SistemaGestionMesas;

namespace SistemaGestionMesas.Helper
{
    public class HelperValidInt
    {
        public static int GetValidInt(int min, int max)
        {
            int result = default;

            while (!int.TryParse(Console.ReadLine(), out result) || result < min || result > max)
            {
                Console.WriteLine($"Indique un valor valido (minimo {min}, maximo {max})");
            }
            return result;
        }
    }
}
