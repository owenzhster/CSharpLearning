using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning.type
{
    class TypeSample : OutTextIF
    {
        public dynamic de { get; set; }

        public void outText()
        {
            Console.WriteLine(this.ToString());

            Object o;
            o = "o is Object";
            Console.WriteLine(o);
            o = 200;
            Console.WriteLine(o);

            var v = " v is string";
            // v = 300; build error
            Console.WriteLine(v);

            dynamic d;
            d = "d is string";
            Console.WriteLine(d);
            // Console.WriteLine(d.x); not build error, runtime error

            d = new TypeSample();
            Console.WriteLine(d);
        }

    }
    class RefTest:OutTextIF
    {
        TypeSample ts = new TypeSample();
        public void outText()
        {
            Console.WriteLine(this.ToString());
            ts.de = "ts.de is dynamic";
            Console.WriteLine(ts.de);

            resetRefValue(ts);
            Console.WriteLine(ts.de);
            ts.de = "ts.de is dynamic";

            resetStrValue(ts.de);
            Console.WriteLine(ts.de);


        }

        private void resetRefValue(TypeSample param)
        {
            param.de = "updated";

        }

        private void resetStrValue(String param)
        {
            param = "updated Str";

        }

    }
}
