using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Contestant
    {
        int contestants = 1;
        
        public void createNumber()
        {
           if(contestants >= 0)
            {
                for (int i = 0; i > contestants; i++)
                {
                    contestants++;
                }
                return;
            }
        }

        public void contestant()
        {
            Console.WriteLine("Please enter your first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Please enter your last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Please enter your email: ");
            string email = Console.ReadLine();
        }

    }

}
        

        

        

