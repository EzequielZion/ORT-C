using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaLocaDeVectores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] vectorNombre = new string[6];
        int[] vectorPuntos = new int[6];
        int PuntosPartido = 0;
        private static void AsignarPuntos(ComboBox cmbJugadores, NumericUpDown nudPuntos, int[] vectorPuntos, string[] vectorNombre, int PuntosPartido)
        {
            if (nudPuntos.Value < 1 || nudPuntos.Value > 3)
            {
                MessageBox.Show("Error; la cantidad de puntos ingresados no es válida");
            }
            else
            {
                switch (cmbJugadores.Text)
                {
                    case "Johnson (Dorsal 44)":
                        vectorNombre[0] = "Johnson (Dorsal 44)";
                        vectorPuntos[0] += (int)nudPuntos.Value;
                        PuntosPartido += vectorPuntos[0];
                        break;
                    case "Rogers (Dorsal 25)":
                        vectorNombre[1] = "Rogers (Dorsal 25)";
                        vectorPuntos[1] += (int)nudPuntos.Value;
                        PuntosPartido += vectorPuntos[1];
                        break;
                    case "Bumaschny (Dorsal 10)":
                        vectorNombre[2] = "Bumaschny (Dorsal 10)";
                        vectorPuntos[2] += (int)nudPuntos.Value;
                        PuntosPartido += vectorPuntos[2];
                        break;
                    case "St. John (Dorsal 33)":
                        vectorNombre[3] = "St. John (Dorsal 33)";
                        vectorPuntos[3] += (int)nudPuntos.Value;
                        PuntosPartido += vectorPuntos[3];
                        break;
                    case "Dowëmenns (Dorsal 3)":
                        vectorNombre[4] = "Dowëmenns (Dorsal 3)";
                        vectorPuntos[4] += (int)nudPuntos.Value;
                        PuntosPartido += vectorPuntos[4];
                        break;
                    case "Martins (Dorsal 99)":
                        vectorNombre[5] = "Martins (Dorsal 99)";
                        vectorPuntos[5] += (int)nudPuntos.Value;
                        PuntosPartido += vectorPuntos[5];
                        break;
                    default:
                        break;
                }
            }
        }
        public static void Ordenar(ref int[] vectorPuntos, ref string[] vectorNombre)
        {
            for (int i = 0; i < vectorPuntos.Length - 1; i++)
            {
                for (int j = 0; j < vectorPuntos.Length - 1; j++)
                {
                    if (vectorPuntos[j] < vectorPuntos[j + 1])
                    {
                        int AuxiliarInt = vectorPuntos[j + 1];
                        vectorPuntos[j + 1] = vectorPuntos[j];
                        vectorPuntos[j] = AuxiliarInt;
                        string AuxiliarString = vectorNombre[j + 1];
                        vectorNombre[j + 1] = vectorNombre[j];
                        vectorNombre[j] = AuxiliarString;
                    }
                }
            }
        }
        private static void ResultadosFinales(Label Puntos, int PuntosPartido, string[] vectorNombre, int[] vectorPuntos, int Menos, int Más, Label MenosConversión, Label MásConversión, Label Orden)
        {
            Puntos.Text += PuntosPartido;
            MenosConversión.Text += vectorNombre[Menos] + ", con un total de " + vectorPuntos[Menos] + " puntos.";
            MásConversión.Text += vectorNombre[Más]  + ", con un total de " + vectorPuntos[Más] + " puntos.";
            Orden.Text += vectorNombre[0] + ", con " + vectorPuntos[0] + " puntos. " + vectorNombre[1] + ", con " + vectorPuntos[1] + " puntos. " + vectorNombre[2] + ", con " + vectorPuntos[2] + " puntos. " + vectorNombre[3] + ", con " + vectorPuntos[3] + " puntos. " + vectorNombre[4] + ", con " + vectorPuntos[4] + " puntos. " + vectorNombre[5] + ", con " + vectorPuntos[5] + " puntos.";
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            AsignarPuntos(cmbJugadores, nudPuntos, vectorPuntos, vectorNombre, PuntosPartido);
        }
        private void btnFin_Click_1(object sender, EventArgs e)
        {
            lblPuntos.Text = "El equipo convirtió: ";
            lblMenosConversión.Text = "El jugador que menos\n convirtió y sus puntos\n fueron: ";
            lblMásConversión.Text = "El jugador que más\n convirtió y sus puntos\n fueron: ";
            lblOrden.Text = "Los jugadores convirtieron\n de mayor a menor en el\n siguiente orden: ";
           {
            int Menor = 1000;
            int Mayor = 0;
            int PosMenosPuntos = 0;
            int PosMásPuntos = 0;
            for (int i = 0; i == vectorPuntos.Length; i++)
            {
                if (vectorPuntos[i] < Menor)
                {
                    PosMenosPuntos = i;
                }
                if (vectorPuntos[i] > Mayor)
                {
                    PosMásPuntos = i;
                }
            }
            Ordenar(ref vectorPuntos, ref vectorNombre);
            ResultadosFinales(lblPuntos, PuntosPartido, vectorNombre, vectorPuntos, PosMenosPuntos, PosMásPuntos, lblMenosConversión, lblMásConversión, lblOrden);
          }
        }
    }
}
