using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMind
{
    class Juego
    {
        //Atributos
        private int numColores;
        private int numIntentos;

        public Juego (int numColores, int numIntentos)
        {
            this.numColores = numColores;
            this.numIntentos = numIntentos;
        }

        /// <summary>
        /// Getter para obtener la cantidad de colores a mostrar
        /// </summary>
        /// <returns></returns>
        public int getNumColores()
        {
            return numColores;
        }

        /// <summary>
        /// Getter para obtener el número de intentos a permitir
        /// </summary>
        /// <returns></returns>
        public int getNumIntentos()
        {
            return numIntentos;
        }
    }
}
