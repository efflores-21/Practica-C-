using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica__2
{
    public partial class Form1 : Form
    {
        // Arreglo para simular los asientos, 0 indica que está libre, 1 indica ocupado
        int[] asientos = new int[10];
        public Form1()
        {
            InitializeComponent();
        }
        private void btnFumar_Click(object sender, EventArgs e)
        {
            AsignarAsiento(0, 5, "fumar");
        }

        // Método para asignar asiento en la sección de no fumar (asientos 6-10)
        private void btnNoFumar_Click(object sender, EventArgs e)
        {
            AsignarAsiento(5, 10, "no fumar");
        }

        // Método para asignar asiento
        private void AsignarAsiento(int inicio, int fin, string seccion)
        {
            int asientoAsignado = -1;

            // Buscar un asiento disponible en el rango indicado
            for (int i = inicio; i < fin; i++)
            {
                if (asientos[i] == 0)
                {
                    asientos[i] = 1;  // Asignar el asiento
                    asientoAsignado = i + 1; // Índice del asiento (ajustado a 1 basado)
                    break;
                }
            }

            if (asientoAsignado != -1)
            {
                // Imprimir pase de abordaje
                MessageBox.Show($"Su asiento es el {asientoAsignado} en la sección de {seccion}.", "Pase de abordaje");
            }
            else
            {
                // Si no hay asientos, preguntar si desea cambiar de sección
                string otraSeccion = seccion == "fumar" ? "no fumar" : "fumar";
                DialogResult result = MessageBox.Show($"La sección de {seccion} está llena. ¿Desea cambiar a la sección de {otraSeccion}?", "Sección llena", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    if (seccion == "fumar")
                        AsignarAsiento(5, 10, "no fumar");
                    else
                        AsignarAsiento(0, 5, "fumar");
                }
                else
                {
                    MessageBox.Show("El próximo vuelo sale en 3 horas.", "Vuelo lleno");
                }
            }

            // Revisar si todos los asientos están ocupados
            int asientosOcupados = 0;
            foreach (int asiento in asientos)
            {
                if (asiento == 1)
                    asientosOcupados++;
            }

            if (asientosOcupados == 10)
            {
                MessageBox.Show("Todos los asientos están ocupados. El próximo vuelo sale en 3 horas.", "Vuelo lleno");
            }
        }
    }
}
    

