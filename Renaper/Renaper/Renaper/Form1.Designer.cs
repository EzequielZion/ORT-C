namespace Renaper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblIngresar1 = new System.Windows.Forms.Label();
            this.lblIngresar2 = new System.Windows.Forms.Label();
            this.txtDatos = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblNom2 = new System.Windows.Forms.Label();
            this.lblNom1 = new System.Windows.Forms.Label();
            this.lblApe1 = new System.Windows.Forms.Label();
            this.lblApe2 = new System.Windows.Forms.Label();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.lblCodPos = new System.Windows.Forms.Label();
            this.lblDirec = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblIngresar1
            // 
            this.lblIngresar1.AutoSize = true;
            this.lblIngresar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresar1.Location = new System.Drawing.Point(12, 9);
            this.lblIngresar1.Name = "lblIngresar1";
            this.lblIngresar1.Size = new System.Drawing.Size(438, 32);
            this.lblIngresar1.TabIndex = 3;
            this.lblIngresar1.Text = "Por favor ingrese (tenga en cuenta que los datos sólo pueden \r\nsepararse mediante" +
    " comas y no debe de haber espacios):";           
            // 
            // lblIngresar2
            // 
            this.lblIngresar2.AutoSize = true;
            this.lblIngresar2.Location = new System.Drawing.Point(12, 41);
            this.lblIngresar2.Name = "lblIngresar2";
            this.lblIngresar2.Size = new System.Drawing.Size(248, 117);
            this.lblIngresar2.TabIndex = 4;
            this.lblIngresar2.Text = resources.GetString("lblIngresar2.Text");
            // 
            // txtDatos
            // 
            this.txtDatos.Location = new System.Drawing.Point(15, 161);
            this.txtDatos.Name = "txtDatos";
            this.txtDatos.Size = new System.Drawing.Size(457, 20);
            this.txtDatos.TabIndex = 5;
           
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(107, 189);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(109, 13);
            this.lbl1.TabIndex = 12;
            this.lbl1.Text = "Su primer nombre es: ";
      
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(107, 212);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(119, 13);
            this.lbl2.TabIndex = 11;
            this.lbl2.Text = "Su segundo nombre es:";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(107, 261);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(120, 13);
            this.lbl4.TabIndex = 10;
            this.lbl4.Text = "Su segundo apellido es:";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(107, 236);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(107, 13);
            this.lbl3.TabIndex = 9;
            this.lbl3.Text = "Su primer apellido es:";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(107, 284);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(136, 13);
            this.lbl5.TabIndex = 13;
            this.lbl5.Text = "Su fecha de nacimiento es:";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Location = new System.Drawing.Point(107, 307);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(103, 13);
            this.lbl6.TabIndex = 14;
            this.lbl6.Text = "Su código postal es:";
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Location = new System.Drawing.Point(107, 331);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(83, 13);
            this.lbl7.TabIndex = 15;
            this.lbl7.Text = "Su dirección es:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(15, 185);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 165);
            this.btnAceptar.TabIndex = 16;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblNom2
            // 
            this.lblNom2.AutoSize = true;
            this.lblNom2.Location = new System.Drawing.Point(229, 212);
            this.lblNom2.Name = "lblNom2";
            this.lblNom2.Size = new System.Drawing.Size(14, 13);
            this.lblNom2.TabIndex = 17;
            this.lblNom2.Text = "X";
            this.lblNom2.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNom1
            // 
            this.lblNom1.AutoSize = true;
            this.lblNom1.Location = new System.Drawing.Point(213, 189);
            this.lblNom1.Name = "lblNom1";
            this.lblNom1.Size = new System.Drawing.Size(14, 13);
            this.lblNom1.TabIndex = 18;
            this.lblNom1.Text = "X";
            // 
            // lblApe1
            // 
            this.lblApe1.AutoSize = true;
            this.lblApe1.Location = new System.Drawing.Point(213, 236);
            this.lblApe1.Name = "lblApe1";
            this.lblApe1.Size = new System.Drawing.Size(14, 13);
            this.lblApe1.TabIndex = 19;
            this.lblApe1.Text = "X";
            this.lblApe1.Click += new System.EventHandler(this.lblApe1_Click);
            // 
            // lblApe2
            // 
            this.lblApe2.AutoSize = true;
            this.lblApe2.Location = new System.Drawing.Point(229, 261);
            this.lblApe2.Name = "lblApe2";
            this.lblApe2.Size = new System.Drawing.Size(14, 13);
            this.lblApe2.TabIndex = 20;
            this.lblApe2.Text = "X";
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Location = new System.Drawing.Point(249, 284);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(14, 13);
            this.lblFechaNac.TabIndex = 21;
            this.lblFechaNac.Text = "X";
            // 
            // lblCodPos
            // 
            this.lblCodPos.AutoSize = true;
            this.lblCodPos.Location = new System.Drawing.Point(212, 307);
            this.lblCodPos.Name = "lblCodPos";
            this.lblCodPos.Size = new System.Drawing.Size(14, 13);
            this.lblCodPos.TabIndex = 22;
            this.lblCodPos.Text = "X";
            // 
            // lblDirec
            // 
            this.lblDirec.AutoSize = true;
            this.lblDirec.Location = new System.Drawing.Point(196, 331);
            this.lblDirec.Name = "lblDirec";
            this.lblDirec.Size = new System.Drawing.Size(14, 13);
            this.lblDirec.TabIndex = 23;
            this.lblDirec.Text = "X";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 359);
            this.Controls.Add(this.lblDirec);
            this.Controls.Add(this.lblCodPos);
            this.Controls.Add(this.lblFechaNac);
            this.Controls.Add(this.lblApe2);
            this.Controls.Add(this.lblApe1);
            this.Controls.Add(this.lblNom1);
            this.Controls.Add(this.lblNom2);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lbl7);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.txtDatos);
            this.Controls.Add(this.lblIngresar2);
            this.Controls.Add(this.lblIngresar1);
            this.Name = "Form1";
            this.Text = "Form1";
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIngresar1;
        private System.Windows.Forms.Label lblIngresar2;
        private System.Windows.Forms.TextBox txtDatos;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblNom2;
        private System.Windows.Forms.Label lblNom1;
        private System.Windows.Forms.Label lblApe1;
        private System.Windows.Forms.Label lblApe2;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.Label lblCodPos;
        private System.Windows.Forms.Label lblDirec;
    }
}

