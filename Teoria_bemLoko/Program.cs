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
            Regra r = new Regra();
            string palavraFinal;
            char palavraInicial;
            char aux;
            string regra;
            #endregion

            #region entrada
            do
            {
                Console.WriteLine("Entre com as variaveis (0 para terminar): ");
                aux = Convert.ToChar(Console.ReadLine());
                r.variaveis.Add(aux);
            } while (aux != '0');

            do
            {
                Console.WriteLine("Entre com o alfabeto: ");
                aux = Convert.ToChar(Console.ReadLine());
                r.alfabeto.Add(aux);
            } while (aux != '0');

            do
            {
                Console.WriteLine("Entre com a regra (separadas por espaco): ");
                //Adiciona no grafo, tentar fazer verificação se a regra contem apenas as variaveis
                regra = Console.ReadLine().ToString();
                if (r.verifica(regra))
                    r.recebe(regra);
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
