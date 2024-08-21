using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajosPracticos123.TPractico1
{
    public partial class Practico1 : Form
    {
        public Practico1()
        {
            InitializeComponent();
        }

        private void Practico1_Load(object sender, EventArgs e)
        {

        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            // Concatenar apellido y nombre
            string result = textApellido.Text + " " + textNombre.Text;

            // Mostrar el resultado en el tercer TextBox    
            textResultado.Text = result;
        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            // Limpiar el TextBox multilinea
            textResultado.Clear();
        }

        private void Practico1_KeyDown(object sender, KeyEventArgs e)
        {
            // Verifica si se presiona Ctrl + S
            if (e.Control && e.KeyCode == Keys.S)
            {
                BSalir.PerformClick(); // Ejecuta el evento Click del botón Salir
            }
        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            // Cierra la aplicación
            Application.Exit();
        }
    }
}
