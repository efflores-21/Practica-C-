using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica__8
{
    public partial class Form1 : Form
    {
        private int intentos = 0; // Contador de intentos
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Definimos el usuario y la contraseña correctos
            int usuarioCorrecto = 12;
            int contrasenaCorrecta = 1234;

            // Intentamos convertir lo ingresado en números enteros
            try
            {
                int usuario = int.Parse(textBox1.Text);
                int contrasena = int.Parse(textBox2.Text);

                // Comprobamos si los datos son correctos
                if (usuario == usuarioCorrecto && contrasena == contrasenaCorrecta)
                {
                    MessageBox.Show("Inicio de sesión correcto. ¡Bienvenido!");
                    intentos = 0; // Reiniciar el contador de intentos tras el éxito
                }
                else
                {
                    intentos++;
                    MessageBox.Show($"Datos incorrectos. Intento {intentos}/3");
                }

                // Comprobamos si se alcanzaron los 3 intentos
                if (intentos >= 3)
                {
                    MessageBox.Show("Has alcanzado el máximo de intentos. Bloqueando acceso.");
                    button1.Enabled = false; // Deshabilitar el botón después de 3 intentos fallidos
                }
            }
            catch (FormatException)
            {
                // Si hay un error en la conversión (no se ingresaron números)
                MessageBox.Show("Por favor, ingrese números válidos.");
            }
        }
    }
}
    

