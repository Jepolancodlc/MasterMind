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
    public partial class ControlUsuario : UserControl
    {
        public ControlUsuario()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método que muestra los pictureBox necesarios
        /// </summary>
        /// <param name="numColores"></param>
        public void Start(int numColores)
        {
            groupBox1.Visible = false;

            if (numColores == 4)
            {
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
            }
            else if (numColores == 5)
            {              
                pictureBox6.Visible = false;
            }
        }

        /// <summary>
        /// Se recibe por parámetro la lista ordenada de colores de la solución
        /// </summary>
        /// <param name="listaColores"></param>
        public List<Color> ComprobarColores(List <Color> listaColores)
        {
            groupBox1.Visible = true;

            int i = 0;
            int j = 0;
            Color[] pictureBoxesColors = new Color[6];
            PictureBox[] pictureBoxesResultado = new PictureBox[6];

            //Añadimos los colores de los pictureBoxes elegidos por el usuario al array para realizar la comprobación.
            pictureBoxesColors[0] = pictureBox1.BackColor;
            pictureBoxesColors[1] = pictureBox2.BackColor;
            pictureBoxesColors[2] = pictureBox3.BackColor;
            pictureBoxesColors[3] = pictureBox4.BackColor;
            pictureBoxesColors[4] = pictureBox5.BackColor;
            pictureBoxesColors[5] = pictureBox6.BackColor;

            List<Color> resultado = new List<Color>();

            foreach(Color color in listaColores)
            {
                if(pictureBoxesColors[i] == color)
                {
                    resultado.Add(Color.Black);
                }
                else if (Array.Exists(pictureBoxesColors, element => element == color))
                {                           
                    resultado.Add(Color.White);
                }
                

                i++;
            }

            pictureBoxesResultado[0] = pictureBox22;
            pictureBoxesResultado[1] = pictureBox24;
            pictureBoxesResultado[2] = pictureBox20;
            pictureBoxesResultado[3] = pictureBox23;
            pictureBoxesResultado[4] = pictureBox21;
            pictureBoxesResultado[5] = pictureBox19;

            //Rellenamos  
            foreach (Color color in resultado)
            {
                pictureBoxesResultado[j].BackColor = color;
                j++;
            }

            //Devolvemos la lista resultado con los colores.
            //Si todos los colores son negro, ha ganado.
            return resultado;

        }

        #region LLenarPaletasColores
        /// <summary>
        /// Método para rellenar la pictureBox número 1
        /// </summary>
        public void LlenarPaleta1(Color color)
        {

            pictureBox1.BackColor = color;


        }

        /// <summary>
        /// Método para rellenar la pictureBox número 2
        /// </summary>
        public void LlenarPaleta2(Color color)
        {

            pictureBox2.BackColor = color;

        }

        /// <summary>
        /// Método para rellenar la pictureBox número 3
        /// </summary>
        public void LlenarPaleta3(Color color)
        {

            pictureBox3.BackColor = color;


        }

        /// <summary>
        /// Método para rellenar la pictureBox número 4
        /// </summary>
        public void LlenarPaleta4(Color color)
        {

            pictureBox4.BackColor = color;

        }

        /// <summary>
        /// Método para rellenar la pictureBox número 5
        /// </summary>
        public void LlenarPaleta5(Color color)
        {

            pictureBox5.BackColor = color;

        }

        /// <summary>
        /// Método para rellenar la pictureBox número 6
        /// </summary>
        public void LlenarPaleta6(Color color)
        {

            pictureBox6.BackColor = color;

        }
        #endregion
    }
}
