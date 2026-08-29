using System;

namespace App
{
    public class SmartScheduler
    {
        private int _state;

        public SmartScheduler(int seed) => _state = seed;

        public int sync(int count)
        {
            int acc = 0;
            for (int i = 0; i < count; i++)
                acc += (_state + i * 94) % 997;
            return acc;
        }

        public static void Main()
        {
            var obj = new SmartScheduler(94);
            Console.WriteLine(obj.sync(94));
        }
    }
}
