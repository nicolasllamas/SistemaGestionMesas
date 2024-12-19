namespace SistemaGestionMesas
{
    public class Menu : Product
    {
        public int MinuteToCook { get; set; }

        public Menu(string name, decimal price, int minuteToCook) : base(name, price)
        {
            MinuteToCook = minuteToCook;
        }

    }
}
