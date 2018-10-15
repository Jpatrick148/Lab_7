using System;
using System.Collections.Generic;
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
            //UserName();
            //IsValidEmail();
            PhoneNumber();
            


            Console.ReadLine();
        }

        public static string UserName()
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
            return input;
        }



        public static bool Email()
        {
            Console.WriteLine("Please Enter an Email Address.");
            // Return true if strIn is in valid e-mail format.
            string test = Console.ReadLine();
            bool check = Regex.IsMatch(test,@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            if (check == false)
            {
                Console.WriteLine("Oops I'm Sorry Email is Invalid. Try Again.");
                Email();
            }
            return check;
        }

        public static bool PhoneNumber()
        {
            Console.WriteLine("Please Enter A Phone number");
            string test = Console.ReadLine();
            bool check = Regex.IsMatch(test, @"^(\+\d[0-9]{1,8})$");
            if (check == false)
            {
                Console.WriteLine("Oops I'm Sorry, the phone number is invalid.");
                PhoneNumber();
            }
            return check;
        }

        public static bool Date()
        {
            Console.WriteLine("Please enter a date. mm/dd/yyyy");
            DateTime test = Console.ReadLine();
            
            bool check = DateTime.TryParseExact(test);
    
        }

    }
}
