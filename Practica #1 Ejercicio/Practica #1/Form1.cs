using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica__1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnSimulate_Click(object sender, EventArgs e)
        {
            // Declaramos las variables necesarias
            Random rand = new Random();
            int[] sumas = new int[13]; // Arreglo para contar las sumas posibles (índices 2-12)

            // Simulación de tirar los dados 36,000 veces
            for (int i = 0; i < 36000; i++)
            {
                int dado1 = rand.Next(1, 7); // Genera un valor entre 1 y 6
                int dado2 = rand.Next(1, 7); // Genera un valor entre 1 y 6
                int suma = dado1 + dado2;    // Suma de los dos dados
                sumas[suma]++;               // Contamos las veces que aparece cada suma
            }

            // Mostrar los resultados en un formato tabular
            dataGridView1.Rows.Clear();
            for (int i = 2; i <= 12; i++) // Las sumas posibles van de 2 a 12
            {
                double porcentaje = (sumas[i] / 36000.0) * 100; // Porcentaje
                dataGridView1.Rows.Add(i, sumas[i], porcentaje.ToString("0.00") + "%");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Configurar DataGridView
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Suma";
            dataGridView1.Columns[1].Name = "Veces Aparecida";
            dataGridView1.Columns[2].Name = "Porcentaje";
        }
    }
}
    

