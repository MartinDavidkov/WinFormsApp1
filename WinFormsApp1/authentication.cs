using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1;

namespace WinFormsApp1
{
    // Authentication class
    public class authenticate
    {
        /* By having a dedicated User class, it becomes easier to extend and modify user-related properties 
        * or methods in the future without directly affecting the authentication logic. 
        * This modularity enhances code maintainability. */
        public class User
        {
            public string Username { get; set; } // User's username property
            public byte[] Image { get; set; } // User's image property (binary data)
            public string email { get; set; }
            public string phone_number  { get; set; }
            public DateTime bday { get; set; }
            public string gender { get; set; }

        }

        /* The DatabaseManager class is responsible for handling database operations, including user authentication. 
        * This is a good practice in software design, as it allows for better organization and maintainability. */
        public class DatabaseManager
        {
            // Method to authenticate user
            public static User AuthenticateUser(string username, string password)
            {
                User user = RetrieveUserInformation(username, password); // for encapsulation purposes, call the private retrieveUserInformation method.
                return user;
            }

            /*The RetrieveUserInformation method encapsulates the logic for querying the database and retrieving user information based on the provided username and password. 
            * This method is private, meaning it is intended to be used only within the DatabaseManager class. */
            private static User RetrieveUserInformation(string username, string password)
            {
                using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC21\SQLEXPRESS; Initial Catalog=userRecords; Integrated Security=True;"))
                {
                    sqlCon.Open(); // Open SQL connection

                    string loginQuery = "SELECT COUNT(1) FROM userInfo WHERE Username=@Username AND Password=@Password";
                    string imgQuery = "SELECT img FROM userInfo WHERE Username=@Username AND Password=@Password";
                    //string emailQuery = "SELECT email FROM userInfo WHERE Username=@Username AND Password=@Password";
                    //string phoneQuery = "SELECT phone_number FROM userInfo WHERE Username=@Username AND Password=@Password";
                    string query = "SELECT * FROM userInfo WHERE Username=@Username AND Password=@Password";

                    using (SqlCommand loginCmd = new SqlCommand(loginQuery, sqlCon))
                    {
                        using (SqlCommand queryCmd = new SqlCommand(query,sqlCon))
                        {
                            
                            
                                loginCmd.CommandType = CommandType.Text;
                                //imgCmd.CommandType = CommandType.Text;

                                loginCmd.Parameters.AddWithValue("@Username", username);
                                loginCmd.Parameters.AddWithValue("@Password", password);
                                queryCmd.Parameters.AddWithValue("@Username", username);
                                queryCmd.Parameters.AddWithValue("@Password", password);
                            //imgCmd.Parameters.AddWithValue("@Username", username);
                            //imgCmd.Parameters.AddWithValue("@Password", password);                           

                            int count = Convert.ToInt32(loginCmd.ExecuteScalar());

                                if (count == 1)
                                {
                                    using (SqlDataReader reader = queryCmd.ExecuteReader())
                                    {
                                        if (reader.Read())
                                        {
                                            byte[] imageData = reader["img"] as byte[];
                                            string email = reader["email"] as string;
                                            string phone_number = reader["phone_number"] as string;
                                            string gender = reader["gender"] as string;
                                            DateTime bday = Convert.ToDateTime(reader["bday"]) ;
                                        return new User { Username = username, Image = imageData, email = email, phone_number=phone_number };
                                        }
                                    }
                                }

                                //return null; // Return null if no user is found with the specified username and password                
                        }
                        //using (SqlCommand emailCmd = new SqlCommand(emailQuery, sqlCon))
                        //{
                        //    emailCmd.CommandType = CommandType.Text;

                        //    emailCmd.Parameters.AddWithValue("@Username", username);
                        //    emailCmd.Parameters.AddWithValue("@Password", password);

                        //    using (SqlDataReader reader = emailCmd.ExecuteReader())
                        //    {
                        //        if (reader.Read())
                        //        {
                        //            string email = reader["email"] as string;
                        //            return new User { Username = username, email = email };
                        //        }
                        //    }
                        //}
                        //using (SqlCommand phoneCmd = new SqlCommand(phoneQuery, sqlCon))
                        //{
                        //    phoneCmd.CommandType = CommandType.Text;

                        //    phoneCmd.Parameters.AddWithValue("@Username", username);
                        //    phoneCmd.Parameters.AddWithValue("@Password", password);
                        //}
                        return null;
                    }
                }
            }
        }

    }
}