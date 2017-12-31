using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiosko_De_La_Abuela
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lbl100.Text = "";
            lbl50.Text = "";
            lbl20.Text = "";
            lbl10.Text = "";
            lbl5.Text = "";
            lbl2.Text = "";
            lbl1.Text = "";
            lbl50C.Text = "";
            lbl25C.Text = "";
            lbl10C.Text = "";
            lbl5C.Text = "";
        }
        int Can100 = 0;
        int Can50 = 0;
        int Can20 = 0;
        int Can10 = 0;
        int Can5 = 0;
        int Can2 = 0;
        int Can1 = 0;
        int Can50C = 0;
        int Can25C = 0;
        int Can10C = 0;
        int Can5C = 0;
        private void nudPago_ValueChanged(object sender, EventArgs e)
        {

        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            Can100 = 0;
            Can50 = 0;
            Can20 = 0;
            Can10 = 0;
            Can5 = 0;
            Can2 = 0;
            Can1 = 0;
            Can50C = 0;
            Can25C = 0;
            Can10C = 0;
            Can5C = 0;
            lbl100.Text = "";
            lbl50.Text = "";
            lbl20.Text = "";
            lbl10.Text = "";
            lbl5.Text = "";
            lbl2.Text = "";
            lbl1.Text = "";
            lbl50C.Text = "";
            lbl25C.Text = "";
            lbl10C.Text = "";
            lbl5C.Text = "";
            decimal PagoNo1 = nudDebePagar.Value;
            decimal PagoNo = nudPago.Value;
            if (PagoNo1 == 0)
            {
                MessageBox.Show("Abuela, no ingresó cuánto debe pagar el cliente. Ingreselo o no funciona");
            }
            else
            {
                if (PagoNo == 0)
                {
                    MessageBox.Show("Abuela, no ingresó con cuánto paga el cliente. Ingreselo o no funciona");
                }
            }
            decimal Pago = PagoNo - PagoNo1;
            if (Pago == 0)
            {
                MessageBox.Show("No hay vuelto, abuela");
            }
            else
            {
                if (Pago < 0)
                {
                    MessageBox.Show("El cliente no paga con suficiente. Que no se pase de vivo, abuela");
                }
                else
                {
                    while (Pago >= 100)
                    {
                        Can100++;
                        Pago -= 100;
                    }
                    while (Pago >= 50)
                    {
                        Can50 += 1;
                        Pago -= 50;
                    }
                    while (Pago >= 20)
                    {
                        Can20 += 1;
                        Pago -= 20;
                    }
                    while (Pago >= 10)
                    {
                        Can10 += 1;
                        Pago -= 10;
                    }
                    while (Pago >= 5)
                    {
                        Can5 += 1;
                        Pago -= 5;
                    }
                    while (Pago >= 2)
                    {
                        Can2 += 1;
                        Pago -= 2;
                    }
                    while (Pago >= 1)
                    {
                        Can1 += 1;
                        Pago -= 1;
                    }
                    while (Pago >= 0.5M)
                    {
                        Can50C += 1;
                        Pago -= 0.5M;
                    }
                    while (Pago >= 0.25M)
                    {
                        Can25C += 1;
                        Pago -= 0.25M;
                    }
                    while (Pago >= 0.1M)
                    {
                        Can10C += 1;
                        Pago -= 0.1M;
                    }
                    while (Pago >= 0.05M)
                    {
                        Can5C += 1;
                        Pago -= 0.05M;
                    }
                    while (Pago > 0)
                    {
                        Can5C += 1;
                        Pago = 0;
                    }
                    MessageBox.Show("Ahora, apretá 'siguiente'");
                }
            }
        }                           

        private void btnSiguiente_Click(object sender, EventArgs e)
        {                          
                lbl100.Text = "X" + Can100;            
                lbl50.Text = "X" + Can50;           
                lbl20.Text = "X" + Can20;            
                lbl10.Text = "X" + Can10;            
                lbl5.Text = "X" + Can5;
                lbl2.Text = "X" + Can2;
                lbl1.Text = "X" + Can1;
                lbl50C.Text = "X" + Can50C;
                lbl25C.Text = "X" + Can25C;
                lbl10C.Text = "X" + Can10C;
                lbl5C.Text = "X" + Can5C;                
        }

        private void lblCantidad_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}


