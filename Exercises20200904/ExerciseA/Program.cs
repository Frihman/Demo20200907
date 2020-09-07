using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseA
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] meal = new string[3];
            String mealD = "default";

            for (int i = 0; i < 3; i++)
            {
                
                Console.WriteLine("Nämn en favoriträtt");
                meal[i] = Console.ReadLine();
                

            }

            Console.WriteLine(meal[0] + " " + meal[1] + " " + meal[2]);

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(meal[i] + " (" + meal[i].Length + ")");

            }

            for (int i = 0; i < 3; i++)
            {
                if (i < 2)
                {
                    if (meal[i].Length > meal[i + 1].Length && i < 2)
                    {
                        if (i == 0)
                        {
                            if (meal[i].Length > meal[i + 2].Length)
                            {
                                mealD = meal[i];
                                break;
                            }
                            continue;
                        }
                        mealD = meal[i];
                        break;
                    }
                    continue;
                    
                }
                mealD = meal[i];
                break;
            }

            Console.WriteLine("Den längsta maträtten är: " + mealD);





        }
    }
}
