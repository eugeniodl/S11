namespace SistemaDeReservas
{
    public partial class Form1 : Form
    {
        private bool isMenuVisible = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnHamburguesa_Click(object sender, EventArgs e)
        {
            // Alterna la visibilidad del menú
            isMenuVisible = !isMenuVisible;
            panelMenu.Visible = isMenuVisible;
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            // Muestra el formulario de reservas en una pestaña
            // var tabPageReservar = new TabPage("Reservar");
            var formReservar = new FormReservar();
            MostrarFormularioEnTabPage(formReservar, tabPage1);
        }

        private void btnVerReservas_Click(object sender, EventArgs e)
        {
            // Muestra el formulario para ver reservas en una pestaña
            // var tabPageVerReservas = new TabPage("Ver Reservas");
            var formVerReservas = new FormVerReservas();
            MostrarFormularioEnTabPage(formVerReservas, tabPage2);
        }

        private void MostrarFormularioEnTabPage(Form formulario, TabPage tabPage)
        {
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            tabPage.Controls.Add(formulario);
            formulario.Show();

            //tabControlCentral.TabPages.Add(tabPage);
            tabControlCentral.SelectedTab = tabPage;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Cierra la aplicación
            Close();
        }
    }

    // Ejemplo de formulario para hacer reservas con FlowLayoutPanel
    public class FormReservar : Form
    {
        public FormReservar()
        {
            Text = "Reservar";

            // Título del formulario
            var lblTitulo = new Label
            {
                Text = "Formulario de Reservas",
                AutoSize = true,
                Font = new Font("Arial", 14, FontStyle.Bold),
                Margin = new Padding(10)
            };

            // FlowLayoutPanel para organizar los campos de forma vertical
            var flowLayoutPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.TopDown,
                Padding = new Padding(20),
                AutoScroll = true
            };

            // Campos de entrada
            var lblNombre = new Label { Text = "Nombre:", AutoSize = true };
            var txtNombre = new TextBox { Width = 200 };

            var lblFecha = new Label { Text = "Fecha de Reserva:", AutoSize = true };
            var datePicker = new DateTimePicker { Width = 200 };

            var lblHabitacion = new Label { Text = "Tipo de Habitación:", AutoSize = true };
            var comboHabitacion = new ComboBox { Width = 200 };
            comboHabitacion.Items.AddRange(new[] { "Simple", "Doble", "Suite" });

            // Botón de guardar
            var btnGuardar = new Button { Text = "Guardar", Width = 100, Height = 30, Margin = new Padding(10) };

            // Agregar controles al FlowLayoutPanel
            flowLayoutPanel.Controls.Add(lblTitulo);
            flowLayoutPanel.Controls.Add(lblNombre);
            flowLayoutPanel.Controls.Add(txtNombre);
            flowLayoutPanel.Controls.Add(lblFecha);
            flowLayoutPanel.Controls.Add(datePicker);
            flowLayoutPanel.Controls.Add(lblHabitacion);
            flowLayoutPanel.Controls.Add(comboHabitacion);
            flowLayoutPanel.Controls.Add(btnGuardar);

            // Agregar FlowLayoutPanel al formulario
            Controls.Add(flowLayoutPanel);
        }
    }

    // Ejemplo de formulario para ver reservas con TableLayoutPanel
    public class FormVerReservas : Form
    {
        public FormVerReservas()
        {
            Text = "Ver Reservas";

            // Título del formulario
            var lblTitulo = new Label
            {
                Text = "Lista de Reservas",
                Font = new Font("Arial", 14, FontStyle.Bold),
                AutoSize = true,
                Dock = DockStyle.Top,
                TextAlign = ContentAlignment.MiddleCenter
            };

            // TableLayoutPanel para organizar los datos en una tabla
            var tableLayoutPanel = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 3,
                RowCount = 1,
                AutoSize = true,
                CellBorderStyle = TableLayoutPanelCellBorderStyle.Single
            };

            // Encabezados de columna
            tableLayoutPanel.Controls.Add(new Label { Text = "Nombre", Font = new Font("Arial", 10, FontStyle.Bold), TextAlign = ContentAlignment.MiddleCenter }, 0, 0);
            tableLayoutPanel.Controls.Add(new Label { Text = "Fecha de Reserva", Font = new Font("Arial", 10, FontStyle.Bold), TextAlign = ContentAlignment.MiddleCenter }, 1, 0);
            tableLayoutPanel.Controls.Add(new Label { Text = "Tipo de Habitación", Font = new Font("Arial", 10, FontStyle.Bold), TextAlign = ContentAlignment.MiddleCenter }, 2, 0);

            // Agregar algunas filas de ejemplo
            tableLayoutPanel.Controls.Add(new Label { Text = "Juan Pérez", TextAlign = ContentAlignment.MiddleCenter }, 0, 1);
            tableLayoutPanel.Controls.Add(new Label { Text = "01/11/2024", TextAlign = ContentAlignment.MiddleCenter }, 1, 1);
            tableLayoutPanel.Controls.Add(new Label { Text = "Suite", TextAlign = ContentAlignment.MiddleCenter }, 2, 1);

            tableLayoutPanel.Controls.Add(new Label { Text = "María López", TextAlign = ContentAlignment.MiddleCenter }, 0, 2);
            tableLayoutPanel.Controls.Add(new Label { Text = "02/11/2024", TextAlign = ContentAlignment.MiddleCenter }, 1, 2);
            tableLayoutPanel.Controls.Add(new Label { Text = "Doble", TextAlign = ContentAlignment.MiddleCenter }, 2, 2);

            // Agregar el título y el TableLayoutPanel al formulario
            Controls.Add(lblTitulo);
            Controls.Add(tableLayoutPanel);
        }
    }

}
