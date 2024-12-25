using System.Reflection;

namespace _09._Ski_Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string rate = Console.ReadLine();

            double totalPrice = 0;

            if (type == "room for one person")
            {
                if (days < 10)
                {
                    totalPrice = (days - 1) * 18.00;
                }
                else if (days >= 10 && days <= 15)
                {
                    totalPrice = (days - 1) * 18.00;
                }
                else if (days > 15)
                {
                    totalPrice = (days - 1) * 18.00;
                }
            }
            else if (type == "apartment")
            {
                if (days < 10)
                {
                    totalPrice = ((days - 1) * 25.00) - ((days - 1) * 25.00 * 0.30);
                }
                else if (days >= 10 && days <= 15)
                {
                    totalPrice = ((days - 1) * 25.00) - ((days - 1) * 25.00 * 0.35);
                }
                else if (days > 15)
                {
                    totalPrice = ((days - 1) * 25.00) - ((days - 1) * 25.00 * 0.50);
                }
            }
            else if (type == "president apartment")
            {
                if (days < 10)
                {
                    totalPrice = ((days - 1) * 35.00) - ((days - 1) * 35.00 * 0.10); 
                }
                else if (days >= 10 && days <= 15)
                {
                    totalPrice = ((days - 1) * 35.00) - ((days - 1) * 35.00 * 0.15);
                }
                else if (days > 15)
                {
                    totalPrice = ((days - 1) * 35.00) - ((days - 1) * 35.00 * 0.20);
                }
            }
            if (rate == "positive")
            {
                totalPrice = totalPrice + (totalPrice * 0.25);
            }
            else if (rate == "negative")
            {
                totalPrice = totalPrice - (totalPrice * 0.10);
            }
            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
