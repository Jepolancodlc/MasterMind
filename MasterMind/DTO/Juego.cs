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

        public int getNumColores()
        {
            return numColores;
        }

        public int getNumIntentos()
        {
            return numIntentos;
        }
    }
}
