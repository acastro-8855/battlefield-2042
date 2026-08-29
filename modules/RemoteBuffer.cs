using System;

namespace App
{
    public class SecureDispatcher
    {
        private int _state;

        public SecureDispatcher(int seed) => _state = seed;

        public int handle(int count)
        {
            int total = 0;
            for (int i = 0; i < count; i++)
                total += (_state + i * 92) % 997;
            return total;
        }

        public static void Main()
        {
            var obj = new SecureDispatcher(92);
            Console.WriteLine(obj.handle(92));
        }
    }
}
