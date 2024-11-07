using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperScissorRockGame
{
    public class User
    {
        public string? Name { get; set; }
        public GameOptions UserOption { get; set; }

        public int Id { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }

        public int Draws { get; set; }
    }
}
