// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel;
public class Program
{
    static void Main(string[]args)
    {
       int a = 1;
       int a_2 = new int();
       a_2 = 1;
       
       // how to declare(write) classes   
       // same way you would  declcare a variable...
       A exampleA = new A();
       exampleA.feild_a = 4;
      // exampleA.method_a();

       B exampleB = new B();
       exampleB.feild_b = 23;
       exampleB.method_b();
       exampleB.feild_a = 11;
       exampleB.method_a();

       C exampleC = new C();
       exampleC.feild_c = 444;
       exampleC.method_c();
       exampleB.feild_b = 333;
       exampleB.method_b();
       exampleA.feild_a = 222;
       exampleA.method_a();

       C2 exampleC2 = new C2();
       exampleC2.method_b();


       

       
       System.Console.WriteLine(exampleA.feild_a + " is the value of example 1");
       System.Console.WriteLine(exampleB.feild_b + " is the value of ex 2");
       System.Console.WriteLine(exampleB.feild_a + " is the value of ex 3");
       System.Console.WriteLine(exampleC.feild_c + " is the value of ex 4");





       
       
    }
}

public class A 
{
    public int feild_a;
    //protected void method_a()
     public virtual void method_a()
    {
        System.Console.WriteLine("this is method A");
    }

}

public abstract class B2 : A
{
    public int feild_b;

    public override void method_a()
    {
        System.Console.WriteLine("this is overriding method A from claass B");
    }
    public abstract void method_b();
    /*{
        System.Console.WriteLine("this is method B");
        //method_a();
    }*/



}    

public  class B : A
{
    public int feild_b;

    public  override void method_a()
    {
        System.Console.WriteLine("this is overriding method A from claass B");
    }
    public void method_b()
    {
        System.Console.WriteLine("this is method B");
        //method_a();
    }



}    
public class C : B
{

    public int feild_c;

    public void method_c()
    {
        System.Console.WriteLine("this is method C");
        
    }

    



    

} 

public class C2 : B2
{

    public int feild_c;

    public void method_c()
    {
        System.Console.WriteLine("this is method C");
        
    }

    public override void method_b()
    {
        System.Console.WriteLine("this is overriding method B of class B2 from class C2");
        //method_a();
    }
}    