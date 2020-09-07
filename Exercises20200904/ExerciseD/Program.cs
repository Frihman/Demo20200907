using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseD
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int sum = 0;
            float mean = 0;

            Console.WriteLine("Nämn ett tal mellan 1-10");
            int loopNr = Convert.ToInt32(Console.ReadLine());

            int[] nrArray = new int[loopNr];

            for (int i = 0; i < loopNr; i++)
            {
                Console.WriteLine("Skriv in ett tal");
                nrArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (var nr in nrArray)
            {
                sum += nr;

            }

            mean = sum / nrArray.Length;

            int highest = nrArray.Max();
            int lowest = nrArray.Min();

            Console.WriteLine("Summan är: " + sum + 
                "\tMedeltalet är: " + mean + 
                "\tLägsta talet är: " + lowest + 
                "\tHögsta talet är: " + highest);


        }
    }
}
