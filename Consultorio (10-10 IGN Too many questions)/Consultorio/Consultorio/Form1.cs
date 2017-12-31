using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Consultorio
{
    public partial class frmConsultorio : Form
    {
        int Costos = 0;
        int SueldoEmpleados = 200;
        int Paciente4 = 0;
        int RecaudadoAmbulancia = 0; 
        int RecaudadoRadiografía = 0;
        int RecaudadoImplantes = 0;
        int RecaudadoEcografía = 0;
        int RecaudadoAnalisis = 0;
        int HombresRadiografiaCant = 0;
        int HombresImplantesCant = 0;
        int HombresEcografiaCant = 0;
        int HombresAnalisisCant = 0;
        int MujeresRadiografiaCant = 0;
        int MujeresImplantesCant = 0;
        int MujeresEcografiaCant = 0;
        int MujeresAnalisisCant = 0;
        int Estudio8 = 0;
        public frmConsultorio()
        {
            InitializeComponent();
        }

        private void btnDía_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MujeresRadiografiaCant + " mujeres se hicieron radiografías");
            MessageBox.Show(HombresRadiografiaCant + " hombres se hicieron radiografías");
            MessageBox.Show(MujeresImplantesCant + " mujeres se hicieron implantes");
            MessageBox.Show(HombresImplantesCant + " hombres se hicieron radiografías");
            MessageBox.Show(MujeresEcografiaCant + " mujeres se hicieron ecografías");
            MessageBox.Show(HombresEcografiaCant + " hombres se hicieron ecografías");
            MessageBox.Show(MujeresAnalisisCant + " mujeres se hicieron análisis de orina");
            MessageBox.Show(HombresAnalisisCant + " hombres se hicieron analísis de orina");
            MessageBox.Show("Se recaudaron $" + RecaudadoRadiografía + " por las radiografías");
            MessageBox.Show("Se recaudaron $" + RecaudadoImplantes + " por los implantes");
            MessageBox.Show("Se recaudaron $" + RecaudadoEcografía + " por las ecografías");
            MessageBox.Show("Se recaudaron $" + RecaudadoAnalisis + " por los análisis");
            MessageBox.Show("La recaudación total de hoy fue de $" + (RecaudadoRadiografía + RecaudadoImplantes + RecaudadoEcografía + RecaudadoAnalisis + RecaudadoAmbulancia- Costos));
        }
        
        private void btnMes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La recaudación total del mes fue de $" + (RecaudadoRadiografía + RecaudadoImplantes + RecaudadoEcografía + RecaudadoAnalisis + RecaudadoAmbulancia - Costos - SueldoEmpleados));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Estudio8 == 8)
            {
                Estudio8 = Estudio8 - 8;
                SueldoEmpleados = SueldoEmpleados + 200;

            }
            if (Paciente4 == 4)
            {
                Paciente4 = Paciente4 - 4;
                Costos = Costos + 40;
                if (rbtCapital.Checked == true)
                {
                    if (rbtTarjeta.Checked == true)
                    {
                        RecaudadoAmbulancia = RecaudadoAmbulancia + 120;
                    }
                    else
                    {
                        if (rbtEfectivo.Checked == true)
                        {
                            RecaudadoAmbulancia = RecaudadoAmbulancia + 108;
                        }
                    }
                }
                else
                {
                    if (rbtGBA.Checked == true)
                    {
                        if (rbtTarjeta.Checked == true)
                        {
                            RecaudadoAmbulancia = RecaudadoAmbulancia + 180;
                        }
                        else
                        {
                            if (rbtEfectivo.Checked == true)
                            {
                                RecaudadoAmbulancia = RecaudadoAmbulancia + 162;
                            }
                        }
                    }
                }

            }


            Paciente4 = Paciente4 + 1;
            if (rbtMujer.Checked == true && cmbEstudios.Text == "Radiografía" && nudEdad.Value < 59)
            {
                MujeresRadiografiaCant = MujeresRadiografiaCant + 1;
                RecaudadoRadiografía = RecaudadoRadiografía + 90;
                Costos = Costos + 20;
                Estudio8 = Estudio8 + 1;

            }
            else
            {
                if (rbtMujer.Checked == true && cmbEstudios.Text == "Radiografía" && nudEdad.Value > 59)
                {
                    MujeresRadiografiaCant = MujeresRadiografiaCant + 1;
                    RecaudadoRadiografía = RecaudadoRadiografía + 45;
                    Costos = Costos + 20;
                    Estudio8 = Estudio8 + 1;
                }
                else
                {
                    if (rbtHombre.Checked == true && cmbEstudios.Text == "Radiografía" && nudEdad.Value < 64)
                    {
                        HombresRadiografiaCant = HombresRadiografiaCant + 1;
                        RecaudadoRadiografía = RecaudadoRadiografía + 90;
                        Costos = Costos + 20;
                        Estudio8 = Estudio8 + 1;
                    }
                    else
                    {
                        if (rbtHombre.Checked == true && cmbEstudios.Text == "Radiografía" && nudEdad.Value > 64)
                        {
                            HombresRadiografiaCant = HombresRadiografiaCant + 1;
                            RecaudadoRadiografía = RecaudadoRadiografía + 45;
                            Costos = Costos + 20;
                            Estudio8 = Estudio8 + 1;
                        }
                    }
                }


                if (rbtMujer.Checked == true && cmbEstudios.Text == "Implantes" && nudEdad.Value < 59)
                {
                    MujeresImplantesCant = MujeresImplantesCant + 1;
                    RecaudadoImplantes = RecaudadoImplantes + 300;
                    Costos = Costos + 60;
                    Estudio8 = Estudio8 + 1;
                }
                else
                {
                    if (rbtMujer.Checked == true && cmbEstudios.Text == "Implantes" && nudEdad.Value > 59)
                    {
                        MujeresImplantesCant = MujeresImplantesCant + 1;
                        RecaudadoImplantes = RecaudadoImplantes + 150;
                        Costos = Costos + 60;
                        Estudio8 = Estudio8 + 1;
                    }
                    else
                    {
                        if (rbtHombre.Checked == true && cmbEstudios.Text == "Implantes" && nudEdad.Value < 64)
                        {
                            HombresImplantesCant = HombresImplantesCant + 1;
                            RecaudadoImplantes = RecaudadoImplantes + 300;
                            Costos = Costos + 60;
                            Estudio8 = Estudio8 + 1;
                        }
                        else
                        {
                            if (rbtHombre.Checked == true && cmbEstudios.Text == "Implantes" && nudEdad.Value > 64)
                            {
                                HombresImplantesCant = HombresImplantesCant + 1;
                                RecaudadoImplantes = RecaudadoImplantes + 150;
                                Costos = Costos + 60;
                                Estudio8 = Estudio8 + 1;
                            }
                        }
                    }

                }
                if (rbtMujer.Checked == true && cmbEstudios.Text == "Ecografía" && nudEdad.Value < 59)
                {
                    MujeresEcografiaCant = MujeresEcografiaCant + 1;
                    RecaudadoEcografía = RecaudadoEcografía + 150;
                    Costos = Costos + 40;
                    Estudio8 = Estudio8 + 1;
                }
                else
                {
                    if (rbtMujer.Checked == true && cmbEstudios.Text == "Ecografía" && nudEdad.Value > 59)
                    {
                        MujeresEcografiaCant = MujeresEcografiaCant + 1;
                        RecaudadoEcografía = RecaudadoEcografía + 75;
                        Costos = Costos + 40;
                        Estudio8 = Estudio8 + 1;
                    }
                    else
                    {
                        if (rbtHombre.Checked == true && cmbEstudios.Text == "Ecografía" && nudEdad.Value < 64)
                        {
                            HombresEcografiaCant = HombresEcografiaCant + 1;
                            RecaudadoEcografía = RecaudadoEcografía + 150;
                            Costos = Costos + 40;
                            Estudio8 = Estudio8 + 1;
                        }
                        else
                        {
                            if (rbtHombre.Checked == true && cmbEstudios.Text == "Ecografía" && nudEdad.Value > 64)
                            {
                                HombresEcografiaCant = HombresEcografiaCant + 1;
                                RecaudadoEcografía = RecaudadoEcografía + 75;
                                Costos = Costos + 40;
                                Estudio8 = Estudio8 + 1;
                            }
                        }
                    }

                }
                if (rbtMujer.Checked == true && cmbEstudios.Text == "Análisis de orina" && nudEdad.Value < 59)
                {
                    MujeresAnalisisCant = MujeresAnalisisCant + 1;
                    RecaudadoAnalisis = RecaudadoAnalisis + 60;
                    Costos = Costos + 15;
                    Estudio8 = Estudio8 + 1;
                }
                else
                {
                    if (rbtMujer.Checked == true && cmbEstudios.Text == "Análisis de orina" && nudEdad.Value > 59)
                    {
                        MujeresAnalisisCant = MujeresAnalisisCant + 1;
                        RecaudadoAnalisis = RecaudadoAnalisis + 30;
                        Costos = Costos + 15;
                        Estudio8 = Estudio8 + 1;
                    }
                    else
                    {
                        if (rbtHombre.Checked == true && cmbEstudios.Text == "Análisis de orina" && nudEdad.Value < 64)
                        {
                            HombresAnalisisCant = HombresAnalisisCant + 1;
                            RecaudadoAnalisis = RecaudadoAnalisis + 60;
                            Costos = Costos + 15;
                            Estudio8 = Estudio8 + 1;
                        }
                        else
                        {
                            if (rbtHombre.Checked == true && cmbEstudios.Text == "Análisis de orina" && nudEdad.Value > 64)
                            {
                                HombresAnalisisCant = HombresAnalisisCant + 1;
                                RecaudadoAnalisis = RecaudadoAnalisis + 30;
                                Costos = Costos + 15;
                                Estudio8 = Estudio8 + 1;
                            }
                        }
                    }
                }
            }
        }

        private void frmConsultorio_Load(object sender, EventArgs e)
        {

        }
    }
}


