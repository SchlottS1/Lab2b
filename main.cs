using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter a number:"); 
    double num1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine ("Enter another number:");
    double num2 = Convert.ToDouble(Console.ReadLine());
    double sum = num1 + num2;
    double diff = Math.Abs(num2 - num1);
    double product = num1 * num2;
    double quotient = num1 / num2;
    double remainder = num1 % num2;
    Console.WriteLine("Sum = " + sum);
    Console.WriteLine("Diff = " + diff);
    Console.WriteLine("Product = " + product);
    Console.WriteLine("Quotient = " + quotient);
    Console.WriteLine("Remainder = " + remainder);
  }
}