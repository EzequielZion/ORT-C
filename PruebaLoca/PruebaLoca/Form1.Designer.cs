namespace PruebaLoca
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
            this.cmbComida = new System.Windows.Forms.ComboBox();
            this.cmbBebidas = new System.Windows.Forms.ComboBox();
            this.nudBebida = new System.Windows.Forms.NumericUpDown();
            this.nudComida = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGananciaMes = new System.Windows.Forms.Button();
            this.btnGananciasDia = new System.Windows.Forms.Button();
            this.btnIngresosDia = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbModoPago = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudBebida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudComida)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbComida
            // 
            this.cmbComida.FormattingEnabled = true;
            this.cmbComida.Items.AddRange(new object[] {
            "Medialuna",
            "Torta",
            "Sandwich"});
            this.cmbComida.Location = new System.Drawing.Point(9, 74);
            this.cmbComida.Name = "cmbComida";
            this.cmbComida.Size = new System.Drawing.Size(121, 21);
            this.cmbComida.TabIndex = 0;
            // 
            // cmbBebidas
            // 
            this.cmbBebidas.FormattingEnabled = true;
            this.cmbBebidas.Items.AddRange(new object[] {
            "Café",
            "Gaseosa",
            "Té"});
            this.cmbBebidas.Location = new System.Drawing.Point(9, 25);
            this.cmbBebidas.Name = "cmbBebidas";
            this.cmbBebidas.Size = new System.Drawing.Size(121, 21);
            this.cmbBebidas.TabIndex = 1;
            // 
            // nudBebida
            // 
            this.nudBebida.Location = new System.Drawing.Point(151, 25);
            this.nudBebida.Name = "nudBebida";
            this.nudBebida.Size = new System.Drawing.Size(120, 20);
            this.nudBebida.TabIndex = 2;
            // 
            // nudComida
            // 
            this.nudComida.Location = new System.Drawing.Point(150, 75);
            this.nudComida.Name = "nudComida";
            this.nudComida.Size = new System.Drawing.Size(120, 20);
            this.nudComida.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "¿Qué bebida y cuántas tomará el cliente?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "¿Qué comerá y cuántas porciones?";
            // 
            // btnGananciaMes
            // 
            this.btnGananciaMes.Location = new System.Drawing.Point(9, 257);
            this.btnGananciaMes.Name = "btnGananciaMes";
            this.btnGananciaMes.Size = new System.Drawing.Size(119, 23);
            this.btnGananciaMes.TabIndex = 7;
            this.btnGananciaMes.Text = "Ganancias del mes";
            this.btnGananciaMes.UseVisualStyleBackColor = true;
            this.btnGananciaMes.Click += new System.EventHandler(this.btnGananciaMes_Click);
            // 
            // btnGananciasDia
            // 
            this.btnGananciasDia.Location = new System.Drawing.Point(8, 228);
            this.btnGananciasDia.Name = "btnGananciasDia";
            this.btnGananciasDia.Size = new System.Drawing.Size(120, 23);
            this.btnGananciasDia.TabIndex = 8;
            this.btnGananciasDia.Text = "Ganancias del día";
            this.btnGananciasDia.UseVisualStyleBackColor = true;
            this.btnGananciasDia.Click += new System.EventHandler(this.btnGananciasDia_Click);
            // 
            // btnIngresosDia
            // 
            this.btnIngresosDia.Location = new System.Drawing.Point(8, 199);
            this.btnIngresosDia.Name = "btnIngresosDia";
            this.btnIngresosDia.Size = new System.Drawing.Size(120, 23);
            this.btnIngresosDia.TabIndex = 9;
            this.btnIngresosDia.Text = "Ingresos del día";
            this.btnIngresosDia.UseVisualStyleBackColor = true;
            this.btnIngresosDia.Click += new System.EventHandler(this.btnIngresosDia_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Modo de pago";
            // 
            // cmbModoPago
            // 
            this.cmbModoPago.FormattingEnabled = true;
            this.cmbModoPago.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta de crédito",
            "Tarjeta de débito"});
            this.cmbModoPago.Location = new System.Drawing.Point(8, 114);
            this.cmbModoPago.Name = "cmbModoPago";
            this.cmbModoPago.Size = new System.Drawing.Size(262, 21);
            this.cmbModoPago.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 292);
            this.Controls.Add(this.cmbModoPago);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnIngresosDia);
            this.Controls.Add(this.btnGananciasDia);
            this.Controls.Add(this.btnGananciaMes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudComida);
            this.Controls.Add(this.nudBebida);
            this.Controls.Add(this.cmbBebidas);
            this.Controls.Add(this.cmbComida);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudBebida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudComida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbComida;
        private System.Windows.Forms.ComboBox cmbBebidas;
        private System.Windows.Forms.NumericUpDown nudBebida;
        private System.Windows.Forms.NumericUpDown nudComida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGananciaMes;
        private System.Windows.Forms.Button btnGananciasDia;
        private System.Windows.Forms.Button btnIngresosDia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbModoPago;
    }
}

