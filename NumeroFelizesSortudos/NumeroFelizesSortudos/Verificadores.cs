using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroFelizesSortudos
{
    public static class Verificadores
    {
        public static bool NumeroFelizes(int numero)
        {
            int numeroDinamico = numero;
            for (int cont = 0; cont < 100; cont++)
            {
                numeroDinamico = SomaDigitos(numeroDinamico);
                if (numeroDinamico == 1)
                    return true;
            }
            return false;
        }

        static int SomaDigitos(int digitos)
        {
            int resto, resultado, soma = 0;

            resultado = digitos;

            while (resultado != 0)
            {
                resto = resultado % 10;
                resultado = resultado / 10;

                soma = soma + (resto * resto);
            }

            return soma;
        }

        public static bool NumeroSortudo(int numero)
        {
            if (numero % 2 == 0)
                return false;
            else if (numero % 3 == 0)
                return false;
            else if (numero % 7 == 0)
                return false;
            else
                return true;
        }
    }
}
