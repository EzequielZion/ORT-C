using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Equipo oEquipo = new Equipo();
        Jugador oJugador = new Jugador();
        List<Equipo> ListaEquipos = new List<Equipo>();
        string ErrorEquipo = "";
        string ErrorJugador = "";
        decimal MayorCantJugadoresEquipoDec = 0;
        string MayorCantJugadoresEquipoSt = "";
        private void ValidoJugador(string Nombre, string Apellido, decimal Edad, decimal Sueldo, ref string Error)
        {
            Error = "";
            if (Nombre == "")
            {
                Error += "Error, no ha ingresado el nombre del jugador.\n";
            }
            if (Apellido == "")
            {
                Error += "Error, no ha ingresado el apellido del jugador.\n";
            }
            if (Edad <= 0)
            {
                Error += "Error, no ha ingresado la edad del jugador.\n";
            }
            if (Sueldo <= 0)
            {
                Error += "Error, no ha ingresado el sueldo del jugador.\n";
            }
        }
        private void btnEquipo_Click(object sender, EventArgs e)
        {
            ErrorEquipo = "";
            if (txtEquipo.Text.Trim() == "")
            {
                ErrorEquipo += "Error, no ha ingresado un equipo. ";
            }
            if (ErrorEquipo == "")
            {
                oEquipo = new Equipo();
                oEquipo.ListaJugadoresDeEquipo = new List<Jugador>();
                oEquipo.Nombre = txtEquipo.Text.Trim();
                cmbEquipos.Items.Add(txtEquipo.Text.Trim());
                ListaEquipos.Add(oEquipo);
            }
            else
            {
                MessageBox.Show(ErrorEquipo);
            }
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            ValidoJugador(txtNombre.Text.Trim(), txtApellido.Text.Trim(), nudEdad.Value, nudSueldo.Value, ref ErrorJugador);
            if (ErrorJugador == "")
            {
                oJugador = new Jugador();
                oJugador.Nombre = txtNombre.Text;
                oJugador.Apellido = txtApellido.Text;
                oJugador.Edad = nudEdad.Value;
                oJugador.Sueldo = nudSueldo.Value;
                foreach (Equipo oEquipo in ListaEquipos)
                {
                    if (cmbEquipos.Text == oEquipo.Nombre)
                    {
                        oEquipo.ListaJugadoresDeEquipo.Add(oJugador);
                    }
                }
            }
            else
            {
                MessageBox.Show(ErrorJugador);
            }
        }
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            Jugador oJugadorMásGanador = new Jugador();
            Jugador oJugadorMásViejo = new Jugador();
            foreach (Equipo oEquipo in ListaEquipos)
            {
                decimal CantJugadores = 0;
                decimal SueldoTotal = 0;
                foreach (Jugador oJugador in oEquipo.ListaJugadoresDeEquipo)
                {
                    SueldoTotal += oJugador.Sueldo;
                    CantJugadores++;
                    if (oJugador.Sueldo >= oJugadorMásGanador.Sueldo)
                    {
                        oJugadorMásGanador = oJugador;
                    }
                    if (oJugador.Edad >= oJugadorMásViejo.Edad)
                    {
                        oJugadorMásViejo = oJugador;
                    }
                }
                if (CantJugadores > MayorCantJugadoresEquipoDec)
                {
                    MayorCantJugadoresEquipoDec = CantJugadores;
                    MayorCantJugadoresEquipoSt = oEquipo.Nombre;
                }
                MessageBox.Show("El sueldo total de " + oEquipo.Nombre + " es " + SueldoTotal + ". Su cantidad de jugadores es " + CantJugadores + ".");
            }
            MessageBox.Show("El jugador que más gana es " + oJugadorMásGanador.Nombre + " " + oJugadorMásGanador.Apellido + " con un sueldo de " + oJugadorMásGanador.Sueldo + ".");
            MessageBox.Show("El jugador más viejo es " + oJugadorMásViejo.Nombre + " " + oJugadorMásViejo.Apellido + " con una edad de " + oJugadorMásViejo.Edad + ".");
            MessageBox.Show("El equipo con más jugadores es " + MayorCantJugadoresEquipoSt + " con " + MayorCantJugadoresEquipoDec + " jugadores.");
        }
    }
}
