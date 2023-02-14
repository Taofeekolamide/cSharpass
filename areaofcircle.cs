 using System;

namespace Basics1
{
class areaofcircle
{
    public void areaOfCircle()
    {
        Console.Write("Enter Radius: ");
        double rad = Convert.ToDouble(Console.ReadLine());
        double area = Math.PI * rad * rad;
        Console.WriteLine("Area of circle is: " + area);
    }
}
};