using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingWPF.Service;

namespace VotingWPF
{
    class Lists
    {
            private static Lists instance = null;

            private UserService userService;

            public Lists()
            {
                this.UserService = new UserService();
            }

            internal static Lists Instance
            {
                get
                {
                    if (instance == null)
                    {
                        instance = new Lists();
                    }
                    return instance;
                }
            }

            internal UserService UserService { get => userService; set => userService = value; }
        }

}
