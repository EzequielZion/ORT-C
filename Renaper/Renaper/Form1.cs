using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Renaper
{
    public partial class Form1 : Form

    {
        
        public Form1()
        {
            InitializeComponent();
             
        }
        
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string Datos = txtDatos.Text;
            if (Datos.IndexOf(' ') > 0)
            {
                MessageBox.Show("Error. Ingresó un espacio.");
            }
            else
            {                
                int posicionComa = Datos.IndexOf(',');
                string Nom1 = Datos.Substring(0, posicionComa);
                Datos = Datos.Substring(posicionComa+1);
                posicionComa = Datos.IndexOf(',');
                string Nom2 = Datos.Substring(0, posicionComa);
                Datos = Datos.Substring(posicionComa+1);
                posicionComa = Datos.IndexOf(',');
                string Ape1 = Datos.Substring(0, posicionComa);
                Datos = Datos.Substring(posicionComa+1);
                posicionComa = Datos.IndexOf(',');
                string Ape2 = Datos.Substring(0, posicionComa);
                Datos = Datos.Substring(posicionComa+1);
                posicionComa = Datos.IndexOf(',');
                string FechaNac = Datos.Substring(0, posicionComa);
                if (FechaNac.Length > 10)
                {
                    MessageBox.Show("Error. La fecha de nacimiento es inválida.");
                }
                else
                {                    
                    Datos = Datos.Substring(posicionComa+1);
                }
                posicionComa = Datos.IndexOf(',');
                string CodPosTotal = Datos.Substring(0, posicionComa);
                string CodPos = Datos.Substring(1, 4);
                if (CodPosTotal.Length > 8)
                {
                    MessageBox.Show("Error. El código postal es inválido.");
                }
                else
                {                    
                    Datos = Datos.Substring(posicionComa+1);
                }
                posicionComa = Datos.IndexOf(',');
                string Direc = Datos.Substring(0);
                if (Nom1 == "" || Nom2 == "" || Ape1 == "" || Ape2 == "" || FechaNac == "" || CodPos == "" || Direc == "")
                {
                    MessageBox.Show("Error. Faltan datos.");
                }
                else
                {
                    lblNom1.Text = Nom1;
                    lblNom2.Text = Nom2;
                    lblApe1.Text = Ape1;
                    lblApe2.Text = Ape2;
                    lblFechaNac.Text = FechaNac;
                    lblCodPos.Text = CodPos;
                    lblDirec.Text = Direc;
                }
                Datos = Datos.Trim();
            }

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblApe1_Click(object sender, EventArgs e)
        {

        }
    }
}
