using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        //connection string
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\acer\Documents\stock manager.mdf"";Integrated Security=True;Connect Timeout=30");


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void displayData()
        {
            CloseConection();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select stockavailable,itemname,manufacturer from itemdetails  where stockavailable<200";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();


        }

        public void CloseConection()
        {
            if (con != null)
            {
                con.Close();
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            displayData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 thirdform = new Form3();
            thirdform.Show();
        }
    }

}
