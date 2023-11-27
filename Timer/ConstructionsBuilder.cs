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
        public int Left { get; set; }

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


        public ConstructionsBuilder(int number, int left)
        {
            Number = number;
            Left = left;
        }

        public Tuple<List<VerticalConstructionPlan>, List<HorizontalConstructionPlan>> GetConstructionsPlans() // get information about construction's plan for current number
        {
            _verticalConstructionPlans = new List<VerticalConstructionPlan>
            {
                new VerticalConstructionPlan(Left, 0),
                new VerticalConstructionPlan(Left + 7, 0),
                new VerticalConstructionPlan(Left, 3),
                new VerticalConstructionPlan(Left + 7, 3)
            };
            _horizontalConstructionPlans = new List<HorizontalConstructionPlan>
            {
                new HorizontalConstructionPlan(0),
                new HorizontalConstructionPlan(3),
                new HorizontalConstructionPlan(6)
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
                        if (i == 1)
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
            return Tuple.Create(_verticalConstructionPlans, _horizontalConstructionPlans);

        }
        /*public Tuple<List<string>, List<string>> CreateConstructions() // build construction
        {
            List<string> verticalConstructions = new List<string>(4);
            for (int i = 0; i < verticalConstructions.Count; i++)
            {
                
            }

            List<string> horizontalConstructions = new List<string>(2);

            foreach (var horizontal in _horizontalConstructionPlans)
            {
                string construction = "";
                if (horizontal.Exists) { construction = "######"; }
                horizontalConstructions.Add(construction);

            }
            return Tuple.Create(verticalConstructions, horizontalConstructions);*/
        
        }
    }

