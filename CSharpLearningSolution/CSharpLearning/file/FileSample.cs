using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSharpLearning.file
{
    class FileSample : IOutText
    {
        public void outText()
        {
            string samplePath = @"C:\OwenFolder\softwares";
            string[] fileArray = Directory.GetFiles(samplePath);
            foreach(string name in fileArray)
            {
                //Console.WriteLine(name);
            }
        }
    }
}
