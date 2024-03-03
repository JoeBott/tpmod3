using Microsoft.VisualBasic;

namespace tpmod3
{
    public partial class Form1 : Form
    {
        private string InputText = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2_Click(sender, e);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            InputText = Interaction.InputBox("Enter text: ", "Input", InputText);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"User Input: {InputText} ", "Output");
        }
    }
}
