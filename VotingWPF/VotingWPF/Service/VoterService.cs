using ProjektPK.Repositories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using VotingWPF.Classes;

namespace VotingWPF.Service
{
    class VoterService
    {
        private Repository<Voter> voterRepository;

        public VoterService()
        {
            this.VoterRepository = new Repository<Voter>();

            Voter voter1 = new Voter("jan", "jan", "jan", "jan", 52, Gender.MALE);
            Voter voter2 = new Voter("michal", "michal", "michal", "michal", 22, Gender.MALE);
            Voter voter3 = new Voter("mat", "mat", "mat", "mat", 34, Gender.OTHER);
            Voter voter4 = new Voter("wojt", "wojt", "wojt", "wojt", 19, Gender.MALE);
            Voter voter5 = new Voter("pat", "pat", "pat", "pat", 99, Gender.FEMALE);
            voter1.Id = 1;
            voter2.Id = 2;
            voter3.Id = 3;
            voter4.Id = 4;
            voter5.Id = 5;
            VoterRepository.addElement(1, voter1);
            VoterRepository.addElement(2, voter2);
            VoterRepository.addElement(3, voter3);
            VoterRepository.addElement(4, voter4);
            VoterRepository.addElement(5, voter5);
        }

        internal Repository<Voter> VoterRepository { get => voterRepository; set => voterRepository = value; }

        public bool FindVoterByUsername(string username)
        {
            List<Voter> voters = VoterRepository.getAll();
            foreach (Voter voter in voters)
            {
                if (voter.UserName == username)
                {
                    return true;
                }
            }
            return false;
        }
        public Voter Login(string username,string password)
        {
            List<Voter> voters = VoterRepository.getAll();
            foreach (Voter voter in voters)
            {
                if (voter.UserName == username && voter.Password == password)
                {
                    return voter;
                }
            }
            return null;
        }

        public void AddVoter(string username, string password, string name, string lastname, int age, Gender gender)
        {
            if(FindVoterByUsername(username)==false)
            {
                Voter voter = new Voter(username, password, name, lastname, age, gender);
                int id = voterRepository.getLastId() + 1;
                voter.Id = id;
                voterRepository.addElement(id, voter);
            }
            else{
            throw new Exception("Choose other username, please");
            }
        }
    }
}