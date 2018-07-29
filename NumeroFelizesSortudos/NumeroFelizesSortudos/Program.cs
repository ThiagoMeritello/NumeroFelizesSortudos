using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroFelizesSortudos
{
    class Program
    {
        static void Main(string[] args)
        {
            string resposta;
            do
            {
                Console.Clear();
                Console.WriteLine("Números Felizes e Sortudos");
                Console.WriteLine("Digite um numero: ");

                int numero = Convert.ToInt32(Console.ReadLine());

                //Verificar se o numero é feliz
                bool numeroFeliz = Verificadores.NumeroFelizes(numero);
                //Verificar se o numero é sortudo
                bool numeroSortudo = Verificadores.NumeroSortudo(numero);

                resposta = string.Empty;
                resposta += "Número ";
                if (numeroSortudo)
                    resposta += "Sortudo e ";
                else
                    resposta += "Não-Sortudo e ";

                if (numeroFeliz)
                    resposta += "Feliz.";
                else
                    resposta += "Não-Feliz.";

                Console.WriteLine(resposta);

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Deseja sair do programa? Digite 'S' para sair ou qualquer tecla para continuar a usar.");
                
            } while (Console.ReadLine().ToUpper() != "S");


        }
    }
}
