using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chekpassword
{
    class Program
    {
        //Hello Im Twana Muhamed Kurdish Im Ceate code Language c# Console 
        //This Code About Securty Contain TWO Part

        //-------------------------------------------------
        // One Part Validation Password

        /*--Validation >>>> 
         * Capital 
         * Lower 
         * Digits 
         * spectionl 
        */

        //----------------------------------------------------

        //Two Part Chaking Password

        /*Chaking >>>> 
         * Min 8 char and max 14 
         * char One upper case 
         * One special char 
         * One lower case 
         * No white space
         */
        //You can visit my GitHub through that link:https://github.com/TwanstDeveloper
        static void Main(string[] args)
        {
            string passwords;
            Console.WriteLine("Enter Password Cheke");
            passwords = Console.ReadLine();
            Console.WriteLine("The password Chake");
            Program obj = new Program();
            obj.chekpassword(passwords);
            Console.ReadKey();
        }
        void chekpassword(string password)
        {
            int capital = 0;
            int smol = 0;
            int digit = 0;
            int spectionl = 0;
            // if Tow statment <<One>> Used Condition Value Input Validtion Password
            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] >= 65 && password[i] <= 90)
                {
                    capital = 1;
                }
                else if (password[i] >= 97 && password[i] <= 122)
                {
                    smol = 1;
                }
                else if (password[i] >= 47 && password[i] <= 58)
                {
                    digit = 1;
                }
                else
                {
                    spectionl = 1;
                }
            }
            // if Tow statment <<Two>> Used Condition cheking After Input Value Password in Console C#

            if (password.Length < 8 || password.Contains(" "))
            {
                Console.WriteLine("Weak");

            }
            else if (password.Length > 14)
            {
                Console.WriteLine("Failed , Size Password limited just 14 Index Input");
            }
            else if (capital == 1 && smol == 1 && digit == 1 && spectionl == 1)
            {
                Console.WriteLine(" Very Strong ");
            }
            else if ((capital == 1 || smol == 1) && digit == 1 && spectionl == 1)
            {
                Console.WriteLine("Strong ");
            }
            else if ((capital == 1 || smol == 1) && (digit == 1))
            {
                Console.WriteLine("mediam ");
            }
            else if ((capital == 1 || smol == 1) && (spectionl == 1))
            {
                Console.WriteLine("mediam ");
            }
            else if (capital == 1)
            {
                Console.WriteLine("Sorry Not Just Capital ");
            }
            else if (smol == 1)
            {
                Console.WriteLine("Sorry Not Just smoll");
            }
             else if (digit==1) 
            {
                Console.WriteLine("Sorry Not Just digit");
            }
            else if (spectionl == 1)
            {
                Console.WriteLine("Sorry Not Just spectionl");
            }
        }
    }
}