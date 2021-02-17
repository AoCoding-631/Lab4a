using System;

class MainClass {
  public static void Main (string[] args) {
    

    int counter = 0;
    int totalSpeed = 0;

    while(counter < 7)
    {

    Console.WriteLine ("Enter distance covered by car 1");
    double distance = Convert.ToDouble(Console.ReadLine());
   
    Console.WriteLine("Enter time taken by car 1");
    double time = Convert.ToDouble(Console.ReadLine());

    double speed = distance / time;
    Console.WriteLine("The speed of the car is " + speed + " miles per hour.");

    totalSpeed = totalSpeed + (int)speed;//i used a tutor to help me with this assignment
    counter++;
    }

    int totalAverage = totalSpeed / 7;

    Console.WriteLine("The average speed of the cars is " + totalAverage + " miles per hour.");

  
  }
}
