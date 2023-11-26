using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class BMI
{
    static void Main(string[] args)
    {
        double a, b, c;
        Console.Write("Wpisz swoja wage (kg): ");
        a = double.Parse(Console.ReadLine());
        Console.Write("Wpisz swoj wzrost (m): ");
        b = double.Parse(Console.ReadLine());
        c = (a / (b*b));
        Console.WriteLine("Twoje BMI : {0}", c);
      
        Console.ReadLine();

    }
}