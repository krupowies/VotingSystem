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
                //ZAIMPLEMENTOWAC FUNKCJE ZWRACAJACA NAZWE UZYTKOWNIKA KTORY MA NAJWECEJ GLOSOW W CANDIDATES
                return "Adam";
            }
        }
    }
}
