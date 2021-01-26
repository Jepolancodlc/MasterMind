
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botondelcolor
            // 
            this.botondelcolor.Location = new System.Drawing.Point(32, 91);
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
            this.colorboton.Location = new System.Drawing.Point(22, 28);
            this.colorboton.Name = "colorboton";
            this.colorboton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.colorboton.Size = new System.Drawing.Size(94, 45);
            this.colorboton.TabIndex = 1;
            this.colorboton.UseVisualStyleBackColor = false;
            this.colorboton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.button1.Location = new System.Drawing.Point(122, 28);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(94, 45);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.button2.Location = new System.Drawing.Point(222, 28);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button2.Size = new System.Drawing.Size(94, 45);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.button3.Location = new System.Drawing.Point(322, 28);
            this.button3.Name = "button3";
            this.button3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button3.Size = new System.Drawing.Size(94, 45);
            this.button3.TabIndex = 4;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.button4.Location = new System.Drawing.Point(422, 28);
            this.button4.Name = "button4";
            this.button4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button4.Size = new System.Drawing.Size(94, 45);
            this.button4.TabIndex = 5;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.button5.Location = new System.Drawing.Point(522, 28);
            this.button5.Name = "button5";
            this.button5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button5.Size = new System.Drawing.Size(94, 45);
            this.button5.TabIndex = 6;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // FormConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.colorboton);
            this.Controls.Add(this.botondelcolor);
            this.Name = "FormConfiguracion";
            this.Text = "FormConfiguracion";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button botondelcolor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button colorboton;

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}