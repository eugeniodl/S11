// Clase adicional para solicitar input al usuario en un cuadro de diálogo
public static class Prompt
{
    public static string ShowDialog(string texto, string titulo, string valorInicial = "")
    {
        Form prompt = new Form()
        {
            Width = 400,
            Height = 150,
            FormBorderStyle = FormBorderStyle.FixedDialog,
            Text = titulo,
            StartPosition = FormStartPosition.CenterScreen
        };

        Label textoLabel = new Label() { Left = 20, Top = 20, Text = texto, Width = 350 };
        TextBox inputBox = new TextBox() { Left = 20, Top = 50, Width = 350, Text = valorInicial };
        Button confirmation = new Button() { Text = "Aceptar", Left = 250, Width = 120, Top = 80, DialogResult = DialogResult.OK };

        confirmation.Click += (sender, e) => { prompt.Close(); };
        prompt.Controls.Add(textoLabel);
        prompt.Controls.Add(inputBox);
        prompt.Controls.Add(confirmation);
        prompt.AcceptButton = confirmation;

        return prompt.ShowDialog() == DialogResult.OK ? inputBox.Text : "";
    }
}