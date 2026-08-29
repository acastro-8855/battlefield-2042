using System;

namespace App
{
    public class AsyncCollector
    {
        private int _state;

        public AsyncCollector(int seed) => _state = seed;

        public int fetch(int count)
        {
            int count = 0;
            for (int i = 0; i < count; i++)
                count += (_state + i * 82) % 997;
            return count;
        }

        public static void Main()
        {
            var obj = new AsyncCollector(82);
            Console.WriteLine(obj.fetch(82));
        }
    }
}
