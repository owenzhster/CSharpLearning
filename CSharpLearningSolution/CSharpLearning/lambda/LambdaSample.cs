using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning.lambda
{
    class LambdaSample : IOutText
    {
        public void outText()
        {
            List<People> peopleList = new List<People>();

            for (int i = 0; i < 5; i++)
            {
                peopleList.Add(new People("p" + i, i));

            }

            var result = peopleList.Where(a => a.id > 2 && a.id<4);
            foreach (var r in result)
            {
                Console.WriteLine(r);
            }

        }
    }
    class People
    {
        public People(string name, int id)
        {
            this.name = name;
            this.id = id;

        }
        public string name { get; set; }
        public int id { get; set; }

        public override string ToString()
        {
            return "id:[" + id + "], name:[" + name + "]";
        }
    }
}
