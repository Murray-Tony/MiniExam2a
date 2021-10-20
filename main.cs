using System;

class Program {
  public static double CylinderVolume(double num1, double num2)
  {
    double Volume = (3.14 * num1 * num1 * num2);
    return Volume;
  }

  public static void Main (string[] args) {
    Console.WriteLine ("Please provide radius of cylinder:");
    double rad = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Please provide height of cylinder:");
    double hght = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("The volume of the cylinder is: " + CylinderVolume(rad, hght));
  }
}