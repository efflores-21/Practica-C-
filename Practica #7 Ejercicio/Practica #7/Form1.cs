using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica__7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            int[,] matriz1 = new int[4, 4];
            int[,] matriz2 = new int[4, 4];
            int[,] suma = new int[4, 4];

            // Leer valores de la primera matriz
            matriz1[0, 0] = int.Parse(textBox1.Text);
            matriz1[0, 1] = int.Parse(textBox2.Text);
            matriz1[0, 2] = int.Parse(textBox3.Text);
            matriz1[0, 3] = int.Parse(textBox4.Text);
            matriz1[1, 0] = int.Parse(textBox5.Text);
            matriz1[1, 1] = int.Parse(textBox6.Text);
            matriz1[1, 2] = int.Parse(textBox7.Text);
            matriz1[1, 3] = int.Parse(textBox8.Text);
            matriz1[2, 0] = int.Parse(textBox9.Text);
            matriz1[2, 1] = int.Parse(textBox10.Text);
            matriz1[2, 2] = int.Parse(textBox11.Text);
            matriz1[2, 3] = int.Parse(textBox12.Text);
            matriz1[3, 0] = int.Parse(textBox13.Text);
            matriz1[3, 1] = int.Parse(textBox14.Text);
            matriz1[3, 2] = int.Parse(textBox15.Text);
            matriz1[3, 3] = int.Parse(textBox16.Text);

            // Leer valores de la segunda matriz
            matriz2[0, 0] = int.Parse(textBox17.Text);
            matriz2[0, 1] = int.Parse(textBox18.Text);
            matriz2[0, 2] = int.Parse(textBox19.Text);
            matriz2[0, 3] = int.Parse(textBox20.Text);
            matriz2[1, 0] = int.Parse(textBox21.Text);
            matriz2[1, 1] = int.Parse(textBox22.Text);
            matriz2[1, 2] = int.Parse(textBox23.Text);
            matriz2[1, 3] = int.Parse(textBox24.Text);
            matriz2[2, 0] = int.Parse(textBox25.Text);
            matriz2[2, 1] = int.Parse(textBox26.Text);
            matriz2[2, 2] = int.Parse(textBox27.Text);
            matriz2[2, 3] = int.Parse(textBox28.Text);
            matriz2[3, 0] = int.Parse(textBox29.Text);
            matriz2[3, 1] = int.Parse(textBox30.Text);
            matriz2[3, 2] = int.Parse(textBox31.Text);
            matriz2[3, 3] = int.Parse(textBox32.Text);

            // Calcular la suma de las dos matrices
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    suma[i, j] = matriz1[i, j] + matriz2[i, j];
                }
            }

            // Mostrar la suma en el ListBox
            listBox1.Items.Clear();
            for (int i = 0; i < 4; i++)
            {
                string fila = "";
                for (int j = 0; j < 4; j++)
                {
                    fila += suma[i, j].ToString() + "\t";
                }
                listBox1.Items.Add(fila);
            }
        }
    }
}
    

