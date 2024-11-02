using System.Windows.Forms;

namespace NotasRapidasApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // Método para destacar la nota
        private void DestacarNota(object sender, EventArgs e)
        {
            txtNota.BackColor = Color.Yellow;
            MessageBox.Show("¡Nota destacada!", "Destacar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Atajos de teclado
        private void AtajosDeTeclado(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S) // Guardar con Ctrl+S
            {
                GuardarNota(sender, e);
            }
            else if (e.Control && e.KeyCode == Keys.L) // Limpiar con Ctrl+L
            {
                LimpiarNota(sender, e);
            }
            else if (e.Control && e.KeyCode == Keys.Q) // Cerrar con Ctrl+Q
            {
                this.Close();
            }
        }

        // Método para guardar la nota
        private void GuardarNota(object sender, EventArgs e)
        {
            MessageBox.Show("Nota guardada exitosamente.",
                "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Método para limpiar la nota
        private void LimpiarNota(object sender, EventArgs e)
        {
            txtNota.Clear();
        }


        // Variables para arrastrar el cuadro de texto
        private Point puntoInicial;
        private bool arrastrando = false;

        // Iniciar arrastre al presionar el botón izquierdo del ratón
        private void IniciarArrastre(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                arrastrando = true;
                puntoInicial = e.Location;
            }
        }

        // Mover el cuadro de texto mientras se arrastra
        private void ArrastrarControl(object sender, MouseEventArgs e)
        {
            if (arrastrando)
            {
                txtNota.Left += e.X - puntoInicial.X;
                txtNota.Top += e.Y - puntoInicial.Y;
            }
        }

        // Terminar el arrastre al soltar el botón izquierdo del ratón
        private void txtNota_MouseUp(object sender, MouseEventArgs e)
        {
            arrastrando = false;
        }

    }
}
