

using ConsoleApp1.Models;

public class Program
{
    public delegate string InfoDelegate();
    public static void Main(string[] args)
    {
        ClassA a1= new ClassA();
        ClassA a2 = new ClassA();
        ClassB b1= new ClassB();
        ClassB b2= new ClassB();
        ClassB b3= new ClassB();

        InfoDelegate classADelegate = new InfoDelegate(ClassA.GetInstanceCount);
        InfoDelegate classBDelegate = new InfoDelegate(ClassB.GetInstanceInfo);

        Console.WriteLine("test:");
        Console.WriteLine(classADelegate.Invoke());
        Console.WriteLine(classBDelegate.Invoke());
    }
}