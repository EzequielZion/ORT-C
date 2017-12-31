namespace Notas
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
            this.nudNotas = new System.Windows.Forms.NumericUpDown();
            this.lblIngresar = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudNotas)).BeginInit();
            this.SuspendLayout();
            // 
            // nudNotas
            // 
            this.nudNotas.Location = new System.Drawing.Point(12, 31);
            this.nudNotas.Name = "nudNotas";
            this.nudNotas.Size = new System.Drawing.Size(167, 20);
            this.nudNotas.TabIndex = 0;
            // 
            // lblIngresar
            // 
            this.lblIngresar.AutoSize = true;
            this.lblIngresar.Location = new System.Drawing.Point(13, 12);
            this.lblIngresar.Name = "lblIngresar";
            this.lblIngresar.Size = new System.Drawing.Size(120, 13);
            this.lblIngresar.TabIndex = 1;
            this.lblIngresar.Text = "Ingrese su primera nota:";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(12, 72);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 50);
            this.btnIngresar.TabIndex = 2;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(104, 72);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(75, 50);
            this.btnFinalizar.TabIndex = 3;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(195, 134);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.lblIngresar);
            this.Controls.Add(this.nudNotas);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudNotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudNotas;
        private System.Windows.Forms.Label lblIngresar;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnFinalizar;
    }
}

