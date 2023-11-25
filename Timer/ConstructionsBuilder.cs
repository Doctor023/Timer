using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Timer;

namespace Timer
{
    public class ConstructionsBuilder
    {

        public int Number { get; set; }
        List<bool> _constructionsPlanBool = new List<bool>(7);

        List<HorizontalConstructionPlan> _horizontalConstructionPlans = new List<HorizontalConstructionPlan>(3);
        List<VerticalConstructionPlan> _verticalConstructionPlans = new List<VerticalConstructionPlan>(4);

        public List<HorizontalConstructionPlan> HorizontalConstructionPlans
        {
            get => _horizontalConstructionPlans; set => _horizontalConstructionPlans = value;
        }
        public List<VerticalConstructionPlan> VerticalConstructionPlans
        {
            get => _verticalConstructionPlans; set => _verticalConstructionPlans = value;
        }


        public ConstructionsBuilder(int number)
        {
            Number = number;
        }

        public void GetConstructionsPlan() // get information about construction's plan for current number
        {
            _verticalConstructionPlans = new List<VerticalConstructionPlan>
            {
                new VerticalConstructionPlan(0),
                new VerticalConstructionPlan(7),
                new VerticalConstructionPlan(0),
                new VerticalConstructionPlan(7)
            };
            _horizontalConstructionPlans = new List<HorizontalConstructionPlan>
            {
                new HorizontalConstructionPlan(),
                new HorizontalConstructionPlan(),
                new HorizontalConstructionPlan()
            };
            switch (Number)
            {
                case 0:

                    for (int i = 0; i < _verticalConstructionPlans.Count; i++)
                    {
                        _verticalConstructionPlans[i].Exists = true;
                    }

                    for (int i = 0; i < _horizontalConstructionPlans.Count; i++)
                    {
                        if (i == 2)
                        {
                            _horizontalConstructionPlans[i].Exists = false;
                        }
                        else
                        {
                            _horizontalConstructionPlans[i].Exists = true;
                        }
                    }

                    break;

            }

        }
        public Tuple<List<string>, List<string>> CreateConstructions() // build construction
        {
            List<string> verticalConstructions = new List<string>(4);
            foreach (var vertical in _verticalConstructionPlans)
            {
                int left = vertical.Left;
                string empty = "";
                for (int i = 0; i < left; i++)
                {
                    empty += " ";
                }
                string construction = $"#\n{empty}#\n{empty}#";
                verticalConstructions.Add(construction);
            }

            List<string> horizontalConstructions = new List<string>(2);

            foreach (var horizontal in _horizontalConstructionPlans)
            {
                string construction = "######";
                horizontalConstructions.Add(construction);

            }
            return Tuple.Create(verticalConstructions, horizontalConstructions);
        
        }
    }
}

