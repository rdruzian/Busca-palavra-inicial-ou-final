using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teoria_bemLoko
{
    class Regra
    {
        string esquerdo;
        string direito;
        string[] aux;

        public void recebe(string passo)
        {
            aux = passo.Split(passo, "");
            esquerdo = aux[0];
            direito = aux[1];
        }
    }
}
