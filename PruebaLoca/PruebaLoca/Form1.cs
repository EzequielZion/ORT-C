using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaLoca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        decimal IngresosDebito = 0;
        decimal IngresosCredito = 0;
        decimal IngresosEfectivo = 0;
        decimal CostosAlimentos = 0;
        int Cantidad = 0;
        decimal VentaBebida = 0;
        decimal VentaComida = 0;
        decimal VentaFinalBebidaDeb = 0;
        decimal VentaFinalComidaDeb = 0;
        decimal VentaFinalBebidaEfec = 0;
        decimal VentaFinalComidaEfec = 0;
        int Empleado = 0;
        int SueldoEmpleados = 200;
        int AlquilerABL = 1000;
        private void btnVenta_Click(object sender, EventArgs e)
        {
            if (Empleado == 10)
            {
                Empleado = 0;
                SueldoEmpleados += 200;
            }
            if (cmbBebidas.Text == "Gaseosa" && cmbComida.Text == "Sandwich" && nudBebida.Value == 1 && nudComida.Value == 1)
            {
                VentaComida += (50M);
                VentaBebida += (50M);
                CostosAlimentos += (10M + 7M);
            }
            switch (cmbBebidas.Text)
            {
                case "Café":
                    if (nudBebida.Value > 1)
                    {
                        nudBebida.Value = Cantidad;
                        CostosAlimentos += Cantidad * (4M);
                        VentaBebida = Cantidad * (15M - 1.5M);
                        Empleado += 1;
                    }
                    else
                    {
                        CostosAlimentos += (4M);
                        VentaBebida = (15M - 4M);
                        Empleado += 1;
                    }
                    break;
                case "Té":
                    nudBebida.Value = Cantidad;
                    CostosAlimentos += (Cantidad * (2M));
                    Empleado += 1;
                    VentaBebida += (Cantidad * (10M));
                    break;
                case "Gaseosa":
                    nudBebida.Value = Cantidad;
                    CostosAlimentos += ((7M) * Cantidad);
                    Empleado += 1;
                    VentaBebida += (Cantidad * (20M));
                    break;
                default:
                    MessageBox.Show("Ingrese qué bebida tomará");
                    break;
            }
            switch (cmbComida.Text)
            {
                case "Medialuna":
                    if (nudComida.Value >= 6)
                    {
                        nudComida.Value = Cantidad;
                        CostosAlimentos += Cantidad * 2M;
                        VentaComida += Cantidad * 6M;
                        Empleado += 1;
                    }
                    else
                    {
                        nudComida.Value = Cantidad;
                        CostosAlimentos += Cantidad * 2M;
                        VentaComida += Cantidad * 8M;
                        Empleado += 1;
                    }
                    break;
                case "Sandwich":
                    {
                        nudComida.Value = Cantidad;
                        CostosAlimentos += 10M;
                        VentaComida += Cantidad * 40M;
                        Empleado += 1;
                    }
                    break;
                case "Torta":
                    {
                        nudComida.Value = Cantidad;
                        CostosAlimentos += 15M;
                        VentaComida += Cantidad * 30M;
                        Empleado += 1;
                    }
                    break;
                default:
                    MessageBox.Show("Ingrese qué comida quiere");
                    break;

            }
            switch (cmbModoPago.Text)
            {
                case "Tarjeta de débito":
                    VentaFinalBebidaDeb = VentaBebida - VentaBebida * 0.05M;
                    VentaFinalComidaDeb = VentaComida - VentaComida * 0.05M;
                    IngresosDebito += VentaFinalBebidaDeb + VentaFinalComidaDeb;
                    break;
                case "Efectivo":
                    VentaFinalBebidaEfec = VentaBebida - VentaBebida * 0.1M;
                    VentaFinalComidaEfec = VentaComida - VentaComida * 0.1M;
                    IngresosEfectivo += VentaFinalBebidaEfec + VentaFinalComidaEfec;
                    break;
                case "Tarjeta de crédito":
                    IngresosCredito += VentaBebida + VentaComida;
                    break;
                default:
                    MessageBox.Show("Ingrese qué método de pago usará");
                    break;
            }
        }

        private void btnIngresosDia_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Los ingresos del día fueron de $" + (IngresosCredito + IngresosDebito + IngresosEfectivo));
            MessageBox.Show("Los ingresos en tarjeta de crédito fueron de $" + IngresosCredito);
            MessageBox.Show("Los ingresos en tarjeta de débito fueron de $" + IngresosDebito);
            MessageBox.Show("Los ingresos en efectivo fueron de $" + IngresosEfectivo);
        }

        private void btnGananciasDia_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Las ganancias del día fueron de $" + ((IngresosCredito + IngresosDebito + IngresosEfectivo) - CostosAlimentos));
        }

        private void btnGananciaMes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Las ganancias del mes fueron de $" + ((IngresosCredito + IngresosDebito + IngresosEfectivo) - (CostosAlimentos + AlquilerABL + SueldoEmpleados)));
            if ((IngresosCredito + IngresosDebito + IngresosEfectivo) > (CostosAlimentos + AlquilerABL + SueldoEmpleados))
            {
                MessageBox.Show("Este mes hubo ganancia");
            }
            if ((IngresosCredito + IngresosDebito + IngresosEfectivo) < (CostosAlimentos + AlquilerABL + SueldoEmpleados))
            {
                MessageBox.Show("Este mes no hubo ganancia");
            }
        }
    }
}
