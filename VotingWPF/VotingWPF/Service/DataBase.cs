using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace VotingWPF.Service
{
    class DataBase
    {
        private static DataBase instance = null;

        private ElectionService electionService;
        private CandidateService candidateService;


        public DataBase()
        {
                this.ElectionService = new ElectionService();
                this.CandidateService = new CandidateService();

        }

        internal static DataBase Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataBase();
                }
                return instance;
            }
        }

        internal ElectionService ElectionService { get => electionService; set => electionService = value; }
        internal CandidateService CandidateService { get => candidateService; set => candidateService = value; }
    }
}
