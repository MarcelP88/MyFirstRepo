// 3-1 classes
// feilds , methods , constructors
using System;


public static class CounterWithTotal
    {
        private static int _count;
        private static int _totalCount;

        public static int GetNextValue()
        {
            _count += 1;
            _totalCount += 1;
            return _count;
        }
        private static int TotalCount=> _totalCount;
    }

public  class Program
{
     static void Main(string[] args)
    {
     /*   Counter counter= new Counter();
        Console.WriteLine($"counter: {counter.GetNextValue()}");
        
        Counter counter1= new Counter(5);
        Console.WriteLine($"counter: {counter1.GetNextValue()}");*/

        Counter mycount = new Counter();
        Console.WriteLine(mycount.GetNextValue());

        Counter countup = new Counter(44);
        Console.WriteLine(countup.GetNextValue());


        //int val = CounterWithTotal.GetNextValue();

    }

}

public class Counter
{
    private int _count;
    private int _x;
    public int GetNextValue()
    {
        _count += 1;
        return _count;
    }
    public Counter(){}
    public Counter(int count)
    {
        _count += count;
        
    }   
    
    public Counter(int count, int x)
    {
        _count += count*10;
        _x = --x;
    }






    
}