using Microsoft.VisualBasic.Logging;
using Npgsql;
using System.Data;
using System.IO;
using System.Xml.Linq;

namespace LibraryManagementSystem
{
    public partial class Login_Register_Form : Form
    {
        public static string UserName { get; set; }
        public static string UserSurname { get; set; }

        public Login_Register_Form()
        {
            InitializeComponent();
            // Set to no text.
            password.Text = "";

            // The control will allow no more than 14 characters.
            password.MaxLength = 14;
            loginTextBoxun.MaxLength = 15;

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelLogin.BringToFront();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void btn_ViewRegisterPage_Click(object sender, EventArgs e)
        {
            panelRegister.BringToFront();
        }

        private void btn_ViewLoginPage_Click(object sender, EventArgs e)
        {
            panelLogin.BringToFront();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string username = loginTextBoxun.Text;
            string password = this.password.Text;
            if (username == "" || password == "")
            {
                MessageBox.Show("Please Provide Password and Username.");
                return;
            }

            using (NpgsqlConnection conn2 = new NpgsqlConnection("Server=localhost;Port=5432;Database=Library;User Id=postgres;Password=1234;"))
            {
                conn2.Open();
                string selectQuery = "SELECT COUNT(*), mode, firstname, secondname FROM users WHERE username = @username AND password = @password GROUP BY mode, firstname, secondname";
                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery, conn2))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        int count = 0;
                        int mode = 0;
                        string firstname = "";
                        string secondname = "";

                        if (reader.Read())
                        {
                            count = reader.GetInt32(0);
                            mode = reader.GetInt32(1);
                            firstname = reader.GetString(2);
                            secondname = reader.GetString(3);

                            UserName = firstname;
                            UserSurname = secondname;
                        }
                        Console.WriteLine("NAme: " + firstname + " - " + secondname + ".");

                        if (count > 0)
                        {
                            // Set the user's role based on the 'mode' column value
                            string role = "";
                            switch (mode)
                            {
                                case 0:
                                    role = "admin";
                                    MessageBox.Show($"Login successful as {role}.");
                                    LoadAdminPage();
                                    break;
                                case 1:
                                    role = "student";
                                    MessageBox.Show($"Login successful as {role}.");
                                    LoadStudentPage();
                                    break;
                                case 2:
                                    role = "teacher";
                                    MessageBox.Show($"Login successful as {role}.");
                                    LoadStudentPage();
                                    break;
                            }

                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.");
                        }
                    }
                }
            }
        }

        public void LoadAdminPage()
        {
            this.Hide();
            Admin_Panel_Form admin_Panel_Form = new Admin_Panel_Form();
            admin_Panel_Form.ShowDialog();
        }
        public void LoadStudentPage()
        {
            this.Hide();
            Application_Form Student_Panel_Form = new Application_Form();
            Student_Panel_Form.ShowDialog();
        }
        private void btn_register_Click(object sender, EventArgs e)
        {

            try
            {
                using (NpgsqlConnection conn2 = new NpgsqlConnection("Server=localhost;Port=5432;Database=Library;User Id=postgres;Password=1234;"))
                {
                    conn2.Open();
                    string username = textBoxun.Text;

                    string selectQuery = "SELECT COUNT(*) FROM public.users WHERE username = @username";
                    using (NpgsqlCommand command = new NpgsqlCommand(selectQuery, conn2))
                    {
                        command.Parameters.AddWithValue("@username", username);

                        var count = command.ExecuteScalar();
                        if (count != null)
                        {
                            int rowCount = Convert.ToInt32(count);
                            //MessageBox.Show($"Count: {rowCount}");
                            if (rowCount > 0)
                            {
                                // Username exists in the database
                                // Perform your desired action here
                                MessageBox.Show("This User exists.");
                            }
                            else
                            {
                                // Username does not exist in the database
                                // Perform your desired action here
                                //MessageBox.Show("This User does not exist.");
                                if (textBoxfn.Text.Equals("") ||
                                    textBoxln.Text.Equals("") ||
                                    textBoxun.Text.Equals("") ||
                                    textBoxpw.Text.Equals(""))
                                {
                                    MessageBox.Show("Please fill all the info.");
                                }
                                else if (textBoxpw.Text.Length <= 10)
                                {
                                    MessageBox.Show("Please use longer password.");
                                }
                                else
                                {

                                    // User does not exist in the database, add the new user
                                    string insertQuery = "INSERT INTO public.users (username, firstname, secondname, password) " +
                                        "VALUES (@username, @firstname, @secondname, @password)";

                                    using (NpgsqlCommand insertCommand = new NpgsqlCommand(insertQuery, conn2))
                                    {
                                        // Set the parameter values for the new user
                                        insertCommand.Parameters.AddWithValue("@username", textBoxun.Text);
                                        insertCommand.Parameters.AddWithValue("@firstname", textBoxfn.Text);
                                        insertCommand.Parameters.AddWithValue("@secondname", textBoxln.Text);
                                        insertCommand.Parameters.AddWithValue("@password", textBoxpw.Text);

                                        // Execute the insert query
                                        int rowsAffected = insertCommand.ExecuteNonQuery();

                                        if (rowsAffected > 0)
                                        {
                                            MessageBox.Show("User added successfully.");
                                            textBoxfn.Text = "";
                                            textBoxln.Text = "";
                                            textBoxun.Text = "";
                                            textBoxpw.Text = "";
                                        }
                                        else
                                        {
                                            MessageBox.Show("Failed to add user.");
                                        }
                                    }
                                }


                            }
                        }
                        else
                        {
                            MessageBox.Show("No users found.");
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }





        }

        private void loginTextBoxun_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginTextBoxpw_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelRegister_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}