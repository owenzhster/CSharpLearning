using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning.operatorO
{
    class OperatorOveride : IOutText
    {
        public void outText()
        {
            Box a = new Box();
            a.h = 1;
            a.l = 2;
            Box b = new Box();
            b.h = 3;
            b.l = 4;

            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
        }
    }

    class Box
    {
        public int h { get; set; }
        public int l { get; set; }

        public static Box operator +(Box a, Box b)
        {
            Box r = new Box();
            r.h = a.h + b.h;
            r.l = a.l + b.l;
            return r;
        }
        public static Box operator -(Box a, Box b)
        {
            Box r = new Box();
            r.h = a.h - b.h;
            r.l = a.l - b.l;
            return r;
        }

        public override string ToString()
        {
            return "h:" + h + ", l:" + l;
        }

    }
}
