
namespace MasterMind
{
    partial class FormDificultad
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.gb_SelNivel = new System.Windows.Forms.GroupBox();
            this.bt_Aceptar = new System.Windows.Forms.Button();
            this.bt_Cancelar = new System.Windows.Forms.Button();
            this.gb_SelNivel.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.radioButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(29, 33);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(156, 37);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "Principiante";
            this.radioButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.radioButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.Color.White;
            this.radioButton2.Location = new System.Drawing.Point(29, 74);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(156, 37);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Medio";
            this.radioButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton3
            // 
            this.radioButton3.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.radioButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.radioButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.ForeColor = System.Drawing.Color.White;
            this.radioButton3.Location = new System.Drawing.Point(29, 115);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(156, 37);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "Avanzado";
            this.radioButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // gb_SelNivel
            // 
            this.gb_SelNivel.BackColor = System.Drawing.Color.Transparent;
            this.gb_SelNivel.Controls.Add(this.radioButton3);
            this.gb_SelNivel.Controls.Add(this.radioButton2);
            this.gb_SelNivel.Controls.Add(this.radioButton1);
            this.gb_SelNivel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_SelNivel.Location = new System.Drawing.Point(44, 35);
            this.gb_SelNivel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_SelNivel.Name = "gb_SelNivel";
            this.gb_SelNivel.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_SelNivel.Size = new System.Drawing.Size(211, 169);
            this.gb_SelNivel.TabIndex = 3;
            this.gb_SelNivel.TabStop = false;
            // 
            // bt_Aceptar
            // 
            this.bt_Aceptar.BackColor = System.Drawing.Color.Transparent;
            this.bt_Aceptar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_Aceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.bt_Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Aceptar.ForeColor = System.Drawing.Color.White;
            this.bt_Aceptar.Location = new System.Drawing.Point(44, 234);
            this.bt_Aceptar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Aceptar.Name = "bt_Aceptar";
            this.bt_Aceptar.Size = new System.Drawing.Size(91, 28);
            this.bt_Aceptar.TabIndex = 4;
            this.bt_Aceptar.Text = "Aceptar";
            this.bt_Aceptar.UseVisualStyleBackColor = false;
            this.bt_Aceptar.Click += new System.EventHandler(this.bt_Aceptar_Click);
            // 
            // bt_Cancelar
            // 
            this.bt_Cancelar.BackColor = System.Drawing.Color.Transparent;
            this.bt_Cancelar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_Cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.bt_Cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.bt_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Cancelar.ForeColor = System.Drawing.Color.White;
            this.bt_Cancelar.Location = new System.Drawing.Point(170, 234);
            this.bt_Cancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Cancelar.Name = "bt_Cancelar";
            this.bt_Cancelar.Size = new System.Drawing.Size(85, 28);
            this.bt_Cancelar.TabIndex = 5;
            this.bt_Cancelar.Text = "Cancelar";
            this.bt_Cancelar.UseVisualStyleBackColor = false;
            this.bt_Cancelar.Click += new System.EventHandler(this.bt_Cancelar_Click);
            // 
            // FormDificultad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::MasterMind.Properties.Resources.fond_opt;
            this.ClientSize = new System.Drawing.Size(312, 316);
            this.Controls.Add(this.bt_Cancelar);
            this.Controls.Add(this.bt_Aceptar);
            this.Controls.Add(this.gb_SelNivel);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormDificultad";
            this.Text = "Seleccionar Nivel";
            this.gb_SelNivel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox gb_SelNivel;
        private System.Windows.Forms.Button bt_Aceptar;
        private System.Windows.Forms.Button bt_Cancelar;
    }
}

