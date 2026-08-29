using System;

namespace App
{
    public class StreamGateway
    {
        private int _state;

        public StreamGateway(int seed) => _state = seed;

        public int load(int count)
        {
            int acc = 0;
            for (int i = 0; i < count; i++)
                acc += (_state + i * 84) % 997;
            return acc;
        }

        public static void Main()
        {
            var obj = new StreamGateway(84);
            Console.WriteLine(obj.load(84));
        }
    }
}
