using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubDeBarrio
{
    public partial class Form1 : Form
    {
        int Backgammon = 0;
        int Futbol = 0;
        int hockey = 0;
        int PelotaPaleta = 0;
        int Burako = 0;
        int RecaudaciónMes = 0;
        int Anios = 0;
        public Form1()
        {
            InitializeComponent();

        }

        private void btnMes_Click(object sender, EventArgs e)
        {

            MessageBox.Show("La recaudación del club es de $" + RecaudaciónMes);
            if (Backgammon > Futbol && Backgammon > hockey && Backgammon > PelotaPaleta && Backgammon > Burako)
            {
                MessageBox.Show("El deporte con más inscriptos es el Backgammon");
            }

            if (Futbol > Backgammon && Futbol > hockey && Futbol > PelotaPaleta && Futbol > Burako)
            {
                MessageBox.Show("El deporte con más inscriptos es el futbol");
            }
            if (hockey > Backgammon && hockey > Futbol && hockey > PelotaPaleta && hockey > Burako)
            {
                MessageBox.Show("El deporte con más inscriptos es el hockey");
            }
            if (PelotaPaleta > Backgammon && PelotaPaleta > Futbol && PelotaPaleta > hockey && PelotaPaleta > Burako)
            {
                MessageBox.Show("El deporte con más inscriptos es la pelota-paleta");

            }
            if (Burako > Backgammon && Burako > Futbol && Burako > hockey && Burako > PelotaPaleta)
            {
                MessageBox.Show("El deporte con más inscriptos fue el burako");
            }

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Anios = DateTime.Today.Year - dtpNacimiento.Value.Year;
            if (nudSocio.Value > 19 || Anios < 13)
            {
                MessageBox.Show("Usted no paga nada. Capo.");
            }
            else
            {
                if (nudSocio.Value > 9)
                {
                    if (Anios < 21)
                    {
                        RecaudaciónMes = RecaudaciónMes + 100;
                    }
                    if (Anios < 45 && Anios > 21)
                    {
                        RecaudaciónMes = RecaudaciónMes + 50;
                    }

                    if (Anios > 44)
                    {
                        RecaudaciónMes = RecaudaciónMes + 40;
                    }
                }
                else
                {
                    if (Anios < 21)
                    {
                        RecaudaciónMes = RecaudaciónMes + 200;
                    }
                    if (Anios < 45 && Anios > 21)
                    {
                        RecaudaciónMes = RecaudaciónMes + 100;
                    }

                    if (Anios > 44)
                    {
                        RecaudaciónMes = RecaudaciónMes + 80;
                    }
                }
            }
            switch (cmbDeportes.Text)
            {
                case "Backgammon":
                    Backgammon = Backgammon + 1;
                    RecaudaciónMes = RecaudaciónMes + 50;
                    break;
                case "Futbol":
                    Futbol = Futbol + 1;
                    RecaudaciónMes = RecaudaciónMes + 30;
                    break;

                case "Hockey":
                    hockey = hockey + 1;
                    RecaudaciónMes = RecaudaciónMes + 30;
                    break;

                case "Pelota-paleta":
                    PelotaPaleta = PelotaPaleta + 1;
                    RecaudaciónMes = RecaudaciónMes + 60;
                    break;

                case "Burako":
                    Burako = Burako + 1;
                    RecaudaciónMes = RecaudaciónMes + 30;
                    break;
                default:
                    break;
            }
        }
    }
}

    

