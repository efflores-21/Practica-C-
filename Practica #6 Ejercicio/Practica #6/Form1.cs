using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica__6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            // Limpiar ListBox antes de mostrar los resultados
            listBox1.Items.Clear();

            // Verificar que los números sean válidos
            if (int.TryParse(textBox1.Text, out int x) && int.TryParse(textBox2.Text, out int y))
            {
                // Mostrar los números en el rango
                if (x < y)
                {
                    for (int i = x; i <= y; i++)
                    {
                        listBox1.Items.Add(i);
                    }
                }
                else
                {
                    for (int i = x; i >= y; i--)
                    {
                        listBox1.Items.Add(i);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese números válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
    

