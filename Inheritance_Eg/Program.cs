using Inheritance_Eg;
using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        DisplayResult dr = new DisplayResult();
        dr.ReadDigits();
        dr.FindSum();
        dr.Show();
    }
}
