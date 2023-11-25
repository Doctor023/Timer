using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test;

namespace Timer
{
    internal class Digit
    {
        private List<string> _constructions = new List<string>(7);
        public int Number { get; set; }
        public Digit()
        {
        }
        public void CreateDigit(int nubmer) // build a number
        {
            Number = nubmer;
            ConstructionsBuilder constructionsBuilder = new ConstructionsBuilder(Number);
            constructionsBuilder.GetConstructionsPlan();
            Tuple<List<string>, List<string>> result = constructionsBuilder.CreateConstructions();
            List<string> verticalConstructions = result.Item1;
            List<string> horizontalConstructions = result.Item2;

            Console.SetCursorPosition(0, 0);
            Console.Write(horizontalConstructions[0]);

            Console.SetCursorPosition(0, 3);
            Console.Write(verticalConstructions[1]);

            Console.SetCursorPosition(0, 6);

            Console.Write(horizontalConstructions[2]);

         

            /*Console.SetCursorPosition(0, 0);
            Console.Write(constructions[1]);

            Console.SetCursorPosition(1, 2);
            Console.Write(constructions[2]);

            Console.SetCursorPosition(0, 3);
            Console.Write(constructions[4]);

            Console.SetCursorPosition(0, 7);
            Console.Write(constructions[5]);*/

            /*Console.SetCursorPosition(9, 0);
            Console.Write(constructions[3]);

           // Console.SetCursorPosition(7, 2);
            Console.Read();*/
        }
    }
}

