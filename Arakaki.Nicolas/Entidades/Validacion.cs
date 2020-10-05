using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Validacion
    {
        /// <summary>
        /// Valida si el string pasado por parámetro es un número decimal.
        /// </summary>
        /// <param name="numString"></param>
        /// <returns>bool: retorna true si el string es un número decimal, caso contrario false</returns>
        public static bool EsNumero(string numString)
        {
            bool retorno = true;

            foreach (char caracter in numString)
            {
                if (!char.IsDigit(caracter))
                {
                    retorno = false;
                    break;
                }
            }

            return retorno;

        }

        /// <summary>
        /// Valida si el string pasado por parámetro no contiene números.
        /// </summary>
        /// <param name="texto"></param>
        /// <returns>bool: retorna true si el string es sólo texto, caso contrario false</returns>
        public static bool EsString(string texto)
        {
            bool retorno = true;

            foreach (char caracter in texto)
            {
                if (char.IsDigit(caracter))
                {
                    retorno = false;
                    break;
                }
            }

            return retorno;
        }

    }
}
