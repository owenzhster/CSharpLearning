using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning.autoFac
{
    class AutoFacSample
    {
        public static void outAllText()
        {
            var builder = new ContainerBuilder();
            var baseType = typeof(IOutText);
            // get all dlls in current appDomain
            var assemblies = AppDomain.CurrentDomain.GetAssemblies();

            // register all IOutText implemented classes
            builder.RegisterAssemblyTypes(assemblies.ToArray()).Where(t => baseType.IsAssignableFrom(t) && t != baseType).As<IOutText>();

            using (var container = builder.Build())
            {
                // get regestered classes from container
                var manager = container.Resolve<IEnumerable<IOutText>>();
                foreach (var m in manager)
                {
                    m.outText();
                }

            }
        }
    }
}
