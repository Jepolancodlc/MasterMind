
namespace MasterMind
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.botondelcolor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorboton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 37);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "gnbeidwasdwa\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 289);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.colorboton);
            this.Controls.Add(this.botondelcolor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botondelcolor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button colorboton;
        private System.Windows.Forms.Label label1;
    }
}

