using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace McDonalds
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i = -1;
        string[] vectorNombre = new string [6];
        int[] vectorCant = new int [6];
        decimal[] vectorPrecio = new decimal[6];
        public static void Ingresar(string Nombre, ref string[] vectorNombre, int Cant, ref int[] vectorCant, decimal Precio, ref decimal[] vectorPrecio, int i)
        {
            if (i > 5)
            {
                MessageBox.Show("Se ingresaron todos los combos existentes; No puede ingresar más combos.");
            }
            else
            {
                vectorNombre[i] = Nombre;
                vectorCant[i] = Cant;
                vectorPrecio[i] = Precio;
            }            
        }
        public static void OrdenarVectores(ref string[] vectorNombre, ref int[] vectorCant, ref decimal[] vectorPrecio)
        {
            for (int i = 0; i < vectorCant.Length - 1; i++)
            {
                for (int j = 0; j < vectorCant.Length - 1; j++)
                {
                    if (vectorCant[j] < vectorCant[j + 1])
                    {
                        string Auxiliar = vectorNombre[j + 1];
                        vectorNombre[j + 1] = vectorNombre[j];
                        vectorNombre[j] = Auxiliar;

                        int Auxiliar1 = vectorCant[j + 1];
                        vectorCant[j + 1] = vectorCant[j];
                        vectorCant[j] = Auxiliar1;

                        decimal Auxiliar2 = vectorPrecio[j + 1];
                        vectorPrecio[j + 1] = vectorPrecio[j];
                        vectorPrecio[j] = Auxiliar2;
                    }
                }
            }
        }       
        public static void Mostrar(string[] vectorNombre, decimal[] vectorPrecio)
        {
            for (int i= 0; i <= vectorPrecio.Length-1; i++)
            {
                MessageBox.Show("Combo: " + vectorNombre[i] + ". Precio: " + vectorPrecio[i]);
            }
        }          
        private void btnIngresar_Click(object sender, EventArgs e)
        {
           string Nombre = txtNombre.Text;
           int Cant = (int)nudCant.Value;
           decimal Precio = nudPrecio.Value;
           i++;
           Ingresar(Nombre, ref vectorNombre, Cant, ref vectorCant, Precio, ref vectorPrecio, i);
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            i = -1;
            OrdenarVectores(ref vectorNombre, ref vectorCant, ref vectorPrecio);
        }
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Mostrar(vectorNombre, vectorPrecio);
        }
    }
}
