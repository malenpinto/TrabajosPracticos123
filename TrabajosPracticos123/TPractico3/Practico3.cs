using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajosPracticos123.TPractico3
{
    public partial class Practico3 : Form
    {
        public Practico3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            // Cierra la aplicación
            this.Close();
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            // Verifica si alguno de los TextBox está vacío
            if (string.IsNullOrWhiteSpace(TDni.Text) || string.IsNullOrWhiteSpace(TNombre.Text) || string.IsNullOrWhiteSpace(TApellido.Text))
            {
                // Muestra un mensaje de error si falta completar algún campo
                MessageBox.Show("Debe Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Variable para almacenar el resultado del MessageBox
                DialogResult ask;

                // Muestra un mensaje de confirmación
                ask = MessageBox.Show(
                    "¿Seguro que desea insertar un nuevo Cliente?",
                    "Confirmar Inserción",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1 // Foco en "Sí"
                );

                // Si el usuario selecciona "Sí"
                if (ask == DialogResult.Yes)
                {
                    // Obtener los valores ingresados en los TextBox
                    string nombre = TNombre.Text;
                    string apellido = TApellido.Text;

                    // Concatenar Nombre y Apellido
                    string nombreCompleto = nombre + " " + apellido;

                    //Tambien se puede hacer en una sola linea:
                    //string nombreCompleto = TNombre.Text + " " + TApellido.Text;

                    // Mostrar el nombre completo en el Label LModificar
                    LModificar.Text = nombreCompleto;

                    // Mostrar un mensaje de información indicando que el cliente se insertó correctamente
                    MessageBox.Show(
                        $"El cliente: {nombreCompleto} se registro correctamente",
                        "Guardar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                // Si el usuario selecciona "No", no se hace nada y se cancela la acción
            }
        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            // Verifica si alguno de los TextBox está vacío
            if (string.IsNullOrWhiteSpace(TDni.Text) || string.IsNullOrWhiteSpace(TNombre.Text) || string.IsNullOrWhiteSpace(TApellido.Text))
            {
                // Muestra un mensaje de error si falta completar algún campo
                MessageBox.Show("Debe Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Concatenar Nombre y Apellido para el mensaje de advertencia
                string nombreCompleto = TNombre.Text + " " + TApellido.Text;

                // Variable para almacenar el resultado del MessageBox
                DialogResult ask;

                // Muestra un mensaje de advertencia con el foco en "No"
                ask = MessageBox.Show(
                    $"Está apunto de eliminar el Cliente: {nombreCompleto}",
                    "Confirmar Eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button2 // Foco en "No"
                );

                // Si el usuario selecciona "Sí"
                if (ask == DialogResult.Yes)
                {
                    // Limpiar todos los TextBox y el Label LModificar
                    TDni.Clear();
                    TNombre.Clear();
                    TApellido.Clear();
                    LModificar.Text = "";
                    TTelefono.Clear();
                    // Desmarcar los CheckBox de Visa, Naranja y Mastercard
                    CBNaranja.Checked = false;
                    CBVisa.Checked = false;
                    CBMastercard.Checked = false;

                    // Mostrar un mensaje de confirmación indicando que el cliente se eliminó correctamente
                    MessageBox.Show(
                        $"El cliente: {nombreCompleto} se elimino correctamente",
                        "Eliminar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                // Si el usuario selecciona "No", no se hace nada y se cancela la acción
            }
        }
        
        private void Practico3_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void TDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es un número y no es la tecla de retroceso
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Cancela la entrada de la tecla
            }
        }

        private void TApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es una letra y no es la tecla de retroceso
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Cancela la entrada de la tecla
            }
        }

        private void TNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es una letra y no es la tecla de retroceso
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Cancela la entrada de la tecla
            }
        }

        private void RBVaron_CheckedChanged(object sender, EventArgs e)
        {
            if (RBVaron.Checked)
            {
                pictureBox1.Image = Properties.Resources.PerfilHombre;
            }
        }

        private void RBMujer_CheckedChanged(object sender, EventArgs e)
        {
            if (RBMujer.Checked)
            {
                pictureBox1.Image = Properties.Resources.PerfilMujer;
            }
        }

        private void TTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es un número y no es la tecla de retroceso
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Cancela la entrada de la tecla
            }
        }
    }
}
