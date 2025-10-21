using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Eg
{
    internal class Digits
    {
        protected int num1, num2;
        public void ReadDigits()
        {
            Console.Write("Enter num1: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter num2: ");
            num2 = Convert.ToInt32(Console.ReadLine());
        }
    }

    internal class  Calculate : Digits 
    {
        protected int sum = 0;
        public void FindSum()
        {
            int numb1 = num1;
            int numb2 = num2;
            sum = numb1 + numb2;
        }
    }

    internal class DisplayResult : Calculate
    {
        public void Show()
        {
            Console.WriteLine($"sum is : {sum}");
        }
    }
}
