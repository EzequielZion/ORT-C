namespace PruebaLocaClasesYObjetos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreProvincia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombreCiudad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nudCantHabitantes = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.nudCantMetrosCuadrados = new System.Windows.Forms.NumericUpDown();
            this.btnIngresarCiudad = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.cmbProvincias = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantHabitantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantMetrosCuadrados)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(254, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ingresar provincia";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese las provincias:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // txtNombreProvincia
            // 
            this.txtNombreProvincia.Location = new System.Drawing.Point(15, 48);
            this.txtNombreProvincia.Name = "txtNombreProvincia";
            this.txtNombreProvincia.Size = new System.Drawing.Size(254, 20);
            this.txtNombreProvincia.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Seleccione la provincia de la ciudad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ingrese datos de ciudades:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nombre de la ciudad:";
            // 
            // txtNombreCiudad
            // 
            this.txtNombreCiudad.Location = new System.Drawing.Point(15, 178);
            this.txtNombreCiudad.Name = "txtNombreCiudad";
            this.txtNombreCiudad.Size = new System.Drawing.Size(254, 20);
            this.txtNombreCiudad.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Cantidad de habitantes de la ciudad:";
            // 
            // nudCantHabitantes
            // 
            this.nudCantHabitantes.Location = new System.Drawing.Point(15, 218);
            this.nudCantHabitantes.Maximum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            this.nudCantHabitantes.Name = "nudCantHabitantes";
            this.nudCantHabitantes.Size = new System.Drawing.Size(254, 20);
            this.nudCantHabitantes.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Cantidad de m² de la ciudad:";
            // 
            // nudCantMetrosCuadrados
            // 
            this.nudCantMetrosCuadrados.Location = new System.Drawing.Point(12, 257);
            this.nudCantMetrosCuadrados.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudCantMetrosCuadrados.Name = "nudCantMetrosCuadrados";
            this.nudCantMetrosCuadrados.Size = new System.Drawing.Size(257, 20);
            this.nudCantMetrosCuadrados.TabIndex = 12;
            // 
            // btnIngresarCiudad
            // 
            this.btnIngresarCiudad.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.btnIngresarCiudad.Location = new System.Drawing.Point(12, 283);
            this.btnIngresarCiudad.Name = "btnIngresarCiudad";
            this.btnIngresarCiudad.Size = new System.Drawing.Size(257, 23);
            this.btnIngresarCiudad.TabIndex = 13;
            this.btnIngresarCiudad.Text = "Ingresar ciudad";
            this.btnIngresarCiudad.UseVisualStyleBackColor = true;
            this.btnIngresarCiudad.Click += new System.EventHandler(this.btnIngresarCiudad_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.btnFinalizar.BackColor = System.Drawing.Color.MistyRose;
            this.btnFinalizar.Location = new System.Drawing.Point(12, 312);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(257, 23);
            this.btnFinalizar.TabIndex = 14;
            this.btnFinalizar.Text = "Mostrar datos finales";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // cmbProvincias
            // 
            this.cmbProvincias.FormattingEnabled = true;
            this.cmbProvincias.Location = new System.Drawing.Point(15, 138);
            this.cmbProvincias.Name = "cmbProvincias";
            this.cmbProvincias.Size = new System.Drawing.Size(254, 21);
            this.cmbProvincias.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 337);
            this.Controls.Add(this.cmbProvincias);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnIngresarCiudad);
            this.Controls.Add(this.nudCantMetrosCuadrados);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nudCantHabitantes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNombreCiudad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombreProvincia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudCantHabitantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantMetrosCuadrados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreProvincia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombreCiudad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudCantHabitantes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudCantMetrosCuadrados;
        private System.Windows.Forms.Button btnIngresarCiudad;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.ComboBox cmbProvincias;
    }
}

