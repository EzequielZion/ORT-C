using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aeropuertos_Argentina_20._000
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] vecRandom = new int[20];
        int i = -1;
        string Error = "";
        private static bool ValidoNombre(string Texto)
        {
            Texto = Texto.Trim();
            bool LetrasBool = true;
            bool NúmsBool = true;
            string LetrasString = Texto.Substring(0, 2);
            string NúmsString = Texto.Substring(2, 4);
            foreach (char C in LetrasString)
            {
                if (Char.IsLetter(C))
                {
                    LetrasBool = true;
                }
                else
                {
                    LetrasBool = false;
                }
            }
            foreach (char C in NúmsString)
            {
                if (Char.IsDigit(C))
                {
                    NúmsBool = true;
                }
                else
                {
                    NúmsBool = false;
                }
            }
                if (Texto.Length != 6 || LetrasBool == false || NúmsBool == false)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private static void Trim(string Nombre, string Origen, string Destino, string Aerolínea)
        {
            Nombre = Nombre.Trim();
            Origen = Origen.Trim();
            Destino = Destino.Trim();
            Aerolínea = Aerolínea.Trim();
        }
        private static bool ValidoFecha(DateTimePicker Fecha)
        {
            if (Fecha.Value > DateTime.Today)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private static bool ValidoStrings(TextBox Origen, TextBox Destino, TextBox Aerolínea)
        {
            if (Origen.Text == "" || Destino.Text == "" || Aerolínea.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private static bool ValidoNúms(decimal CantPasajeros, decimal Precio, int[] vecRandom, int i)
        {
            if (CantPasajeros <= 0 || Precio <= 0 || vecRandom[i] <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        List<Vuelo> ListaVuelos = new List<Vuelo>();
        private void button1_Click(object sender, EventArgs e)
        {
            Error = "";
            bool Nombre = false;
            bool Fecha = false;
            bool Strings = false;
            bool Núms = false;
            Nombre = ValidoNombre(txtNombre.Text);
            Fecha = ValidoFecha(dtpSalida);
            Strings = ValidoStrings(txtOrigen, txtDestino, txtAerolínea);
            Núms = ValidoNúms(nudCantPasajeros.Value, nudPrecio.Value, vecRandom, i);
            Trim(txtNombre.Text, txtOrigen.Text, txtDestino.Text, txtAerolínea.Text);
            if (Nombre == false)
            {
                Error += "Error, el nombre es incorrecto.\n";
            }
            if (Fecha == false)
            {
                Error += "Error, la fecha es incorrecta.\n";
            }
            if (Strings == false)
            {
                Error += "Error, el origen, el destino o la aerolínea es incorrecta.\n";
            }
            if (Núms == false)
            {
                Error += "Error, la cantidad de pasajeros o el precio del vuelo son incorrectos.\n";
            }
            if (Error != "")
            {
                MessageBox.Show(Error);
            }
            else
            {
                Vuelo oVuelo = new Vuelo();
                oVuelo.Nombre = txtNombre.Text;
                oVuelo.Origen = txtOrigen.Text;
                oVuelo.Destino = txtDestino.Text;
                oVuelo.Aerolínea = txtAerolínea.Text;
                oVuelo.Fecha = dtpSalida.Value;
                oVuelo.NúmPuerta = vecRandom[i];
                oVuelo.Precio = nudPrecio.Value;
                oVuelo.CantPasajeros = nudCantPasajeros.Value;
                oVuelo.Recaudación = nudCantPasajeros.Value*nudPrecio.Value;
                ListaVuelos.Add(oVuelo);
            }
        }
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            bool Rep = true;
            int NúmPuerta = 0;
            i++;
            if (i <= 19)
            {
                Random NúmRandom = new Random();
                while (Rep == true)
                {
                    Rep = false;
                    NúmPuerta = NúmRandom.Next(1, 20);
                    for (int j = 0; j <= 19; j++)
                    {
                        if (vecRandom[j] == NúmPuerta)
                        {
                            Rep = true;
                            break;
                        }
                    }
                }
                vecRandom[i] = NúmPuerta;
            }
            else
            {
                Error = "Error, ya no hay números de puertas disponibles./n";
            }
        }
        private void btnResultados_Click(object sender, EventArgs e)
        {
            Vuelo oVueloMásPasajeros = new Vuelo();
            Vuelo oVueloMayorRecaudación = new Vuelo();
            foreach (Vuelo oVuelo in ListaVuelos)
            {
                if (oVuelo.CantPasajeros > oVueloMásPasajeros.CantPasajeros)
                {
                    oVueloMásPasajeros.CantPasajeros = oVuelo.CantPasajeros;
                    oVueloMásPasajeros.Nombre = oVuelo.Nombre;
                }
                if (oVuelo.Recaudación > oVueloMayorRecaudación.Recaudación)
                {
                    oVueloMayorRecaudación.Recaudación = oVuelo.Recaudación;
                    oVueloMayorRecaudación.Nombre = oVuelo.Nombre;
                }
            }
            MessageBox.Show("El vuelo con mayor cantidad de pasajeros fue el vuelo " + oVueloMásPasajeros.Nombre + ", con un total de " + oVueloMásPasajeros.CantPasajeros + " pasajeros.");
            MessageBox.Show("El vuelo con mayor recaudación fue el vuelo " + oVueloMayorRecaudación.Nombre + ", siendo la misma de $" + oVueloMayorRecaudación.Recaudación + ".");
        }
    }    
}