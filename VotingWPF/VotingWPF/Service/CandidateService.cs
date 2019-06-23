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

            Candidate candidate1 = new Candidate("aaa", "aaa", "aaa", "aaa", 18, Gender.MALE);
            Candidate candidate2 = new Candidate("bbb", "bbb", "bbb", "bbb", 19, Gender.MALE);
            Candidate candidate3 = new Candidate("ccc", "ccc", "ccc", "ccc", 32, Gender.FEMALE);
            Candidate candidate4 = new Candidate("ddd", "ddd", "ddd", "ddd", 62, Gender.MALE);
            Candidate candidate5 = new Candidate("eee", "eee", "eee", "eee", 42, Gender.OTHER);
            candidate1.Id = 1;
            candidate2.Id = 2;
            candidate3.Id = 3;
            candidate4.Id = 4;
            candidate5.Id = 5;
            CandidateRepository.addElement(1,candidate1);
            CandidateRepository.addElement(2, candidate2);
            CandidateRepository.addElement(3, candidate3);
            CandidateRepository.addElement(4, candidate4);
            CandidateRepository.addElement(5, candidate5);
        }
        public bool FindCandidateByUsername(string username)
        {
            List<Candidate> candidates = candidateRepository.getAll();
            foreach(Candidate candidate in candidates)
            {
                if(candidate.UserName == username)
                {
                    return true;
                }
            }
            return false;
        }

        public Candidate ReturnCandidateByUsername(string username)
        {
            List<Candidate> candidates = candidateRepository.getAll();
            foreach (Candidate candidate in candidates)
            {
                if (candidate.UserName == username)
                {
                    return candidate;
                }
            }
            return null;
        }



        public void AddCandidate(string username, string password, string name, string lastname, int age, Gender gender)
        {
            if (FindCandidateByUsername(username) == false)
            {
                Candidate candidate = new Candidate(username, password, name, lastname, age, gender);
                int id = candidateRepository.getLastId() + 1;
                candidate.Id = id;
                candidateRepository.addElement(id, candidate);
            }
            else
            {
                throw new Exception("Choose other username, please");
            }
        }




        internal Repository<Candidate> CandidateRepository { get => candidateRepository; set => candidateRepository = value; }
    }
}