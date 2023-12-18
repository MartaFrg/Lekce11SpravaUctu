using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekce11SpravaUctu
{
    internal class ZapornyVkladException : ArgumentOutOfRangeException
    {
        public DateTime Cas;
        public int Vklad;
        public ZapornyVkladException(string message, string param, int vklad) : base(message, param)
        {
            Vklad= vklad;
            Cas = DateTime.Now;
        }
    }
}
