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
            this.cmbVehiculos.Location = new System.Drawing.Point(25, 63);
            this.cmbVehiculos.Name = "cmbVehiculos";
            this.cmbVehiculos.Size = new System.Drawing.Size(121, 21);
            this.cmbVehiculos.TabIndex = 1;
            this.cmbVehiculos.SelectedIndexChanged += new System.EventHandler(this.cmbVehiculos_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 273);
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
    }
}

