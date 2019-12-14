using System;
using System.Collections.Generic; //for lists

namespace c_
{
    class Program
    {
        public static void display()
        {
            Console.WriteLine("Hello World!");
        }
    }
}


    class second
    {
        public static void Main(String []args)
        {
            // int num1 = 5;
            // c_.Program.display(); //function call using the namespace.class.function
            // Console.WriteLine(num1+2);  //printing a variable and adding
          
            // Random rnd = new Random();  //setting up for random int
            // int num2 = rnd.Next(1,11);
            // Console.WriteLine(num2);

            int[] x = new int[10];
            int num3 = 0;
            for(int i = 0; i <= 9; i++)
            {
                // Console.WriteLine("i: {0}", i);
                x[i]= num3;
                num3++;
            }
            // for(int i = 0;i <= 9;i++)
            // {
                // Console.WriteLine(x[i]);
            // }
            // Console.WriteLine(x.Length); //length of array function (case senstitive)
        
            int[,] twoD= new int[3,3];  //2D array intialization

            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(4);
            numbers.Add(9);
            Console.WriteLine(numbers.Count);
            // for(int i = 0; i<= numbers.Count; i++)
            // {
                // Console.WriteLine(numbers[i]);
            // }
        
        }

    }