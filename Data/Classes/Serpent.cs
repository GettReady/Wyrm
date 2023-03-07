using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wyrm.Data.Classes
{
    public class Serpent
    {
        Queue<(int x, int y)> body;
        int length = 3;
        int animationDelay = 300;
        (int x, int y) snakeHead;
        (int x, int y) direction;        

        public Serpent((int, int) snakeHead, (int, int) direction)
        {
            this.snakeHead = snakeHead;
            this.direction = direction;
            InitializeBody();
        }

        private void InitializeBody()
        {
            body = new Queue<(int x, int y)>();
            for (int i = length - 1; i > 0; --i)
            {
                body.Enqueue((snakeHead.x + i, snakeHead.y));
            }
            body.Enqueue(snakeHead);
        }
    }
}
