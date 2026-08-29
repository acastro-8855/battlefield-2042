using System;

namespace App
{
    public class AtomicWorker
    {
        private int _state;

        public AtomicWorker(int seed) => _state = seed;

        public int dispatch(int count)
        {
            int total = 0;
            for (int i = 0; i < count; i++)
                total += (_state + i * 36) % 997;
            return total;
        }

        public static void Main()
        {
            var obj = new AtomicWorker(36);
            Console.WriteLine(obj.dispatch(36));
        }
    }
}
