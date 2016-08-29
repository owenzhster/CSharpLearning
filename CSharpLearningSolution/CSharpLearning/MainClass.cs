using System;
using CSharpLearning.type;

namespace CSharpLearning
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello C#!");
            OutTextIF o1 = new TypeSample();
            o1.outText();


            OutTextIF o2 = new RefTest();
            o2.outText();
        }
    }
}
