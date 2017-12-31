using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
     
        decimal cantidad = 0;
        int Auto = 0;
        int Moto = 0;
        int Camión = 0;
        int Camioneta = 0;
        int Vehículos = 0;
        int Vehículo100 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmbVehiculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Vehículo100 == 100)
            {
                Vehículo100 = Vehículo100 - 100;
                MessageBox.Show("Usted no debe abonar");
            } 
            else
            
            if (cmbVehiculos.Text == "Auto")
            {
                Vehículos = Vehículos + 1;
                Auto = Auto + 1; 
                cantidad = cantidad + 10;
                Vehículo100 = Vehículo100 + 1;
                MessageBox.Show("Usted debe abonar $10");
            }

            if (Vehículo100 == 100)
            {
                Vehículo100 = Vehículo100 - 100;
                MessageBox.Show("Usted no debe abonar");
            }
            else
            if (cmbVehiculos.Text == "Moto")
            {
                Vehículos = Vehículos + 1;
                Moto = Moto + 1; 
                cantidad = cantidad + 4;
                Vehículo100 = Vehículo100 + 1;
                MessageBox.Show("Usted debe abonar $4");
            }
            if (Vehículo100 == 100)
            {
                Vehículo100 = Vehículo100 - 100;
                MessageBox.Show("Usted no debe abonar");
            }
            else
            if (cmbVehiculos.Text == "Camión")
            {
                Vehículos = Vehículos + 1;
                Camión = Camión + 1; 
                cantidad = cantidad + 32.40M;
                Vehículo100 = Vehículo100 + 1;
                MessageBox.Show("Usted debe abonar $32.40");
            }
            if (Vehículo100 == 100)
            {
                Vehículo100 = Vehículo100 - 100;
                MessageBox.Show("Usted no debe abonar");
            }
            else
            if (cmbVehiculos.Text == "Camioneta")
            {
                Vehículos = Vehículos + 1;
                Camioneta = Camioneta + 1;
                cantidad = cantidad + 18.50M;
                Vehículo100 = Vehículo100 + 1;
                MessageBox.Show("Usted debe abonar $18.50");
            }
           
            
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {



            if (Auto > Moto && Auto > Camioneta && Auto > Camión)
            {
                MessageBox.Show("El vehículo que más transitó fue el auto");
            }

            if (Camión > Moto && Camión > Camioneta && Camión > Auto)
            {
                MessageBox.Show("El vehículo que más transitó fue el camión");
            }

            if (Moto > Camioneta && Moto > Camión && Moto > Auto)
            {
                MessageBox.Show("El vehículo que más transitó fue la moto");
            }

            if (Camioneta > Auto && Camioneta > Moto && Camioneta > Camión)
            {
                MessageBox.Show("El vehículo que más transitó fue la camioneta");
            }


        }

        private void btnRecaudacion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hoy se recaudaron $" + cantidad);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Vehículos == 1)
            MessageBox.Show("Hoy pasó 1 vehículo");
            else
            MessageBox.Show("Hoy pasaron " + Vehículos + " vehículos");
        }



    }
}