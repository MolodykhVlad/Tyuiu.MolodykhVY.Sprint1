using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MolodykhVY.Sprint1.Task6.V11.Lib
{
    public class DataService : ISprint1Task6V11
    {
        public bool CheckeFirstLetterRepetition(string value)
        {
            DataService ds = new DataService();
            char firstLetter = value[0];
            bool containsFirstLetter = value.Substring(1).Contains(firstLetter);
            return containsFirstLetter;

        }
    }
}
