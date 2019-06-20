using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingWPF.Classes;

namespace VotingWPF.Repositoriy
{
    class UserRepository
    {
        List<Voter> votersList;
        List<Candidate> candidatesList;

        public UserRepository()
        {
            this.votersList = new List<Voter>();
            this.candidatesList = new List<Candidate>();
        }

        public int getLastVoterID()
        {
            Voter temp = new Voter();
            if(votersList.Count == 0)
            {
                return 0;
            }
            temp = votersList.Last();
            return temp.Id;
        }
        public List<Candidate> getCandidates()
        {
            return candidatesList;
        }

        public List<Voter> getVoters()
        {
            return votersList;
        }
        public int getLastCandidateID()
        {
            Candidate temp = new Candidate();
            if(candidatesList.Count == 0)
            {
                return 0;
            }
            temp = candidatesList.Last();
            return temp.Id;
        }



        public void addVoter(Voter voter)
        {
            votersList.Add(voter);
        }
        public void addCandidate(Candidate candidate)
        {
            candidatesList.Add(candidate);
        }



        public void deleteVoter(int idToFind)
        {
           Voter result = votersList.Find(
               delegate (Voter temp)
               {
                   return temp.Id == idToFind;
               }
            );
            if (result != null)
            {
                votersList.Remove(result);
            }
            else
            {
                throw new Exception("Could not find !");
            }
        }


        public void deleteCandidate(int idToFind)
        {
            Candidate result = candidatesList.Find(
                delegate (Candidate temp)
                {
                    return temp.Id == idToFind;
                }
             );
            if (result != null)
            {
                candidatesList.Remove(result);
            }
            else
            {
                throw new Exception("Could not find !");
            }
        }



        public void loadVoterFromFile()
        {
            string fileName = @"";
            string line = "";

            StreamReader file = new StreamReader(fileName);
            while((line = file.ReadLine()) !=null)
            {
                string[] userData = line.Split(' ');
                int id = 0;
                Int32.TryParse(userData[0], out id);
                Voter voter = new Voter();
            }
        }

        public void loadCandFromFile()
        {
            string fileName = @"";
            string line = "";

            StreamReader file = new StreamReader(fileName);
            while ((line = file.ReadLine()) != null)
            {
                string[] userData = line.Split(' ');
                int id = 0;
                Int32.TryParse(userData[0], out id);
            }
        }

    }
}
