using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab_7
{
    class Program
    {
        static void Main(string[] args)
        {
            UserName();
            Email();
            PhoneNumber();
            Date();

            Console.WriteLine("All of your Information was entered correctly. GLHF");
            Console.ReadLine();
        }

        public static void UserName()
        {
            bool check;

            Console.WriteLine("Please enter a name. Please capitalize");
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                if (Regex.IsMatch(input, @"^[A-Z][a-zA-Z\s]{1,30}$"))
                {
                    check = true;
                }
                else
                {
                    check = false;
                }

                if (check == false)
                {
                    Console.WriteLine("Please enter a Valid Name.");
                    input = Console.ReadLine();
                }
            }           
        }



        public static void Email()
        {
            bool check;
            do
            {
                Console.WriteLine("Please Enter an Email Address.");
                // Return true if strIn is in valid e-mail format.
                string test = Console.ReadLine();
                check = Regex.IsMatch(test,
                    @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            } while (!check);
        }

        public static void PhoneNumber()
        {
            bool check;
            do
            {
                Console.Write("Please Enter A Phone number: ");
                string test = Console.ReadLine();
                check = Regex.IsMatch(test, @"^\d{10}$");
                if (!check)
                {
                    Console.WriteLine("Ooops");
                }

            } while (!check);
        }



        public static void Date()
        {
            
            bool check;
            do
            {
                DateTime dt;
                Console.WriteLine("Please enter a date. mm/dd/yyyy.");
                check = DateTime.TryParseExact(Console.ReadLine(), "MM/dd/yyyy", CultureInfo.InvariantCulture,
                    DateTimeStyles.None, out dt);
                if (!check)
                {
                    Console.WriteLine("Incorrect Format, Please try again.");
                }
            } while (!check);
        }

    }
}
