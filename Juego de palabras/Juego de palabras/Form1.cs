using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juego_de_palabras
{
    public partial class Form1 : Form
    {
        int CantTot = 0;
        int CantA = 0;
        int CantE = 0;
        int CantI = 0;
        int CantO = 0;
        int CantU = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private static int cant(string letra, string texto)
        {
            int CantLetra = 0;
            int PosicionLetra = 0;            
            PosicionLetra = texto.IndexOf(letra);
            while (PosicionLetra > -1)
            {                
                CantLetra++;                
                texto = texto.Substring(PosicionLetra + 1);
                PosicionLetra = texto.IndexOf(letra);
            }
            return CantLetra;
        }

        private void aToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CantA = cant("a", txtTexto.Text);
            MessageBox.Show("Hay " + CantA);
        }

        private void eToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CantE = cant("e", txtTexto.Text);
            MessageBox.Show("Hay " + CantE);
        }

        private void iToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CantI = cant("i", txtTexto.Text);
            MessageBox.Show("Hay " + CantI);
        }

        private void oToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CantO = cant("o", txtTexto.Text);
            MessageBox.Show("Hay " + CantO);
        }

        private void uToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CantU = cant("u", txtTexto.Text);
            MessageBox.Show("Hay " + CantU);
        }

        private void consonantesToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            string Texto = txtTexto.Text;
            Texto = Texto.Replace(" ", "");
            int Todo = Texto.Length;
            int Vocales = CantA + CantE + CantI + CantO + CantU;
            int Consonantes = Todo - Vocales;
            MessageBox.Show("Hay " + Consonantes + " consonantes");
        }

        private void vocalMásUsadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CantA > CantE && CantA > CantI && CantA > CantO && CantA > CantU) 
            {
                MessageBox.Show("La vocal más usada es la A");
            }
            if (CantE > CantA && CantE > CantI && CantE > CantO && CantE > CantU)
            {
                MessageBox.Show("La vocal más usada es la E");
            }
            if (CantI > CantA && CantI > CantE && CantI > CantO && CantI > CantU)
            {
                MessageBox.Show("La vocal más usada es la I");
            }
            if (CantO > CantA && CantO > CantE && CantO > CantI && CantO > CantU)
            {
                MessageBox.Show("La vocal más usada es la O");
            }
            if (CantU > CantA && CantU > CantE && CantU > CantI && CantU > CantO)
            {
                MessageBox.Show("La vocal más usada es la U");
            }   
            else
            {
                MessageBox.Show("La cantidad de vocales es igual en uno o más casos o, no hay vocales");
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void cantidadDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Texto = txtTexto.Text;
            Texto = Texto.Trim();
            int PosicionEspacio = 0;
            int CantPalabras = 0;
            PosicionEspacio = Texto.IndexOf(' ');
            while (PosicionEspacio > 0)
            {
                Texto = Texto.Substring(PosicionEspacio + 1);
                CantPalabras++;                
                PosicionEspacio = Texto.IndexOf(' ');
            }
            CantPalabras++;
            if (CantPalabras == 1)
            {
                MessageBox.Show("Hay " + CantPalabras + " palabra");
            }
            else
            {
                MessageBox.Show("Hay " + CantPalabras + " palabras");
            }
        }

        private void verificaciónDeCapicúaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool Error = false;
            string Texto = txtTexto.Text;
            Texto = Texto.Replace(" ", "");
            int Todo = Texto.Length;
            string PriLetra = Texto.Substring(0, 1);
            string UltLetra = Texto.Substring(Todo - 1);
            for (int i = 1; i < Todo / 2; i++)
            {
                if (PriLetra == UltLetra)
                {
                    PriLetra = Texto.Substring(0 + i, 1);
                    UltLetra = Texto.Substring(Todo - i - 1, 1);
                    Error = true;
                }
                else
                {
                    MessageBox.Show("No es capicúa");
                    Error = false;
                    break;
                }            
            }
            if (Error == true)
            {
                MessageBox.Show("Es capicúa");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtTexto.Text = "";
        }
    }
}
