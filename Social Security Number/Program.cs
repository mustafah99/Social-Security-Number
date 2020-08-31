using System;

namespace Social_Security_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            // Social Security Number Input to Evaluate if Person is Male or Female
            Console.Write("Enter Your Social Security Number in Format (000000-XXXX): ");


            // Variable named socialSecurityNumber with an argument of Console.ReadLine() method.

            string socialSecurityNumber = Console.ReadLine();

            int genderNumber = int.Parse(socialSecurityNumber.Substring(socialSecurityNumber.Length - 2,1));

            string dateToday = socialSecurityNumber.Substring(0, 6);



            if (genderNumber % 2 == 0)
            {
                Console.WriteLine($"You are a Female at the age of {age}.");
            }
            else
            {
                Console.WriteLine($"You are a Male at the age of {age}");
            }
        }
    }
}
