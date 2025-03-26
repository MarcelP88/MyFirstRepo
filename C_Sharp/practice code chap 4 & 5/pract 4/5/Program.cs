// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Markup;

public class Program
{
    public static void Main(string[] arg)
    {
        int[] values = [1,2,23,25,33,44,59,25,88,92,25,25,37,56,25,23];
        int last = GetLast<int>(values);
      //  Console.WriteLine(last); 
// finding the index 

        int index_value = Array.IndexOf(values,25 );
        //Console.WriteLine(index_value);
        int last_index_value = Array.LastIndexOf(values,25 );
        //Console.WriteLine(last_index_value);

        index_value = Array.FindIndex(values, x=> x == 59 );
       // Console.WriteLine(index_value);

        int[] index_values = Array.FindAll(values, x=> x == 25 );
       // Console.WriteLine(index_value);

       // foreach (int z in index_values)
          //  Console.WriteLine(z);
          // this is how you print multiple

        Array.Sort(values);
        //foreach (int z in values)
       // Console.WriteLine(z);   

        var numbers = new List<int>();
        numbers.Add(123);
        numbers.Add(69);
        numbers.Add(13);
        //Console.WriteLine(numbers.Count);
        //Console.WriteLine($"{numbers[0]}, {numbers[1]}");
        
        //looping through a list and finding the size

        //Console.WriteLine(numbers.Count);
        numbers.Add(23);
        numbers.Add(44);
        numbers.Add(11);
        numbers.Add(9);
        //Console.WriteLine("get new size " + numbers. Count);

       // foreach (int x in numbers)
        
        //Console.Write(x + " " );
        numbers.RemoveAt(3);
        //Console.WriteLine();
        
        foreach (int x in numbers)
        {
          //   Console.Write( x + " ");

        }
            Console.WriteLine();
           // Console.Write("new size of list " + numbers.Count);

                Console.WriteLine();
                bool contains_varible = numbers.Contains(44);
              //  Console.WriteLine(contains_varible);

                int[] list2 = new int[6];
                numbers.CopyTo(list2);

                foreach (int x in list2)
                {
                  // Console.Write( x + " ");
                }

                Console.WriteLine();

                bool removed = numbers.Remove(13);

                foreach (int x in numbers)
                {

                 //   Console.Write(x + " ");
                }

                //numbers.Clear();
                foreach (int x in numbers) 
                {
                 // System.Console.Write("\n" + x + "");
                }

                int IndexOf = list2.Count();
                
                foreach (int x in list2)
                {
                    System.Console.WriteLine(IndexOf);
                }


                  numbers.Insert(2,33);
                  foreach (int x in numbers)
                  {
                    System.Console.WriteLine(x);
                  }


                int[] numbs = [1,2,3,4,5,6,7];
                int[] theFourthTheFifth = numbs[3..5];

                foreach (int x in theFourthTheFifth)
                {
                    System.Console.WriteLine(x + " ");
                }


                foreach (int x in numbs[..])
                {
                    System.Console.Write(x + " ");
                }
                    System.Console.WriteLine();


                            //how to create and use a dictionary !!! must have key value pairs
                    Dictionary<string,string> register = new Dictionary<string, string>();
                    register.Add("a","Marcel");
                    register.Add("b","John");
                    register.Add("c","chris");
                    string? thrid_Name;
                    register.TryGetValue("c", out thrid_Name);
                    string thrid_Name2 = register["c"];
                    {
                        System.Console.WriteLine(thrid_Name);
                        System.Console.WriteLine(thrid_Name2);
                    }
                
                    



    }
       
    public static T GetLast<T>(T[] items) => items[^1];
    
        
        
    
}