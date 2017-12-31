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
        int auto = 0;
        int moto = 0;
        int camion = 0;
        int camioneta = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmbVehiculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbVehiculos.Text == "Auto")
            {
                cantidad = cantidad + 10;
                MessageBox.Show("Usted debe abonar $10");
            }
      

            if (cmbVehiculos.Text == "Moto")
            {
                cantidad = cantidad + 4;
                MessageBox.Show("Usted debe abonar $4");
            }
           
        }
       
         
    
        
    }
} 