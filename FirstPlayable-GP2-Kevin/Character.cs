using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPlayable_GP2_Kevin
{
    internal class Character
    {
        protected int _xPos;
        protected int _yPos;
        public Health _health;
        public Character(int HP, int x, int y)
        {
            _xPos = x;
            _yPos = y;
            _health = new Health(HP);
        }
    }
}
