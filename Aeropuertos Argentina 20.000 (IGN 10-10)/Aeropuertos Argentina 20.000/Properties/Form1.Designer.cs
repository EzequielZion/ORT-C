namespace Aeropuertos_Argentina_20._000
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnIngresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.dtpSalida = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAerolínea = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nudPrecio = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nudCantPasajeros = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnResultados = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantPasajeros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(17, 345);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(369, 38);
            this.btnIngresar.TabIndex = 0;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "-Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(76, 131);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(310, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(76, 183);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(310, 20);
            this.txtDestino.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "-Origen";
            // 
            // txtOrigen
            // 
            this.txtOrigen.Location = new System.Drawing.Point(76, 157);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.Size = new System.Drawing.Size(310, 20);
            this.txtOrigen.TabIndex = 8;
            // 
            // dtpSalida
            // 
            this.dtpSalida.Location = new System.Drawing.Point(107, 235);
            this.dtpSalida.Name = "dtpSalida";
            this.dtpSalida.Size = new System.Drawing.Size(279, 20);
            this.dtpSalida.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(226, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ingrese los siguientes datos por vuelo:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAerolínea
            // 
            this.txtAerolínea.Location = new System.Drawing.Point(76, 209);
            this.txtAerolínea.Name = "txtAerolínea";
            this.txtAerolínea.Size = new System.Drawing.Size(310, 20);
            this.txtAerolínea.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "-Destino";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "-Aerolínea";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "-Fecha de salida";
            // 
            // nudPrecio
            // 
            this.nudPrecio.DecimalPlaces = 2;
            this.nudPrecio.Location = new System.Drawing.Point(131, 293);
            this.nudPrecio.Name = "nudPrecio";
            this.nudPrecio.Size = new System.Drawing.Size(255, 20);
            this.nudPrecio.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "-Precio del pasaje";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 315);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "-Cantidad de pasajeros";
            // 
            // nudCantPasajeros
            // 
            this.nudCantPasajeros.Location = new System.Drawing.Point(131, 319);
            this.nudCantPasajeros.Name = "nudCantPasajeros";
            this.nudCantPasajeros.Size = new System.Drawing.Size(255, 20);
            this.nudCantPasajeros.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 260);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "-Número de puerta";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(107, 260);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(279, 23);
            this.btnGenerar.TabIndex = 21;
            this.btnGenerar.Text = "Generar número";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnResultados
            // 
            this.btnResultados.Location = new System.Drawing.Point(17, 389);
            this.btnResultados.Name = "btnResultados";
            this.btnResultados.Size = new System.Drawing.Size(369, 38);
            this.btnResultados.TabIndex = 22;
            this.btnResultados.Text = "Mostrar resultados";
            this.btnResultados.UseVisualStyleBackColor = true;
            this.btnResultados.Click += new System.EventHandler(this.btnResultados_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(58, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(403, 437);
            this.Controls.Add(this.btnResultados);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nudCantPasajeros);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nudPrecio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAerolínea);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpSalida);
            this.Controls.Add(this.txtOrigen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnIngresar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantPasajeros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOrigen;
        private System.Windows.Forms.DateTimePicker dtpSalida;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAerolínea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudPrecio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudCantPasajeros;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnResultados;


    }
}

