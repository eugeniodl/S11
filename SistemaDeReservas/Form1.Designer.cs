namespace SistemaDeReservas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer = new SplitContainer();
            panelMenu = new Panel();
            groupBoxMenu = new GroupBox();
            btnSalir = new Button();
            btnVerReservas = new Button();
            btnReservar = new Button();
            btnHamburguesa = new Button();
            tabControlCentral = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            panelMenu.SuspendLayout();
            groupBoxMenu.SuspendLayout();
            tabControlCentral.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer
            // 
            splitContainer.Dock = DockStyle.Top;
            splitContainer.Location = new Point(0, 0);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.Controls.Add(panelMenu);
            splitContainer.Panel1.Controls.Add(btnHamburguesa);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(tabControlCentral);
            splitContainer.Size = new Size(800, 450);
            splitContainer.SplitterDistance = 200;
            splitContainer.TabIndex = 4;
            // 
            // panelMenu
            // 
            panelMenu.Controls.Add(groupBoxMenu);
            panelMenu.Dock = DockStyle.Top;
            panelMenu.Location = new Point(0, 30);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(200, 420);
            panelMenu.TabIndex = 2;
            panelMenu.Visible = false;
            // 
            // groupBoxMenu
            // 
            groupBoxMenu.Controls.Add(btnSalir);
            groupBoxMenu.Controls.Add(btnVerReservas);
            groupBoxMenu.Controls.Add(btnReservar);
            groupBoxMenu.Dock = DockStyle.Top;
            groupBoxMenu.Location = new Point(0, 0);
            groupBoxMenu.Name = "groupBoxMenu";
            groupBoxMenu.Size = new Size(200, 133);
            groupBoxMenu.TabIndex = 2;
            groupBoxMenu.TabStop = false;
            groupBoxMenu.Text = "Menú de Reservas";
            // 
            // btnSalir
            // 
            btnSalir.Dock = DockStyle.Top;
            btnSalir.Location = new Point(3, 81);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(194, 29);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnVerReservas
            // 
            btnVerReservas.Dock = DockStyle.Top;
            btnVerReservas.Location = new Point(3, 52);
            btnVerReservas.Name = "btnVerReservas";
            btnVerReservas.Size = new Size(194, 29);
            btnVerReservas.TabIndex = 1;
            btnVerReservas.Text = "Ver Reservas";
            btnVerReservas.UseVisualStyleBackColor = true;
            btnVerReservas.Click += btnVerReservas_Click;
            // 
            // btnReservar
            // 
            btnReservar.Dock = DockStyle.Top;
            btnReservar.Location = new Point(3, 23);
            btnReservar.Name = "btnReservar";
            btnReservar.Size = new Size(194, 29);
            btnReservar.TabIndex = 0;
            btnReservar.Text = "Reservar";
            btnReservar.UseVisualStyleBackColor = true;
            btnReservar.Click += btnReservar_Click;
            // 
            // btnHamburguesa
            // 
            btnHamburguesa.Dock = DockStyle.Top;
            btnHamburguesa.Location = new Point(0, 0);
            btnHamburguesa.Name = "btnHamburguesa";
            btnHamburguesa.Size = new Size(200, 30);
            btnHamburguesa.TabIndex = 7;
            btnHamburguesa.Text = "≡";
            btnHamburguesa.UseVisualStyleBackColor = true;
            btnHamburguesa.Click += btnHamburguesa_Click;
            // 
            // tabControlCentral
            // 
            tabControlCentral.Controls.Add(tabPage1);
            tabControlCentral.Controls.Add(tabPage2);
            tabControlCentral.Dock = DockStyle.Fill;
            tabControlCentral.Location = new Point(0, 0);
            tabControlCentral.Name = "tabControlCentral";
            tabControlCentral.SelectedIndex = 0;
            tabControlCentral.Size = new Size(596, 450);
            tabControlCentral.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(588, 417);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Reservar";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(588, 417);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Ver Reservas";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 445);
            Controls.Add(splitContainer);
            Name = "Form1";
            Text = "Form1";
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            panelMenu.ResumeLayout(false);
            groupBoxMenu.ResumeLayout(false);
            tabControlCentral.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer;
        private Panel panelMenu;
        private GroupBox groupBoxMenu;
        private Button btnSalir;
        private Button btnVerReservas;
        private Button btnReservar;
        private TabControl tabControlCentral;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnHamburguesa;
    }
}
