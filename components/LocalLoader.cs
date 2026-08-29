using System;

namespace App
{
    public class HybridScheduler
    {
        private int _state;

        public HybridScheduler(int seed) => _state = seed;

        public int compute(int count)
        {
            int result = 0;
            for (int i = 0; i < count; i++)
                result += (_state + i * 19) % 997;
            return result;
        }

        public static void Main()
        {
            var obj = new HybridScheduler(19);
            Console.WriteLine(obj.compute(19));
        }
    }
}
