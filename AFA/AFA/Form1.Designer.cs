namespace AFA
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEquipo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEquipo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbEquipos = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.nudSueldo = new System.Windows.Forms.NumericUpDown();
            this.nudEdad = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnFinalizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSueldo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Onyx", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Asociación del Fútbol Argentino";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(125, 385);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnEquipo
            // 
            this.btnEquipo.Location = new System.Drawing.Point(12, 104);
            this.btnEquipo.Name = "btnEquipo";
            this.btnEquipo.Size = new System.Drawing.Size(337, 23);
            this.btnEquipo.TabIndex = 2;
            this.btnEquipo.Text = "Cargar";
            this.btnEquipo.UseVisualStyleBackColor = true;
            this.btnEquipo.Click += new System.EventHandler(this.btnEquipo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Niagara Solid", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ingrese los equipos a la base de datos:";
            // 
            // txtEquipo
            // 
            this.txtEquipo.Location = new System.Drawing.Point(13, 78);
            this.txtEquipo.Name = "txtEquipo";
            this.txtEquipo.Size = new System.Drawing.Size(336, 20);
            this.txtEquipo.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Niagara Solid", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ingrese los jugadores:";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(11, 330);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(338, 23);
            this.btnIngresar.TabIndex = 6;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(10, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Equipo del jugador";
            // 
            // cmbEquipos
            // 
            this.cmbEquipos.FormattingEnabled = true;
            this.cmbEquipos.Location = new System.Drawing.Point(13, 172);
            this.cmbEquipos.Name = "cmbEquipos";
            this.cmbEquipos.Size = new System.Drawing.Size(337, 21);
            this.cmbEquipos.TabIndex = 10;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(13, 217);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(336, 20);
            this.txtNombre.TabIndex = 12;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(13, 258);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(337, 20);
            this.txtApellido.TabIndex = 14;
            // 
            // nudSueldo
            // 
            this.nudSueldo.Location = new System.Drawing.Point(12, 302);
            this.nudSueldo.Maximum = new decimal(new int[] {
            6000000,
            0,
            0,
            0});
            this.nudSueldo.Name = "nudSueldo";
            this.nudSueldo.Size = new System.Drawing.Size(158, 20);
            this.nudSueldo.TabIndex = 16;
            // 
            // nudEdad
            // 
            this.nudEdad.Location = new System.Drawing.Point(179, 302);
            this.nudEdad.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudEdad.Name = "nudEdad";
            this.nudEdad.Size = new System.Drawing.Size(170, 20);
            this.nudEdad.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(10, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 18);
            this.label5.TabIndex = 19;
            this.label5.Text = "Nombre del jugador";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(10, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 18);
            this.label6.TabIndex = 20;
            this.label6.Text = "Apellido del jugador";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label7.Location = new System.Drawing.Point(10, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 18);
            this.label7.TabIndex = 21;
            this.label7.Text = "Sueldo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label8.Location = new System.Drawing.Point(176, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 18);
            this.label8.TabIndex = 22;
            this.label8.Text = "Edad:";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFinalizar.Location = new System.Drawing.Point(11, 359);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(338, 23);
            this.btnFinalizar.TabIndex = 23;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 488);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nudEdad);
            this.Controls.Add(this.nudSueldo);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.cmbEquipos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtEquipo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEquipo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSueldo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEquipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEquipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbEquipos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.NumericUpDown nudSueldo;
        private System.Windows.Forms.NumericUpDown nudEdad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnFinalizar;
    }
}

