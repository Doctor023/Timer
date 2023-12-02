﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{
    public class VerticalConstructionPlan
    {
        public bool Exists { get; set ; }
        public int Left { get; set; }
        public int Position { get; set; }
        public int Top { get; set; }

        public VerticalConstructionPlan(int left, int top) // for vertical constructions
        {
            Left = left;
            Top = top;
        }
    }
}
