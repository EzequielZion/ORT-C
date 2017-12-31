using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programación_Números_Romanos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "Número: ";
            string Resultado = lblResultado.Text;            
            string NúmeroNatural = txtNúmero.Text;
            int Número = Convert.ToInt32(NúmeroNatural);
            if (Número < 1)
            {
                MessageBox.Show("Error. Ingrese un número mayor");
                txtNúmero.Text = "";
            }
            if (Número > 1999)
            {
                MessageBox.Show("Error. Ingrese un número menor");
                txtNúmero.Text = "";
            }
            if (Número >= 1000)
            {
                Resultado += "M";
                Número -= 1000;                
            }
            if (Número >= 900)
            {
                Resultado += "CM";
                Número -= 900;
            }
            if (Número >= 500)
            {
                Resultado += "D";
                Número -= 500;
            }
            if (Número >= 400 && Número <= 500)
            {
                Resultado += "CD";
                Número -= 400;
            }
            while (Número >= 100)
            {
                Resultado += "C";
                Número -= 100;
            }
            if (Número >= 90)
            {
                Resultado += "XC";
                Número -= 90;
            }
            if (Número >= 50)
            {
                Resultado += "L";
                Número -= 50;
            }
            if (Número >= 40 && Número <= 50)
            {
                Resultado += "XL";
                Número -= 40;
            }
            while (Número >= 10)
            {
                Resultado += "X";
                Número -= 10;
            }
            if (Número == 9)
            {
                Resultado += "IX";
                Número -= 9;
            }
            if (Número >= 5)
            {
                Resultado += "V";
                Número -= 5;
            }
            if (Número == 4)
            {
                Resultado += "IV";
                Número -= 4;
            }
            while (Número >= 1)
            {
                Resultado += "I";
                Número -= 1;
            }           
 
            lblResultado.Text = Resultado;
        }
    }
}
