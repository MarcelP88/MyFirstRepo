// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//using System;
//using System.Net.Security;
//public class MyType
//{
//    public static void Main()
//    {
//        Console.WriteLine("Hello, World!");
//    } 
//}
//string part1 = "the ultimate question";
//string theanswerng part2 = "of something";
//int theAnswer = 42;
//int andAnotherthing;
//part2 = "of"life, the universe, and everything";

//using System.Net.Security;

//Console.WriteLine("Hello" + "World");
//Console.WriteLine(12 + 30);
//Math.Sqrt(4);
/*int i = 42;
double di = i;
Console.WriteLine(i / 5);
Console.WriteLine(di / 5);
Console.WriteLine(i / 5.0);*/
//Concat("Hello", "World");
/*char[] chars = ['c', 'a', 'f', 'e', (char) 0x302, 's'];
string text = new string(chars);
Console.WriteLine(chars[4]);*/

//string concatanation

/*string firstName = "max";
string lastName = "chris";
string fullName = firstName + " " + lastName;
Console.WriteLine(fullName);

//string interpolation

string fullName2 = $"{firstName} {lastName}";
Console.WriteLine(fullName2);*/

//int Variable

/*int number = 10;
Console.WriteLine(number);
number = number + 1;
Console.WriteLine(number);
number++;
Console.WriteLine(number);
number--;
Console.WriteLine(number);
number--;
Console.WriteLine(number);
number = number + 10;
Console.WriteLine(number);
number = number - 5;
Console.WriteLine(number);
number += 15;
Console.WriteLine(number);
number -= 15;
Console.WriteLine(number);
//post fix and pre increment and decrement operators
int number2 = 8;
int number3 = 0;
number3 = number2 + number;
Console.WriteLine(number3);
number3 = number2 + number++;
Console.WriteLine(number3);
Console.WriteLine(number2 + number);
Console.WriteLine(number2 +  ++number);

//relational operators

if (number2 >= number)
Console.WriteLine("left number is bigger");
else
Console.WriteLine("right number is bigger");

//conditional operator
string outcome = (number2 >= number) ? "left number is bigger" : "right number is bigger";
Console.WriteLine(outcome);*/

// nested if statement
/*Console.WriteLine("enter a number for temperture");
int temperatureInCelsius = Convert.ToInt32(Console.ReadLine());
if (temperatureInCelsius < 52)
{
    Console.WriteLine("Too cold");
}
else if (temperatureInCelsius > 58)
{
    Console.WriteLine("Too hot");
}
else
{
    Console.WriteLine("Just right");
}*/

// code practice variables

/*using System;
public class Program
{
    public static void Main(string[] args)
    {
    string name = "Marcel the Great";
    name = "sky walker";

    Console.WriteLine(name);

    }
}*/


/*using System;
public class Program
{
    public static void Main(string[] args)
    {
        float height =(float)2.22;
        decimal weight =(decimal) 44.44;
        Console.WriteLine(height);
        Console.WriteLine(weight);
    }    

}*/


//switch statement

/*using System;
using System.Transactions;
public class Program
{
    public static void Main(string[] args)
    {
    
            Console.WriteLine("Enter a number between 1 and 15");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number > 0 && number < 6)
        {
            Console.WriteLine("the number is in the 1 to 5 range");
        }
        else if (number > 5 && number < 11)
        {
            Console.WriteLine("the number is in the 6 to 10 range");
        }
        else if (number > 10 && number < 16)
        {
             Console.WriteLine("the number is between 10 and 15 range");
        }
    }   

}    */

/*using System;
public class Program
{
    public static void Main(string[] args)
    {    
         Console.WriteLine("Enter a number between 1 and 15");
         int number = Convert.ToInt32(Console.ReadLine());
         switch (number)
         {
            case 1:
            case 2:
            case 3:
            case 4:
            case 5:
            Console.WriteLine("the number is in the 1 to 5 range");
            break;


            case 6:
            case 7:
            case 8:
            case 9:
            case 10:
            Console.WriteLine("the number is in the 6 to 10 range");
            break;

            case 11:
            case 12:
            case 13:
            case 14:
            case 15:
            default:
            Console.WriteLine("the number is between 10 and 15 range");
            break;
         }
        

    }

}*/

// loops 


using System;
public class Program
{

    public static void Main(string[] args)
    {
        char[] letters = { 'a', 'b', 'c', 'd'};
   //            Console.WriteLine(letters[0]);

      //        for (int i = 0; i < letters.Length; i++)

     //     {
       //       Console.Write(letters[i]+ "      ");

       //   }
    //          Console.WriteLine(letters[0].ToString()+" "+ letters[1].ToString()+"  " + letters[2].ToString() + letters[3].ToString() );

     /*          int i = 0;
                while (i < letters.Length)

            {
                Console.WriteLine(letters[i]);
                    i++;
            }*/

                     foreach (char c in letters)
             {
                Console.WriteLine(c);
             }
            

    }
}




