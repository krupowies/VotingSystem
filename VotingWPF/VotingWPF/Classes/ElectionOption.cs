using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingWPF.Classes
{
    class ElectionOption
    {
        Candidate Person;
        int voteCounter;
        public ElectionOption(Candidate Person)
        {
            this.Person = Person;
            this.VoteCounter = 0;
        }

        public int VoteCounter { get => voteCounter; set => voteCounter = value; }

        public void AddOne()
        {
            this.VoteCounter += 1;
        }
    }
}
