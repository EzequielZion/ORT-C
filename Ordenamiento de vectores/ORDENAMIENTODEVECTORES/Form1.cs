using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ORDENAMIENTODEVECTORES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] vectorCant = new int[6];
        private void Form1_Load(object sender, EventArgs e)
        {
            vectorCant[0] = 8;
            vectorCant[1] = 7;
            vectorCant[2] = 9;
            vectorCant[3] = 2;
            vectorCant[4] = 3;
            vectorCant[5] = 1;
        }

        private void btnSelección_Click(object sender, EventArgs e)
        {
            //Funciona
            int PosMin = 0;
            int Aux = 0;
            for (int i = 0; i < vectorCant.Length - 1; i++)
            {
                PosMin = i;
                for (int j = i + 1; j < vectorCant.Length; j++)
                {
                    if (vectorCant[j] < vectorCant[PosMin])
                    {
                        PosMin = j;
                    }
                }
                if (PosMin != i)
                {
                    Aux = vectorCant[i];
                    vectorCant[i] = vectorCant[PosMin];
                    vectorCant[PosMin] = Aux;
                }
            }
        }
        private void btnInserción_Click(object sender, EventArgs e)
        {
            //Funciona
            for (int i = 0; i < vectorCant.Length - 1; i++)
            {
                int j = i + 1;
                while (j > 0)
                {
                    if (vectorCant[j - 1] > vectorCant[j])
                    {
                        int Auxiliar = vectorCant[j - 1];
                        vectorCant[j - 1] = vectorCant[j];
                        vectorCant[j] = Auxiliar;
                    }
                    j--;
                }
            }
        }

        private void btnBurbuja_Click(object sender, EventArgs e)
        {
            //Funciona
            for (int i = 0; i < vectorCant.Length - 1; i++)
            {
                for (int j = 0; j < vectorCant.Length - 1; j++)
                {
                    if (vectorCant[j] > vectorCant[j + 1])
                    {
                        int Auxiliar = vectorCant[j + 1];
                        vectorCant[j + 1] = vectorCant[j];
                        vectorCant[j] = Auxiliar;
                    }
                }
            }
        }
        private void btnTimSort_Click(object sender, EventArgs e)
        {
            //Funciona
            int j = 0;
            int Aux = 0;
            int iposta = (vectorCant.Length) / 2;
            while (iposta > 0)
            {
                for (int i = 0; i <= vectorCant.Length - 1; i++)
                {
                    j = i;
                    Aux = vectorCant[i];
                    while ((j >= iposta) && (vectorCant[j - iposta] > Aux))
                    {
                        vectorCant[j] = vectorCant[j - iposta];
                        j = j - iposta;
                    }
                    vectorCant[j] = Aux;
                }
                if (iposta / 2 != 0)
                {
                    iposta = iposta / 2;
                }
                else
                {
                    if (iposta == 1)
                    {
                        iposta = 0;
                    }
                    else
                    {
                        iposta = 1;
                    }
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            vectorCant[0] = 8;
            vectorCant[1] = 7;
            vectorCant[2] = 9;
            vectorCant[3] = 2;
            vectorCant[4] = 3;
            vectorCant[5] = 1;
        }
    }
}
