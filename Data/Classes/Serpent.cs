using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wyrm.Data.Classes
{
    public abstract class Serpent : IActor
    {
        protected Queue<(int x, int y)> body;
        protected int length = 3;
        protected int animationDelay = 300;
        protected (int x, int y) snakeHead;
        protected (int x, int y) direction;
        protected Field field;
        public event Action Snacked;

        public bool IsPaused { get; protected set; } = false;

        public Serpent((int, int) snakeHead, (int, int) direction, Field field)
        {
            this.snakeHead = snakeHead;
            this.direction = direction;
            this.field = field;
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

        protected void OnSnack()
        {
            Snacked?.Invoke();
        }

        public abstract void Move();

        public abstract Task Act();

        public abstract Task Spawn();

        public abstract void Pause();

        public abstract void Unpause();
    }
}
