﻿namespace FixingVol2
{
    using System;
  public  class Program
    {
      public  static void Main(string[] args)
        {
            int num1, num2;
            byte result;

            num1 = 30;
            num2 = 60;
            try
            {
                result = Convert.ToByte(num1 * num2);
                Console.WriteLine($"{num1} x {num2} = {result}");
                Console.ReadLine();
            }
            catch (Exception)
            {
                throw new ArgumentException("Values are out of range!");
            }
            
        }
    }
}
