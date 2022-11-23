namespace WinFormsowaTabliczkaMnozenia
{
    public partial class Form1 : Form
    {
        private readonly Random losowacz = new();
        private DateTime testStart;
        private DateTime testEnd;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResetujFormularz();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            ResetujFormularz();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            testEnd = DateTime.Now;
            time.Text = $"Twój czas to: {Convert.ToInt32((testEnd - testStart).TotalSeconds).ToString()} sekundy!";

            var wynik = 0;
            
            var textBoxes = new List<TextBox> {
                textBoxA1,
                textBoxA2,
                textBoxA3,
                textBoxA4,
                textBoxB1,
                textBoxB2,
                textBoxB3,
                textBoxB4,
                textBoxC1,
                textBoxC2,
                textBoxC3,
                textBoxC4,
                textBoxD1,
                textBoxD2,
                textBoxD3,
                textBoxD4
            };

            foreach (var textBox in textBoxes)
            {
                var czyPoprawnyWynikDzialania = SprawdzWynikDzialania(textBox);
                if (czyPoprawnyWynikDzialania)
                    wynik++;
            }

            score.Text = "Twój wynik to: " + wynik + " poprawnych odpowiedzi.";
        }

        private void timerStart_Click(object sender, EventArgs e)
        {
            testStart = DateTime.Now;
        }

        private void timerStop_Click(object sender, EventArgs e)
        {
            
        }

        private void ResetujFormularz()
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

            textBoxA1.BackColor = Color.White;
            textBoxA2.BackColor = Color.White;
            textBoxA3.BackColor = Color.White;
            textBoxA4.BackColor = Color.White;
            textBoxB1.BackColor = Color.White;
            textBoxB2.BackColor = Color.White;
            textBoxB3.BackColor = Color.White;
            textBoxB4.BackColor = Color.White;
            textBoxC1.BackColor = Color.White;
            textBoxC2.BackColor = Color.White;
            textBoxC3.BackColor = Color.White;
            textBoxC4.BackColor = Color.White;
            textBoxD1.BackColor = Color.White;
            textBoxD2.BackColor = Color.White;
            textBoxD3.BackColor = Color.White;
            textBoxD4.BackColor = Color.White;

            time.Text = "";
            score.Text = "";

            testStart = DateTime.Now;
        }

        private string WylosujLiczbe()
        {
            return losowacz.Next(3, 11).ToString();
        }

        private bool SprawdzWynikDzialania(TextBox textBox)
        {
            var name = textBox.Name;
            var columnName = name.Substring(name.Length - 2, 1);
            var rowName = name.Substring(name.Length - 1, 1);

            var labels = new List<Label> { label1, label2, label3, label4, labelA, labelB, labelC, labelD };

            var labelCol = labels.Where(l => l.Name == "label" + columnName).First();
            var labelRow = labels.Where(l => l.Name == "label" + rowName).First();

            var a = int.Parse(labelCol.Text);
            var b = int.Parse(labelRow.Text);

            if (!(a * b == int.Parse(textBox.Text)))
            {
                textBox.BackColor = Color.Red;
                return false;
            }

            return true;
        }

        private void score_Click(object sender, EventArgs e)
        {

        }
    }
}