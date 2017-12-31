using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programación_Fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private static string Sucesión(decimal Cant)
        {            
            int Num1 = 0;
            int Num2 = 1;
            int Num3 = 0;
            string Resultado = "";
            for (int i = 2; i <= Cant; i++)
            {
                Num3 = Num1 + Num2;
                Num2 = Num1;
                Num1 = Num3;
                Resultado += Num3.ToString() + ", ";
            }
            return Resultado;
        }
        private static string Llegar(decimal Cantidad)
        {
            int Num1 = 0;
            int Num2 = 1;
            int Num3 = 0;
            string Resultado = "";            
            while (Num3<Cantidad)
            {
                Num3 = Num1 + Num2;
                Num2 = Num1;
                Num1 = Num3;
                Resultado += Num3.ToString() + ", ";
            }
            return Resultado;
        }
        
        private static string Existencia(decimal Número)
        {
            bool Existencia = false;
            int Num1 = 0;
            int Num2 = 1;
            int Num3 = 0;
            string Resultado = "";
            while (Num3 <= Número)
            {
                if (Num3 == Número)
                {
                    Existencia = true;
                }               
                Num3 = Num1 + Num2;
                Num2 = Num1;
                Num1 = Num3;                  
            }
            if (Existencia == true)
            {
                Resultado = "El número existe dentro de la sucesión";
            }
            if (Existencia == false)
            {
                Resultado = "El número no existe dentro de la sucesión";
            }
            return Resultado; 
        }

        private void btnVecesARealizar_Click(object sender, EventArgs e)
        {
            lblFibonacci.Text = "Resultado: ";
            string Resultado = Sucesión(nudCant.Value);
            lblFibonacci.Text += "0, " + Resultado;
        }

        private void btnHastaLlegarA_Click(object sender, EventArgs e)
        {
            lblFibonacci.Text = "Resultado: ";
            string Resultado = Llegar(nudCant.Value);
            lblFibonacci.Text += "0, " + Resultado;
        }
        private void btnExistencia_Click(object sender, EventArgs e)
        {
            lblFibonacci.Text = "Resultado: ";
            string Resultado = Existencia(nudCant.Value);
            lblFibonacci.Text += Resultado;
        }          
    }
}
