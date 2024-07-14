using System.Data;
using System.Data.SqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
///header file

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //connection string
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\acer\Documents\stock manager.mdf"";Integrated Security=True;Connect Timeout=30");

        private void Form2_Load(object sender, EventArgs e)
        {
            displayData();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            DialogResult result = MessageBox.Show("Are you wish to proceed this insertion?", "Insert Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //Console.WriteLine(result);

            if (result == DialogResult.Yes)
            {
                // Execute function for "Yes" click


                try
                {
                    CloseConection();
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into itemdetails values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data successfully inserted", "insert data");
                    con.Close();
                    displayData();
                }

                catch
                {
                    MessageBox.Show(textBox1.Text + "is already in table.process terminated", "insert data-duplicate Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }





            }
            else  //if (result == DialogResult.No)/thama wada naa delete button hadanacan inna
            {
                // Execute function for "No" click
                MessageBox.Show("cancelled", "insert data");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you wish to proceed this Deletion?", "Delete Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //Console.WriteLine(result);


            if (result == DialogResult.Yes)
            {
                try
                {
                    // Execute function for "Yes" click
                    CloseConection();
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "delete from itemdetails where itemid='" + textBox1.Text + "' ";
                    cmd.ExecuteNonQuery();

                    con.Close();

                    displayData();

                    MessageBox.Show("Data successfully deleted", "Delete data");
                }

                catch
                {
                    MessageBox.Show(textBox1.Text + "is not in table.process terminated", "delete data-notfound Error");
                }


            }
            else  //if (result == DialogResult.No)/thama wada naa delete button hadanacan inna
            {
                // Execute function for "No" click
                MessageBox.Show("cancelled", "Delete data");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you wish to proceed this Uptade?", "update Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //Console.WriteLine(result);


            if (result == DialogResult.Yes)
            {
                // Execute function for "Yes" click
                CloseConection();
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                String iid = textBox1.Text;
                cmd.CommandText = "update itemdetails set itemname='" + textBox2.Text + "', stockavailable='" + textBox3.Text + "', currentprice='" + textBox4.Text + "',  manufacturer='" + textBox5.Text + "', manufacturerEmail='" + textBox6.Text + "' where itemid= '" + iid + "'";
                cmd.ExecuteNonQuery();

                con.Close();

                displayData();

                MessageBox.Show("Data successfully updated", "Update data");


            }
            else  //if (result == DialogResult.No)/thama wada naa delete button hadanacan inna
            {
                // Execute function for "No" click
                MessageBox.Show("cancelled", "Update data");
            }

        }

        public void displayData()
        {
            CloseConection();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from itemdetails";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

            ClearTextbox();
        }

        public void CloseConection()
        {
            if (con != null)
            {
                con.Close();
            }
        }

        public void ClearTextbox()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 thirdform = new Form3();
            thirdform.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
