using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaLocaClasesYObjetos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string ErrorProvincia = "";
        string ErrorCiudad = "";
        decimal CantHabitantesTotal = 0;
        decimal MinMetrosCuadradosProvincia = 5000000;
        decimal MáxHabitantesCiudad = 0;
        decimal MáxHabitantesProvincia = 0;
        decimal MáxDensidadPoblaciónProvincia = 0;
        string StMinMetrosCuadradosProvincia = "";
        string StMáxHabitantesCiudad = "";
        string StMáxHabitantesProvincia = "";
        string StMáxDensidadPoblaciónProvincia = "";
        private void ValidoDatosProvincia(string NombreProvincia, string ErrorProvincia)
        {
            ErrorProvincia = "";
            if (NombreProvincia == "")
            {
                ErrorProvincia += "Error, no ha ingresado una provincia. ";
            }
        }
        private void ValidoDatosCiudad(string NombreCiudad, decimal CantHabitantes, decimal CantMetrosCuadrados, string ErrorCiudad)
        {
            ErrorCiudad = "";
            if (NombreCiudad == "")
            {
                ErrorCiudad += "Error, no ha ingresado una ciudad. ";
            }
            if (CantHabitantes <= 0)
            {
                ErrorCiudad += "Error, la cantidad de habitantes es inválida. ";
            }
            if (CantMetrosCuadrados <= 0)
            {
                ErrorCiudad += "Error, la cantidad de m² es inválida. ";
            }
        }
        List<Provincia> ListaProvincias = new List<Provincia>();
        Provincia oProvincia = new Provincia();
        private void button1_Click(object sender, EventArgs e)
        {
            ValidoDatosProvincia(txtNombreProvincia.Text, ErrorProvincia);
            if (ErrorProvincia == "")
            {
                oProvincia = new Provincia();
                oProvincia.ListaCiudadesDeProvincias = new List<Ciudad>();
                oProvincia.Nombre = txtNombreProvincia.Text;
                cmbProvincias.Items.Add(txtNombreProvincia.Text);
                ListaProvincias.Add(oProvincia);
            }
            else
            {
                MessageBox.Show(ErrorProvincia);
            }
        }
        Ciudad oCiudad = new Ciudad();
        private void btnIngresarCiudad_Click(object sender, EventArgs e)
        {
            ValidoDatosCiudad(txtNombreCiudad.Text, nudCantHabitantes.Value, nudCantMetrosCuadrados.Value, ErrorCiudad);
            if (ErrorCiudad == "")
            {
                oCiudad.Nombre = txtNombreCiudad.Text;
                oCiudad.CantHabitantes = nudCantHabitantes.Value;
                oCiudad.MetrosCuadrados = nudCantMetrosCuadrados.Value;
                CantHabitantesTotal += nudCantHabitantes.Value;
                foreach (Provincia oProvincia in ListaProvincias)
                {
                    if (cmbProvincias.Text == oProvincia.Nombre)
                    {
                        oProvincia.ListaCiudadesDeProvincias.Add(oCiudad);
                        oProvincia.CantHabitantes += nudCantHabitantes.Value;
                        oProvincia.MetrosCuadrados += nudCantMetrosCuadrados.Value;
                    }
                }
            }
            else
            {
                MessageBox.Show(ErrorCiudad);
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            foreach (Provincia oProvincia in ListaProvincias)
            {
                decimal DensidadPoblaciónProvincia = oProvincia.MetrosCuadrados / oProvincia.CantHabitantes;
                if (oProvincia.CantHabitantes > MáxHabitantesProvincia)
                {
                    MáxHabitantesProvincia = oProvincia.CantHabitantes;
                    StMáxHabitantesProvincia = oProvincia.Nombre;
                }
                if (oProvincia.MetrosCuadrados < MinMetrosCuadradosProvincia)
                {
                    MinMetrosCuadradosProvincia = oProvincia.MetrosCuadrados;
                    StMinMetrosCuadradosProvincia = oProvincia.Nombre;
                }
                if (DensidadPoblaciónProvincia > MáxDensidadPoblaciónProvincia)
                {
                    MáxDensidadPoblaciónProvincia = DensidadPoblaciónProvincia;
                    StMáxDensidadPoblaciónProvincia = oProvincia.Nombre;
                }
                foreach  (Ciudad oCiudad in oProvincia.ListaCiudadesDeProvincias)
                {
                    if (oCiudad.CantHabitantes > MáxHabitantesCiudad)
                    {
                        MáxHabitantesCiudad = oCiudad.CantHabitantes;
                        StMáxHabitantesCiudad = oCiudad.Nombre;
                    }
                }
                
            }
            MessageBox.Show("La población total del país es " + CantHabitantesTotal + ". La ciudad con más habitantes es " + StMáxHabitantesCiudad + ". La provincia con más habitantes es " + StMáxHabitantesProvincia + ". La provincia con menos metros cuadrados es " + StMinMetrosCuadradosProvincia + ". La provincia con más habitantes por m² es " + StMáxDensidadPoblaciónProvincia);
        }
    }
}
