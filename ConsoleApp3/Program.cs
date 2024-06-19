

namespace ConsoleApp3

{

    internal class Program
    {
        static void Main(string[] args) 
        {


            


            string[] days = new string[6];


            days[0] = "Monday";
            days[1] = "Tuesday";
            days[2] = "Wednesday";
            days[3] = "Thirsday";
            days[4] = "Friday";
            days[5] = "Saturday";
            days[6] = "Sunday";

            int input = int.Parse(Console.ReadLine());

            if (input == 1)
            {
                Console.WriteLine(days[0]);
            }
            else if (input == 2)
            {
                Console.WriteLine(days[1]);
            }
            else if (input == 3)
            {
                Console.WriteLine(days[2]);
            }
            else if (input == 4)
            {
                Console.WriteLine(days[3]);
            }
            else if (input == 5)
            {
                Console.WriteLine(days[4]);
            }
            else if (input == 6)
            {
                Console.WriteLine(days[5]);
            }
            else if (input == 7)
            {
                Console.WriteLine(days[6]);
            }
            else
            {
                Console.WriteLine("Invalid Day!");
            }

        }
    }
}
