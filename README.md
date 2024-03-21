**FORM1:**

## User Registration Form

This Windows Forms application provides a user registration form with validation checks for username, password, email, phone number, and birthdate. The application stores user information in a SQL Server database.

### Features:

- **Username Validation:** Validates that the username is at least 5 characters long.
- **Password Validation:** Checks if the password meets certain criteria such as length, presence of uppercase letters, lowercase letters, and digits.
- **Email Validation:** Validates the format of the email address using a regular expression.
- **Phone Number Validation:** Validates the format of the phone number using a regular expression.
- **Age Validation:** Checks if the user is at least 18 years old based on the provided birthdate.
- **Duplicate Username Check:** Checks if the username already exists in the database before registration.
- **User Registration:** Inserts user information into the database upon successful validation.
- **Navigation:** Allows users to navigate to the login form.

### Libraries Used:

- **System.Net.Mail:** Used for email validation.
- **System.Data.SqlClient:** Provides classes for accessing and managing SQL Server databases.
- **Microsoft.VisualBasic.Logging:** Offers support for logging in Visual Basic.
- **System.Diagnostics.Metrics:** Provides support for collecting and reporting metrics.
- **System.Linq:** Provides extension methods for querying data collections.
- **System.ComponentModel.DataAnnotations:** Used for data validation.
- **System.Text.RegularExpressions:** Used for pattern matching with regular expressions.

### Database Connection:

The application connects to a SQL Server database named "userRecords" hosted on the server "LAB109PC21\SQLEXPRESS" using integrated security.

### User Interface:

- **TextBoxes:** For entering username, password, email, and phone number.
- **DateTimePicker:** For selecting the birthdate.
- **ComboBox:** For selecting the gender.
- **Buttons:** 
  - "Register": Initiates the user registration process.
  - "Back": Navigates back to the login form.

### Code Highlights:

- **Validation Methods:** Separate methods for validating username, password, email, phone number, and birthdate.
- **Insertion to Database:** Inserts user information into the database if all validations pass.
- **Duplicate Username Check:** Queries the database to ensure that the username is unique.
- **Navigation:** Hides the registration form and shows the login form upon successful registration or when the user clicks the "Back" button.

### Usage:

1. Enter user information in the respective fields.
2. Click the "Register" button to create an account.
3. If successful, a message will be displayed, and the login form will appear.
4. Click the "Back" button to return to the login form without registering.

### Note:

- Ensure that the database connection string is configured correctly in the `SqlConnection` constructor.
- Adjust the database schema and table names as needed to match your environment.










**Form2:**

## Login Form

This Windows Forms application provides a login form for users to authenticate themselves. It connects to a SQL Server database to validate user credentials.

### Features:

- **User Authentication:** Validates user credentials against the database.
- **Input Validation:** Ensures that both username and password fields are not empty before attempting authentication.

### Libraries Used:

- **System.Data.SqlClient:** Provides classes for accessing and managing SQL Server databases.
- **System.Linq:** Provides extension methods for querying data collections.

### Database Connection:

The application establishes a connection to the SQL Server database to retrieve user information for authentication.

### User Interface:

- **TextBoxes:** For entering username and password.
- **Button:** "Login" button to initiate the authentication process.

### Code Highlights:

- **Authentication Method:** Calls a method from the `DatabaseManager` class to authenticate user credentials against the database.
- **Validation:** Checks if both username and password fields are filled before attempting authentication.
- **Navigation:** If authentication is successful, hides the login form and opens the welcome form (`Form3`) with the authenticated user's information.

### Usage:

1. Enter your username and password in the respective fields.
2. Click the "Login" button to authenticate.
3. If authentication is successful, the welcome form (`Form3`) will be displayed.
4. If authentication fails, an error message will be shown indicating invalid credentials.

### Note:

- Ensure that the database connection string and authentication logic in the `DatabaseManager` class are properly configured.
- Adjust the authentication logic as needed to match your application requirements.
- Handle exceptions and errors appropriately for a robust application.










**FORM3:**

## User Profile Form

This Windows Forms application provides a user profile form to display user information and upload a profile picture. It connects to a SQL Server database to retrieve and update user profile data.

### Features:

