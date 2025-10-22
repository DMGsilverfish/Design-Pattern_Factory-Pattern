using System;

namespace FactoryPatternExample
{
    // The 'Product' interface
    interface IPizza
    {
        void Prepare();
        void Bake();
        void Serve();
    }

    // Concrete Products
    class USAPizza : IPizza
    {
        public void Prepare()
        {
            Console.WriteLine("Preparing a thick crust pizza with extra cheese and pepperoni 🇺🇸");
        }

        public void Bake()
        {
            Console.WriteLine("Baking pizza in a deep-dish oven.");
        }

        public void Serve()
        {
            Console.WriteLine("Serving with ranch dip.\n");
        }
    }

    class ItalianPizza : IPizza
    {
        public void Prepare()
        {
            Console.WriteLine("Preparing a thin crust Margherita pizza with fresh mozzarella and basil 🇮🇹");
        }

        public void Bake()
        {
            Console.WriteLine("Baking in a wood-fired brick oven.");
        }

        public void Serve()
        {
            Console.WriteLine("Serving with olive oil drizzle.\n");
        }
    }

    class ChinesePizza : IPizza
    {
        public void Prepare()
        {
            Console.WriteLine("Preparing a crispy rice-flour crust pizza with Peking duck and hoisin sauce 🇨🇳");
        }

        public void Bake()
        {
            Console.WriteLine("Baking in a bamboo steamer oven.");
        }

        public void Serve()
        {
            Console.WriteLine("Serving with sweet chili sauce.\n");
        }
    }

    // The 'Creator' / Factory class
    class PizzaFactory
    {
        public IPizza CreatePizza(string region)
        {
            switch (region.ToLower())
            {
                case "usa":
                    return new USAPizza();
                case "italy":
                    return new ItalianPizza();
                case "china":
                    return new ChinesePizza();
                default:
                    throw new ArgumentException("Unknown region. Please choose USA, Italy, or China.");
            }
        }
    }

    // The 'Client' class
    internal class Program
    {
        static void Main(string[] args)
        {
            PizzaFactory factory = new PizzaFactory();

            Console.WriteLine("Welcome to the Global Pizza Factory! 🍕");
            Console.Write("Enter your region (USA, Italy, China): ");
            string region = Console.ReadLine();

            try
            {
                IPizza pizza = factory.CreatePizza(region);

                pizza.Prepare();
                pizza.Bake();
                pizza.Serve();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
