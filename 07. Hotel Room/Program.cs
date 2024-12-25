namespace _07._Hotel_Room
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double studio = 0;
            double apartment = 0;
            

            if (month == "May" || month == "October")
            {
                studio = 50;
                apartment = 65;

                if (nights <= 7 )
                {
                    studio *= nights;
                    apartment *= nights;
                }
                else if (nights > 7 && nights <= 14)
                {
                    studio *= nights * 0.95;
                    apartment *= nights;
                }
                else if (nights > 14) 
                {
                    studio *= nights * 0.70;
                    apartment *= nights * 0.90;
                }


                
            }
            else if (month == "June" || month == "September")
            {
                studio = 75.20;
                apartment = 68.70;

                if (nights <= 14)
                {
                    studio *= nights;
                    apartment *= nights;
                }
                else
                {
                    studio *= nights * 0.80;
                    apartment *= nights * 0.90;
                }
            }
            else
            {
                studio = 76 * nights;
                apartment = 77;
                    
                if (nights > 14)
                {
                   apartment *= nights * 0.90;
                }
                else
                {
                    apartment *= nights;
                }
            }
            Console.WriteLine($"Apartment: {apartment:f2} lv.");
            Console.WriteLine($"Studio: {studio:f2} lv." );
           


        }
    }
}
