using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Inheritance_Eg
{
    internal class ReadNumber
    {
        protected int[] numArray;
        public void ReadNum(int size)
        {
            numArray = new int[size];  
            for( int i = 0; i < size; i++)
            {
                numArray[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public int[] GetNumber()
        {
            return numArray;
        }

        public void SetNumber(int[] number)
        {
            numArray = number;
        }
    }

    internal class Sum : ReadNumber
    {
        public int FindSum()
        {
            int sum = 0;
            foreach (int i in numArray)
            {
                sum += i;
            }
            return sum;
        }
    }

    internal class Avg : ReadNumber
    {
        public double FindAvg()
        {
            int sum = 0;
            foreach (int i in numArray)
            {
                sum += i;   
            }
            return (double)sum / numArray.Length;
        }
    }
}
