namespace PruebaLocaDeVectores
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
            this.cmbJugadores = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudPuntos = new System.Windows.Forms.NumericUpDown();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnFin = new System.Windows.Forms.Button();
            this.lblPuntos = new System.Windows.Forms.Label();
            this.lblMenosConversión = new System.Windows.Forms.Label();
            this.lblMásConversión = new System.Windows.Forms.Label();
            this.lblOrden = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudPuntos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Matura MT Script Capitals", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(382, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amazonas Basket Club:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(435, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seleccione un jugador";
            // 
            // cmbJugadores
            // 
            this.cmbJugadores.FormattingEnabled = true;
            this.cmbJugadores.Items.AddRange(new object[] {
            "Johnson (Dorsal 44)",
            "Rogers (Dorsal 25)",
            "Bumaschny (Dorsal 10)",
            "St. John (Dorsal 33)",
            "Dowëmenns (Dorsal 3)",
            "Martins (Dorsal 99)"});
            this.cmbJugadores.Location = new System.Drawing.Point(16, 58);
            this.cmbJugadores.Name = "cmbJugadores";
            this.cmbJugadores.Size = new System.Drawing.Size(910, 21);
            this.cmbJugadores.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(396, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Seleccione cuántos puntos asignarle:";
            // 
            // nudPuntos
            // 
            this.nudPuntos.Location = new System.Drawing.Point(16, 99);
            this.nudPuntos.Name = "nudPuntos";
            this.nudPuntos.Size = new System.Drawing.Size(910, 20);
            this.nudPuntos.TabIndex = 4;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(16, 126);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(910, 23);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "Ingresar";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnFin
            // 
            this.btnFin.Location = new System.Drawing.Point(16, 156);
            this.btnFin.Name = "btnFin";
            this.btnFin.Size = new System.Drawing.Size(910, 23);
            this.btnFin.TabIndex = 6;
            this.btnFin.Text = "Resultados finales";
            this.btnFin.UseVisualStyleBackColor = true;
            this.btnFin.Click += new System.EventHandler(this.btnFin_Click_1);
            // 
            // lblPuntos
            // 
            this.lblPuntos.AutoSize = true;
            this.lblPuntos.Location = new System.Drawing.Point(13, 190);
            this.lblPuntos.Name = "lblPuntos";
            this.lblPuntos.Size = new System.Drawing.Size(100, 13);
            this.lblPuntos.TabIndex = 7;
            this.lblPuntos.Text = "El equipo convirtió: ";
            // 
            // lblMenosConversión
            // 
            this.lblMenosConversión.AutoSize = true;
            this.lblMenosConversión.Location = new System.Drawing.Point(272, 190);
            this.lblMenosConversión.Name = "lblMenosConversión";
            this.lblMenosConversión.Size = new System.Drawing.Size(112, 39);
            this.lblMenosConversión.TabIndex = 8;
            this.lblMenosConversión.Text = "El jugador que menos\r\nconvirtió y sus puntos \r\nfueron:";
            // 
            // lblMásConversión
            // 
            this.lblMásConversión.AutoSize = true;
            this.lblMásConversión.Location = new System.Drawing.Point(600, 190);
            this.lblMásConversión.Name = "lblMásConversión";
            this.lblMásConversión.Size = new System.Drawing.Size(109, 39);
            this.lblMásConversión.TabIndex = 9;
            this.lblMásConversión.Text = "El jugador que más\r\nconvirtió y sus puntos\r\nfueron:";
            // 
            // lblOrden
            // 
            this.lblOrden.AutoSize = true;
            this.lblOrden.Location = new System.Drawing.Point(13, 247);
            this.lblOrden.Name = "lblOrden";
            this.lblOrden.Size = new System.Drawing.Size(134, 39);
            this.lblOrden.TabIndex = 10;
            this.lblOrden.Text = "Los jugadores convirtieron \r\nde mayor a menor en el \r\nsiguiente orden:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 299);
            this.Controls.Add(this.lblOrden);
            this.Controls.Add(this.lblMásConversión);
            this.Controls.Add(this.lblMenosConversión);
            this.Controls.Add(this.lblPuntos);
            this.Controls.Add(this.btnFin);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.nudPuntos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbJugadores);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudPuntos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbJugadores;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudPuntos;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnFin;
        private System.Windows.Forms.Label lblPuntos;
        private System.Windows.Forms.Label lblMenosConversión;
        private System.Windows.Forms.Label lblMásConversión;
        private System.Windows.Forms.Label lblOrden;
    }
}

