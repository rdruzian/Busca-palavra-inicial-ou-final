using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teoria_bemLoko
{
    class Program
    {
        static void Main(string[] args)
        {
            #region variaveis
            List<char> alfabeto = new List<char>();
            List<char> variaveis = new List<char>();
            string palavraFinal;
            char palavraInicial;
            char aux;
            Graph g = new Graph();
            #endregion

            #region entrada
            do
            {
                Console.WriteLine("Entre com as variaveis (0 para terminar): ");
                aux = Convert.ToChar(Console.ReadLine());
                variaveis.Add(aux);
            } while (aux != '0');

            do
            {
                Console.WriteLine("Entre com o alfabeto: ");
                aux = Convert.ToChar(Console.ReadLine());
                variaveis.Add(aux);
            } while (aux != '0');

            do
            {
                Console.WriteLine("Entre com a regra: ");
                //Adiciona no grafo, tentar fazer verificação se a regra contem apenas as variaveis
            } while (aux != '0');
            
            Console.WriteLine("Palavra final ou inicial (F/I): ");

            aux = Convert.ToChar(Console.ReadLine());
            if(aux.Equals('F') || aux.Equals('f'))
            {
                Console.WriteLine("Entre com a palavra: ");
                palavraFinal = Console.ReadLine();
                //faz a busca da palavra, fazer busca atraves do passeio em largura
            }

            else if(aux.Equals('I') || aux.Equals('i'))
            {
                Console.WriteLine("Entre com a palavra: ");
                palavraInicial = Convert.ToChar(Console.ReadLine());
                //faz a busca da palavra, fazer busca atraves do passeio em largura
            }
            #endregion
        }
    }
}
