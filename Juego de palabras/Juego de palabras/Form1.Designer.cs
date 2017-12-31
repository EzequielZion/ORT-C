namespace Juego_de_palabras
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cantidadDeVocalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cantidadDeVocalesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vocalMásUsadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.iToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.oToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.uToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consonantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cantidadDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verificaciónDeCapicúaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cantidadDeVocalesToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 26);
            // 
            // cantidadDeVocalesToolStripMenuItem
            // 
            this.cantidadDeVocalesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem,
            this.eToolStripMenuItem,
            this.iToolStripMenuItem,
            this.oToolStripMenuItem,
            this.uToolStripMenuItem});
            this.cantidadDeVocalesToolStripMenuItem.Name = "cantidadDeVocalesToolStripMenuItem";
            this.cantidadDeVocalesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cantidadDeVocalesToolStripMenuItem.Text = "Cantidad de vocales";
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(83, 22);
            this.aToolStripMenuItem.Text = "A";
            // 
            // eToolStripMenuItem
            // 
            this.eToolStripMenuItem.Name = "eToolStripMenuItem";
            this.eToolStripMenuItem.Size = new System.Drawing.Size(83, 22);
            this.eToolStripMenuItem.Text = "E";
            // 
            // iToolStripMenuItem
            // 
            this.iToolStripMenuItem.Name = "iToolStripMenuItem";
            this.iToolStripMenuItem.Size = new System.Drawing.Size(83, 22);
            this.iToolStripMenuItem.Text = "I";
            // 
            // oToolStripMenuItem
            // 
            this.oToolStripMenuItem.Name = "oToolStripMenuItem";
            this.oToolStripMenuItem.Size = new System.Drawing.Size(83, 22);
            this.oToolStripMenuItem.Text = "O";
            // 
            // uToolStripMenuItem
            // 
            this.uToolStripMenuItem.Name = "uToolStripMenuItem";
            this.uToolStripMenuItem.Size = new System.Drawing.Size(83, 22);
            this.uToolStripMenuItem.Text = "U";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cantidadDeVocalesToolStripMenuItem1,
            this.consonantesToolStripMenuItem,
            this.cantidadDeToolStripMenuItem,
            this.verificaciónDeCapicúaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(517, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cantidadDeVocalesToolStripMenuItem1
            // 
            this.cantidadDeVocalesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vocalMásUsadaToolStripMenuItem,
            this.aToolStripMenuItem1,
            this.eToolStripMenuItem1,
            this.iToolStripMenuItem1,
            this.oToolStripMenuItem1,
            this.uToolStripMenuItem1});
            this.cantidadDeVocalesToolStripMenuItem1.Name = "cantidadDeVocalesToolStripMenuItem1";
            this.cantidadDeVocalesToolStripMenuItem1.Size = new System.Drawing.Size(59, 20);
            this.cantidadDeVocalesToolStripMenuItem1.Text = "Vocales";
            // 
            // vocalMásUsadaToolStripMenuItem
            // 
            this.vocalMásUsadaToolStripMenuItem.Name = "vocalMásUsadaToolStripMenuItem";
            this.vocalMásUsadaToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.vocalMásUsadaToolStripMenuItem.Text = "Vocal más usada";
            this.vocalMásUsadaToolStripMenuItem.Click += new System.EventHandler(this.vocalMásUsadaToolStripMenuItem_Click);
            // 
            // aToolStripMenuItem1
            // 
            this.aToolStripMenuItem1.Name = "aToolStripMenuItem1";
            this.aToolStripMenuItem1.Size = new System.Drawing.Size(162, 22);
            this.aToolStripMenuItem1.Text = "Cantidad de A";
            this.aToolStripMenuItem1.Click += new System.EventHandler(this.aToolStripMenuItem1_Click);
            // 
            // eToolStripMenuItem1
            // 
            this.eToolStripMenuItem1.Name = "eToolStripMenuItem1";
            this.eToolStripMenuItem1.Size = new System.Drawing.Size(162, 22);
            this.eToolStripMenuItem1.Text = "Cantidad de E";
            this.eToolStripMenuItem1.Click += new System.EventHandler(this.eToolStripMenuItem1_Click);
            // 
            // iToolStripMenuItem1
            // 
            this.iToolStripMenuItem1.Name = "iToolStripMenuItem1";
            this.iToolStripMenuItem1.Size = new System.Drawing.Size(162, 22);
            this.iToolStripMenuItem1.Text = "Cantidad de I";
            this.iToolStripMenuItem1.Click += new System.EventHandler(this.iToolStripMenuItem1_Click);
            // 
            // oToolStripMenuItem1
            // 
            this.oToolStripMenuItem1.Name = "oToolStripMenuItem1";
            this.oToolStripMenuItem1.Size = new System.Drawing.Size(162, 22);
            this.oToolStripMenuItem1.Text = "Cantidad de O";
            this.oToolStripMenuItem1.Click += new System.EventHandler(this.oToolStripMenuItem1_Click);
            // 
            // uToolStripMenuItem1
            // 
            this.uToolStripMenuItem1.Name = "uToolStripMenuItem1";
            this.uToolStripMenuItem1.Size = new System.Drawing.Size(162, 22);
            this.uToolStripMenuItem1.Text = "Cantidad de U";
            this.uToolStripMenuItem1.Click += new System.EventHandler(this.uToolStripMenuItem1_Click);
            // 
            // consonantesToolStripMenuItem
            // 
            this.consonantesToolStripMenuItem.Name = "consonantesToolStripMenuItem";
            this.consonantesToolStripMenuItem.Size = new System.Drawing.Size(153, 20);
            this.consonantesToolStripMenuItem.Text = "Cantidad de consonantes";
            this.consonantesToolStripMenuItem.Click += new System.EventHandler(this.consonantesToolStripMenuItem_Click);
            // 
            // cantidadDeToolStripMenuItem
            // 
            this.cantidadDeToolStripMenuItem.Name = "cantidadDeToolStripMenuItem";
            this.cantidadDeToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.cantidadDeToolStripMenuItem.Text = "Cantidad de palabras";
            this.cantidadDeToolStripMenuItem.Click += new System.EventHandler(this.cantidadDeToolStripMenuItem_Click);
            // 
            // verificaciónDeCapicúaToolStripMenuItem
            // 
            this.verificaciónDeCapicúaToolStripMenuItem.Name = "verificaciónDeCapicúaToolStripMenuItem";
            this.verificaciónDeCapicúaToolStripMenuItem.Size = new System.Drawing.Size(141, 20);
            this.verificaciónDeCapicúaToolStripMenuItem.Text = "Verificación de capicúa";
            this.verificaciónDeCapicúaToolStripMenuItem.Click += new System.EventHandler(this.verificaciónDeCapicúaToolStripMenuItem_Click);
            // 
            // txtTexto
            // 
            this.txtTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTexto.Location = new System.Drawing.Point(12, 59);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(423, 20);
            this.txtTexto.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingrese una palabra u oración (no use mayúsculas):";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(360, 85);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 4;
            this.btnBorrar.Text = "Borrar texto";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 109);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cantidadDeVocalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uToolStripMenuItem;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem consonantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cantidadDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cantidadDeVocalesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vocalMásUsadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem iToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem oToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem uToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem verificaciónDeCapicúaToolStripMenuItem;
        private System.Windows.Forms.Button btnBorrar;
    }
}

