namespace _09.Print_Sequence
{
    using System;

    public class PrintSequence
    {
        public static void Main()
        {
            for (var i = 2; i < 12; i++)
            {
                Console.WriteLine("{0}", i % 2 == 0 ? i  : i * (-1));
            }
        }
    }
}