using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class ISweepstakesManager
    {
        Sweepstakes sweepstakes = new Sweepstakes();

        internal Sweepstakes Sweepstakes
        {
            get => sweepstakes;
            set
            {
                sweepstakes = value;
            }
        }

        public MarketingFirm MarketingFirm
        {
            get => MarketingFirm;
            set
            {
                MarketingFirm = value;
            }
        }

        internal Contestant Contestant
        {
            get => Contestant;
            set
            {
                Contestant = value;
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
