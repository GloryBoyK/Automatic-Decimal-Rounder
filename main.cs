using System;

class Program {
  public static void Main (string[] args) {

    //The decimal you want to round
    double yourDecimal=8.6;

    //The final product
    int roundedInteger=Convert.ToInt32(yourDecimal);

    Console.WriteLine("Your original decimal is: "+yourDecimal);
    Console.Write("Your decimal rounded as an interger is: "+roundedInteger);
  }
}