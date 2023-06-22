using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LibraryManagementSystem
{
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(SettingForm_FormClosing);

        }



        private void button1_Click(object sender, EventArgs e)
        {
            setSetting("maxborrow", textBox1.Text);
        }
        public void setSetting(string SettingId, string newValue)
        {
            using (NpgsqlConnection conn2 = new NpgsqlConnection("Server=localhost;Port=5432;Database=Library;User Id=postgres;Password=1234;"))
            {
                conn2.Open();
                string updateQuery = "UPDATE settings SET value = @newValue WHERE name = @setting;";
                using (NpgsqlCommand command = new NpgsqlCommand(updateQuery, conn2))
                {
                    command.Parameters.AddWithValue("@newValue", newValue);
                    command.Parameters.AddWithValue("@setting", SettingId);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            setSetting("maxdue", textBox2.Text);
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {

        }


        private void SettingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Add your custom logic here
            // You can cancel the closing event by setting e.Cancel = true if needed
            Console.WriteLine("closed");
            this.Hide();
            Admin_Panel_Form admform = new Admin_Panel_Form();
            admform.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Add your custom logic here
            // You can cancel the closing event by setting e.Cancel = true if needed
            Console.WriteLine("closed");
            this.Hide();
            Admin_Panel_Form admform = new Admin_Panel_Form();
            admform.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "") MessageBox.Show("Provide a username.");
            SetUserRole(textBox3.Text, 2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "") MessageBox.Show("Provide a username.");
            SetUserRole(textBox3.Text, 1);
        }

        private void ShowUsersByMode(int mode)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=Library;User Id=postgres;Password=1234;"))
            {
                conn.Open();

                string selectQuery = "SELECT username, firstname, secondname FROM public.users WHERE mode = @mode";
                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery, conn))
                {
                    command.Parameters.AddWithValue("@mode", mode);

                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
        }

        private void SetUserRole(string username, int mode)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=Library;User Id=postgres;Password=1234;"))
            {
                conn.Open();

                string updateQuery = "UPDATE public.users SET mode = @mode WHERE username = @username";
                using (NpgsqlCommand command = new NpgsqlCommand(updateQuery, conn))
                {
                    command.Parameters.AddWithValue("@mode", mode);
                    command.Parameters.AddWithValue("@username", username);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User role updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("User not found.");
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ShowUsersByMode(2);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ShowUsersByMode(1);
        }
    }


}
