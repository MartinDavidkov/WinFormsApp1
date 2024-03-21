using System;  // Importing the System namespace
using System.Collections.Generic;  // Importing namespaces for various functionalities
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WinFormsApp1.authenticate;  // Importing static members from the authenticate class
using static WinFormsApp1.imageUploader;  // Importing static members from the imageUploader class
using WinFormsApp1;
using System.Diagnostics;



namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        private User authenticatedUser;
        public Form3(User user)
        {
            InitializeComponent();
            authenticatedUser = user;
            welcome.Text = $"Welcome, {authenticatedUser.Username}!";
            email.Text = $"This is your email: {authenticatedUser.email}!";
            phone.Text = $"This is your phone number: {authenticatedUser.phone_number}!";


            if (user.Image != null && user.Image.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(user.Image))
                {
                    pictureBox1.Image = Image.FromStream(ms);
                }
            }
        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();  // Creating an OpenFileDialog instance

            // Setting the filter for the file dialog to allow only specific image file types
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp|All files (*.*)|*.*";

            // Checking if the user selected a file and clicked the OK button
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string selectedImagePath = openFileDialog.FileName;  // Getting the path of the selected image
                    Image selectedImage = Image.FromFile(selectedImagePath);  // Creating an Image object from the selected file

                    byte[] imageData = ImageToByteArray(selectedImage);  // Converting the image to a byte array

                    // Updating the user's image in the database
                    UploadImage(authenticatedUser.Username, imageData);

                    // Displaying the uploaded image on the form
                    pictureBox1.Image = selectedImage;

                    // Hiding the upload button since the user now has an image
                    uploadBtn.Hide();
                }
                catch (Exception ex)
                {
                    // Displaying an error message if an exception occurs during image upload
                    MessageBox.Show($"Error uploading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void enter_Click(object sender, EventArgs e)
        {
            this.Hide();
            check checkForm = new check();
            checkForm.Show();
        }
    }
}
