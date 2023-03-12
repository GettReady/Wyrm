using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wyrm.Data
{
    interface IActor
    {
        public bool IsPaused { get; }

        public Task Act();
        public Task Spawn();
        public void Pause();
        public void Unpause();
    }
}
