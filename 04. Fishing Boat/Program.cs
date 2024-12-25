namespace _04._Fishing_Boat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermen = int.Parse(Console.ReadLine());
            double boatLoan = 0;
           


            if (season == "Spring")
            {
                boatLoan = 3000;
            }
            else if (season == "Summer" || season == "Autumn")
            {
                boatLoan = 4200;
            }
            else if (season == "Winter")
            {
                boatLoan = 2600;
            }
            if (fishermen <= 6)
            {
                boatLoan -= boatLoan * 0.10;
            }
            else if (fishermen > 7 && fishermen <= 11)
            {
                boatLoan -= boatLoan * 0.15;
            }
            else if (fishermen > 12)
            {
                boatLoan -= boatLoan * 0.25;
            }
            


            if (fishermen % 2 == 0 && season != "Autumn")
            {
                boatLoan -= boatLoan * 0.05;
            }

            

            if (boatLoan > budget)
            {
                Console.WriteLine($"Not enough money! You need {(boatLoan - budget):f2} leva.");
            }
            else
            {
                Console.WriteLine($"Yes! You have {(budget - boatLoan):f2} leva left.");
            }
        }
    }
}
