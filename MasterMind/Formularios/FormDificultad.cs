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
    public partial class FormDificultad : Form
    {
        FormJugar formularioJugar;
        public FormDificultad()
        {
            InitializeComponent();
            
        }

        public void bt_Aceptar_Click(object sender, EventArgs e)
        {
            //Principiante
            if(radioButton1.Checked)
            {
                 formularioJugar = new FormJugar(4,10);
                
            } 
            else if (radioButton2.Checked)
            { // Intermedio
                 formularioJugar = new FormJugar(5,8);              
            }
            else
            { // Avanzado
                 formularioJugar = new FormJugar(6,6);            
            }

          formularioJugar.Show();

            // FormConfiguracion formConfiguracion = new FormConfiguracion(instanciaJuego.getNumColores());TODO

            // formConfiguracion.Show();TODO
            this.Hide();
        }
        public void bt_Cancelar_Click(object sender, EventArgs e)
        {
            //Modo principiante
            formularioJugar = new FormJugar(4, 10);

            formularioJugar.Show();

            // FormConfiguracion formConfiguracion = new FormConfiguracion(instanciaJuego); TODO

            //formConfiguracion.Show();TODO
            this.Hide();
        }
       
    }
}
