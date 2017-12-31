namespace Inmobiliaria
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDire = new System.Windows.Forms.TextBox();
            this.nudAmb = new System.Windows.Forms.NumericUpDown();
            this.nudPrecio = new System.Windows.Forms.NumericUpDown();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.lblCaro = new System.Windows.Forms.Label();
            this.lblAmbientes = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inmobiliaria:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Forte", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(236, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "\"la binaria\"";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingrese la dirección de la propiedad vendida:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(260, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ingrese la cantidad de ambientes de dicha propiedad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ingrese el precio de lista de la propiedad:";
            // 
            // txtDire
            // 
            this.txtDire.Location = new System.Drawing.Point(15, 57);
            this.txtDire.Name = "txtDire";
            this.txtDire.Size = new System.Drawing.Size(416, 20);
            this.txtDire.TabIndex = 5;
            // 
            // nudAmb
            // 
            this.nudAmb.Location = new System.Drawing.Point(15, 97);
            this.nudAmb.Maximum = new decimal(new int[] {
            1978789,
            0,
            0,
            0});
            this.nudAmb.Name = "nudAmb";
            this.nudAmb.Size = new System.Drawing.Size(416, 20);
            this.nudAmb.TabIndex = 6;
            // 
            // nudPrecio
            // 
            this.nudPrecio.DecimalPlaces = 2;
            this.nudPrecio.Location = new System.Drawing.Point(15, 138);
            this.nudPrecio.Maximum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            this.nudPrecio.Minimum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.nudPrecio.Name = "nudPrecio";
            this.nudPrecio.Size = new System.Drawing.Size(416, 20);
            this.nudPrecio.TabIndex = 7;
            this.nudPrecio.Value = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(15, 191);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(416, 23);
            this.btnFinalizar.TabIndex = 8;
            this.btnFinalizar.Text = "Finalizar semana";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // lblCaro
            // 
            this.lblCaro.AutoSize = true;
            this.lblCaro.Location = new System.Drawing.Point(12, 217);
            this.lblCaro.Name = "lblCaro";
            this.lblCaro.Size = new System.Drawing.Size(140, 26);
            this.lblCaro.TabIndex = 9;
            this.lblCaro.Text = "La propiedad más cara y su \r\ncorrespondiente valor son: ";
            // 
            // lblAmbientes
            // 
            this.lblAmbientes.AutoSize = true;
            this.lblAmbientes.Location = new System.Drawing.Point(12, 253);
            this.lblAmbientes.Name = "lblAmbientes";
            this.lblAmbientes.Size = new System.Drawing.Size(165, 26);
            this.lblAmbientes.TabIndex = 10;
            this.lblAmbientes.Text = "La dirección de la propiedad con \r\nmás ambientes es: ";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(12, 296);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(183, 13);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "La recaudación de la semana fue de:";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(15, 164);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(416, 23);
            this.btnIngresar.TabIndex = 12;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 318);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblAmbientes);
            this.Controls.Add(this.lblCaro);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.nudPrecio);
            this.Controls.Add(this.nudAmb);
            this.Controls.Add(this.txtDire);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudAmb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDire;
        private System.Windows.Forms.NumericUpDown nudAmb;
        private System.Windows.Forms.NumericUpDown nudPrecio;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Label lblCaro;
        private System.Windows.Forms.Label lblAmbientes;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnIngresar;
    }
}

