namespace WindowsFormsApplication1
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
            this.lblSeleccione = new System.Windows.Forms.Label();
            this.cmbVehiculos = new System.Windows.Forms.ComboBox();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnRecaudacion = new System.Windows.Forms.Button();
            this.btnVehiculosTot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSeleccione
            // 
            this.lblSeleccione.AutoSize = true;
            this.lblSeleccione.Location = new System.Drawing.Point(22, 22);
            this.lblSeleccione.Name = "lblSeleccione";
            this.lblSeleccione.Size = new System.Drawing.Size(154, 13);
            this.lblSeleccione.TabIndex = 0;
            this.lblSeleccione.Text = "Seleccione su tipo de vehículo";
            // 
            // cmbVehiculos
            // 
            this.cmbVehiculos.FormattingEnabled = true;
            this.cmbVehiculos.Items.AddRange(new object[] {
            "Auto",
            "Moto",
            "Camión",
            "Camioneta"});
            this.cmbVehiculos.Location = new System.Drawing.Point(25, 38);
            this.cmbVehiculos.Name = "cmbVehiculos";
            this.cmbVehiculos.Size = new System.Drawing.Size(202, 21);
            this.cmbVehiculos.TabIndex = 1;
            this.cmbVehiculos.SelectedIndexChanged += new System.EventHandler(this.cmbVehiculos_SelectedIndexChanged);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(25, 65);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(219, 30);
            this.btnFinalizar.TabIndex = 2;
            this.btnFinalizar.Text = "Finalizar día ";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnRecaudacion
            // 
            this.btnRecaudacion.Location = new System.Drawing.Point(25, 101);
            this.btnRecaudacion.Name = "btnRecaudacion";
            this.btnRecaudacion.Size = new System.Drawing.Size(219, 30);
            this.btnRecaudacion.TabIndex = 3;
            this.btnRecaudacion.Text = "Recaudación total";
            this.btnRecaudacion.UseVisualStyleBackColor = true;
            this.btnRecaudacion.Click += new System.EventHandler(this.btnRecaudacion_Click);
            // 
            // btnVehiculosTot
            // 
            this.btnVehiculosTot.Location = new System.Drawing.Point(25, 137);
            this.btnVehiculosTot.Name = "btnVehiculosTot";
            this.btnVehiculosTot.Size = new System.Drawing.Size(219, 30);
            this.btnVehiculosTot.TabIndex = 4;
            this.btnVehiculosTot.Text = "Vehículos totales";
            this.btnVehiculosTot.UseVisualStyleBackColor = true;
            this.btnVehiculosTot.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 246);
            this.Controls.Add(this.btnVehiculosTot);
            this.Controls.Add(this.btnRecaudacion);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.cmbVehiculos);
            this.Controls.Add(this.lblSeleccione);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSeleccione;
        private System.Windows.Forms.ComboBox cmbVehiculos;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnRecaudacion;
        private System.Windows.Forms.Button btnVehiculosTot;
    }
}

