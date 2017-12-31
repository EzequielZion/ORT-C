namespace Consultorio
{
    partial class frmConsultorio
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
            this.cmbEstudios = new System.Windows.Forms.ComboBox();
            this.rbtMujer = new System.Windows.Forms.RadioButton();
            this.rbtHombre = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.nudEdad = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDía = new System.Windows.Forms.Button();
            this.btnMes = new System.Windows.Forms.Button();
            this.btnRealizar = new System.Windows.Forms.Button();
            this.rbtEfectivo = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.rbtTarjeta = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbtCapital = new System.Windows.Forms.RadioButton();
            this.rbtGBA = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbEstudios
            // 
            this.cmbEstudios.FormattingEnabled = true;
            this.cmbEstudios.Items.AddRange(new object[] {
            "Radiografía",
            "Implantes",
            "Ecografía",
            "Análisis de orina"});
            this.cmbEstudios.Location = new System.Drawing.Point(18, 146);
            this.cmbEstudios.Name = "cmbEstudios";
            this.cmbEstudios.Size = new System.Drawing.Size(121, 21);
            this.cmbEstudios.TabIndex = 2;
            // 
            // rbtMujer
            // 
            this.rbtMujer.AutoSize = true;
            this.rbtMujer.Location = new System.Drawing.Point(6, 19);
            this.rbtMujer.Name = "rbtMujer";
            this.rbtMujer.Size = new System.Drawing.Size(51, 17);
            this.rbtMujer.TabIndex = 3;
            this.rbtMujer.TabStop = true;
            this.rbtMujer.Text = "Mujer";
            this.rbtMujer.UseVisualStyleBackColor = true;
            // 
            // rbtHombre
            // 
            this.rbtHombre.AutoSize = true;
            this.rbtHombre.Location = new System.Drawing.Point(6, 42);
            this.rbtHombre.Name = "rbtHombre";
            this.rbtHombre.Size = new System.Drawing.Size(62, 17);
            this.rbtHombre.TabIndex = 4;
            this.rbtHombre.TabStop = true;
            this.rbtHombre.Text = "Hombre";
            this.rbtHombre.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Edad";
            // 
            // nudEdad
            // 
            this.nudEdad.Location = new System.Drawing.Point(18, 97);
            this.nudEdad.Name = "nudEdad";
            this.nudEdad.Size = new System.Drawing.Size(120, 20);
            this.nudEdad.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Estudio a realizar";
            // 
            // btnDía
            // 
            this.btnDía.Location = new System.Drawing.Point(205, 12);
            this.btnDía.Name = "btnDía";
            this.btnDía.Size = new System.Drawing.Size(75, 183);
            this.btnDía.TabIndex = 8;
            this.btnDía.Text = "Finalizar día";
            this.btnDía.UseVisualStyleBackColor = true;
            this.btnDía.Click += new System.EventHandler(this.btnDía_Click);
            // 
            // btnMes
            // 
            this.btnMes.Location = new System.Drawing.Point(205, 201);
            this.btnMes.Name = "btnMes";
            this.btnMes.Size = new System.Drawing.Size(75, 159);
            this.btnMes.TabIndex = 9;
            this.btnMes.Text = "Finalizar mes";
            this.btnMes.UseVisualStyleBackColor = true;
            this.btnMes.Click += new System.EventHandler(this.btnMes_Click);
            // 
            // btnRealizar
            // 
            this.btnRealizar.Location = new System.Drawing.Point(12, 326);
            this.btnRealizar.Name = "btnRealizar";
            this.btnRealizar.Size = new System.Drawing.Size(158, 23);
            this.btnRealizar.TabIndex = 10;
            this.btnRealizar.Text = "Realizar estudio";
            this.btnRealizar.UseVisualStyleBackColor = true;
            this.btnRealizar.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbtEfectivo
            // 
            this.rbtEfectivo.AutoSize = true;
            this.rbtEfectivo.Location = new System.Drawing.Point(6, 30);
            this.rbtEfectivo.Name = "rbtEfectivo";
            this.rbtEfectivo.Size = new System.Drawing.Size(64, 17);
            this.rbtEfectivo.TabIndex = 11;
            this.rbtEfectivo.TabStop = true;
            this.rbtEfectivo.Text = "Efectivo";
            this.rbtEfectivo.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 12;
            // 
            // rbtTarjeta
            // 
            this.rbtTarjeta.AutoSize = true;
            this.rbtTarjeta.Location = new System.Drawing.Point(6, 53);
            this.rbtTarjeta.Name = "rbtTarjeta";
            this.rbtTarjeta.Size = new System.Drawing.Size(58, 17);
            this.rbtTarjeta.TabIndex = 13;
            this.rbtTarjeta.TabStop = true;
            this.rbtTarjeta.Text = "Tarjeta";
            this.rbtTarjeta.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtMujer);
            this.groupBox1.Controls.Add(this.rbtHombre);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(127, 66);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Género";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtEfectivo);
            this.groupBox2.Controls.Add(this.rbtTarjeta);
            this.groupBox2.Location = new System.Drawing.Point(18, 244);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(131, 76);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Medio de pago de la ambulancia";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbtCapital);
            this.groupBox3.Controls.Add(this.rbtGBA);
            this.groupBox3.Location = new System.Drawing.Point(19, 173);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(131, 65);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lugar de residencia";
            // 
            // rbtCapital
            // 
            this.rbtCapital.AutoSize = true;
            this.rbtCapital.Location = new System.Drawing.Point(7, 19);
            this.rbtCapital.Name = "rbtCapital";
            this.rbtCapital.Size = new System.Drawing.Size(57, 17);
            this.rbtCapital.TabIndex = 11;
            this.rbtCapital.TabStop = true;
            this.rbtCapital.Text = "Capital";
            this.rbtCapital.UseVisualStyleBackColor = true;
            // 
            // rbtGBA
            // 
            this.rbtGBA.AutoSize = true;
            this.rbtGBA.Location = new System.Drawing.Point(6, 39);
            this.rbtGBA.Name = "rbtGBA";
            this.rbtGBA.Size = new System.Drawing.Size(47, 17);
            this.rbtGBA.TabIndex = 13;
            this.rbtGBA.TabStop = true;
            this.rbtGBA.Text = "GBA";
            this.rbtGBA.UseVisualStyleBackColor = true;
            // 
            // frmConsultorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 381);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRealizar);
            this.Controls.Add(this.btnMes);
            this.Controls.Add(this.btnDía);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudEdad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbEstudios);
            this.Name = "frmConsultorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultorio";
            this.Load += new System.EventHandler(this.frmConsultorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEstudios;
        private System.Windows.Forms.RadioButton rbtMujer;
        private System.Windows.Forms.RadioButton rbtHombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudEdad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDía;
        private System.Windows.Forms.Button btnMes;
        private System.Windows.Forms.Button btnRealizar;
        private System.Windows.Forms.RadioButton rbtEfectivo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbtTarjeta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbtCapital;
        private System.Windows.Forms.RadioButton rbtGBA;
    }
}

