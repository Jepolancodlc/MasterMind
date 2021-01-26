
namespace MasterMind
{
    partial class FormConfiguracion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.botondelcolor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorboton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botondelcolor
            // 
            this.botondelcolor.Location = new System.Drawing.Point(22, 126);
            this.botondelcolor.Name = "botondelcolor";
            this.botondelcolor.Size = new System.Drawing.Size(75, 23);
            this.botondelcolor.TabIndex = 0;
            this.botondelcolor.Text = "Elije el color";
            this.botondelcolor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.botondelcolor.UseMnemonic = false;
            this.botondelcolor.UseVisualStyleBackColor = true;
            this.botondelcolor.UseWaitCursor = true;
            this.botondelcolor.Click += new System.EventHandler(this.button1_Click);
            // 
            // colorboton
            // 
            this.colorboton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.colorboton.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.colorboton.Location = new System.Drawing.Point(12, 75);
            this.colorboton.Name = "colorboton";
            this.colorboton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.colorboton.Size = new System.Drawing.Size(94, 45);
            this.colorboton.TabIndex = 1;
            this.colorboton.UseVisualStyleBackColor = false;
            this.colorboton.Click += new System.EventHandler(this.button1_Click_1);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.colorboton);
            this.Controls.Add(this.botondelcolor);
            this.Text = "FormConfiguracion";




        }

        private System.Windows.Forms.Button botondelcolor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button colorboton;

        #endregion
    }
}