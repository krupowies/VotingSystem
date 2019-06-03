using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingWPF.Classes
{
    class Election
    {
        string question;
        int votes;
        List<Candidate> candidates;
        public Election(string question,int votes)
        {
            this.question = question;
            this.votes = votes;
            this.Candidates = new List<Candidate>();
        }
        public string Question { get => question; set => question = value; }
        public int Votes { get => votes; set => votes = value; }
        internal List<Candidate> Candidates { get => candidates; set => candidates = value; }
    }
}