- **Display User Information:** Displays the authenticated user's username, email, and phone number.
- **Upload Profile Picture:** Allows the user to upload a profile picture from their local system.
- **Image Display:** Displays the uploaded profile picture on the form.
- **Navigation:** Provides a button to navigate to another form (`check` form).

### Libraries Used:

- **System.Data.SqlClient:** Provides classes for accessing and managing SQL Server databases.
- **System.IO:** Provides classes for working with files and streams.
- **System.Drawing:** Provides classes for creating, manipulating, and displaying images.

### User Interface:

- **Labels:** Display the user's username, email, and phone number.
- **PictureBox:** Displays the uploaded profile picture.
- **Buttons:** 
  - "Upload Picture": Initiates the process to upload a profile picture.
  - "Enter": Navigates to another form (`check` form).

### Code Highlights:

- **Initialization:** Initializes the form with user information retrieved during authentication.
- **Profile Picture Upload:** Allows the user to upload a profile picture from their local system. The uploaded picture is displayed on the form.
- **Image Conversion:** Converts the uploaded image to a byte array for storage in the database.
- **Database Interaction:** Updates the user's profile picture in the database upon successful upload.
- **Navigation:** Hides the profile form and opens another form (`check` form) when the "Enter" button is clicked.

### Usage:

1. The form is loaded with the authenticated user's information, including username, email, and phone number.
2. Click the "Upload Picture" button to select a profile picture from your local system. The selected picture will be displayed on the form.
3. Click the "Enter" button to navigate to another form (`check` form).

### Note:

- Ensure that the database connection and image upload logic are properly configured in the application.
- Adjust the database schema and table names as needed to match your environment.
- Handle exceptions and errors appropriately for a robust application.










**LOGIN:**

## Login Class

This class represents a simple login functionality within a Windows Forms application.

### Features:

- **ShowDialog Method:** Provides a method to display a login dialog.

### Usage:

1. Instantiate the `Login` class.
2. Call the `ShowDialog` method to display the login dialog.

### Note:

- This class currently throws a `NotImplementedException` when the `ShowDialog` method is called. You need to implement the actual login functionality within this method.










**Authentication:**

## Authentication Class

This class provides functionality for user authentication within a Windows Forms application. It connects to a SQL Server database to validate user credentials and retrieve user information.

### User Class

- **Purpose:** Encapsulates user-related properties for better maintainability.
- **Properties:**
  - `Username`: User's username.
  - `Image`: User's profile picture in binary format.
  - `email`: User's email address.
  - `phone_number`: User's phone number.
  - `bday`: User's birthdate.
  - `gender`: User's gender.

### DatabaseManager Class

- **Purpose:** Handles database operations, including user authentication and information retrieval.
- **Methods:**
  - `AuthenticateUser`: Authenticates the user by querying the database with the provided username and password.
  - `RetrieveUserInformation`: Encapsulates the logic for querying the database and retrieving user information.

### Usage:

1. Call the `AuthenticateUser` method of the `DatabaseManager` class, passing the username and password as parameters.
2. If authentication is successful, the method returns a `User` object containing the user's information.
3. If authentication fails or no user is found with the provided credentials, the method returns `null`.

### Note:

- Ensure that the database connection string and query logic are properly configured in the application.
- Adjust the database schema and table names as needed to match your environment.
- Handle exceptions and errors appropriately for a robust authentication system.









**Check:**

## Check Form

This Windows Forms application provides functionality to check restaurant table availability based on various criteria. It connects to a SQL Server database to query table information and display results.

### Features:

- **Dynamic Filtering:** Allows users to filter table availability based on different criteria such as status, table type, availability, and presence of kids.
- **Reset Functionality:** Provides a button to reset filters and clear the data grid view.
- **Reservation and Reservation Viewing:** Allows users to reserve a table or view existing reservations.

### User Interface:

- **ComboBoxes:** For selecting filtering criteria (status, table type, availability, kids).
- **Buttons:** 
  - "Check Availability": Initiates the table availability check based on selected criteria.
  - "Reset Filters": Clears selected filters and resets the data grid view.
  - "Reserve": Opens a form to reserve a table.
  - "See Reservations": Opens a form to view existing reservations.

### Database Connection:

The application connects to a SQL Server database named "Restaurant" hosted on the server "LAB109PC21\SQLEXPRESS" using integrated security.

