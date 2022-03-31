// Cristiano
// ICS2O-Unit3-02-CSharp
// March 31 2022

using System;

class Program
{
    public static void Main(string[] args)
    {
        float length;
        float width;
        float height;
        float answer;
        Console.WriteLine("Enter length of pyramid (cm):");
        length = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Enter width of pyramid (cm):");
        width = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Enter height of pyramid (cm):");
        height = Convert.ToSingle(Console.ReadLine());
        answer = (length * width * height) / 3;
        Console.WriteLine("\nThe volume of the pyramid is " + answer + "cm³");
        Console.WriteLine("\nFinished.");
    }
}
