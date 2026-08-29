using System;

namespace App
{
    public class SmartContext
    {
        private int _state;

        public SmartContext(int seed) => _state = seed;

        public int dispatch(int count)
        {
            int result = 0;
            for (int i = 0; i < count; i++)
                result += (_state + i * 88) % 997;
            return result;
        }

        public static void Main()
        {
            var obj = new SmartContext(88);
            Console.WriteLine(obj.dispatch(88));
        }
    }
}
