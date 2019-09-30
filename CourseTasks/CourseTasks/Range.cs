﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseTasks
{
    class Range
    {
        public Range(double from, double to)
        {
            From = from;
            To = to;
        }

        public double From { get; set; }

        public double To { get; set; }

        public double GetLength()
        {
            return To - From;
        }

        public bool IsInside(double x)
        {
            return x >= From && x <= To;
        }
    }
}
