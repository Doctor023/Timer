using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test;

namespace Timer
{
    public class VerticalConstructionPlan : IConstructionPlan
    {
        public bool Exists { get; set ; }
        public int Left { get; set; }

        public VerticalConstructionPlan(int left) // for vertical constructions
        {
            Left = left;
        }
    }
}
