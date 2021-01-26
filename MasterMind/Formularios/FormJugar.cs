using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterMind
{
    public partial class FormJugar : Form
    {
        public FormJugar(int numColores, int numIntentos)
        {
            InitializeComponent();


            Juego instanciaJuego = new Juego(numColores, numIntentos);

        }

    }
}
