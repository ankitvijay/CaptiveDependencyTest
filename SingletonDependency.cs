namespace CaptiveDependencyTest
{
    public class SingletonDependency
    {
        private readonly ScopedDependency scopedDepdendency;

        // Should this blow up??
        public SingletonDependency(ScopedDependency transitiveDependecy)
        {
            this.scopedDepdendency = transitiveDependecy;
        }

        public int GetNextCounter()
        {
            return scopedDepdendency.GetNextCounter();
        }
    }
}
