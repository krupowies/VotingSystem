using ProjektPK.Repositories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using VotingWPF.Classes;


namespace VotingWPF.Service
{
    class CandidateService
    {
        private Repository<Candidate> candidateRepository;

        public CandidateService()
        {
            this.CandidateRepository = new Repository<Candidate>();
        }
        public Candidate FindCandidateByUsername(string username)
        {
            List<Candidate> candidates = candidateRepository.getAll();
            foreach(Candidate candidate in candidates)
            {
                if(candidate.UserName == username)
                {
                    return candidate;
                }
            }
            return null;
        }

        internal Repository<Candidate> CandidateRepository { get => candidateRepository; set => candidateRepository = value; }
    }
}