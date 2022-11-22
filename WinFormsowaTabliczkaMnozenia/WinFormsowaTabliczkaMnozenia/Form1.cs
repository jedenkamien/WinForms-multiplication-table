namespace WinFormsowaTabliczkaMnozenia
{
    public partial class Form1 : Form
    {
        private readonly Random losowacz = new();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            labelA.Text = WylosujLiczbe();
            labelB.Text = WylosujLiczbe();
            labelC.Text = WylosujLiczbe();
            labelD.Text = WylosujLiczbe();
            label1.Text = WylosujLiczbe();
            label2.Text = WylosujLiczbe();
            label3.Text = WylosujLiczbe();
            label4.Text = WylosujLiczbe();

            textBoxA1.Text = string.Empty;
            textBoxA2.Text = string.Empty;
            textBoxA3.Text = string.Empty;
            textBoxA4.Text = string.Empty;
            textBoxB1.Text = string.Empty;
            textBoxB2.Text = string.Empty;
            textBoxB3.Text = string.Empty;
            textBoxB4.Text = string.Empty;
            textBoxC1.Text = string.Empty;
            textBoxC2.Text = string.Empty;
            textBoxC3.Text = string.Empty;
            textBoxC4.Text = string.Empty;
            textBoxD1.Text = string.Empty;
            textBoxD2.Text = string.Empty;
            textBoxD3.Text = string.Empty;
            textBoxD4.Text = string.Empty;

            textBoxA1.BackColor = Color.Transparent;
            textBoxA2.BackColor = Color.Transparent;
            textBoxA3.BackColor = Color.Transparent;
            textBoxA4.BackColor = Color.Transparent;
            textBoxB1.BackColor = Color.Transparent;
            textBoxB2.BackColor = Color.Transparent;
            textBoxB3.BackColor = Color.Transparent;
            textBoxB4.BackColor = Color.Transparent;
            textBoxC1.BackColor = Color.Transparent;
            textBoxC2.BackColor = Color.Transparent;
            textBoxC3.BackColor = Color.Transparent;
            textBoxC4.BackColor = Color.Transparent;
            textBoxD1.BackColor = Color.Transparent;
            textBoxD2.BackColor = Color.Transparent;
            textBoxD3.BackColor = Color.Transparent;
            textBoxD4.BackColor = Color.Transparent;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private string WylosujLiczbe()
        {
            return losowacz.Next(10).ToString();
        }
    }
}