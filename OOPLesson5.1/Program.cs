using OOPLesson5._1;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //פולימורפיזם - רב צורתיות 

            //ליצור מחלקה  person
            //prop firstname lastname

            //בנאי 
            //person
            //print

            //יורשת ממחלקה  person מחלקה סטודנטים
            //prop grades 

            //בנאי student 
            // print 

            Person person1 = new Person("yarin","yoav");
            Console.WriteLine(person1.GetString());

            Person person2 = new Students(30, "yarin", "yoav");
            Console.WriteLine(person2.GetString());// "yarin", "yoav", 30


            //Base ba1 = new Base();
            //Console.WriteLine(ba1.Print());//base
            //Base ba2 = new Derived();
            //Console.WriteLine(ba2.Print());//Derived
            //Base ba3 = new Test();
            //Console.WriteLine(ba3.Print());//base
        }

        class Base
        {
            public int x { get; set; }
            
            public virtual string Print() //פונקציה וירטואלית 
                                          //מגדירה את הפונקציה שנשתמש במקרים מסוימים ובמקרים מסויימים לא
            {
                return "base";
            }

        }
        

        class Derived : Base
        {
            public int Y { get; set; }
            public override  string Print() // override דורסת את הפונקציה מ ה base
            {
                return "Derived";
            }

        }

        class Test : Base
        {
            public string Print()
            {
                return "Test";
            }
        }
    }
}