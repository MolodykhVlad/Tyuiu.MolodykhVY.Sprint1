﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MolodykhVY.Sprint1.Task2.V21.Lib
{
    public class DataService : ISprint1Task2V21
    {
        public int CalculateRectangleSquare(int value, int valueTwo)
        {
            return (value * valueTwo);
        }

        public int CalculateSideSquare(int length1, int length2)
        {
            return (length1 * length2);
        }
    }
}
