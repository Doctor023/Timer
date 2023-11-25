using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test;

namespace Timer
{
    public class HorizontalConstructionPlan : IConstructionPlan
    {
        public bool Exists { get; set; }
        public int Left { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public HorizontalConstructionPlan() // for horizontal constructions
        {
        }
    }
}
