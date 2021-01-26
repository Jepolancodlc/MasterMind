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
    public partial class FormConfiguracion : Form
    {
        Color[] listaColoresPaleta;
        int num = 0;
        bool lleno = false;
        public FormConfiguracion(int numColores)
        {
            InitializeComponent();
          
            listaColoresPaleta = new Color[numColores];

            if (numColores > 4)
            {
                button4.Visible = true;

                if (numColores >5)
                {
                    button5.Visible = true;
                }
            }
        }

        /// <summary>
        /// Boton para terminar la elección de la paleta de colores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //Boton aceptar
            this.Hide();
            lleno = true;
        }

        /// <summary>
        /// Evento para cada color de la paleta de colores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_1(object sender, EventArgs e)
        {
            Button pillin = (Button)sender;


            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pillin.BackColor = colorDialog1.Color;
                listaColoresPaleta[num] = pillin.BackColor;
            }
            num++;
        }

        /// <summary>
        /// Method that returns the list with the colors choosen by the user
        /// </summary>
        /// <returns></returns>
        public void getList(ref Color[] lista)
        {
            lista = listaColoresPaleta;
            
        }

        public bool getLleno()
        {
            return lleno;
        }
    }
}
