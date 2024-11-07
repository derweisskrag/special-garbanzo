using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperScissorRockGame
{
    internal class UserService
    {
        private Connection _connection;

        public UserService(Connection connection)
        {
            _connection = connection;
        }

        public User SignIn(string name)
        {
            using (var connection = _connection.GetConnection())
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM Users WHERE Name = @Name";
                command.Parameters.AddWithValue("@Name", name);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // User found, return the user object
                        return new User
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Wins = reader.GetInt32(2),
                            Losses = reader.GetInt32(3),
                        };
                    }
                }

                command.CommandText = "INSERT INTO Users (Name) VALUES (@Name)";
                command.ExecuteNonQuery();

                command.CommandText = "SELECT last_insert_rowid()";
                // danger zone
                var userId = (int)(long) command.ExecuteScalar()!;

                return new User
                {
                    Id = userId,
                    Name = name
                };
               
            }
        }

        public void RecordGameResult(int userId, GameOptions userChoice, GameOptions computerChoice, GameResult result)
        {
            using (var connection = _connection.GetConnection())
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "INSERT INTO GameHistory (UserId, UserChoice, ComputerChoice, Result) VALUES (@UserId, @UserChoice, @ComputerChoice, @Result)";
                command.Parameters.AddWithValue("@UserId", userId);
                command.Parameters.AddWithValue("@UserChoice", (int)userChoice);
                command.Parameters.AddWithValue("@ComputerChoice", (int)computerChoice);
                command.Parameters.AddWithValue("@Result", result.ToString());
                command.ExecuteNonQuery();
            }
        }

        public void RecordUserResult(User user)
        {
            using (var connection = _connection.GetConnection())
            {
                connection.Open();
                var command = connection.CreateCommand();

                // Use UPDATE to modify existing user data
                command.CommandText = "UPDATE Users SET Wins = @Wins, Losses = @Losses, UserOption = @UserChoice, Draws = @Draws WHERE Name = @Name";

                command.Parameters.AddWithValue("@Wins", user.Wins);
                command.Parameters.AddWithValue("@Losses", user.Losses);
                command.Parameters.AddWithValue("@UserChoice", (int)user.UserOption); // Assuming UserOption is an enum and stored as an int
                command.Parameters.AddWithValue("@Draws", user.Draws);
                command.Parameters.AddWithValue("@Name", user.Name);

                command.ExecuteNonQuery();
            }
        }

        public User FindUserByName(string name) 
        {
            using (var connection = _connection.GetConnection()) 
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM Users WHERE LOWER(Name) = LOWER(@Name)";
                command.Parameters.AddWithValue("@Name", name);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // User found, return the user object
                        return new User
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Wins = reader.GetInt32(2),
                            Losses = reader.GetInt32(3),
                            UserOption = (GameOptions) reader.GetInt32(4),
                            Draws = reader.GetInt32(5),
                        };
                    }
                }

                // return the Guest
                return new User { Id = 0, Name = "" };
            }
        }
    }
}
