namespace _01.Declare_Variables
{
    using System;

    public class DeclareVariables
    {
        public static void Main()
        {
            ushort numOne = 52130;
            sbyte numTwo = -115;
            int numThree = 4825932;
            byte numFour = 97;
            short numFive = -10000;

            Console.WriteLine("{0}, {1}, {2}, {3}, {4}", 
                numOne, numTwo, numThree, numFour, numFive);
        }
    }
}