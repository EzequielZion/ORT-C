namespace Prueba_Loca_2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cúantasPalabrasTieneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuántasPalabrasSonImparesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.confirmaciónDeSiSeIngresóUnNúmeroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.númerosPrimosEntreLosDosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.nudDos = new System.Windows.Forms.NumericUpDown();
            this.nudUno = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPrimos = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUno)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cúantasPalabrasTieneToolStripMenuItem,
            this.cuántasPalabrasSonImparesToolStripMenuItem,
            this.confirmaciónDeSiSeIngresóUnNúmeroToolStripMenuItem,
            this.númerosPrimosEntreLosDosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(707, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cúantasPalabrasTieneToolStripMenuItem
            // 
            this.cúantasPalabrasTieneToolStripMenuItem.Name = "cúantasPalabrasTieneToolStripMenuItem";
            this.cúantasPalabrasTieneToolStripMenuItem.Size = new System.Drawing.Size(163, 20);
            this.cúantasPalabrasTieneToolStripMenuItem.Text = "Cantidad de palabras que hay";
            this.cúantasPalabrasTieneToolStripMenuItem.Click += new System.EventHandler(this.cúantasPalabrasTieneToolStripMenuItem_Click);
            // 
            // cuántasPalabrasSonImparesToolStripMenuItem
            // 
            this.cuántasPalabrasSonImparesToolStripMenuItem.Name = "cuántasPalabrasSonImparesToolStripMenuItem";
            this.cuántasPalabrasSonImparesToolStripMenuItem.Size = new System.Drawing.Size(161, 20);
            this.cuántasPalabrasSonImparesToolStripMenuItem.Text = "Cantidad de palabras impares";
            this.cuántasPalabrasSonImparesToolStripMenuItem.Click += new System.EventHandler(this.cuántasPalabrasSonImparesToolStripMenuItem_Click);
            // 
            // confirmaciónDeSiSeIngresóUnNúmeroToolStripMenuItem
            // 
            this.confirmaciónDeSiSeIngresóUnNúmeroToolStripMenuItem.Name = "confirmaciónDeSiSeIngresóUnNúmeroToolStripMenuItem";
            this.confirmaciónDeSiSeIngresóUnNúmeroToolStripMenuItem.Size = new System.Drawing.Size(212, 20);
            this.confirmaciónDeSiSeIngresóUnNúmeroToolStripMenuItem.Text = "Confirmación de si se ingresó un número";
            this.confirmaciónDeSiSeIngresóUnNúmeroToolStripMenuItem.Click += new System.EventHandler(this.confirmaciónDeSiSeIngresóUnNúmeroToolStripMenuItem_Click);
            // 
            // númerosPrimosEntreLosDosToolStripMenuItem
            // 
            this.númerosPrimosEntreLosDosToolStripMenuItem.Name = "númerosPrimosEntreLosDosToolStripMenuItem";
            this.númerosPrimosEntreLosDosToolStripMenuItem.Size = new System.Drawing.Size(160, 20);
            this.númerosPrimosEntreLosDosToolStripMenuItem.Text = "Números primos entre los dos";
            this.númerosPrimosEntreLosDosToolStripMenuItem.Click += new System.EventHandler(this.númerosPrimosEntreLosDosToolStripMenuItem_Click);
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(1, 27);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(706, 20);
            this.txtTexto.TabIndex = 1;
            // 
            // nudDos
            // 
            this.nudDos.Location = new System.Drawing.Point(1, 92);
            this.nudDos.Name = "nudDos";
            this.nudDos.Size = new System.Drawing.Size(706, 20);
            this.nudDos.TabIndex = 2;
            // 
            // nudUno
            // 
            this.nudUno.Location = new System.Drawing.Point(1, 66);
            this.nudUno.Name = "nudUno";
            this.nudUno.Size = new System.Drawing.Size(706, 20);
            this.nudUno.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(657, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Atención: el cuarto botón sólo funcionará con el ingreso de dos números que deben" +
    " ser ingresados a continuación";
            // 
            // lblPrimos
            // 
            this.lblPrimos.AutoSize = true;
            this.lblPrimos.Location = new System.Drawing.Point(0, 119);
            this.lblPrimos.Name = "lblPrimos";
            this.lblPrimos.Size = new System.Drawing.Size(164, 13);
            this.lblPrimos.TabIndex = 5;
            this.lblPrimos.Text = "Los números primos que hay son:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 138);
            this.Controls.Add(this.lblPrimos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudUno);
            this.Controls.Add(this.nudDos);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cúantasPalabrasTieneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuántasPalabrasSonImparesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem confirmaciónDeSiSeIngresóUnNúmeroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem númerosPrimosEntreLosDosToolStripMenuItem;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.NumericUpDown nudDos;
        private System.Windows.Forms.NumericUpDown nudUno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPrimos;

    }
}

