using System;
using System.Collections;
public class TriangleType

    

{
    static void Main(string[] args)
    {
        Console.Write("Enter the length of the first side: ");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the length of the second side: ");
        double side2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the length of the third side: ");
        double side3 = Convert.ToDouble(Console.ReadLine());
 
        if (side1 == side2 && side2 == side3)
        {
            Console.WriteLine("Equilateral");
        }
        else if (side1 == side2 || side1 == side3 || side2 == side3)
        {
             Console.WriteLine("Isosceles");
        }
        else
        {
             Console.WriteLine("Scalene");
        }
    }
}