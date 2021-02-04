using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterMind.Formularios
{
    public partial class FormPopUp : Form
    {
        public FormPopUp()
        {
            InitializeComponent();
        }

        public void uploadImage(Image imagen)
        {
            pictureBox1.Image = imagen;

        }
        public void uploadText(string text)
        {
            label1.Text = text;
            label1.ForeColor = Color.Red;
        }

        private void cerrar(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
