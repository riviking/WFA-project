namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 secondForm = new Form2();
            secondForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "abc123")
            {
                this.Hide();
                Form3 thirdform = new Form3();
                thirdform.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username Or Password!.Try again", "invalid credentials", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            { 
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }
    }
}