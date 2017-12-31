using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private static void Primos(int Num, Label Primitos, Label Cant, Label EsONo)
        {
            Primitos.Text = "Los números primos que  hay entre 1 y el número\ningresado son: ";
            Cant.Text = "La cantidad de números primos que hay es: ";
            EsONo.Text = "El número: ";
            int CantPrimos = 0;
            int CantResto = 0;
            int Resto2 = Num % 2;
            int Resto3 = Num % 3;
            int Resto5 = Num % 5;
            int Resto7 = Num % 7;
            for (int i = 1; i <= Num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    int Resto = i % j;
                    if (Resto == 0)
                    { 
                        CantResto++; 
                    }
                }
                if (CantResto == 2)
                {
                   CantPrimos++;
                   Primitos.Text += i + ", ";
                }
                CantResto = 0;
            }
            Cant.Text += CantPrimos;
            if (Resto2 != 0 && Resto3 != 0 && Resto5 != 0 && Resto7 != 0 || Num == 2 || Num == 3 || Num == 5 || Num == 7)
            {
                EsONo.Text += "es primo";
            }
            else
            {

                EsONo.Text += "no es primo";
            }
        }       

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            decimal Num1 = nudNum.Value;
            int Num = Decimal.ToInt32(Num1);
            Primos(Num, lblNúmerosPrimos, lblCant, lblEsONo);            
        }
    }
}
                        

