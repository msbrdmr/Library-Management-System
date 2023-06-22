using Npgsql;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LibraryManagementSystem
{
    public partial class Application_Form : Form
    {
        public Application_Form()
        {
            InitializeComponent();
            FetchBooksDB();
            if (!string.IsNullOrEmpty(Login_Register_Form.UserName))
            {
                labelName.Text = "Welcome " + Login_Register_Form.UserName + "!";
            }
            else
            {
                // Set a default text if Login_Register_Form.UserName is null or empty
                labelName.Text = "Welcome!";
            }

        }

        private void Application_Form_Load(object sender, EventArgs e)
        {
            // Check if Login_Register_Form.UserName is not null or empty before setting the label text
            
        }

        public void FetchBooksDB()
        {
            NpgsqlConnection conn4 = new NpgsqlConnection("Server=localhost;Port=5432;Database=Library;User Id=postgres;Password=1234;");
            conn4.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn4;
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
            conn4.Close();
        }



        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Application_Form_Load_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = textBox2.Text.Trim().ToLower();

            // Clear the selection before performing the search
            dataGridView1.ClearSelection();

            // Iterate through each row in the DataGridView
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Iterate through each cell in the current row
                foreach (DataGridViewCell cell in row.Cells)
                {
                    // Check if the cell value contains the search term
                    if (cell.Value != null && cell.Value.ToString().ToLower().Contains(searchTerm))
                    {
                        // Select the entire row and scroll it into view
                        row.Selected = true;
                        dataGridView1.FirstDisplayedScrollingRowIndex = row.Index;
                        break;
                    }
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn4 = new NpgsqlConnection("Server=localhost;Port=5432;Database=Library;User Id=postgres;Password=1234;");
            conn4.Open();
            string name = Login_Register_Form.UserName;
            string surname = Login_Register_Form.UserSurname;

            if (textBox1.Text == "")
            {
                MessageBox.Show("Please provide a book ID.");
                return;
            }

            string bookId = textBox1.Text;

            // Check if the book exists in the library.books table
            string selectQuery = "SELECT howmuchofthat FROM books WHERE id = @bookId";
            using (NpgsqlCommand command = new NpgsqlCommand(selectQuery, conn4))
            {
                command.Parameters.AddWithValue("@bookId", int.Parse(bookId));
                object result = command.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    int howMuchOfThat = Convert.ToInt32(result);

                    if (howMuchOfThat > 0)
                    {
                        // Decrease the component count in the library.books table
                        string updateQuery = "UPDATE books SET howmuchofthat = howmuchofthat - 1 WHERE id = @bookId";
                        using (NpgsqlCommand updateCommand = new NpgsqlCommand(updateQuery, conn4))
                        {
                            updateCommand.Parameters.AddWithValue("@bookId", int.Parse(bookId));
                            updateCommand.ExecuteNonQuery();

                            // Generate borrowId using student's username and bookId
                            string borrowId = $"{name}{surname}_{bookId}";

                            // Get the book name from the library.books table
                            string selectBookNameQuery = "SELECT bookname FROM books WHERE id = @bookId";
                            using (NpgsqlCommand selectBookNameCommand = new NpgsqlCommand(selectBookNameQuery, conn4))
                            {
                                selectBookNameCommand.Parameters.AddWithValue("@bookId", int.Parse(bookId));
                                object bookNameResult = selectBookNameCommand.ExecuteScalar();

                                if (bookNameResult != null && bookNameResult != DBNull.Value)
                                {
                                    string bookName = bookNameResult.ToString();

                                    // Insert the borrowId, borrower name, and borrowed book name into the appropriate table
                                    string insertQuery = "INSERT INTO borrow_records (borrow_id, borrower_name, book_name) VALUES (@borrowId, @borrowerName, @bookName)";
                                    using (NpgsqlCommand insertCommand = new NpgsqlCommand(insertQuery, conn4))
                                    {
                                        insertCommand.Parameters.AddWithValue("@borrowId", borrowId);
                                        insertCommand.Parameters.AddWithValue("@borrowerName", $"{name} {surname}");
                                        insertCommand.Parameters.AddWithValue("@bookname", bookName);

                                        insertCommand.ExecuteNonQuery();

                                        MessageBox.Show("Book borrowed successfully.");
                                        FetchBooksDB();
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("This book is currently not available.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid book ID.");
                }
            }

            conn4.Close();
        }




        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("Please Provide Book Id.");
            }
        }
    }
}
