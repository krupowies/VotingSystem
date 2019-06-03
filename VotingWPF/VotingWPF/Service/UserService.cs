using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingWPF.Classes;
using VotingWPF.Repositories;

namespace VotingWPF.Service
{
    class UserService
    {
        UserRepository UserRepository;

        public UserService()
        {
            this.UserRepository = new UserRepository();
            UserRepository.loadData();
        }
        public void addUser(Role role,string username,string password,string name,string lastName,int age,Gender gender, string description)
        {
            if(role == Role.CANDIDATE)
            {
                int id = UserRepository.getLastCandidateID() + 1;
                Candidate user = new Candidate(username,password, id, role, name, lastName, age, gender, description);
                UserRepository.addCandidate(user);
            }
            else
            {
                int id = UserRepository.getLastVoterID() + 1;
                Voter user = new Voter(username, password, role, name, lastName, age, gender);
                UserRepository.addVoter(user);
            }
        }
        public bool loginCandidate(string username, string password)
        {
            List<Candidate> users = UserRepository.getCandidates();
            foreach (Candidate candidate in users)
            {
                if (username == candidate.UserName && password == candidate.Password)
                {
                    return true;
                }
                else
                    return false;
            }
            return false;

        }

        public bool loginVoter(string username, string password)
        {
            List<Voter> users = UserRepository.getVoters();
            foreach (Voter voter in users)
            {
                if (username == voter.UserName && password == voter.Password)
                {
                    return true;
                }
                else
                    return false;
            }
            return false;

        }

    }
}
