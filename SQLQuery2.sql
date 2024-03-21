CREATE TABLE UserInfo (
    id INT PRIMARY KEY IDENTITY(1,1),
    username NVARCHAR(255) NOT NULL,
    password NVARCHAR(255) NOT NULL,
    email NVARCHAR(255) NOT NULL,
    bday DATE NOT NULL,
    gender NVARCHAR(10) NOT NULL,
    phone_number NVARCHAR(15) NOT NULL
);
