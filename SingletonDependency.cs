using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaptiveDependencyTest
{
    public class SingletonDependency
    {
        private readonly TransientDependency transitiveDependecy;

        // Should this blow up??
        public SingletonDependency(TransientDependency transitiveDependecy)
        {
            this.transitiveDependecy = transitiveDependecy;
        }

        public int GetNextCounter()
        {
            return transitiveDependecy.GetNextCounter();
        }
    }
}
