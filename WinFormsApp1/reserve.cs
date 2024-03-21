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
    public partial class reserve : Form
    {
        public reserve()
        {
            InitializeComponent();
        }

        private void reserve1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC21\SQLEXPRESS; Initial Catalog=Restaurant; Integrated Security=True;"))
            {
                sqlCon.Open(); // Open SQL connection

                // Check if the table is available
                string availabilityQuery = "SELECT Availability FROM restaurant_table1 WHERE TableID = @TableID";

                SqlCommand availabilityCmd = new SqlCommand(availabilityQuery, sqlCon);
                availabilityCmd.Parameters.AddWithValue("@TableID", tableID.Text);
                string availabilityResult = availabilityCmd.ExecuteScalar().ToString().Trim();

                if (availabilityResult.Equals("Available", StringComparison.OrdinalIgnoreCase))
                {
                    // Table is available, proceed with booking
                    string insertQuery = "INSERT INTO reservation VALUES (@Name, @Phone, @TableID)";
                    SqlCommand insertCmd = new SqlCommand(insertQuery, sqlCon);

                    // Set parameters based on selected values
                    insertCmd.Parameters.AddWithValue("@Phone", phone.Text);
                    insertCmd.Parameters.AddWithValue("@Name", name.Text);
                    insertCmd.Parameters.AddWithValue("@TableID", tableID.Text);

                    insertCmd.ExecuteNonQuery();

                    // Update table availability status
                    string updateAvailabilityQuery = "UPDATE restaurant_table1 SET Availability = 'not available' WHERE TableID = @TableID";
                    SqlCommand updateAvailabilityCmd = new SqlCommand(updateAvailabilityQuery, sqlCon);
                    updateAvailabilityCmd.Parameters.AddWithValue("@Phone", phone.Text);
                    updateAvailabilityCmd.Parameters.AddWithValue("@TableID", tableID.Text);
                    updateAvailabilityCmd.ExecuteNonQuery();

                    MessageBox.Show("Booking Successful!");
                }
                else
                {
                    // Table is not available
                    MessageBox.Show("Sorry, the table is not available for booking.");
                }
            }
        }
    }
}
