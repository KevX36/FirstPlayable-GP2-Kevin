using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPlayable_GP2_Kevin
{
    internal class Enemy
    {
        public int _xPos { get; private set; }
        public int _yPos { get; private set; }
        public Health _health;
        public Enemy(int HP,int x, int y)
        {
            _xPos = x;
            _yPos = y;
            _health = new Health(HP);
        }

        public void Move(Player player, Map map)
        {
            if(_xPos< player._xPos)
            {
                if(player._xPos == _xPos-- && player._yPos == _yPos)
                {
                    player._health.TakeDamage(1);
                }
                else if (map.CheakSpace(_xPos--,_yPos))
                {
                    _xPos--;
                }
            }
            else if (_xPos > player._xPos)
            {
                if (player._xPos == _xPos++ && player._yPos == _yPos)
                {
                    player._health.TakeDamage(1);
                }
                else if (map.CheakSpace(_xPos++, _yPos))
                {
                    _xPos++;
                }
            }
            else if (_yPos < player._yPos)
            {
                if (player._xPos == _xPos && player._yPos == _yPos--)
                {
                    player._health.TakeDamage(1);
                }
                else if (map.CheakSpace(_xPos, _yPos--))
                {
                    _yPos--;
                }
            }
            else if (_yPos > player._yPos)
            {
                if (player._xPos == _xPos && player._yPos == _yPos++)
                {
                    player._health.TakeDamage(1);
                }
                else if (map.CheakSpace(_xPos, _yPos++))
                {
                    _yPos++;
                }
            }
        }

        public void DrawEnemy()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(_xPos+5, _yPos+5);
            Console.Write("X");
            Console.BackgroundColor = ConsoleColor.Black;
        }















    }
}
