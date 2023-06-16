using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Models
{
    internal class Game
    {
        private int _score;
        public int Score {
            get { return _score; } 
            set { _score = value; } 
        }
    }
}
