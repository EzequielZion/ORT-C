namespace Programación_Números_Romanos
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
            this.txtNúmero = new System.Windows.Forms.TextBox();
            this.lblSinImportancia = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNúmero
            // 
            this.txtNúmero.Font = new System.Drawing.Font("Goudy Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNúmero.Location = new System.Drawing.Point(16, 54);
            this.txtNúmero.Name = "txtNúmero";
            this.txtNúmero.Size = new System.Drawing.Size(255, 23);
            this.txtNúmero.TabIndex = 0;
            // 
            // lblSinImportancia
            // 
            this.lblSinImportancia.Font = new System.Drawing.Font("Goudy Old Style", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinImportancia.Location = new System.Drawing.Point(12, 9);
            this.lblSinImportancia.Name = "lblSinImportancia";
            this.lblSinImportancia.Size = new System.Drawing.Size(259, 42);
            this.lblSinImportancia.TabIndex = 1;
            this.lblSinImportancia.Text = "Ingrese un número natural  y haga click \r\nen convertir.";
            // 
            // lblResultado
            // 
            this.lblResultado.Font = new System.Drawing.Font("Goudy Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(13, 109);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(258, 16);
            this.lblResultado.TabIndex = 2;
            this.lblResultado.Text = "Número:";
            // 
            // btnConvertir
            // 
            this.btnConvertir.Font = new System.Drawing.Font("Goudy Old Style", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertir.Location = new System.Drawing.Point(16, 83);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(255, 23);
            this.btnConvertir.TabIndex = 3;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 134);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblSinImportancia);
            this.Controls.Add(this.txtNúmero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNúmero;
        private System.Windows.Forms.Label lblSinImportancia;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnConvertir;
    }
}

