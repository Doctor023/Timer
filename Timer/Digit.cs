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

        public int Position { get; set; }

        Tuple<List<VerticalConstructionPlan>, List<HorizontalConstructionPlan>>? Result;
        List<VerticalConstructionPlan>? VerticalConstructionPlans;
        List<HorizontalConstructionPlan>? HorizontalConstructionPlans;

        public void CreateDigit(int nubmer) // build a number
        {
            Number = nubmer;

            ConstructionsBuilder constructionsBuilder = new ConstructionsBuilder(Number);
            constructionsBuilder.GetConstructionsPlans();

            Result = constructionsBuilder.GetConstructionsPlans();
            VerticalConstructionPlans = Result.Item1;
            HorizontalConstructionPlans = Result.Item2;

            CreateVerticalConstructions();
            CreateHorizontalConstructions();

            Console.Read();
        }

        void CreateVerticalConstructions()
        {
            if (VerticalConstructionPlans != null)
            {
                foreach (var verticalConstructionPlan in VerticalConstructionPlans)
                {
                    for (int top = 0; top < 7; top++)
                    {
                        if (!verticalConstructionPlan.Exists) { continue; }
                        Console.SetCursorPosition(verticalConstructionPlan.Left, top);
                        Console.WriteLine("#");
                    }
                }
            }
        }

        void CreateHorizontalConstructions()
        {
            if (HorizontalConstructionPlans != null)
            {
                foreach (var horizontalConstructionPlan in HorizontalConstructionPlans)
                {
                    if (horizontalConstructionPlan.Exists)
                    {
                        string text = "########";

                        Console.SetCursorPosition(0, horizontalConstructionPlan.Top);
                        Console.WriteLine(text);
                    }
                }
            }
        }
    }
}

