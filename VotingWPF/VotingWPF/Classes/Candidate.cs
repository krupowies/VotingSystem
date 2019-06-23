using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingWPF.Classes
{
    class Candidate : User
    {
        string name;
        string lastName; 
        int age;
        Gender gender;
        public Candidate(string userName, string password, string name, string lastName, int age, Gender gender) : base(userName, password, Role.CANDIDATE)
        {
            this.name = name;
            this.lastName = lastName;
            this.age = age;
            this.gender = gender;
        }

        public Candidate() : base()
        { 
        }

        public string Name { get => name; set => name = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int Age { get => age; set => age = value; }
        internal Gender Gender { get => gender; set => gender = value; }
    }
}
