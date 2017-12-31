namespace ORDENAMIENTODEVECTORES
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
            this.btnSelección = new System.Windows.Forms.Button();
            this.btnInserción = new System.Windows.Forms.Button();
            this.btnBurbuja = new System.Windows.Forms.Button();
            this.btnTimSort = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSelección
            // 
            this.btnSelección.Location = new System.Drawing.Point(33, 12);
            this.btnSelección.Name = "btnSelección";
            this.btnSelección.Size = new System.Drawing.Size(212, 61);
            this.btnSelección.TabIndex = 0;
            this.btnSelección.Text = "Por Selección";
            this.btnSelección.UseVisualStyleBackColor = true;
            this.btnSelección.Click += new System.EventHandler(this.btnSelección_Click);
            // 
            // btnInserción
            // 
            this.btnInserción.Location = new System.Drawing.Point(33, 89);
            this.btnInserción.Name = "btnInserción";
            this.btnInserción.Size = new System.Drawing.Size(212, 61);
            this.btnInserción.TabIndex = 1;
            this.btnInserción.Text = "Por Inserción";
            this.btnInserción.UseVisualStyleBackColor = true;
            this.btnInserción.Click += new System.EventHandler(this.btnInserción_Click);
            // 
            // btnBurbuja
            // 
            this.btnBurbuja.Location = new System.Drawing.Point(33, 174);
            this.btnBurbuja.Name = "btnBurbuja";
            this.btnBurbuja.Size = new System.Drawing.Size(212, 61);
            this.btnBurbuja.TabIndex = 2;
            this.btnBurbuja.Text = "Por Burbujero";
            this.btnBurbuja.UseVisualStyleBackColor = true;
            this.btnBurbuja.Click += new System.EventHandler(this.btnBurbuja_Click);
            // 
            // btnTimSort
            // 
            this.btnTimSort.Location = new System.Drawing.Point(33, 252);
            this.btnTimSort.Name = "btnTimSort";
            this.btnTimSort.Size = new System.Drawing.Size(212, 61);
            this.btnTimSort.TabIndex = 3;
            this.btnTimSort.Text = "Por ShellSort";
            this.btnTimSort.UseVisualStyleBackColor = true;
            this.btnTimSort.Click += new System.EventHandler(this.btnTimSort_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(263, 12);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(199, 301);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 342);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnTimSort);
            this.Controls.Add(this.btnBurbuja);
            this.Controls.Add(this.btnInserción);
            this.Controls.Add(this.btnSelección);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSelección;
        private System.Windows.Forms.Button btnInserción;
        private System.Windows.Forms.Button btnBurbuja;
        private System.Windows.Forms.Button btnTimSort;
        private System.Windows.Forms.Button btnReset;
    }
}

