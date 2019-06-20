using ProjektPK.Repositories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using VotingWPF.Classes;

namespace VotingWPF.Service
{
    class ElectionService
    {
        private Repository<Election> electionRepository;
        private Repository<Candidate> candidateRepository;

        internal Repository<Election> ElectionRepository { get => electionRepository; set => electionRepository = value; }

        public ElectionService()
        {
            this.ElectionRepository = new Repository<Election>();
            this.candidateRepository = new Repository<Candidate>();
        }

        public void AddElection(string name,string question)
        {
            Election election = new Election(ElectionRepository.getLastId()+1, name, question);
            electionRepository.addElement(election.Id,election);
        }
       
        public Candidate FindCandidate(string username)
        {
            List<Candidate> candidates = candidateRepository.getAll();
            foreach(Candidate candidate in candidates)
            {
                if(candidate.UserName == username)
                {
                    return candidate;
                }
            };
            return null;
        }
    }
}