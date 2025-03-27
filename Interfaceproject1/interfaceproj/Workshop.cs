public class Workshop : IAction
{
    public void Jump()
    {
        Console.WriteLine("i am jumping");
    }

    public void Run()
    {
       Console.WriteLine("i am running");
    }

    public void Sit()
    {
        Console.WriteLine("i am sitting");
    }

    public void Stand()
    {
        Console.WriteLine("i am standing");
    }

    public void Walk()
    {
        Console.WriteLine("i am walking");
    }
}