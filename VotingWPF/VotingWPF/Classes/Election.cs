using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingWPF.Classes
{
    class Election
    {
        int id;
        string name;
        string question;
        List<ElectionOption> candidates;
        List<Voter> voters;
        public Election(int id,string name,string question)
        {
            this.id = id;
            this.Name = name;
            this.question = question;
            this.Candidates = new List<ElectionOption>();
            voters = new List<Voter>();
        }
        public string Question { get => question; set => question = value; }
        public string Name { get => name; set => name = value; }
        public int Id { get => id; set => id = value; }
        internal List<ElectionOption> Candidates { get => candidates; set => candidates = value; }
        internal List<Voter> Voters { get => voters; set => voters = value; }
        public void AddOption(Candidate Person)
        {
            ElectionOption candidate = new ElectionOption(Person);
            candidates.Add(candidate);
        }
        public string Winner { get {
                string winner = "";
                int temp = 0;
               foreach(ElectionOption candidate in candidates)
                {
                    if(candidate.VoteCounter > temp)
                    {
                        temp = candidate.VoteCounter;
                        winner = candidate.Candidate.LastName;
                    }
                }
                return winner;
            }
        }

        public void AddVoter(Voter voter)
        {
            voters.Add(voter);
        }
        public bool VoterVoted(Voter person)
        {
           foreach(Voter voter in voters)
            {
                if(voter.UserName == person.UserName)
                {
                    return true;
                }
            }
            return false;
        }
        public void Voting(Voter voter,Candidate candidate)
        {
            voters.Add(voter);
            foreach(ElectionOption option in candidates)
            {
                if (option.Candidate.UserName == candidate.UserName)
                    option.VoteCounter += 1;
            }
        }
    }
}
