namespace _06._Operations_Between_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            char operatation = char.Parse(Console.ReadLine());
            double result = 0;

            if (operatation == '+' || operatation == '-' || operatation == '*')
            {
                if (operatation == '+')
                {
                    result = num1 + num2;
                }
                else if (operatation == '-') 
                { 
                    result = num1 - num2;
                }
                else if (operatation == '*')
                {
                    result = num1 * num2;
                }
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{num1} {operatation} {num2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{num1} {operatation} {num2} = {result} - odd");
                    
                }
            }
            if (operatation == '/' || operatation == '%')
            {
                if (num2 == 0)
                {
                    Console.WriteLine($"Cannot divide {num1} by zero");
                }
                else if (operatation == '/')
                {
                    result = num1 /(double)num2;
                    Console.WriteLine($"{num1} / {num2} = {result:f2}");
                }
                else if (operatation == '%')
                {
                    result = num1 % num2;
                    Console.WriteLine($"{num1} % {num2} = {result}");
                }
            }

        }
    }
}
