using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PaperScissorRockGame.Entities;

namespace PaperScissorRockGame.Session
{
    public class UserSession
    {
        public User user;

        public UserSession() 
        {
            this.user = new Guest();
        }

        public void SignIn(User user)
        {
            this.user = user;
        }

        public void SignOut()
        {
            this.user = new Guest();
        }
    }
}