### Code Highlights:

- **Dynamic SQL Query:** Constructs a SQL query based on selected filtering criteria and executes it to fetch table availability data.
- **Parameterized Queries:** Uses parameterized queries to prevent SQL injection attacks.
- **DataAdapter:** Utilizes SqlDataAdapter to fetch data from the database and populate the DataGridView.
- **Form Interaction:** Opens new forms (`reserve` and `reservations`) for reserving tables and viewing reservations, respectively.

### Usage:

1. Select filtering criteria from the ComboBoxes (status, table type, availability, kids).
2. Click the "Check Availability" button to fetch table availability based on the selected criteria.
3. Click the "Reset Filters" button to clear selected filters and reset the data grid view.
4. Click the "Reserve" button to reserve a table.
5. Click the "See Reservations" button to view existing reservations.

### Note:

- Ensure that the database connection string and query logic are properly configured in the application.
- Adjust the database schema and table names as needed to match your environment.
- Handle exceptions and errors appropriately for a robust application.









**Image Uploader:**

## ImageUploader Class

This class provides functionality to upload images to a SQL Server database for specific usernames.

### Features:

- **Image Upload:** Allows uploading images to the database for a specified username.
- **Image Conversion:** Provides a method to convert an `Image` object to a byte array for storage in the database.

### Usage:

1. Call the `UploadImage` method, passing the username and image byte array as parameters, to upload an image to the database.
2. Use the `ImageToByteArray` method to convert an `Image` object to a byte array before calling the `UploadImage` method.

### Note:

- Ensure that the database connection string and update query logic are properly configured in the application.
- Adjust the database schema and table names as needed to match your environment.








**Reservation:**

## Reservations Form

This form allows users to view existing reservations and delete them if necessary. It retrieves reservation data from a SQL Server database and displays it in a DataGridView. Users can select a reservation from the DataGridView and delete it, which also updates the table availability status.

### Features:

- **View Reservations:** Displays existing reservations in a DataGridView.
- **Delete Reservations:** Allows users to delete selected reservations, updating the table availability status accordingly.

### Database Connection:

The form connects to a SQL Server database named "Restaurant" hosted on the server "LAB109PC21\SQLEXPRESS" using integrated security.

### Code Highlights:

- **Load Reservations:** Retrieves reservation data from the database and populates the DataGridView during form load.
- **Delete Reservation:** Deletes the selected reservation from the database and updates the table availability status. Displays appropriate messages based on the deletion result.

### Usage:

1. Launch the form to view existing reservations.
2. Select a reservation from the DataGridView.
3. Click the "Delete" button to delete the selected reservation.
4. If the deletion is successful, a success message is displayed. Otherwise, an error message is shown.

### Note:

- Ensure that the database connection string and query logic are properly configured in the application.
- Adjust the database schema and table names as needed to match your environment.
- Handle exceptions and errors appropriately for a robust application.








**Reserve:**

## Reserve Form

This form allows users to reserve a table in a restaurant by providing their name and phone number. It checks the availability of the selected table and inserts a reservation into the database if the table is available.

### Features:

- **Table Reservation:** Enables users to reserve a table by entering their name and phone number.
- **Availability Check:** Verifies if the selected table is available for booking before proceeding with the reservation.
- **Database Update:** Inserts the reservation into the database and updates the table availability status accordingly.

### Database Connection:

The form connects to a SQL Server database named "Restaurant" hosted on the server "LAB109PC21\SQLEXPRESS" using integrated security.

### Code Highlights:

- **Availability Check:** Queries the database to check the availability status of the selected table before proceeding with the reservation.
- **Reservation Insertion:** Inserts the reservation details into the database if the selected table is available for booking.
- **Database Update:** Updates the table availability status in the database after a successful reservation.

### Usage:

1. Enter the name and phone number of the person making the reservation.
2. Enter the table ID for the table to be reserved.
3. Click the "Reserve" button to proceed with the reservation.
4. If the table is available, a success message is displayed, and the reservation is inserted into the database. Otherwise, an error message is shown.

### Note:

- Ensure that the database connection string and query logic are properly configured in the application.
- Adjust the database schema and table names as needed to match your environment.
- Validate user input and handle exceptions appropriately for a robust application.
