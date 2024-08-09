namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox4.Text);
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);

            Random rnd = new Random();

            int[] arrayB = new int[n];
            for (int i = 0; i < n; i++)
            {
                arrayB[i] = rnd.Next(a, b + 1);
            }

            label6.Text = string.Join(Environment.NewLine, arrayB.Select(x => x.ToString()));

            int[] counts = new int[n];
            int intervalSize = (b - a) / n;

            for (int i = 0; i < n; i++)
            {
                foreach (int value in arrayB)
                {
                    counts[i] += (value >= a + i * intervalSize && value < a + (i + 1) * intervalSize) ? 1 : 0;
                }
            }

            listBox1.Items.Clear();
            for (int i = 0; i < counts.Length; i++)
            {
                listBox1.Items.Add($"Отрезок {i + 1}: {counts[i]} элемент(а/ов)");
            }
        }
    }
}