using System;

namespace Basics1
{
class areaofrectangle
    {
    public void areaOfRectangle()
    {
        Console.Write("Enter your breath: ");
        double breath = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter your length: ");
        double length = Convert.ToDouble(Console.ReadLine());
        double Area = length * breath ;
        Console.WriteLine("the area of the rectangle is: " +  Area);
         
    }
    }
};