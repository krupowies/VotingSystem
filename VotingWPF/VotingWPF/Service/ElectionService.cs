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

        internal Repository<Election> ElectionRepository { get => electionRepository; set => electionRepository = value; }

        public ElectionService()
        {
            this.ElectionRepository = new Repository<Election>();
        }

        public void AddElection(string name,string question)
        {
            Election election = new Election(ElectionRepository.getLastId()+1, name, question);
            electionRepository.addElement(election.Id,election);
        }
       
    
    }
}