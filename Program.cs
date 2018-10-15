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
            IsValidEmail();
            


            Console.ReadLine();
        }

        public static string UserName()
        {
            bool check = false;

            Console.WriteLine("Please enter a name. Please capitalize");
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                if (Regex.IsMatch(input, @"^[a-zA-Z\s]+$"))
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

        public static bool IsValidEmail(string strIn)
        {
            Console.WriteLine("Please Enter an Email Address.");
            // Return true if strIn is in valid e-mail format.
            string test = Console.ReadLine();
            
            return Regex.IsMatch(test, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }

        


    }
}
