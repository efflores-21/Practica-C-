using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica__3
{
    public partial class Form1 : Form
    {
        // Definir el arreglo de ventas [producto, vendedor]
        private double[,] ventas = new double[5, 4];  // 5 productos, 4 vendedores
        public Form1()
        {
            InitializeComponent();
            InicializarDataGridView();
        }
        // Inicializar el DataGridView para mostrar las ventas
        private void InicializarDataGridView()
        {
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "Producto";
            dataGridView1.Columns[1].Name = "Vendedor 1";
            dataGridView1.Columns[2].Name = "Vendedor 2";
            dataGridView1.Columns[3].Name = "Vendedor 3";
            dataGridView1.Columns[4].Name = "Vendedor 4";
            dataGridView1.Rows.Add("Producto 1");
            dataGridView1.Rows.Add("Producto 2");
            dataGridView1.Rows.Add("Producto 3");
            dataGridView1.Rows.Add("Producto 4");
            dataGridView1.Rows.Add("Producto 5");
        }

        // Función para cargar las ventas simuladas
        private void CargarVentas()
        {
            // Simulación de ventas de los vendedores por producto
            Random rand = new Random();
            for (int producto = 0; producto < 5; producto++)
            {
                for (int vendedor = 0; vendedor < 4; vendedor++)
                {
                    ventas[producto, vendedor] = rand.Next(100, 1000);  // Genera un valor de ventas aleatorio entre 100 y 1000
                }
            }
        }

        // Función para mostrar los resultados en el DataGridView
        private void MostrarResultados()
        {
            // Calcular totales por producto (filas) y por vendedor (columnas)
            double[] totalProducto = new double[5];  // Total por producto
            double[] totalVendedor = new double[4];  // Total por vendedor

            // Llenar el DataGridView y calcular totales
            for (int producto = 0; producto < 5; producto++)
            {
                double sumaProducto = 0;
                for (int vendedor = 0; vendedor < 4; vendedor++)
                {
                    dataGridView1.Rows[producto].Cells[vendedor + 1].Value = ventas[producto, vendedor];
                    sumaProducto += ventas[producto, vendedor];  // Suma por producto
                    totalVendedor[vendedor] += ventas[producto, vendedor];  // Suma por vendedor
                }
                totalProducto[producto] = sumaProducto;
            }

            // Agregar columna con el total por producto
            dataGridView1.Columns.Add("TotalProducto", "Total Producto");
            for (int producto = 0; producto < 5; producto++)
            {
                dataGridView1.Rows[producto].Cells[5].Value = totalProducto[producto];
            }

            // Agregar fila con el total por vendedor
            string[] totalVendedoresRow = new string[6];
            totalVendedoresRow[0] = "Total Vendedor";
            for (int vendedor = 0; vendedor < 4; vendedor++)
            {
                totalVendedoresRow[vendedor + 1] = totalVendedor[vendedor].ToString();
            }
            totalVendedoresRow[5] = "";  // Vacío en la intersección
            dataGridView1.Rows.Add(totalVendedoresRow);
        }

        // Evento al hacer clic en el botón de cargar ventas
        private void btnCargar_Click(object sender, EventArgs e)
        {
            CargarVentas();
            MostrarResultados();
        }
    }
}
    

