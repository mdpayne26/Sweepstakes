using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Program
    {
        internal ISweepstakesManager ISweepstakesManager
        {
            get => default(Sweepstakes.ISweepstakesManager);
            set
            {
            }
        }

        static void Main(string[] args)
        {
        }
    }
}
