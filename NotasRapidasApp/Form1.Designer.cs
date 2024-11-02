namespace NotasRapidasApp
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
            btnGuardar = new Button();
            btnLimpiar = new Button();
            txtNota = new TextBox();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnGuardar.Location = new Point(99, 413);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(172, 42);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            toolTip1.SetToolTip(btnGuardar, "Guardar (Ctrl+S)\r\n");
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += GuardarNota;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLimpiar.Location = new Point(505, 413);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(172, 42);
            btnLimpiar.TabIndex = 1;
            btnLimpiar.Text = "Limpiar";
            toolTip1.SetToolTip(btnLimpiar, "Limpiar (Ctrl+L)\r\n");
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += LimpiarNota;
            // 
            // txtNota
            // 
            txtNota.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtNota.Location = new Point(46, 56);
            txtNota.Multiline = true;
            txtNota.Name = "txtNota";
            txtNota.Size = new Size(695, 323);
            txtNota.TabIndex = 2;
            txtNota.DoubleClick += DestacarNota;
            txtNota.MouseDown += IniciarArrastre;
            txtNota.MouseMove += ArrastrarControl;
            txtNota.MouseUp += txtNota_MouseUp;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 505);
            Controls.Add(txtNota);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            KeyPreview = true;
            Name = "Form1";
            Text = "NotasRapidasApp";
            toolTip1.SetToolTip(this, "Cerrar (Ctrl+Q)");
            KeyDown += AtajosDeTeclado;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private Button btnLimpiar;
        private TextBox txtNota;
        private ToolTip toolTip1;
    }
}
