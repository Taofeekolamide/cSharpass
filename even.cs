using System;

namespace Basics1
{
class even
    {
    public void Even()
    {   
       Console.Write("Check whether a number is even or odd:");
       Console.Write("Input an integer: ");
       int bar = Convert.ToInt32(Console.ReadLine());
       int rag = bar % 2;
       if (rag == 0)
       Console.WriteLine("is an even integer.");
       else
       Console.WriteLine("is an odd integer.");

    }
    }
}