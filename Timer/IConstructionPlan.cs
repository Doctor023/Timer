using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public interface IConstructionPlan
    {
        public bool Exists { get; set; }
        public int Left { get; set; }
    }
}