using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mueblería
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int SillasVendidas = 0;
        int CantDescuentos = 0;
        decimal Recaudación = 0;
        string[] vectorMaterial = new string[10];
        decimal[] vectorPrecio = new decimal[10];
        int[] vectorContador = new int[10];       

        private static bool ValidoFactura(string Texto)     
        {           
            Texto = Texto.Trim();            
            bool AB = false;
            bool NumsBool = true;            
            string Primer = "";
            string NumsString = "";
            int NumsInt = 0;
            Primer = Texto.Substring(0, 1);
            NumsString = Texto.Substring(2, 4);
            NumsInt = Convert.ToInt32(NumsString);
            if (Primer == "A" || Primer == "B")
            {
                 AB = true;
            }
            if (NumsInt < 0 || NumsInt > 5000)
            {
                NumsBool = false;
            }
            if (Texto.Length != 6 || AB == false || NumsBool == false)
            {
                return false;
            }
            else
            {
                return true;
            }           
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string Error = "";
            int Sillas = (int)nudSillas.Value;
            int Código = (int)nudCódigo.Value - 1;
            bool Factura = ValidoFactura(txtFactura.Text);            
            decimal Descuento = 1;
            decimal Incremento = 1;
            decimal Pagar = 0;
            lblCliente.Text = "El cliente pagará: ";
            if (Factura == false)
            {
                Error += "Error; la factura no es válida. ";
            }
            if (Sillas < 1 || Sillas > 12)
            {
                Error += "Error; la cantidad de sillas elegidas no es válida. ";
            }
            if (cmbTamaño.Text == "")
            {
                Error += "Error; debe elegir un tamaño. ";
            }
            if (nudCódigo.Value < 1 || nudCódigo.Value > 10)
            {
                Error += "Error; debe elegir un código válido. ";
            }
            if (Error != "")
            {
                MessageBox.Show(Error);
            }
            else
            { 
            switch (cmbTamaño.Text) 
            {
                case "Chico":
                    if (Sillas >= 8)
                    {
                        Incremento += 0.15M;
                    }
                    break;
                case "Grande":
                    Descuento -= 0.1M;
                    CantDescuentos++;
                    break;
                default:
                    break;
            }
            if (vectorMaterial[Código] == "Metal")
            {
                Incremento += 0.1M;
            }
            if (vectorMaterial[Código] == "Combinado")
            {
                Descuento -= 0.075M;
                CantDescuentos++;
            }
            Pagar = vectorPrecio[Código];
            Pagar *= Incremento;
            Pagar *= Descuento;
            Recaudación += Pagar;
            SillasVendidas += Sillas;
            vectorContador[Código]++;
            lblCliente.Text = "El cliente pagará: " + Pagar;
        }
        }
        private void btnFin_Click(object sender, EventArgs e)
        {            
            int PosMenosVendido = 0;
            int PosMásVendido = 0;
            int AuxiliarMin = 1000;
            int AuxiliarMáx = 0;
            for (int i = 0; i <= vectorContador.Length-1; i++)
            {
                if (vectorContador[i] <= AuxiliarMin && vectorContador[i] > 0)
                {
                    PosMenosVendido = i;
                    AuxiliarMin = vectorContador[i];
                }
                if (vectorContador[i] >= AuxiliarMáx)
                {
                    PosMásVendido = i;
                    AuxiliarMáx = vectorContador[i];
                }
            }
            PosMenosVendido++;
            PosMásVendido++;
            if (PosMenosVendido != PosMásVendido)
            {
                lblCódigoMenos.Text = "El código menos elegido fue el: " + PosMenosVendido;
                lblMPMenos.Text = "Y su material y precio respectivo son: " + vectorMaterial[PosMenosVendido] + "/ " + vectorPrecio[PosMenosVendido];
                lblCódigoMás.Text = "El código más elegido fue el: " + PosMásVendido;
                lblMPMás.Text = "Y su material y precio respectivo son: " + vectorMaterial[PosMásVendido] + "/ " + vectorPrecio[PosMásVendido];
                lblDescuentos.Text = "La cantidad de descuentos realizados fue de: " + CantDescuentos;
                lblSillas.Text = "La cantidad de sillas vendidas fue de: " + SillasVendidas;
                lblRecaudaciónTotal.Text = "La recaudación total fue de: " + Recaudación;
            }
            else
            {
                lblCódigoMenos.Text = "El código menos elegido fue el: ";
                lblMPMenos.Text = "Y su material y precio respectivo son: ";
                lblCódigoMás.Text = "El código más elegido fue el: " + PosMásVendido;
                lblMPMás.Text = "Y su material y precio respectivo son: " + vectorMaterial[PosMásVendido] + "/ " + vectorPrecio[PosMásVendido];
                lblDescuentos.Text = "La cantidad de descuentos realizados fue de: " + CantDescuentos;
                lblSillas.Text = "La cantidad de sillas vendidas fue de: " + SillasVendidas;
                lblRecaudaciónTotal.Text = "La recaudación total fue de: " + Recaudación;
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            vectorMaterial[0] = "Madera";
            vectorMaterial[1] = "Madera";
            vectorMaterial[2] = "Madera";
            vectorMaterial[3] = "Madera";
            vectorMaterial[4] = "Metal";
            vectorMaterial[5] = "Metal";
            vectorMaterial[6] = "Metal";
            vectorMaterial[7] = "Metal";
            vectorMaterial[8] = "Combinado";
            vectorMaterial[9] = "Combinado";
            vectorPrecio[0] = 500.00M;
            vectorPrecio[1] = 600.00M;
            vectorPrecio[2] = 800.00M;
            vectorPrecio[3] = 1000.00M;
            vectorPrecio[4] = 2000.50M;
            vectorPrecio[5] = 2550.50M;
            vectorPrecio[6] = 3100.50M;
            vectorPrecio[7] = 4000.00M;
            vectorPrecio[8] = 5500.00M;
            vectorPrecio[9] = 6100.25M;
        }               
    }
}
