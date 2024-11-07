using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperScissorRockGame
{
    internal class UserFactory
    {
        public static UserController CreateUserController()
        {
            var dbConnection = new Connection("data source=C:\\Users\\Administrator\\Desktop\\special-garbanzo\\project_6\\PaperScissorRockGame\\PaperScissorRockGame\\Database\\GameDB.db");
            var userService = new UserService(dbConnection);
            var userController = new UserController(userService);
            return userController;
        }
    }
}
