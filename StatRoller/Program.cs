using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatRoller
{
    class Program
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            List<int> results = new List<int>();

            for (int i = 0; i < 6; i++)
            {

                List<int> rolls = new List<int>();
               

                for (int j = 0; j < 4; j++)
                {
                   rolls.Add(random.Next(1, 7));
                }
                Console.WriteLine("Your 4 rolls are...");
                string individualRolls = string.Join(",", rolls);
               // Console.WriteLine("\n");

                Console.WriteLine(individualRolls);

                Console.WriteLine("Your rolls minus the lowest roll");
                rolls.Remove(rolls.Min());
                results.Add(rolls.Sum());

                string modifiedRolls = string.Join(",", rolls);
                Console.WriteLine(modifiedRolls); 

                Console.WriteLine("Your stat roll is {0}!\n", rolls.Sum());   
            }


            string finalNumbers = string.Join(",", results);

            Console.WriteLine("Your final stats are...\n" + finalNumbers);





            Console.ReadLine();
        }
    }
}


