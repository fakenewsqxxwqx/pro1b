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
            num = 10;//限定题目为10道
            label2.Text = num.ToString();
            string s = (num * 10).ToString() + "seconds";
            label4.Text = s;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2(score, num);
            this.Hide();
            form2.ShowDialog();
            this.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}