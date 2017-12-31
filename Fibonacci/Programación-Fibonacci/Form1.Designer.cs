namespace Programación_Fibonacci
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
            this.btnVecesARealizar = new System.Windows.Forms.Button();
            this.lblSinImportancia1 = new System.Windows.Forms.Label();
            this.lblSinImportancia2 = new System.Windows.Forms.Label();
            this.btnHastaLlegarA = new System.Windows.Forms.Button();
            this.lblSinImportancia3 = new System.Windows.Forms.Label();
            this.btnExistencia = new System.Windows.Forms.Button();
            this.lblSinImportancia = new System.Windows.Forms.Label();
            this.lblFibonacci = new System.Windows.Forms.Label();
            this.nudCant = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudCant)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVecesARealizar
            // 
            this.btnVecesARealizar.Location = new System.Drawing.Point(15, 159);
            this.btnVecesARealizar.Name = "btnVecesARealizar";
            this.btnVecesARealizar.Size = new System.Drawing.Size(299, 37);
            this.btnVecesARealizar.TabIndex = 0;
            this.btnVecesARealizar.Text = "Ejecutar A";
            this.btnVecesARealizar.UseVisualStyleBackColor = true;
            this.btnVecesARealizar.Click += new System.EventHandler(this.btnVecesARealizar_Click);
            // 
            // lblSinImportancia1
            // 
            this.lblSinImportancia1.AutoSize = true;
            this.lblSinImportancia1.Location = new System.Drawing.Point(12, 42);
            this.lblSinImportancia1.Name = "lblSinImportancia1";
            this.lblSinImportancia1.Size = new System.Drawing.Size(264, 13);
            this.lblSinImportancia1.TabIndex = 4;
            this.lblSinImportancia1.Text = "A-Ingrese cuántas veces quiere la sucesión se realice:";
            // 
            // lblSinImportancia2
            // 
            this.lblSinImportancia2.AutoSize = true;
            this.lblSinImportancia2.Location = new System.Drawing.Point(12, 64);
            this.lblSinImportancia2.Name = "lblSinImportancia2";
            this.lblSinImportancia2.Size = new System.Drawing.Size(274, 26);
            this.lblSinImportancia2.TabIndex = 8;
            this.lblSinImportancia2.Text = "B-Ingrese un número. Se indicará en la sucesión cuándo\r\nllega a éste:";
            // 
            // btnHastaLlegarA
            // 
            this.btnHastaLlegarA.Location = new System.Drawing.Point(15, 202);
            this.btnHastaLlegarA.Name = "btnHastaLlegarA";
            this.btnHastaLlegarA.Size = new System.Drawing.Size(299, 37);
            this.btnHastaLlegarA.TabIndex = 6;
            this.btnHastaLlegarA.Text = "Ejecutar B";
            this.btnHastaLlegarA.UseVisualStyleBackColor = true;
            this.btnHastaLlegarA.Click += new System.EventHandler(this.btnHastaLlegarA_Click);
            // 
            // lblSinImportancia3
            // 
            this.lblSinImportancia3.AutoSize = true;
            this.lblSinImportancia3.Location = new System.Drawing.Point(12, 99);
            this.lblSinImportancia3.Name = "lblSinImportancia3";
            this.lblSinImportancia3.Size = new System.Drawing.Size(282, 26);
            this.lblSinImportancia3.TabIndex = 12;
            this.lblSinImportancia3.Text = "C-Ingrese un número. Se indicará si tal número existe en la\r\nsucesión de Fibonacc" +
    "i:\r\n";
            // 
            // btnExistencia
            // 
            this.btnExistencia.Location = new System.Drawing.Point(15, 245);
            this.btnExistencia.Name = "btnExistencia";
            this.btnExistencia.Size = new System.Drawing.Size(299, 37);
            this.btnExistencia.TabIndex = 10;
            this.btnExistencia.Text = "Ejecutar C";
            this.btnExistencia.UseVisualStyleBackColor = true;
            this.btnExistencia.Click += new System.EventHandler(this.btnExistencia_Click);
            // 
            // lblSinImportancia
            // 
            this.lblSinImportancia.AutoSize = true;
            this.lblSinImportancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinImportancia.Location = new System.Drawing.Point(12, 16);
            this.lblSinImportancia.Name = "lblSinImportancia";
            this.lblSinImportancia.Size = new System.Drawing.Size(164, 16);
            this.lblSinImportancia.TabIndex = 14;
            this.lblSinImportancia.Text = "Siga las instrucciones:";
            // 
            // lblFibonacci
            // 
            this.lblFibonacci.Location = new System.Drawing.Point(12, 285);
            this.lblFibonacci.Name = "lblFibonacci";
            this.lblFibonacci.Size = new System.Drawing.Size(302, 148);
            this.lblFibonacci.TabIndex = 16;
            this.lblFibonacci.Text = "Resultado:";
            // 
            // nudCant
            // 
            this.nudCant.Location = new System.Drawing.Point(15, 133);
            this.nudCant.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.nudCant.Name = "nudCant";
            this.nudCant.Size = new System.Drawing.Size(299, 20);
            this.nudCant.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 450);
            this.Controls.Add(this.nudCant);
            this.Controls.Add(this.lblFibonacci);
            this.Controls.Add(this.lblSinImportancia);
            this.Controls.Add(this.lblSinImportancia3);
            this.Controls.Add(this.btnExistencia);
            this.Controls.Add(this.lblSinImportancia2);
            this.Controls.Add(this.btnHastaLlegarA);
            this.Controls.Add(this.lblSinImportancia1);
            this.Controls.Add(this.btnVecesARealizar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudCant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVecesARealizar;
        private System.Windows.Forms.Label lblSinImportancia1;
        private System.Windows.Forms.Label lblSinImportancia2;
        private System.Windows.Forms.Button btnHastaLlegarA;
        private System.Windows.Forms.Label lblSinImportancia3;
        private System.Windows.Forms.Button btnExistencia;
        private System.Windows.Forms.Label lblSinImportancia;
        private System.Windows.Forms.Label lblFibonacci;
        private System.Windows.Forms.NumericUpDown nudCant;
    }
}

