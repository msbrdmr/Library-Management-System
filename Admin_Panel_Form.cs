using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class Admin_Panel_Form : Form
    {
        public Admin_Panel_Form()
        {
            InitializeComponent();


        }

        private void btn_fetch_Click(object sender, EventArgs e)
        {
            fetchUsers();
        }

        private void fetchUsers()
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=Library;User Id=postgres;Password=1234;");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from users";

            NpgsqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView1.DataSource = dt;
            }

            cmd.Dispose();
            conn.Close();
        }

        public void FetchBorrows()
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=Library;User Id=postgres;Password=1234;");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from borrow_records";

            NpgsqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView2.DataSource = dt;
            }

            cmd.Dispose();
            conn.Close();
        }

        public void fetchBooks()
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=Library;User Id=postgres;Password=1234;");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from public.books";

            NpgsqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView1.DataSource = dt;
            }

            cmd.Dispose();
            conn.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Panel_Form_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SettingForm form = new SettingForm();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FetchBorrows();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fetchBooks();
        }
    }
}
