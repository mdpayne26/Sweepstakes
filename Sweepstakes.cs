using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Sweepstakes
    {
        string sweepstakes;
        string PickWinner;
        Contestant contestant = new Contestant();
        
        Dictionary<string, Int32> ContestantList = new Dictionary<string, Int32>();
        
        public void CreateDictionary()
        {
            //ContestantList.Add(Contestant.contestant);
        }

        public Contestant Contestant
        {
            get => contestant;
            set
            {
                contestant = value;
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

        internal ISweepstakesManager ISweepstakesManager
        {
            get => ISweepstakesManager;
            set
            {
                ISweepstakesManager = value;
            }
        }

        void RegisterConstestant(Contestant contestant)
        {
            //Contestant.contestant();
        }

        void PrintContestant(Contestant contestant)
        {
            //Contestant.contestant();
        }
        public void RunSweepstakes()
        {
            UserInterface.Welcome();
            Contestant.contestant();
            Contestant.createNumber();
        }
        //public void ContestantList()
        //{
            
        //}
    }
}
            
            

