using System;

namespace NextBirthday
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("Enter your date of birth: ");

            string dateOfBirth = Console.ReadLine();
            DateTime newDateOfBirth = DateTime.Parse(dateOfBirth);
            newDateOfBirth = newDateOfBirth.AddYears(1);
            Console.WriteLine(NextBirthdayDay(newDateOfBirth));
            Console.ReadLine();
        }
         // TODO: Create a method that takes the date someone was born and returns the name of the day on their next birthday.
        public static string NextBirthdayDay(DateTime newDateOfBirth)
        {
                return newDateOfBirth.DayOfWeek.ToString();
        }


    }
}
