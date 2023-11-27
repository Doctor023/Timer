using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test;

namespace Timer
{
    public class HorizontalConstructionPlan
    {
        public bool Exists { get; set; }
        public int Top { get; set; }

        public HorizontalConstructionPlan(int top) // for horizontal constructions
        {
            Top = top;
        }
    }
}
