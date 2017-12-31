namespace ClubDeBarrio
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
            this.dtpNacimiento = new System.Windows.Forms.DateTimePicker();
            this.cmbDeportes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudSocio = new System.Windows.Forms.NumericUpDown();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnMes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudSocio)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpNacimiento
            // 
            this.dtpNacimiento.Location = new System.Drawing.Point(29, 49);
            this.dtpNacimiento.Name = "dtpNacimiento";
            this.dtpNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpNacimiento.TabIndex = 0;
            // 
            // cmbDeportes
            // 
            this.cmbDeportes.FormattingEnabled = true;
            this.cmbDeportes.Items.AddRange(new object[] {
            "Backgammon",
            "Futbol",
            "Hockey",
            "Pelota-paleta",
            "Burako"});
            this.cmbDeportes.Location = new System.Drawing.Point(29, 175);
            this.cmbDeportes.Name = "cmbDeportes";
            this.cmbDeportes.Size = new System.Drawing.Size(197, 21);
            this.cmbDeportes.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese el año de nacimiento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "¿Desde cuándo es socio?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Deporte que realiza";
            // 
            // nudSocio
            // 
            this.nudSocio.Location = new System.Drawing.Point(32, 124);
            this.nudSocio.Name = "nudSocio";
            this.nudSocio.Size = new System.Drawing.Size(197, 20);
            this.nudSocio.TabIndex = 5;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(29, 216);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(99, 23);
            this.btnIngresar.TabIndex = 6;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnMes
            // 
            this.btnMes.Location = new System.Drawing.Point(134, 216);
            this.btnMes.Name = "btnMes";
            this.btnMes.Size = new System.Drawing.Size(92, 23);
            this.btnMes.TabIndex = 7;
            this.btnMes.Text = "Finalizar mes";
            this.btnMes.UseVisualStyleBackColor = true;
            this.btnMes.Click += new System.EventHandler(this.btnMes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 260);
            this.Controls.Add(this.btnMes);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.nudSocio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbDeportes);
            this.Controls.Add(this.dtpNacimiento);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudSocio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpNacimiento;
        private System.Windows.Forms.ComboBox cmbDeportes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudSocio;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnMes;
    }
}

