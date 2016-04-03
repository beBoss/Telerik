namespace _15.Age
{
    using System;
    using System.Globalization;

    public class CalculateAge
    {
        public static void Main()
        {
            var birthDate = Console.ReadLine();
            var pattern = "MM.dd.yyyy";

            var parsedDate = DateTime.ParseExact(birthDate, pattern, CultureInfo.InvariantCulture);

            var today = DateTime.Now;
            var age = today.Year - parsedDate.Year;

            if (today < parsedDate.AddYears(age)) age--;

            Console.WriteLine(age);
            Console.WriteLine(age + 10);

        }
    }
}