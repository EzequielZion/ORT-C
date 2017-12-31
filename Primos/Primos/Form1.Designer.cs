namespace Primos
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.nudNum = new System.Windows.Forms.NumericUpDown();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblNúmerosPrimos = new System.Windows.Forms.Label();
            this.lblCant = new System.Windows.Forms.Label();
            this.lblEsONo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudNum)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(8, 4);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(139, 19);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Ingrese un número:";
            // 
            // nudNum
            // 
            this.nudNum.Location = new System.Drawing.Point(12, 26);
            this.nudNum.Name = "nudNum";
            this.nudNum.Size = new System.Drawing.Size(452, 20);
            this.nudNum.TabIndex = 1;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(12, 52);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(452, 23);
            this.btnIngresar.TabIndex = 3;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lblNúmerosPrimos
            // 
            this.lblNúmerosPrimos.AutoSize = true;
            this.lblNúmerosPrimos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNúmerosPrimos.Location = new System.Drawing.Point(12, 78);
            this.lblNúmerosPrimos.Name = "lblNúmerosPrimos";
            this.lblNúmerosPrimos.Size = new System.Drawing.Size(240, 26);
            this.lblNúmerosPrimos.TabIndex = 4;
            this.lblNúmerosPrimos.Text = "Los números primos que  hay entre 1 y el número \r\ningresado son:";
            // 
            // lblCant
            // 
            this.lblCant.AutoSize = true;
            this.lblCant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCant.Location = new System.Drawing.Point(12, 114);
            this.lblCant.Name = "lblCant";
            this.lblCant.Size = new System.Drawing.Size(212, 13);
            this.lblCant.TabIndex = 5;
            this.lblCant.Text = "La cantidad de números primos que hay es:";
            // 
            // lblEsONo
            // 
            this.lblEsONo.AutoSize = true;
            this.lblEsONo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEsONo.Location = new System.Drawing.Point(12, 138);
            this.lblEsONo.Name = "lblEsONo";
            this.lblEsONo.Size = new System.Drawing.Size(57, 13);
            this.lblEsONo.TabIndex = 6;
            this.lblEsONo.Text = "El número:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 162);
            this.Controls.Add(this.lblEsONo);
            this.Controls.Add(this.lblCant);
            this.Controls.Add(this.lblNúmerosPrimos);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.nudNum);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.NumericUpDown nudNum;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label lblNúmerosPrimos;
        private System.Windows.Forms.Label lblCant;
        private System.Windows.Forms.Label lblEsONo;
    }
}

