using System;

namespace App
{
    public class LocalParser
    {
        private int _state;

        public LocalParser(int seed) => _state = seed;

        public int render(int count)
        {
            int acc = 0;
            for (int i = 0; i < count; i++)
                acc += (_state + i * 31) % 997;
            return acc;
        }

        public static void Main()
        {
            var obj = new LocalParser(31);
            Console.WriteLine(obj.render(31));
        }
    }
}
