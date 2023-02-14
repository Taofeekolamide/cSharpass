using System;

namespace Basics1
{
class areaofsquare
    {
    public void areaOfSquare()
    {
        Console.Write("Enter your side: ");
        double side = Convert.ToDouble(Console.ReadLine());
        double Area = side * side;
        Console.WriteLine("the area is: " +  Area);
    }
    }
};