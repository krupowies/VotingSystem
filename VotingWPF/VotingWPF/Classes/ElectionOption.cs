using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingWPF.Classes
{
    class ElectionOption
    {
        Candidate candidate;
        int voteCounter;
        public ElectionOption(Candidate candidate)
        {
            this.Candidate = candidate;
            this.VoteCounter = 0;
        } 

        public int VoteCounter { get => voteCounter; set => voteCounter = value; }
        internal Candidate Candidate { get => candidate; set => candidate = value; }

        public void AddOne()
        {
            this.VoteCounter += 1;
        }

        public string CandidateName { get { return candidate.Name; } }
        public string CandidateLastName { get { return candidate.LastName; } }
        public int CandidateVotes { get { return voteCounter; } }
    }
}
