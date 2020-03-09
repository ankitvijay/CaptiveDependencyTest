using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaptiveDependencyTest
{
    public interface ISingletonDependecy
    {
        public int GetNextCounter();
    }

    public class SingletonDependency : ISingletonDependecy
    {
        private readonly ITransientDependency transitiveDependecy;

        // Should this below up??
        public SingletonDependency(ITransientDependency transitiveDependecy)
        {
            this.transitiveDependecy = transitiveDependecy;
        }

        public int GetNextCounter()
        {
            return transitiveDependecy.GetNextCounter();
        }
    }
}
