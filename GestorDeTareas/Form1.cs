
using System.Windows.Forms;

namespace GestorDeTareas
{
    public partial class Form1 : Form
    {
        private List<string> tareas = new List<string>(); // Lista de tareas

        public Form1()
        {
            InitializeComponent();

            toolStripStatusLabel.Text = string.Empty;
        }

        private void AgregarTarea(object sender, EventArgs e)
        {
            string nuevaTarea = Prompt.ShowDialog("Ingrese la nueva tarea:", "Agregar Tarea");
            if (!string.IsNullOrEmpty(nuevaTarea))
            {
                tareas.Add(nuevaTarea);
                listBox1.Items.Add(nuevaTarea);
                ActualizarEstado("Tarea agregada");
            }
        }

        private void ActualizarEstado(string mensaje)
        {
            toolStripStatusLabel.Text = mensaje;
        }

        private void EditarTarea(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string tareaActual = listBox1.SelectedItem.ToString();
                string tareaEditada = Prompt.ShowDialog("Editar tarea:", "Editar Tarea", tareaActual);
                if (!string.IsNullOrEmpty(tareaEditada))
                {
                    int index = listBox1.SelectedIndex;
                    tareas[index] = tareaEditada;
                    listBox1.Items[index] = tareaEditada;
                    ActualizarEstado("Tarea editada");
                }
            }
            else
            {
                MessageBox.Show("Seleccione una tarea para editar", "Advertencia");
            }
        }

        private void EliminarTarea(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                int index = listBox1.SelectedIndex;
                tareas.RemoveAt(index);
                listBox1.Items.RemoveAt(index);
                ActualizarEstado("Tarea eliminada");
            }
            else
            {
                MessageBox.Show("Seleccione una tarea para eliminar", "Advertencia");
            }
        }

        private void Salir(object sender, EventArgs e)
        {
            Close();
        }
    }
}
