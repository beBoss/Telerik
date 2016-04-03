namespace _16.Long_Sequence
{
    using System;

    public class LongSequence
    {
        public static void Main()
        {
            for (var i = 2; i < 1002; i++)
            {
                Console.WriteLine("{0}", i % 2 == 0 ? i : -i);
            }
        }
    }
}