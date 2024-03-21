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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class reservations : Form
    {
        public reservations()
        {
            InitializeComponent();
        }

        private void reservations_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC21\SQLEXPRESS; Initial Catalog=Restaurant; Integrated Security=True;"))
            {
                sqlCon.Open(); // Open SQL connection

                // Start with a base SQL query
                string query = "SELECT * FROM reservation";

                SqlCommand cmd = new SqlCommand(query, sqlCon);

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables.Count > 0 ? ds.Tables[0] : null;
                }
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a note to delete.");
                return;
            }

            int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
            int tableID = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells["TableID"].Value);

            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC21\SQLEXPRESS; Initial Catalog=Restaurant; Integrated Security=True; Encrypt=False;"))
            {
                try
                {
                    sqlCon.Open();
                    string query = "DELETE FROM reservation WHERE TableID = @TableID";
                    SqlCommand command = new SqlCommand(query, sqlCon);
                    command.Parameters.AddWithValue("@TableID", tableID);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Reservation deleted successfully.");
                        //search_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete reservation.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                reservations_Load(sender, e);

                string updateAvailabilityQuery = "UPDATE restaurant_table1 SET Availability = 'available' WHERE TableID = @TableID";
                SqlCommand updateAvailabilityCmd = new SqlCommand(updateAvailabilityQuery, sqlCon);
                updateAvailabilityCmd.Parameters.AddWithValue("@TableID", tableID);
                updateAvailabilityCmd.ExecuteNonQuery();
            }
        }
    }
}
