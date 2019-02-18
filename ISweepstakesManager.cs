using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class ISweepstakesManager
    {
        internal Sweepstakes Sweepstakes
        {
            get => default(Sweepstakes.Sweepstakes);
            set
            {
            }
        }

        internal Customer Customer
        {
            get => default(Sweepstakes.Customer);
            set
            {
            }
        }

        public MarketingFirm MarketingFirm
        {
            get => default(Sweepstakes.MarketingFirm);
            set
            {
            }
        }

        void InsertSweepstakes(Sweepstakes sweepstakes)
        {

        }
        public Sweepstakes GetSweepstakes()
        {
            
        }
    }
}
