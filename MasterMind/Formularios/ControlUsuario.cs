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
