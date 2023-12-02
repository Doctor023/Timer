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

                case 1:

                    for (int i = 0; i < _verticalConstructionPlans.Count; i++)
                    {
                        if (i == 0 || i == 2)
                        {
                            _verticalConstructionPlans[i].Exists = false;
                        }
                        else
                        {
                            _verticalConstructionPlans[i].Exists = true;
                        }
                    }

                    for (int i = 0; i < _horizontalConstructionPlans.Count; i++)
                    {
                        _horizontalConstructionPlans[i].Exists = false;
                    }
                    break;

                case 2:

                    for (int i = 0; i < _verticalConstructionPlans.Count; i++)
                    {
                        if (i == 0 || i == 3)
                        {
                            _verticalConstructionPlans[i].Exists = false;
                        }
                        else
                        {
                            _verticalConstructionPlans[i].Exists = true;
                        }
                    }

                    for (int i = 0; i < _horizontalConstructionPlans.Count; i++)
                    {
                        _horizontalConstructionPlans[i].Exists = true;
                    }
                    break;
                case 3:

                    for (int i = 0; i < _verticalConstructionPlans.Count; i++)
                    {
                        if (i == 0 || i == 2)
                        {
                            _verticalConstructionPlans[i].Exists = false;
                        }
                        else
                        {
                            _verticalConstructionPlans[i].Exists = true;
                        }
                    }

                    for (int i = 0; i < _horizontalConstructionPlans.Count; i++)
                    {
                        _horizontalConstructionPlans[i].Exists = true;
                    }
                    break;

                case 4:

                    for (int i = 0; i < _verticalConstructionPlans.Count; i++)
                    {
                        if (i == 2)
                        {
                            _verticalConstructionPlans[i].Exists = false;
                        }
                        else
                        {
                            _verticalConstructionPlans[i].Exists = true;
                        }
                    }

                    for (int i = 0; i < _horizontalConstructionPlans.Count; i++)
                    {
                        _horizontalConstructionPlans[i].Exists = true;
                        if (i == 0 || i == 2)
                        {
                            _horizontalConstructionPlans[i].Exists = false;
                        }
                    }
                    break;

                case 5:

                    for (int i = 0; i < _verticalConstructionPlans.Count; i++)
                    {
                        if (i == 2 || i == 4 || i == 1)
                        {
                            _verticalConstructionPlans[i].Exists = false;
                        }
                        else
                        {
                            _verticalConstructionPlans[i].Exists = true;
                        }
                    }

                    for (int i = 0; i < _horizontalConstructionPlans.Count; i++)
                    {
                        _horizontalConstructionPlans[i].Exists = true;
                    }
                    break;              

                case 6:

                    for (int i = 0; i < _verticalConstructionPlans.Count; i++)
                    {
                        if (i == 1)
                        {
                            _verticalConstructionPlans[i].Exists = false;
                        }
                        else
                        {
                            _verticalConstructionPlans[i].Exists = true;
                        }
                    }

                    for (int i = 0; i < _horizontalConstructionPlans.Count; i++)
                    {
                        _horizontalConstructionPlans[i].Exists = true;
                    }
                    break;

                case 7:

                    for (int i = 0; i < _verticalConstructionPlans.Count; i++)
                    {
                        if (i == 0 || i == 2)
                        {
                            _verticalConstructionPlans[i].Exists = false;
                        }
                        else
                        {
                            _verticalConstructionPlans[i].Exists = true;
                        }
                    }

                    for (int i = 0; i < _horizontalConstructionPlans.Count; i++)
                    {
                        if (i == 1 || i == 2)
                        {
                            _horizontalConstructionPlans[i].Exists = false;
                        }
                        else
                        {
                            _horizontalConstructionPlans[i].Exists = true;
                        }
                    }
                break;

                case 8:

                    for (int i = 0; i < _verticalConstructionPlans.Count; i++)
                    {
                        _verticalConstructionPlans[i].Exists = true;
                    }

                    for (int i = 0; i < _horizontalConstructionPlans.Count; i++)
                    {

                        _horizontalConstructionPlans[i].Exists = true;

                    }
                    break;

                case 9:

                    for (int i = 0; i < _verticalConstructionPlans.Count; i++)
                    {
                        if (i == 2)
                        {
                            _verticalConstructionPlans[i].Exists = false;
                        }
                        else
                        {
                            _verticalConstructionPlans[i].Exists = true;
                        }
                    }

                    for (int i = 0; i < _horizontalConstructionPlans.Count; i++)
                    {
                        _horizontalConstructionPlans[i].Exists = true;
                    }
                    break;
            }

            return Tuple.Create(_verticalConstructionPlans, _horizontalConstructionPlans);

        }    
        }
    }

