using System;

class MainClass {
  public static void Main (string[] args) {
   for(int counter = 0; counter<5;counter++)
   {
     Console.WriteLine("What is your name?");
     string name = Console.ReadLine();
     Console.WriteLine("What is your height in inches?");
     int height = Convert.ToInt32(Console.ReadLine());
     Console.WriteLine("What is your weight in pounds?");
     int pounds = Convert.ToInt32(Console.ReadLine());
     double BMI = (703 * pounds) / (height * height);
     Console.WriteLine("Your BMI is " + BMI);
     if(BMI < 18.5)
     {
       Console.WriteLine(name + " is underweight.");
     }
     if(18.5 <= BMI && BMI <= 24.9)
     {
       Console.WriteLine(name + " is normal weight.");
     }
     if(25 <= BMI && BMI <= 29.9)
     {
       Console.WriteLine(name + " is overweight.");
     }
     if(30 <= BMI)
     {
       Console.WriteLine(name + " is obese.");
     }
   }
  }
}