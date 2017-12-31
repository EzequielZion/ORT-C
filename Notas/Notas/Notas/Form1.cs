using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        decimal Nota1 = 0;
        decimal Nota2 = 0;
        decimal Nota3 = 0;
        decimal Promedio = 0;
        int AlumAprob = 0;
        int AlumDesaprob = 0;

        private void btnIngresar_Click(object sender, EventArgs e)
        {


            if (nudNotas.Value < 1 || nudNotas.Value > 10)
            {
                MessageBox.Show("Error. Ingrese una nota válida");
            }

            if (Nota1 > 0 && Nota1 < 11 && Nota2 > 0 && Nota2 < 11)
            {
                Nota3 = nudNotas.Value;
            }
            if (Nota1 > 0 && Nota1 < 11)
            {
                if (Nota3 == 0)
                {
                    Nota2 = nudNotas.Value;
                    MessageBox.Show("Ingrese la nota de su tercer trimestre");
                }
            }
            if (Nota2 == 0)
            {
                Nota1 = nudNotas.Value;
                MessageBox.Show("Ingrese la nota de su segundo trimestre");
            }
            if (Nota1 > 0 && Nota1 < 11 && Nota2 > 0 && Nota2 < 11 && Nota3 > 0 && Nota3 < 11)
            {
                if (((Nota1 + Nota2 + Nota3) / 3) >= 6 && Nota3 > 5)
                {
                    MessageBox.Show("Usted aprobó la materia");
                    MessageBox.Show("Su promedio fue de " + (Nota1 + Nota2 + Nota3) / 3);
                    AlumAprob += 1;
                    Nota1 = 0;
                    Nota2 = 0;
                    Nota3 = 0;
                }
                else
                {
                    MessageBox.Show("Usted desaprobó la materia");
                    MessageBox.Show("Su promedio fue de " + (Nota1 + Nota2 + Nota3) / 3);
                    AlumDesaprob += 1;
                    Nota1 = 0;
                    Nota2 = 0;
                    Nota3 = 0;
                }
                
            }

        }
      
        private void btnFinalizar_Click_1(object sender, EventArgs e)
        {
            Promedio = (AlumAprob * 100) / (AlumAprob + AlumDesaprob);
            MessageBox.Show("El porcentaje de los aprobados es del " + Promedio + "%");
            AlumAprob = 0;
            AlumDesaprob = 0;
        }
        }
       
        }         
        
        

