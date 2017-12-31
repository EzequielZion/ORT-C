namespace Mueblería
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
            this.label4 = new System.Windows.Forms.Label();
            this.nudSillas = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFactura = new System.Windows.Forms.TextBox();
            this.cmbTamaño = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nudCódigo = new System.Windows.Forms.NumericUpDown();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblPago = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnFin = new System.Windows.Forms.Button();
            this.lblCódigoMenos = new System.Windows.Forms.Label();
            this.lblCódigoMás = new System.Windows.Forms.Label();
            this.lblMPMenos = new System.Windows.Forms.Label();
            this.lblMPMás = new System.Windows.Forms.Label();
            this.lblRecaudaciónTotal = new System.Windows.Forms.Label();
            this.lblDescuentos = new System.Windows.Forms.Label();
            this.lblSillas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudSillas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCódigo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mueblería:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingrese el código del set:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(169, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ingrese cuántas sillas tendrá el set:";
            // 
            // nudSillas
            // 
            this.nudSillas.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSillas.Location = new System.Drawing.Point(169, 70);
            this.nudSillas.Name = "nudSillas";
            this.nudSillas.Size = new System.Drawing.Size(151, 23);
            this.nudSillas.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ingrese la factura del cliente:";
            // 
            // txtFactura
            // 
            this.txtFactura.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFactura.Location = new System.Drawing.Point(12, 164);
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.Size = new System.Drawing.Size(308, 21);
            this.txtFactura.TabIndex = 9;
            // 
            // cmbTamaño
            // 
            this.cmbTamaño.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTamaño.FormattingEnabled = true;
            this.cmbTamaño.Items.AddRange(new object[] {
            "Chico",
            "Mediano",
            "Grande"});
            this.cmbTamaño.Location = new System.Drawing.Point(12, 70);
            this.cmbTamaño.Name = "cmbTamaño";
            this.cmbTamaño.Size = new System.Drawing.Size(151, 23);
            this.cmbTamaño.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ingrese el tamaño del set:";
            // 
            // nudCódigo
            // 
            this.nudCódigo.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCódigo.Location = new System.Drawing.Point(12, 117);
            this.nudCódigo.Name = "nudCódigo";
            this.nudCódigo.Size = new System.Drawing.Size(308, 23);
            this.nudCódigo.TabIndex = 14;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(12, 219);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(96, 16);
            this.lblCliente.TabIndex = 15;
            this.lblCliente.Text = "El cliente pagará: ";
            // 
            // lblPago
            // 
            this.lblPago.AutoSize = true;
            this.lblPago.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPago.Location = new System.Drawing.Point(12, 242);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(0, 33);
            this.lblPago.TabIndex = 16;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnOk.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(12, 192);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(308, 24);
            this.btnOk.TabIndex = 17;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnFin
            // 
            this.btnFin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnFin.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFin.Location = new System.Drawing.Point(12, 238);
            this.btnFin.Name = "btnFin";
            this.btnFin.Size = new System.Drawing.Size(308, 24);
            this.btnFin.TabIndex = 18;
            this.btnFin.Text = "Finalizar";
            this.btnFin.UseVisualStyleBackColor = false;
            this.btnFin.Click += new System.EventHandler(this.btnFin_Click);
            // 
            // lblCódigoMenos
            // 
            this.lblCódigoMenos.AutoSize = true;
            this.lblCódigoMenos.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCódigoMenos.Location = new System.Drawing.Point(12, 265);
            this.lblCódigoMenos.Name = "lblCódigoMenos";
            this.lblCódigoMenos.Size = new System.Drawing.Size(160, 16);
            this.lblCódigoMenos.TabIndex = 19;
            this.lblCódigoMenos.Text = "El código menos elegido fue el: ";
            // 
            // lblCódigoMás
            // 
            this.lblCódigoMás.AutoSize = true;
            this.lblCódigoMás.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCódigoMás.Location = new System.Drawing.Point(12, 307);
            this.lblCódigoMás.Name = "lblCódigoMás";
            this.lblCódigoMás.Size = new System.Drawing.Size(148, 16);
            this.lblCódigoMás.TabIndex = 20;
            this.lblCódigoMás.Text = "El código más elegido fue el: ";
            // 
            // lblMPMenos
            // 
            this.lblMPMenos.AutoSize = true;
            this.lblMPMenos.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMPMenos.Location = new System.Drawing.Point(12, 283);
            this.lblMPMenos.Name = "lblMPMenos";
            this.lblMPMenos.Size = new System.Drawing.Size(192, 16);
            this.lblMPMenos.TabIndex = 21;
            this.lblMPMenos.Text = "Y su material y precio respectivo son: ";
            // 
            // lblMPMás
            // 
            this.lblMPMás.AutoSize = true;
            this.lblMPMás.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMPMás.Location = new System.Drawing.Point(12, 323);
            this.lblMPMás.Name = "lblMPMás";
            this.lblMPMás.Size = new System.Drawing.Size(192, 16);
            this.lblMPMás.TabIndex = 22;
            this.lblMPMás.Text = "Y su material y precio respectivo son: ";
            // 
            // lblRecaudaciónTotal
            // 
            this.lblRecaudaciónTotal.AutoSize = true;
            this.lblRecaudaciónTotal.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecaudaciónTotal.Location = new System.Drawing.Point(12, 402);
            this.lblRecaudaciónTotal.Name = "lblRecaudaciónTotal";
            this.lblRecaudaciónTotal.Size = new System.Drawing.Size(147, 16);
            this.lblRecaudaciónTotal.TabIndex = 23;
            this.lblRecaudaciónTotal.Text = "La recaudación total fue de: ";
            // 
            // lblDescuentos
            // 
            this.lblDescuentos.AutoSize = true;
            this.lblDescuentos.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescuentos.Location = new System.Drawing.Point(12, 349);
            this.lblDescuentos.Name = "lblDescuentos";
            this.lblDescuentos.Size = new System.Drawing.Size(227, 16);
            this.lblDescuentos.TabIndex = 24;
            this.lblDescuentos.Text = "La cantidad de descuentos realizados fue de: ";
            // 
            // lblSillas
            // 
            this.lblSillas.AutoSize = true;
            this.lblSillas.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSillas.Location = new System.Drawing.Point(12, 374);
            this.lblSillas.Name = "lblSillas";
            this.lblSillas.Size = new System.Drawing.Size(189, 16);
            this.lblSillas.TabIndex = 25;
            this.lblSillas.Text = "La cantidad de sillas vendidas fue de: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(334, 430);
            this.Controls.Add(this.lblSillas);
            this.Controls.Add(this.lblDescuentos);
            this.Controls.Add(this.lblRecaudaciónTotal);
            this.Controls.Add(this.lblMPMás);
            this.Controls.Add(this.lblMPMenos);
            this.Controls.Add(this.lblCódigoMás);
            this.Controls.Add(this.lblCódigoMenos);
            this.Controls.Add(this.btnFin);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblPago);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.nudCódigo);
            this.Controls.Add(this.cmbTamaño);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFactura);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudSillas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.nudSillas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCódigo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudSillas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFactura;
        private System.Windows.Forms.ComboBox cmbTamaño;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudCódigo;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblPago;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnFin;
        private System.Windows.Forms.Label lblCódigoMenos;
        private System.Windows.Forms.Label lblCódigoMás;
        private System.Windows.Forms.Label lblMPMenos;
        private System.Windows.Forms.Label lblMPMás;
        private System.Windows.Forms.Label lblRecaudaciónTotal;
        private System.Windows.Forms.Label lblDescuentos;
        private System.Windows.Forms.Label lblSillas;


    }
}

