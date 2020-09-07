using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseC
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Skriv in en palindrom");
            string text = Console.ReadLine();

            char[] letters = text.ToCharArray();

            for (int i = letters.Length - 1; i >= 0; i--)
            {
                Console.Write(letters[i]);

            }

            Console.WriteLine();
        }
    }
}
