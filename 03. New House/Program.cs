namespace _03._New_House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flowersType = Console.ReadLine();
            int numberOfFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double totalPrice = 0;
            if (flowersType == "Roses")
            {
                totalPrice = numberOfFlowers * 5;

                if (numberOfFlowers > 80)
                {
                    totalPrice = totalPrice - totalPrice * 0.10;
                }
            }
            else if (flowersType == "Dahlias")
            {
                totalPrice = numberOfFlowers * 3.80;

                if (numberOfFlowers > 90)
                {
                    totalPrice = totalPrice - totalPrice * 0.15;
                }
            }
            else if(flowersType == "Tulips")
            {
                totalPrice = numberOfFlowers * 2.80;

                if (numberOfFlowers > 80)
                {
                    totalPrice = totalPrice - totalPrice * 0.15;
                }
            }
            else if (flowersType == "Narcissus")
            {
                totalPrice = numberOfFlowers * 3;

                if (numberOfFlowers < 120)
                {
                    totalPrice = totalPrice + totalPrice * 0.15;
                }
            }
            else if (flowersType == "Gladiolus")
            {
                totalPrice = numberOfFlowers * 2.50;

                if (numberOfFlowers < 80)
                {
                    totalPrice = totalPrice + totalPrice * 0.20;
                }
            }
            if (totalPrice > budget)
            {
                Console.WriteLine($"Not enough money, you need {totalPrice - budget:f2} leva more.");               
            }
            else
            {
                 Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {flowersType} and {budget - totalPrice:f2} leva left.");
            }
        }
    }
}
