using System;
using System.Globalization;

namespace Social_Security_Number
{
    class Program
    {
        public static void Main(string[] args)
        {
            string socialSecurityNumber;

            if (args.Length > 0)
            {
                // Social Security Number Input to Evaluate if Person is Male or Female
                Console.WriteLine($"You have provided Social Security Number {args[0]}");
                socialSecurityNumber = args[0];
            }
            else
            {
                Console.WriteLine("Enter Your Social Security Number in Format (YYMMDD-XXXX): ");
                socialSecurityNumber = Console.ReadLine();
            }

            // Variable named socialSecurityNumber with an argument of Console.ReadLine() method.

            string gender;

            int genderNumber = int.Parse(socialSecurityNumber.Substring(socialSecurityNumber.Length - 2, 1));

            bool isGender = genderNumber % 2 == 0;

            gender = isGender ? "Female" : "Male";

            DateTime birthDate = DateTime.ParseExact(socialSecurityNumber.Substring(0, 6), "yyMMdd", CultureInfo.InvariantCulture);

            int age = DateTime.Now.Year - birthDate.Year;

            if ((birthDate.Month > DateTime.Now.Month) || (birthDate.Month == DateTime.Now.Month && birthDate.Day > DateTime.Now.Day))
            {
                age--;
            }
            else
            {
                Console.WriteLine($"You are a {gender} at the age of {age}");
            }
        }
    }
}
