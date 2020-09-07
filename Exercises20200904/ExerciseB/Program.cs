using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseB
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] delimiterChars = { ' ', ',', '.', '.'};
            
            Console.WriteLine("Ge ett favoritcitat på minst 5 ord");
            string text = Console.ReadLine();

            string[] words = text.Split(delimiterChars);

            Console.WriteLine("Citatet består av " + words.Length + " ord");

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }



        }
    }
}
