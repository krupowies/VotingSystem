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
        string description;
        public Candidate(string userName, string password, int id, Role role, string name, string lastName, int age, Gender gender,string description) : base(userName, password, role)
        {
            this.name = name;
            this.lastName = lastName;
            this.age = age;
            this.gender = gender;
            this.description = description;
        }

        public Candidate() : base()
        { 
        }

        public string Name { get => name; set => name = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int Age { get => age; set => age = value; }
        public string Description { get => description; set => description = value; }
        internal Gender Gender { get => gender; set => gender = value; }
    }
}
