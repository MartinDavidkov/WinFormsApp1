using System.Net.Mail;
using System.Data.SqlClient;
using Microsoft.VisualBasic.Logging;
using System.Diagnostics.Metrics;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private SqlCommand cmd;
        private SqlConnection cn;
        private SqlDataReader dr;
        public Form1()
        {
            InitializeComponent();
        }
        private void username_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (username.Text.Length < 5)
            {
                MessageBox.Show("Username should be at least 5 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                username.Focus();
                e.Cancel = true;
            }

        }

        private void password_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!(password.Text.Length > 8 && password.Text.Any(char.IsUpper) && password.Text.Any(char.IsLower) && password.Text.Any(char.IsDigit)))
            {
                MessageBox.Show("One or more password criteria(s) hasn't been met", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                password.SelectAll();
                e.Cancel = true;
            }
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            length.Show();
            capital.Show();
            lowercase.Show();
            number.Show();

            if (password.Text.Length > 8)
                length.ForeColor = Color.Green;
            else
                length.ForeColor = Color.Red;

            if (password.Text.Any(char.IsUpper))
                capital.ForeColor = Color.Green;
            else
                capital.ForeColor = Color.Red;

            if (password.Text.Any(char.IsLower))
                lowercase.ForeColor = Color.Green;
            else
                lowercase.ForeColor = Color.Red;

            if (password.Text.Any(char.IsDigit))
                number.ForeColor = Color.Green;
            else
                number.ForeColor = Color.Red;
        }

        private void email_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (email.Text != string.Empty)
            {
                if (!IsValidEmail(email.Text))
                {
                    MessageBox.Show("email not valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    email.SelectAll();
                    e.Cancel = true;
                }
            }
        }

        public static bool IsValidEmail(string email)
        {
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            if (string.IsNullOrEmpty(email))
                return false;

            Regex regex = new Regex(emailPattern);
            return regex.IsMatch(email);
        }

        public static bool IsValidPhone(string phone)
        {
            string phonePattern = @"^[\+]?[(]?[0-9]{3}[)]?[-\s\.]?[0-9]{3}[-\s\.]?[0-9]{4,6}$";

            if (string.IsNullOrEmpty(phone))
                return false;

            Regex regex = new Regex(phonePattern);
            return regex.IsMatch(phone);
        }
        private void phone_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (phone.Text != string.Empty)
            {
                if (!IsValidPhone(phone.Text))
                {
                    MessageBox.Show("phone not valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    email.SelectAll();
                    e.Cancel = true;
                }
            }
        }

        private void bday_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            int age = DateTime.Now.Year - bday.Value.Year - (DateTime.Now.DayOfYear > bday.Value.DayOfYear ? 1 : 0);

            if (age < 18)
            {
                MessageBox.Show("Not old enough", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                phone.SelectAll();
                e.Cancel = true;
            }
        }

        // Button click event for user registration
        private void button1_Click(object sender, EventArgs e)
        {
            // Connecting to the database
            using (cn = new SqlConnection(@"Data Source=LAB109PC21\SQLEXPRESS; Initial Catalog=userRecords; Integrated Security=True;"))
            {
                cn.Open();

                // Checking if the username already exists
                using (cmd = new SqlCommand("SELECT username FROM UserInfo WHERE username = @username", cn))
                {
                    cmd.Parameters.AddWithValue("@username", username.Text);
                    dr = cmd.ExecuteReader();
                    {
                        if (dr.Read())
                        {
                            MessageBox.Show("Username already exists, please try another", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            dr.Close();

                            // Inserting user information into the database
                            using (cmd = new SqlCommand("INSERT INTO UserInfo (username, password, email, bday, gender, phone_number, img) VALUES (@username, @password, @email, @bday, @gender, @phone_number, NULLIF(CONVERT(varbinary(max), @img), ''))", cn))
                            {
                                cmd.Parameters.AddWithValue("@username", username.Text);
                                cmd.Parameters.AddWithValue("@email", email.Text);
                                cmd.Parameters.AddWithValue("@password", password.Text);
                                cmd.Parameters.AddWithValue("@bday", bday.Value);
                                cmd.Parameters.AddWithValue("@gender", gender.Text);
                                cmd.Parameters.AddWithValue("@phone_number", phone.Text);
                                cmd.Parameters.AddWithValue("@img", "");

                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Your Account is created. Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Hide();
                                Form2 login = new Form2();
                                login.Show();
                            }
                        }
                    }
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 login = new Form2();
            login.Show();
        }

    }
}