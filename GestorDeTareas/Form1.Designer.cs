namespace GestorDeTareas
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            archivoMenu = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            tareasMenu = new ToolStripMenuItem();
            agregarTareaToolStripMenuItem = new ToolStripMenuItem();
            editarTareaToolStripMenuItem = new ToolStripMenuItem();
            eliminarTareaToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            contextMenuStrip1 = new ContextMenuStrip(components);
            agregarTareaToolStripMenuItem1 = new ToolStripMenuItem();
            editarTareaToolStripMenuItem1 = new ToolStripMenuItem();
            eliminarTareaToolStripMenuItem1 = new ToolStripMenuItem();
            listBox1 = new ListBox();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoMenu, tareasMenu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoMenu
            // 
            archivoMenu.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            archivoMenu.Name = "archivoMenu";
            archivoMenu.Size = new Size(73, 24);
            archivoMenu.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(121, 26);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += Salir;
            // 
            // tareasMenu
            // 
            tareasMenu.DropDownItems.AddRange(new ToolStripItem[] { agregarTareaToolStripMenuItem, editarTareaToolStripMenuItem, eliminarTareaToolStripMenuItem });
            tareasMenu.Name = "tareasMenu";
            tareasMenu.Size = new Size(64, 24);
            tareasMenu.Text = "Tareas";
            // 
            // agregarTareaToolStripMenuItem
            // 
            agregarTareaToolStripMenuItem.Name = "agregarTareaToolStripMenuItem";
            agregarTareaToolStripMenuItem.Size = new Size(185, 26);
            agregarTareaToolStripMenuItem.Text = "Agregar Tarea";
            agregarTareaToolStripMenuItem.Click += AgregarTarea;
            // 
            // editarTareaToolStripMenuItem
            // 
            editarTareaToolStripMenuItem.Name = "editarTareaToolStripMenuItem";
            editarTareaToolStripMenuItem.Size = new Size(185, 26);
            editarTareaToolStripMenuItem.Text = "Editar Tarea";
            editarTareaToolStripMenuItem.Click += EditarTarea;
            // 
            // eliminarTareaToolStripMenuItem
            // 
            eliminarTareaToolStripMenuItem.Name = "eliminarTareaToolStripMenuItem";
            eliminarTareaToolStripMenuItem.Size = new Size(185, 26);
            eliminarTareaToolStripMenuItem.Text = "Eliminar Tarea";
            eliminarTareaToolStripMenuItem.Click += EliminarTarea;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
            statusStrip1.Location = new Point(0, 424);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 26);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(151, 20);
            toolStripStatusLabel.Text = "toolStripStatusLabel1";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3 });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 27);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(29, 24);
            toolStripButton1.Text = "Agregar";
            toolStripButton1.Click += AgregarTarea;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(29, 24);
            toolStripButton2.Text = "Editar";
            toolStripButton2.Click += EditarTarea;
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(29, 24);
            toolStripButton3.Text = "Eliminar";
            toolStripButton3.Click += EliminarTarea;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { agregarTareaToolStripMenuItem1, editarTareaToolStripMenuItem1, eliminarTareaToolStripMenuItem1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(172, 76);
            // 
            // agregarTareaToolStripMenuItem1
            // 
            agregarTareaToolStripMenuItem1.Name = "agregarTareaToolStripMenuItem1";
            agregarTareaToolStripMenuItem1.Size = new Size(171, 24);
            agregarTareaToolStripMenuItem1.Text = "Agregar Tarea";
            // 
            // editarTareaToolStripMenuItem1
            // 
            editarTareaToolStripMenuItem1.Name = "editarTareaToolStripMenuItem1";
            editarTareaToolStripMenuItem1.Size = new Size(171, 24);
            editarTareaToolStripMenuItem1.Text = "Editar Tarea";
            // 
            // eliminarTareaToolStripMenuItem1
            // 
            eliminarTareaToolStripMenuItem1.Name = "eliminarTareaToolStripMenuItem1";
            eliminarTareaToolStripMenuItem1.Size = new Size(171, 24);
            eliminarTareaToolStripMenuItem1.Text = "Eliminar Tarea";
            // 
            // listBox1
            // 
            listBox1.ContextMenuStrip = contextMenuStrip1;
            listBox1.Dock = DockStyle.Fill;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(0, 55);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(800, 369);
            listBox1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private StatusStrip statusStrip1;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripMenuItem archivoMenu;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem tareasMenu;
        private ToolStripMenuItem agregarTareaToolStripMenuItem;
        private ToolStripMenuItem editarTareaToolStripMenuItem;
        private ToolStripMenuItem eliminarTareaToolStripMenuItem;
        private ToolStripStatusLabel toolStripStatusLabel;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem agregarTareaToolStripMenuItem1;
        private ToolStripMenuItem editarTareaToolStripMenuItem1;
        private ToolStripMenuItem eliminarTareaToolStripMenuItem1;
        private ListBox listBox1;
    }
}
