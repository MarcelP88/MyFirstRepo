// See https://aka.ms/new-console-template for more information
/*using   System;
using System.Security.Cryptography.X509Certificates;
public class Program
{
    public static void Main(string[]args)
    {
         int[] points = new int[3];
        points = [1, 2 , 3];

        try{

        System.Console.WriteLine(points[0]);
        System.Console.WriteLine(points[6]);
       
        }catch(Exception)
        {
            System.Console.WriteLine("exception occured");
        }

          System.Console.WriteLine(points[1]);
          System.Console.WriteLine(points[2]);

        using (var r = new StreamReader(@"C:\Users\James Hill\Documents\exfile.txt"))
        {
            while (!r.EndOfStream)  
            {

                 Console.WriteLine(r.ReadLine());
            }
        }

    }

    
}
public class Car
{
    public static void e_Car(string[]args)
    {
        string[] e_Car = new string[4] {"BMW", "Audi", "Aston", "G wagon"};
        
        Console.WriteLine(e_Car[0]);
    }    

}
public class Top_speed : Car
{
    public static void t_Speed(int[]args)
    {
        int[] t_speed = new int[4];
        t_speed = [240, 220, 240, 160];
    }


}
public class Colors : Car
{
    public static void Car_c(string[]args)
    {
        string[] car_C = new string[4] {"Vanta Black", "Matte Black", "Army Green", "Goblin Green"};
        System.Console.WriteLine(car_C[0]);
         
    }
}*/

/*using System;
public class Sum
{
  public static void  SumArray(int[] arr)
   {
     int sum = 0;
     for (int i = 0; i < arr.Length; i++ )
      {
	    sum += arr[i];
      }
     Console.WriteLine("the total is "+ sum);
   } 
  public static void Main(string[]args)
   {
     int[] points = { 10, 20, 30, 40, 50 };
     SumArray(points);
   }  
}*/

//    chap 6 assignment 1 - 2

/*using System;

public class Program

{
    public static void Main()
    {
       Dog myDog = new Dog();
        myDog.Speak();
        myDog.ShowInfo();
    }
}
public class Animal
{
    public  void Speak()
    {
        System.Console.WriteLine("I'm barking");
    }
    protected void Describe()
    {
        System.Console.WriteLine("I,m a Big Dog");
    }

}

public class Dog : Animal
{
    public void Speak()
    {
        System.Console.WriteLine("Woof Woof");
    }

    public void ShowInfo()
    {
        Describe();
    }
}*/

// CHAP 6 - 3 & 4

using System;
using System.ComponentModel;

/*public class Vehicle
{
    public virtual void Move()
    {
        Console.WriteLine("BMW X6 I Drive series");
    }

}

public class Car : Vehicle
{
    public  sealed override void Move()
    {
        Console.WriteLine("Picture me Rolling");
    }   
}

public class SportsCar : Car
{
    public override void Move()
    {
        Console.WriteLine("BMW X6 I Drive series");       
    
    }
}
public class Program
{
    public static void Main()
    {
        Car myCar = new Car();
        myCar.Move();
    }
}*/

// Chap 6 - #5

/*public abstract class Shape
{
    public abstract int GetArea();
}

public class Rectangle : Shape
{
    public int Width { get; set; }
    public int Height { get; set; }

    public override int GetArea()
    {
        return Width * Height;
    }
}

public class Program
{
    public static void Main()
    {
        Rectangle myRec = new Rectangle { Width = 5, Height = 10 };
        int area = myRec.GetArea();
        Console.WriteLine("The area of is " + area); 
    }
}*/


public interface ICalculator
{
    int Add(int a, int b);
}

public class SimpleCalculator : ICalculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }
}

public class Program 
{
    public static void Main()
    {
        ICalculator calculator = new SimpleCalculator();
        int result = calculator.Add(5, 3);
        System.Console.WriteLine("The Answer is: " + result);
    }
}





    
        