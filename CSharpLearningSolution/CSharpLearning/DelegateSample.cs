using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning
{
    class DelegateSample : IOutText
    {
        public delegate string printMessageHandler(string message);
        public void outText()
        {
            
        }
        private string printMessage()
        {
            return "";
        }
    }
}
