namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private int score;
        private int num;
        public Form1()
        {
            InitializeComponent();
            score = 0;
            Random random = new Random();
            num = random.Next(5, 11);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2(score,num);
            this.Hide();
            form2.ShowDialog();
            this.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}