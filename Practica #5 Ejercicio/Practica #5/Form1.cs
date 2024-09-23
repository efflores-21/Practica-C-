using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica__5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Agregar operaciones al ComboBox
            comboBox1.Items.AddRange(new string[] { "+", "-", "x", "/" });
            comboBox1.SelectedIndex = 0; // Seleccionar la primera opción por defecto
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Verificar que los números sean válidos
            if (double.TryParse(textBox1.Text, out double num1) && double.TryParse(textBox2.Text, out double num2))
            {
                string operacion = comboBox1.SelectedItem.ToString();
                double resultado = 0;

                // Realizar la operación seleccionada
                switch (operacion)
                {
                    case "+":
                        resultado = num1 + num2;
                        break;
                    case "-":
                        resultado = num1 - num2;
                        break;
                    case "x":
                        resultado = num1 * num2;
                        break;
                    case "/":
                        if (num2 != 0)
                        {
                            resultado = num1 / num2;
                        }
                        else
                        {
                            MessageBox.Show("No se puede dividir entre 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        break;
                }

                // Mostrar el resultado en el Label
                label1.Text = "Resultado: " + resultado.ToString();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese números válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
    

