namespace _08.On_Time_for_the_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int examHour = int.Parse(Console.ReadLine());
                int examMinutes = int.Parse(Console.ReadLine());
                int hourOfArrive = int.Parse(Console.ReadLine());
                int minutesOfArrive = int.Parse(Console.ReadLine());

                int totalExamMinutes = examHour * 60 + examMinutes;
                int totalMinutesOfArrive = hourOfArrive * 60 + minutesOfArrive;

                if (totalExamMinutes < totalMinutesOfArrive)
                {
                    Console.WriteLine("Late");
                    if (totalMinutesOfArrive - totalExamMinutes < 60)
                    {
                        Console.WriteLine($"{totalMinutesOfArrive - totalExamMinutes} minutes after the start");
                    }
                    else
                    {
                        int reverseHour = (totalMinutesOfArrive - totalExamMinutes) / 60;
                        int reverseMinutes = (totalMinutesOfArrive - totalExamMinutes) % 60;
                        Console.WriteLine($"{reverseHour}:{reverseMinutes:d2} hours after the start");
                    }
                }
                else if (totalExamMinutes == totalMinutesOfArrive)
                {
                    Console.WriteLine("On time");
                }
                else if (totalExamMinutes - totalMinutesOfArrive <= 30)
                {
                    Console.WriteLine("On time");
                    Console.WriteLine($"{totalExamMinutes - totalMinutesOfArrive} minutes before the start");
                }
                else if (totalExamMinutes - totalMinutesOfArrive > 30)
                {
                    Console.WriteLine("Early");
                    int reverseHour = (totalExamMinutes - totalMinutesOfArrive) / 60;
                    int reverseMinutes = (totalExamMinutes - totalMinutesOfArrive) % 60;

                    if (reverseHour == 0)
                    {
                        Console.WriteLine($"{totalExamMinutes - totalMinutesOfArrive} minutes before the start");
                    }
                    else
                    {
                        Console.WriteLine($"{reverseHour}:{reverseMinutes:d2} hours before the start");
                    }

                }
            }
        }
    }
}
