using System;
using CSharpLearning.type;
using CSharpLearning.operatorO;
using CSharpLearning.express;
using Autofac;
using CSharpLearning.file;
using System.Text;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using CSharpLearning.lambda;
using CSharpLearning.autoFac;

namespace CSharpLearning
{
    class MainClass
    {
        //public IOutText outText { get; set; }
        //private IOutText outText;

        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Hello C#!");
            Console.WriteLine("你好！");
            AutoFacSample.outAllText();


        }
    }
}
