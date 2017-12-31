using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_Loca_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblPrimos.Text = "Los números primos que hay son:"; 
        }       
        
        public static int CantidadPalabras(string TextoPosta)
        {
            string Texto = TextoPosta;
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
            return CantPalabras;
        }
        private static int Numero(string Frase)
        {
            int CantNumeros = 0;
            string Texto = Frase;
            for (int i = 0; i <= 9; i++)
            {
                int PosNumeros = Frase.IndexOf(i.ToString());
                while (PosNumeros >= 0)
                {
                    Frase = Frase.Substring(PosNumeros + 1);
                    CantNumeros++;
                    PosNumeros = Frase.IndexOf(i.ToString());
                }
                Frase = Frase;
            }
            return CantNumeros;
        }
        public static int(Texto)
       {  
        int Contador = CantidadPalabras(Texto);
            int Impares = 0;
            for (int i = 0; i < Contador; i++)
            {               
                Texto = Texto.Trim();
                int PosicionEspacio = Texto.IndexOf(' ');
                if(PosicionEspacio == -1)
                {
                    int Letras = Frase.Length;
                    Letras = Letras % 2;
                    if (Letras != 0)
                    {
                        Impares++;
                    }               
                }
                else
                {
                    string palabra = Frase.Substring(0, posEspacio);
                    Frase = Frase.Substring(posEspacio + 1);
                    palabra = palabra.Trim();
                    int cantLetras = palabra.Length;
                    cantLetras = cantLetras % 2;
                    if (cantLetras != 0)
                    {
                        Impares++;
                    }   
                }              
            
            return  Impares;
}
        public static string NumerosPrimos(NumericUpDown nud1, NumericUpDown nud2)
        {
            decimal Num1 = nud1.Value;
            decimal Num2 = nud2.Value;            
            string TextoPrimos = "";
            int Primos = 0;
            if (Num1 > Num2)
            {
                for (Num2 = Num2; Num2 <= Num1; Num2++)
                {
                    for (int i = 1; i <= Num2; i++)
                    {
                        decimal resto = Num2 % i;
                        if (resto == 0)
                        {
                            Primos++;
                        }
                    }
                    if (Primos == 2)
                    {
                        TextoPrimos += "," + Num2;
                        Primos = 0;
                    }
                    else
                    {
                        Primos = 0;
                    }
                }
            }
            else
            {
                for (Num1 = Num1; Num1 <= Num2; Num1++)
                {
                    for (int i = 1; i <= Num1; i++)
                    {
                        decimal resto = Num1 % i;
                        if (resto == 0)
                        {
                            Primos++;
                        }
                    }
                    if (Primos == 2)
                    {
                        TextoPrimos += ", " + Num1;
                        Primos = 0;
                    }
                    else
                    {
                        Primos = 0;
                    }
                }
            }

            return TextoPrimos;
        }               

        private void cúantasPalabrasTieneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int CantPalabras = 0;
            CantPalabras = CantidadPalabras(txtTexto.Text);
            if (CantPalabras == 1)
            {
                MessageBox.Show("Hay " + CantPalabras + " palabra");
            }
            else
            {
                MessageBox.Show("Hay " + CantPalabras + " palabras");
            }
        }        

        private void cuántasPalabrasSonImparesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int CantImpares = 0;
            int CantPalabras = 0;
            CantPalabras = CantidadPalabras(txtTexto.Text);
            for (int i = 1; i == CantPalabras; i++)
            {
                string Texto = txtTexto.Text;
                Texto = Texto.Trim();
                int PosicionEspacio = Texto.IndexOf(' ');
                decimal Resto = 0;
                if (PosicionEspacio > 0)
                {
                    string Palabra = Texto.Substring(0, PosicionEspacio);
                    int Palabra1 = Palabra.Length;
                    Resto = Palabra1 % 2;
                }
                else
                {
                    string Palabra = Texto.Substring(0);
                    int Palabra1 = Palabra.Length;
                    Resto = Palabra1 % 2;
                }
                if (Resto != 0)
                {
                    CantImpares++;
                }
                Texto = Texto.Substring(PosicionEspacio);
            }
            CantPalabras = CantidadPalabras(txtTexto.Text);
            
            if (CantImpares == 1)
            {
                MessageBox.Show("Hay " + CantImpares + " palabra impar");
            }
            else
            {
                MessageBox.Show("Hay " + CantImpares + " palabras impares");
            }
        }

        private void confirmaciónDeSiSeIngresóUnNúmeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Texto = txtTexto.Text;
            int CantNumeros = Numero(Texto);
            if (CantNumeros > 0)
            {
                MessageBox.Show("Hay números, y su cantidad es " + CantNumeros);
            }
            else
            {
                MessageBox.Show("No hay numeros");
            }
        }

        private void cuántosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void númerosPrimosEntreLosDosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblPrimos.Text += NumerosPrimos(nudUno, nudDos);
        }
    }
}
