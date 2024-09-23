using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica__4
{
    public partial class Form1 : Form
    {
        // Arreglo para contar vendedores en cada rango de salario
        private int[] contadoresRangoSalarios = new int[9];
        public Form1()
        {
        InitializeComponent();
        InicializarDataGridView();
        }
        // Inicializar el DataGridView con los rangos de salario
        private void InicializarDataGridView()
        {
            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].Name = "Rango de Salario";
            dataGridView1.Columns[1].Name = "Número de Vendedores";

            // Agregar las filas con los rangos de salario
            dataGridView1.Rows.Add("$200 - $299");
            dataGridView1.Rows.Add("$300 - $399");
            dataGridView1.Rows.Add("$400 - $499");
            dataGridView1.Rows.Add("$500 - $599");
            dataGridView1.Rows.Add("$600 - $699");
            dataGridView1.Rows.Add("$700 - $799");
            dataGridView1.Rows.Add("$800 - $899");
            dataGridView1.Rows.Add("$900 - $999");
            dataGridView1.Rows.Add("$1000 o superior");
        }

        // Evento al hacer clic en el botón "Calcular"
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Obtener las ventas brutas del TextBox
            if (decimal.TryParse(txtVentasBrutas.Text, out decimal ventasBrutas))
            {
                // Calcular el salario total
                decimal salarioBase = 200m;
                decimal salario = salarioBase + (ventasBrutas * 0.09m);
                int salarioEntero = (int)salario; // Truncar a entero

                // Determinar en qué rango cae el salario y actualizar el contador
                if (salarioEntero >= 1000)
                    contadoresRangoSalarios[8]++;
                else if (salarioEntero >= 900)
                    contadoresRangoSalarios[7]++;
                else if (salarioEntero >= 800)
                    contadoresRangoSalarios[6]++;
                else if (salarioEntero >= 700)
                    contadoresRangoSalarios[5]++;
                else if (salarioEntero >= 600)
                    contadoresRangoSalarios[4]++;
                else if (salarioEntero >= 500)
                    contadoresRangoSalarios[3]++;
                else if (salarioEntero >= 400)
                    contadoresRangoSalarios[2]++;
                else if (salarioEntero >= 300)
                    contadoresRangoSalarios[1]++;
                else if (salarioEntero >= 200)
                    contadoresRangoSalarios[0]++;

                // Mostrar los resultados en el DataGridView
                for (int i = 0; i < contadoresRangoSalarios.Length; i++)
                {
                    dataGridView1.Rows[i].Cells[1].Value = contadoresRangoSalarios[i];
                }

                // Limpiar el TextBox para la siguiente entrada
                txtVentasBrutas.Clear();
            }
            else
            {
                MessageBox.Show("Ingrese un valor válido para las ventas brutas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

    

