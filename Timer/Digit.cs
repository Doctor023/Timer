using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{
    internal class Digit
    {
        private List<string> _constructions = new List<string>(7);

        public int Number { get; set; }

        public int Position { get; set; }
        public int Left { get; set; }

        Tuple<List<VerticalConstructionPlan>, List<HorizontalConstructionPlan>>? Result;
        List<VerticalConstructionPlan>? VerticalConstructionPlans;
        List<HorizontalConstructionPlan>? HorizontalConstructionPlans;

        public void CreateDigit(int nubmer, int position) // build a number
        {
            Number = nubmer;
            Position = position;

            Left = GetCurrentPosition();

            ConstructionsBuilder constructionsBuilder = new ConstructionsBuilder(Number, Left);
            constructionsBuilder.GetConstructionsPlans();

            Result = constructionsBuilder.GetConstructionsPlans();
            VerticalConstructionPlans = Result.Item1;
            HorizontalConstructionPlans = Result.Item2;

            CreateVerticalConstructions();
            CreateHorizontalConstructions();
        }

        void CreateVerticalConstructions()
        {
            if (VerticalConstructionPlans != null)
            {
                foreach (var verticalConstructionPlan in VerticalConstructionPlans)
                {
                    int top = verticalConstructionPlan.Top;
                    string text = "";
                    if (verticalConstructionPlan.Exists)
                    {
                         text = "#";
                    }
                    for (int i = 0; i < 4; i++)
                    {
                        Console.SetCursorPosition(verticalConstructionPlan.Left, top);
                        Console.Write(text);
                        top++;
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

                        Console.SetCursorPosition(Left, horizontalConstructionPlan.Top);
                        Console.Write(text);
                    }
                }
            }
        }
        int GetCurrentPosition()
        {
            int left = 0;
            switch (Position)
            {
                case 1: left = 10; break;
                case 2: left = 25; break;
                case 3: left = 35; break;
                default: break;
            }
            return left;
        }
    }
}

