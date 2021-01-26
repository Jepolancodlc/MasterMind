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
        //Atributos 
        private ControlUsuario controlUsuario;
        private Juego instanciaJuego;
        private List<Color> listaSolucionColores; 
        private int posicionY = 10;
        private int numColores;
        private Color[] arrayColores;
        private int clicks = 0;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="numColores"></param>
        /// <param name="numIntentos"></param>
        public FormJugar(int numColores, int numIntentos)
        {
            InitializeComponent();

            this.numColores = numColores;

            instanciaJuego = new Juego(this.numColores, numIntentos);
            controlUsuario = new ControlUsuario();

            controlUsuario.Location = new Point(10, posicionY);

            this.Controls.Add(controlUsuario);
            controlUsuario.Start(numColores);

            controlUsuario.Show();

            ObtenerColorRandom();

            ObtenerColoresDisponibles();

        }

        /// <summary>
        /// Rellenamos la solución con colores randoms
        /// </summary>
        private void ObtenerColorRandom()
        {
            arrayColores = new Color[10];
            Random random = new Random();

            arrayColores[0] = Color.Red;
            arrayColores[1] = Color.Blue;
            arrayColores[2] = Color.Green;
            arrayColores[3] = Color.Yellow;
            arrayColores[4] = Color.Gold;
            arrayColores[5] = Color.Orange;
            arrayColores[6] = Color.Navy;
            arrayColores[7] = Color.Aqua;
            arrayColores[8] = Color.Brown;
            arrayColores[9] = Color.Violet;

            listaSolucionColores = new List<Color>();

            for(int i = 0; i < numColores; i++)
            {
                listaSolucionColores.Add(arrayColores[random.Next(0,10)]);
            }

            pictureBox18.BackColor = listaSolucionColores[0];
            pictureBox17.BackColor = listaSolucionColores[1];
            pictureBox16.BackColor = listaSolucionColores[2];
            pictureBox15.BackColor = listaSolucionColores[3];

            if(numColores > 4)
            {
                pictureBox14.BackColor = listaSolucionColores[4];
                if (numColores > 5)
                {
                    pictureBox13.BackColor = listaSolucionColores[5];
                }
            }           

        }

        /// <summary>
        /// Obtenemos los colores disponibles que mostramos al usuario
        /// </summary>
        private void ObtenerColoresDisponibles()
        {
            Color[] coloresDisponibles = ColorRandom();
            
            pictureBox12.BackColor = coloresDisponibles[0];
            pictureBox11.BackColor = coloresDisponibles[1];
            pictureBox10.BackColor = coloresDisponibles[2];
            pictureBox9.BackColor = coloresDisponibles[3];

            if (numColores > 4)
            {
                pictureBox8.BackColor = coloresDisponibles[4];
                if (numColores > 5)
                {
                    pictureBox7.BackColor = coloresDisponibles[5];
                }
            }
            
        }

        private Color[] ColorRandom()
        {
            Color[] listaPaleta = new Color[numColores];
            Color[] listaComprobante = null;
            Random random = new Random();

            for (int i = 0; i < numColores; i++)
            {
                if(listaComprobante == null )
                {
                    listaComprobante = new Color[numColores];
                    listaPaleta[i] = listaSolucionColores[i];
                }
                else if(Array.Exists(listaComprobante, element => element == listaSolucionColores[i]))
                {

                    listaPaleta[i] = arrayColores[random.Next(0, 10)];

                    while (Array.Exists(listaComprobante, element => element == listaPaleta[i]))
                    {
                        listaPaleta[i] = arrayColores[random.Next(0, 10)];
                    }
                   
                }
                else
                {
                    listaPaleta[i] = listaSolucionColores[i];
                }

                listaComprobante[i] = listaPaleta[i];
            }

            return listaPaleta;
        }

        /// <summary>
        /// Botón para comprobar los colores introducidos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            List<Color> resultado;
            ControlUsuario controlUsuario1 = new ControlUsuario();

            clicks = 0;

            resultado = controlUsuario.ComprobarColores(listaSolucionColores);

            if (resultado.Count == instanciaJuego.getNumColores())
            {

                if (!resultado.Contains(Color.White))
                {
                    //Hemos ganado
                    MessageBox.Show("¡Has ganado!");
                }
                else
                {
                    posicionY += 50;

                    button1.Location = new Point(155, posicionY + 21);

                    controlUsuario1 = new ControlUsuario();
                    controlUsuario1.Location = new Point(10, posicionY);

                    this.Controls.Add(controlUsuario1);
                    controlUsuario1.Start(numColores);

                    controlUsuario1.Show();

                }
                       
            }
            else
            {
                posicionY += 50;

                button1.Location = new Point(155, posicionY + 21);

                controlUsuario1 = new ControlUsuario();
                controlUsuario1.Location = new Point(10, posicionY);

                this.Controls.Add(controlUsuario1);
                controlUsuario1.Start(numColores);

                controlUsuario1.Show();

            }

            controlUsuario = controlUsuario1;

        }

        /// <summary>
        /// Evento que obtiene el color seleccionado por el usuario y lo añade
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox12_Click(object sender, EventArgs e)
        {

            PictureBox picture = (PictureBox)sender;

            switch(clicks)
            {
                case 0:
                    controlUsuario.LlenarPaleta1(picture.BackColor);
                    break;
                case 1:
                    controlUsuario.LlenarPaleta2(picture.BackColor);
                    break;
                case 2:
                    controlUsuario.LlenarPaleta3(picture.BackColor);
                    break;
                case 3:
                    controlUsuario.LlenarPaleta4(picture.BackColor);
                    break;
                case 4:
                    controlUsuario.LlenarPaleta5(picture.BackColor);
                    break;
                case 5:
                    controlUsuario.LlenarPaleta6(picture.BackColor);
                    break;
                

            }

            clicks++;
        }
    }
}
