using System;

class MainClass {
  public static void Main (string[] args) {
    
    Console.WriteLine ("Enter Temp in celsius");
    double tc = Convert.ToDouble
    (Console.ReadLine());
    
    double tf = (tc * 9/5) +32;

    Console.WriteLine("Temp in farenheit is" + tf);
}
}