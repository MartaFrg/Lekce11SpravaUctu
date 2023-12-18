using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekce11SpravaUctu
{
    internal class ZapornyVyberException:ArgumentOutOfRangeException
    {
        public DateTime Cas;
        public int Vyber;
        public ZapornyVyberException(string message, string param, int vyber) : base(message, param)
        {
            Vyber = vyber;
            Cas = DateTime.Now;
        }
    }
}
