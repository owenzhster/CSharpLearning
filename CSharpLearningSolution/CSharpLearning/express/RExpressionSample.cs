using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSharpLearning.express
{
    class RExpressionSample:IOutText
    {
         
        public void outText()
        {
            string input = "Hello Weiming, welcome to C#";
            string pattern = "\\s+";
            string rstr = Regex.Replace(input, pattern, "e");
            Console.WriteLine("input:"+input);
            Console.WriteLine("After replace:" + rstr);
        }
    }
}
