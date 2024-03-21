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
    public partial class check : Form
    {
        public check()
        {
            InitializeComponent();
        }

        private void check_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC21\SQLEXPRESS; Initial Catalog=Restaurant; Integrated Security=True;"))
            {
                sqlCon.Open(); // Open SQL connection

                // Start with a base SQL query
                string query = "SELECT * FROM restaurant_table1 WHERE 1 = 1";

                // Create a list to store the conditions for filtering
                List<string> conditions = new List<string>();

                // Check each ComboBox and add a condition if an item is selected
                if (comboBox1.SelectedItem != null)
                    conditions.Add("availability = @status");

                if (comboBox2.SelectedItem != null)
                    conditions.Add("position = @tableType");

                if (comboBox3.SelectedItem != null)
                    conditions.Add("places = @tableAvailability");

                if (comboBox4.SelectedItem != null)
                    conditions.Add("kids = @kids");

                // combine the conditions into the SQL query
                if (conditions.Count > 0)
                {
                    query += " AND " + string.Join(" AND ", conditions);
                }

                SqlCommand cmd = new SqlCommand(query, sqlCon);

                // Set parameters based on selected values
                if (comboBox1.SelectedItem != null)
                    cmd.Parameters.AddWithValue("@status", comboBox1.SelectedItem.ToString());
                if (comboBox2.SelectedItem != null)
                    cmd.Parameters.AddWithValue("@tableType", comboBox2.SelectedItem.ToString());
                if (comboBox3.SelectedItem != null)
                    cmd.Parameters.AddWithValue("@tableAvailability", comboBox3.SelectedItem.ToString());
                if (comboBox4.SelectedItem != null)
                    cmd.Parameters.AddWithValue("@kids", comboBox4.SelectedItem.ToString());

                // Use SqlDataAdapter to fetch data and populate DataGridView
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables.Count > 0 ? ds.Tables[0] : null;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
        }

        private void reserve_Click(object sender, EventArgs e)
        {
            using (reserve userInputForm = new reserve())
            {
                userInputForm.ShowDialog();
            }
        }

        private void seeReservations_Click(object sender, EventArgs e)
        {
            using (reservations userInputForm = new reservations())
            {
                userInputForm.ShowDialog();
            }
        }
    }
}
