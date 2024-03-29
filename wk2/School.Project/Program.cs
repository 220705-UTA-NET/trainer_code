﻿using System;
using System.Data.SqlClient;

namespace School
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Creating a School...");

            Student st1 = new Student("Ellery", "ellery@gmail.com", "(123)456-7890", "1500 Pennsylvania Ave", "The White House", "Washington", "DC", "20500", 25, 3);
            Student st2 = new Student("Derick", "Derick@outlook.com", "(987)654-3210", "1600 Pennsylvania Ave", "The White House", "Washington", "DC", "20500", 24, 5);

            Teacher t1 = new Teacher("Eunice", "Eunice@hotmail.com", "(567)-432-9012", "1700 Pennsylvania Ave", "", "Washington", "DC", "20500", 27, "Math", "Room 1", true, 100000, new List<string>() { "Math", "Physics" });
            Course c1 = new Course("Math", "Mathmatics", "B5-103", DateTime.Now, 3);

            Console.WriteLine("School created!");

            Insert(st2);
            GetStudents();


        }


        static void Insert(Student st1)
        {
            // your connection string has all the details needed to connect to a database
            string connectionString = "//Your connection string here";
            // a SQLConnection object is created to connect to the database, and is provided the connection string
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();
            string cmdText = 
                @"INSERT INTO School.Students (Id, Name, Email, Phone, Address1, Address2, City, State, Zip, Age, YearsCompleted)
                VALUES
                (@Id, @Name, @Email, @Phone, @Address1, @Address2, @City, @State, @Zip, @Age, @YearsCompleted)";

            using SqlCommand cmd = new SqlCommand(cmdText, connection);

            cmd.Parameters.AddWithValue("@ID", st1.Id);
            cmd.Parameters.AddWithValue("@Name", st1.name);
            cmd.Parameters.AddWithValue("@Email", st1.email);
            cmd.Parameters.AddWithValue("@Phone", st1.phone);
            cmd.Parameters.AddWithValue("@Address1", st1.address1);
            cmd.Parameters.AddWithValue("@Address2", st1.address2);
            cmd.Parameters.AddWithValue("@City", st1.city);
            cmd.Parameters.AddWithValue("@State", st1.state);
            cmd.Parameters.AddWithValue("@Zip", st1.zip);
            cmd.Parameters.AddWithValue("@Age", st1.age);
            cmd.Parameters.AddWithValue("@YearsCompleted", st1.YearsCompleted);

            cmd.ExecuteNonQuery();
            connection.Close();
        }

        static void GetStudents()
        {
            // your connection string has all the details needed to connect to a database
            string connectionString = "//Your connection string here";
            // a SQLConnection object is created to connect to the database, and is provided the connection string
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open(); // open the connection to the database

            //using SqlCommand cmd = new SqlCommand("SELECT * FROM School.Students;", connection);
            //we can use a string as a parameter of the SqlCommand

            string cmdText = "SELECT Id, Name, Phone FROM School.Students;";

            using SqlCommand cmd = new SqlCommand(cmdText, connection);

            //cmd.ExecuteNonQuery();
            using SqlDataReader reader = cmd.ExecuteReader();

            Console.WriteLine("Students in the database:");

            while (reader.Read())
            {
                // Select * From School.Students; returns...
                // Id, Name, Email, Phone, Address1, Address2, City, State, Zip, Age

                // Select Name, Id, Phone From School.Students; returns...
                // Name, Id, Phone

                // Console.WriteLine(reader.GetInt32(0) +  reader.GetString(1));
                int id  = reader.GetInt32(0);
                string name = reader.GetString(1);
                string phone = reader.GetString(2);
                Console.WriteLine(id + " " + name + " " + phone);                
            }
            connection.Close();
        }
    }
}