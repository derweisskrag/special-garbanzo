using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace PaperScissorRockGame
{
    internal class UserController
    {
        private UserService _UserService;

        public UserController(UserService UserService)
        {
            _UserService = UserService;
        }

        public User SignIn(string name)
        {
            return _UserService.SignIn(name);
        }

        public User FindUserByName(string name)
        {
            return _UserService.FindUserByName(name);
        }

        public void RecordGameResult(int userId, GameOptions userChoice, GameOptions computerChoice, GameResult gameResult)
        {
            _UserService.RecordGameResult(userId,  userChoice, computerChoice, gameResult);
        }

        public void RecordUserResult(User user)
        {
            _UserService.RecordUserResult(user);
        }
    }
}
