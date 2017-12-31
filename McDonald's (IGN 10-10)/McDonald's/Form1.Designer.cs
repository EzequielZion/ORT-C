namespace McDonalds
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudCant = new System.Windows.Forms.NumericUpDown();
            this.nudPrecio = new System.Windows.Forms.NumericUpDown();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudCant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Khaki;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Combos McDonald\'s";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(12, 56);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(332, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingrese el nombre del combo: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(335, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ingrese la cantidad de hamburguesas que tiene el combo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ingrese el precio del combo:";
            // 
            // nudCant
            // 
            this.nudCant.Location = new System.Drawing.Point(12, 95);
            this.nudCant.Name = "nudCant";
            this.nudCant.Size = new System.Drawing.Size(332, 20);
            this.nudCant.TabIndex = 5;
            // 
            // nudPrecio
            // 
            this.nudPrecio.DecimalPlaces = 2;
            this.nudPrecio.Location = new System.Drawing.Point(12, 134);
            this.nudPrecio.Name = "nudPrecio";
            this.nudPrecio.Size = new System.Drawing.Size(332, 20);
            this.nudPrecio.TabIndex = 6;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(12, 161);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(163, 23);
            this.btnIngresar.TabIndex = 7;
            this.btnIngresar.Text = "Ingresar combo";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenar.Location = new System.Drawing.Point(181, 161);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(163, 23);
            this.btnOrdenar.TabIndex = 8;
            this.btnOrdenar.Text = "Ordenar combos";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.Location = new System.Drawing.Point(12, 190);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(332, 37);
            this.btnMostrar.TabIndex = 9;
            this.btnMostrar.Text = "Mostrar los combos de mayor a menor \r\ncantidad de hamburguesas\r\n";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(369, 237);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.nudPrecio);
            this.Controls.Add(this.nudCant);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudCant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudCant;
        private System.Windows.Forms.NumericUpDown nudPrecio;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Button btnMostrar;
    }
}

