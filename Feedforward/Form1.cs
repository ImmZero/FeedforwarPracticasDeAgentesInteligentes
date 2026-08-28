using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Feedforward
{
    public partial class Form1 : Form
    {
        double w = 4 ;
        //C1
        double w0_1_1, w1_1_1, w2_1_1, w0_2_1, w1_2_1, w2_2_1;
        //C2
        double w0_2_2, w1_2_2, w2_2_2, w0_1_2, w1_1_2, w2_1_2;
        //C3
        double w0_1_3, w1_1_3, w2_1_3, w0_2_3, w1_2_3, w2_2_3;

        private void datos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //Salidas
        double w0_1_4, w1_1_4, w2_1_4, w0_2_4, w1_2_4, w2_2_4;

        public Form1()
        {
            InitializeComponent();
        }
        private void Feedforward_Click(object sender, EventArgs e)
        {
            if (rbxor.Checked == true)
            {
                // Inicializar la tabla "Tabla"
                Tabla.Rows.Clear();
                Tabla.Columns.Clear();
                lbs1.Items.Clear();
                //Asiganar valor de los pesos
                InicializarPesos();

                /*
                w2 = Math.Round(random.NextDouble() * 100) / 100; // Generar número aleatorio con 2 decimales
                w1 = Math.Round(random.NextDouble() * 100) / 100; // Generar número aleatorio con 2 decimales
                w0 = Math.Round(random.NextDouble() * 100) / 100; // Generar número aleatorio con 2 decimales
                */

                // Agregar nuevas columnas con encabezados "LS", "AS", "LP", "AP".
                string[] ColumnasX = new string[]
                {
                "x1", "x2", "Yesp"
                };
                // Agregar nuevas columnas con encabezados "LS", "AS", "LP", "AP"
                foreach (string columna in ColumnasX)
                {
                    Tabla.Columns.Add(columna, columna);
                }
                Tabla.Rows.Add(3);
                // Agregar la columna "Yesp" a la tabla "Tabla"
                Tabla.Columns.Add("Yres", "Yres");
                //Agregar valores de las filas de X1
                XOR();
                XORinicio();
            }

            if (rbejercicio.Checked == true)
            {
                // Inicializar la tabla "Tabla"
                Tabla.Rows.Clear();
                Tabla.Columns.Clear();
                lbs1.Items.Clear();
                //Asiganar valor de los pesos
                InicializarPesos2();

                /*
                w2 = Math.Round(random.NextDouble() * 100) / 100; // Generar número aleatorio con 2 decimales
                w1 = Math.Round(random.NextDouble() * 100) / 100; // Generar número aleatorio con 2 decimales
                w0 = Math.Round(random.NextDouble() * 100) / 100; // Generar número aleatorio con 2 decimales
                */

                // Agregar nuevas columnas con encabezados "LS", "AS", "LP", "AP".
                string[] ColumnasX2 = new string[]
                {
                "x1", "x2", "Yesp"
                };
                // Agregar nuevas columnas con encabezados "LS", "AS", "LP", "AP"
                foreach (string columna2 in ColumnasX2)
                {
                    Tabla.Columns.Add(columna2, columna2);
                }
                Tabla.Rows.Add(3);

                // Agregar la columna "Yesp" a la tabla "Tabla"
                Tabla.Columns.Add("Yres1", "Yres1");
                Tabla.Columns.Add("Yres2", "Yres2");
                //Agregar valores de las filas de X1
                XOR();
                XORinicio2();
            }
        }
        private void XOR()
        {
            //Agregar valores de las filas de X1,X2,X3
            double[] valoresX1 = new double[]
            {
                0,0,1,1
            };
            double[] valoresX2 = new double[]
            {
                0,1,0,1
            };
            double[] yesp = new double[]
            {
                0,1,1,0
            };
            //Agregar valores de las filas de X1
            for (int i = 0; i < valoresX1.Length; i++)
            {
                Tabla.Rows[i].Cells["x1"].Value = valoresX1[i];
                Tabla.Rows[i].Cells["x2"].Value = valoresX2[i];
                Tabla.Rows[i].Cells["Yesp"].Value = yesp[i];
            }
        }
        private void XORinicio()
        {
            // Obtener la cantidad de filas y columnas en la tabla "Tabla"
            int rowCount = Tabla.Rows.Count;
            int colCount = Tabla.Columns.Count;
            // Lista para almacenar las sumas por fila
            List<double> sumasPorFila = new List<double>();
            // Lista para almacenar los resultados de las comparaciones
            List<int> resultadosComparacion = new List<int>();

            for (int j = 0; j < rowCount; j++)
            {
                double valorx1 = Convert.ToDouble(Tabla.Rows[j].Cells["x1"].Value);
                double valorx2 = Convert.ToDouble(Tabla.Rows[j].Cells["x2"].Value);
                //Capa1
                double fx = CalcularSalidaRed(valorx1, valorx2, w0_1_1, w1_1_1, w2_1_1);
                double fx2 = CalcularSalidaRed(valorx1, valorx2, w0_2_1, w1_2_1, w2_2_1);
                //Capa2
                double Y = CalcularSalidaRed(fx, fx2, w0_1_2, w1_1_2, w2_1_2);
                // Asignar el valor calculado de Y a la celda correspondiente en la columna "Yres"
                Tabla.Rows[j].Cells["Yres"].Value = Y;
                lbs1.Items.Add("Y interno = " + valorx1.ToString());
                lbs1.Items.Add("Y interno = " + valorx2.ToString());
                lbs1.Items.Add(" ");
                lbs1.Items.Add("fx interno = " + fx.ToString());
                lbs1.Items.Add("fx2 interno = " + fx2.ToString());
                lbs1.Items.Add("Y interno = " + Y.ToString());
                lbs1.Items.Add(" ");
            }        
        }
        private void InicializarPesos()
        {
            // W11
            w1_1_1 = 1;//5.191129; 
            w2_1_1 = 1;//5.473012;
            //U11
            w0_1_1 = 0.5;//-1.90289;        

            // W12
            w1_2_1 = 1;//2.769596; 
            w2_2_1 = 1;//2.758669;
            //U12
            w0_2_1 = 0.5;//-4.127002;

            // W21
            w1_1_2 = 1;// 5.839709; 
            w2_1_2 = 1;//-6.186834;
            //U21
            w0_1_2 = 0.5;//-2.570539;
        }
        private double CalcularSalidaRed(double x1, double x2, double w0, double w1, double w2)
        {
            double resultado = (x1 * w1) + (x2 * w2) + w0;
            return 1 / (1 + Math.Exp(-resultado));
        }
        private void XORinicio2()
        {
            // Obtener la cantidad de filas y columnas en la tabla "Tabla"
            int rowCount = Tabla.Rows.Count;
            int colCount = Tabla.Columns.Count;
            // Lista para almacenar las sumas por fila
            List<double> sumasPorFila = new List<double>();
            // Lista para almacenar los resultados de las comparaciones
            List<int> resultadosComparacion = new List<int>();

            for (int j = 0; j < rowCount; j++)
            {
                double valorx1 = Convert.ToDouble(Tabla.Rows[j].Cells["x1"].Value);
                double valorx2 = Convert.ToDouble(Tabla.Rows[j].Cells["x2"].Value);
                //Capa1
                double C11 = CalcularSalidaRed(valorx1, valorx2, w0_1_1, w1_1_1, w2_1_1);
                double C12 = CalcularSalidaRed(valorx1, valorx2, w0_2_1, w1_2_1, w2_2_1);
                //Capa2
                double C21 = CalcularSalidaRed(C11, C12, w0_1_2, w1_1_2, w2_1_2);
                double C22 = CalcularSalidaRed(C11, C12, w0_2_2, w1_2_2, w2_2_2);
                //capa3 Salida
                double C31 = CalcularSalidaRed(C21, C22, w0_1_3, w1_1_3, w2_1_3);
                double C32 = CalcularSalidaRed(C21, C22, w0_2_3, w1_2_3, w2_2_3);
                // Asignar el valor calculado de Y a la celda correspondiente en la columna "Yres"
                Tabla.Rows[j].Cells["Yres1"].Value = C31;
                Tabla.Rows[j].Cells["Yres2"].Value = C32;
                lbs1.Items.Add("Y1 interno = " + valorx1.ToString());
                lbs1.Items.Add("Y2 interno = " + valorx2.ToString());
                lbs1.Items.Add(" ");
                lbs1.Items.Add("C11 interno = " + C11.ToString());
                lbs1.Items.Add("C12 interno = " + C12.ToString());

                lbs1.Items.Add("C21 interno = " + C21.ToString());
                lbs1.Items.Add("C22 interno = " + C22.ToString());

                lbs1.Items.Add("C31 interno = " + C31.ToString());
                lbs1.Items.Add("C32 interno = " + C32.ToString());

                lbs1.Items.Add("Y1 interno = " + C31.ToString());
                lbs1.Items.Add("Y2 interno = " + C32.ToString());
                lbs1.Items.Add(" ");
            }
        }
        private void InicializarPesos2()
        {
            // W111
            w1_1_1 = 1;
            w2_1_1 = 1;
            //U111
            w0_1_1 = 0.5;

            // W121
            w1_2_1 = 1;
            w2_2_1 = 1;
            //U121
            w0_2_1 = 0.5;

            // W21
            w1_1_2 = 1;
            w2_1_2 = 1;
            //U21
            w0_1_2 = 0.5;

            // W22
            w1_2_2 = 1;
            w2_2_2 = 1;
            //U22
            w0_2_2 = 0.5;

            // W31
            w1_1_3 = 1;
            w2_1_3 = 1;
            //U31
            w0_1_3 = 0.5;

            // W32
            w1_2_3 = 1;
            w2_2_3 = 1;
            //U32
            w0_2_3 = 0.5;
        }
    }
}