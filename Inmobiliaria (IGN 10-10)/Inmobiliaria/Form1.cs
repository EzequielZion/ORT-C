using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inmobiliaria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblAmbientes.Text = "La dirección de la propiedad con \nmás ambientes es: ";
            lblCaro.Text = "La propiedad más cara y su \n correspondiente valor es: ";
            lblTotal.Text = "La recaudación de la semana fue de: ";            
        }
        private void Labels(Label Ambientes, Label Caro, Label Total)
        {
            Ambientes.Text = "La dirección de la propiedad con \nmás ambientes es: ";
            Caro.Text = "La propiedad más cara y su \n correspondiente valor es: ";
            Total.Text = "La recaudación de la semana fue de: ";       
        }
        decimal Recaudación = 0;
        int PosiciónMayorAmb = 0;
        int PosiciónMayorPrecio= 0;
        decimal[] VectorPrecio = new decimal [6];
        decimal AmbientesMayorDec = 0;
        string AmbientesMayorSt = "";
        string[] VectorDire = new string[6];
        decimal[] VectorAmbientes = new decimal [6];               
        decimal CasaCaraDec = 0;
        int i = 0;
            
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string Error = "";         
             if (i < 6)
             {
                 if (nudPrecio.Value > 2000000)
                 {
                     Error += "El precio ingresado es demasiado alto; ingrese un precio válido. ";
                 }
                 if (nudPrecio.Value < 500000)
                 {
                     Error += "El precio ingresado es demasiado bajo; ingrese un precio válido. ";
                 }
                 if (nudAmb.Value > 6)
                 {
                     Error += "La cantidad de ambientes ingresados es demasiado alta; ingrese una cantidad válida. ";
                 }
                 if (nudAmb.Value < 1)
                 {
                     Error += "La cantidad de ambientes ingresados es demasiado baja; ingrese una cantidad válida. ";
                 }
                 if (txtDire.Text == "")
                 {
                     Error += "Ingrese una dirección válida.";
                 }
                     if (Error == "")
                     {
                 VectorDire[i] = txtDire.Text;
                 VectorAmbientes[i] = nudAmb.Value;
                 VectorPrecio[i] = nudPrecio.Value;
                 Labels(lblAmbientes, lblCaro, lblTotal);
                    
                     if (VectorAmbientes[i] > VectorAmbientes[PosiciónMayorAmb])
                     {
                         PosiciónMayorAmb = i;                         
                     }
                     if (VectorPrecio[i] > VectorPrecio[PosiciónMayorPrecio])
                     {
                         PosiciónMayorPrecio = i;
                     }
                     Recaudación += VectorPrecio[i];
                     i++;
                     }  
                     else
                     {
                         MessageBox.Show(Error);
                     }
                 }                                        
             else
             {
                 MessageBox.Show("El sistema no permite que se ingrese más de seis propiedades por semana.");
             }
       }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            Labels(lblAmbientes, lblCaro, lblTotal);
            lblAmbientes.Text += "'" + VectorDire[PosiciónMayorAmb] + "'";
            lblCaro.Text += "$" + VectorPrecio[PosiciónMayorPrecio];
            lblTotal.Text += "$" + Recaudación;
            i = 6;
            Recaudación = 0;                      
        }
    }
}
