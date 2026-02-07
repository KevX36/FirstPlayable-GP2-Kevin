using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPlayable_GP2_Kevin
{
    internal class Player
    {
        public int _xPos {  get; private set; }
        public int _yPos { get; private set; }
        public Health _health;
        public Player(int HP, int x, int y)
        {
            _xPos = x;
            _yPos = y;
            _health = new Health(HP);
        }
    }
}
