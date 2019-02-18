using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    static class UserInterface
    {
        public static void Welcome()
        {


            Console.WriteLine("Please enter your information below to enter " + "Sweepstakes.Sweepstake");
            Console.WriteLine("Please enter your first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Please enter your last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Please enter your email: ");
            string email = Console.ReadLine();
            Console.WriteLine("Please enter your registration number: ");
            string regNum = Console.ReadLine();
        }
    }
}
