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
        //Atributos TODO
        ControlUsuario controlUsuario;
        Juego instanciaJuego;
        List<Color> listaSolucionColores; //TODO
        int posicionY = 10;
        private int numColores;

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

            

        }

        /// <summary>
        /// Rellenamos la solución con colores randoms
        /// </summary>
        private void ObtenerColorRandom()
        {
            Color[] arrayColores = new Color[10];
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
        /// Botón para comprobar los colores introducidos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            List<Color> resultado;
            ControlUsuario controlUsuario1 = new ControlUsuario();

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
    }
}
