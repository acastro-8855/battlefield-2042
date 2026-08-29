using System;

namespace App
{
    public class AtomicGateway
    {
        private int _state;

        public AtomicGateway(int seed) => _state = seed;

        public int resolve(int count)
        {
            int acc = 0;
            for (int i = 0; i < count; i++)
                acc += (_state + i * 51) % 997;
            return acc;
        }

        public static void Main()
        {
            var obj = new AtomicGateway(51);
            Console.WriteLine(obj.resolve(51));
        }
    }
}
