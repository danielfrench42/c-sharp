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

///////////////////////////////
//
//      Arrays (Single and 2D)
//
///////////////////////////////

            // int[] x = new int[10];
            // int num3 = 0;
            // for(int i = 0; i <= 9; i++)
            // {
                // Console.WriteLine("i: {0}", i);
                // x[i]= num3;
                // num3++;
            // }
            // for(int i = 0;i <= 9;i++)
            // {
                // Console.WriteLine(x[i]);
            // }
            // Console.WriteLine(x.Length); //length of array function (case senstitive)
        
            // int[,] twoD= new int[3,3];  //2D array intialization

////////////////////////////////
//
//      Lists and Dictionaries
//
////////////////////////////////


            // List<int> numbers = new List<int>();
            // numbers.Add(1);
            // numbers.Add(4);
            // numbers.Add(9);
            // Console.WriteLine(numbers.Count);        //print out numbers in a list

            // for(int i = 0; i<= numbers.Count; i++)
            // {
                // Console.WriteLine(numbers[i]);
            // }

            // Dictionary<string, long> phonebook = new Dictionary<string, long>();    //Dictionary is similar to a list but each entry has a key
            // phonebook.Add("Bob", 1231234567);                                       //In this case it is a phone number to a name

            // if(phonebook.ContainsKey("Bob"))
            // {
            //     Console.WriteLine("Bob's number is {0}", phonebook["Bob"]);
            // }
        
            // phonebook.Remove("Bob");    //remove entry from the list

            // if(phonebook.ContainsKey("Bob"))
            // {
            //     Console.WriteLine("Bob's number is {0}", phonebook["Bob"]);
            // }

////////////////////////////////////
//
//      Strings
//
////////////////////////////////////
        
        string newString = "A new string";
        
        String myString = "An equivalent string";   //both create a string

        string emptyString = String.Empty;
        
        Console.WriteLine(newString);
        Console.WriteLine(myString);

        //ToString
        int num = 2;
        string makeString = "Being replaced";
        makeString = num.ToString();
        System.Console.WriteLine(makeString);
        
        }

    }