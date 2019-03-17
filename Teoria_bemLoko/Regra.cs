using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teoria_bemLoko
{
    class Regra
    {
        public List<char> alfabeto = new List<char>();
        public List<char> variaveis = new List<char>();
        public List<Tuple<string,string>> regra = new List<Tuple<string,string>>();
        public string palavraInicial, palavraFinal;
        private string[] aux;
        Graph g = new Graph();

        /// <summary>
        /// Verifica se as entradas são válidas para o alfabeto e variaeis
        /// </summary>
        /// <param name="regras"></param>
        /// <returns></returns>
        public bool verifica(string regras)
        {
            aux = regras.Split(Convert.ToChar(regras), ' ');
            foreach (var v in aux)
            {
                foreach(var v1 in variaveis)
                    if (!v.Contains(v1))
                        return false;
            }
            return true;
        }

        /// <summary>
        /// Adiciona um nó ao grafo sendo o nome contém as variaveis e o valor a substituição
        /// por exemplo...
        /// name = S e valor = XY
        /// </summary>
        /// <param name="itens"></param>
        public void recebe(string itens)
        {
            aux = itens.Split(Convert.ToChar(itens), ' ');
            g.AddNode(aux[0], aux[1]);
        }

        public void busca(string palavra)
        {
            Console.WriteLine(g.DepthFirstSearch(palavra));
        }
    }
}
