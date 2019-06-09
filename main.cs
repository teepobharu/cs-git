using System;
using System.Collections;
using System.Collections.Generic;
using person;
using shapes;
using abShapes;
using house;
// using person.little;
namespace myapp
{
    class Program
    {

        static void WorkingWithInt()
        {
            double a = 1.8;
            double b = 1.0;
            double c = a + b;
            // Console.WriteLine(a);
            // Console.WriteLine(b);
            // Console.WriteLine($"Something { b / a}");
            // Type stringType = typeof(string);
            // Console.WriteLine($"Type {stringType.FullName}");
            // Console.WriteLine($"{(int)0.2}");
        }

        static int fibo(int x)
        {
            var sumList = new List<int> { 1, 1 };
            var previous = sumList[sumList.Count - 1];
            var twoPrevious = sumList[sumList.Count - 2];

            for (int count = 2; count < x; count++)
            {
                previous = sumList[sumList.Count - 1];
                twoPrevious = sumList[sumList.Count - 2];
                var sum = previous + twoPrevious;
                sumList.Add(sum);
                // Console.WriteLine(sum);
            }
            return sumList[x - 1];
        }

        static void Main(string[] args)
        {
            Console.WriteLine("FIBO: " + fibo(20));
            // List<int> newList = new List<int>();
            Console.WriteLine("=====PERSON====: ");
            Person<string> p = new Person<string>("somepersonname");
            p.Name = "ne.name";
            Console.WriteLine(p.child);
            p.child = 2;
            Console.WriteLine(p.child);
            Console.WriteLine("My age before: " + p.Age);
            p.Age = 2;
            Console.WriteLine("My age after: " + p.Age);
            Console.WriteLine("Person name from accessors: " + p.Name);
            p.Alert();
            Console.WriteLine("=====Shapes Inheritance + Abstract ====: ");
            aShape as1 = new aCircle("myshape");
            Shape s1 = new Circle();
            s1.Draw();
            as1.Draw();
            Console.WriteLine("=====Houses interface ====: ");
            House h1 = new House(200, "Db");
            h1.rent(0);
        }
    }
}


namespace outer
{
    class Testy
    {
        public void hi()
        {
            House h1 = new House(200, "db");
        }
    }
}
class Adjacent
{
    public void adjacentGo()
    {
        Console.WriteLine("ADjavcent");
    }
}
