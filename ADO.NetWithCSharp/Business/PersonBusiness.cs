using ADO.NetWithCSharp.Models;
using System.Data;
using System.Data.SqlClient;

namespace ADO.NetWithCSharp.Business;

public class PersonBusiness
{
    //const string connectionString = "Server=.;Database=YourDatabaseName;User Id=YourUsername;Password=YourPassword;Integrated Security=True";
    const string connectionString = "Data Source=185.159.153.40,1433;Initial Catalog=drpharms_LearningCsharp;Persist Security Info=False;User ID=drpharms_LearningCsharp;Password=Le@rning_1234$;MultipleActiveResultSets=True;";

    public List<Person> GetPeople()
    {
        List<Person> people = new List<Person>();

        // Replace "YourTableName" with the actual name of the table you want to query
        string tableName = "drpharms_LearningCsharp.Person";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();

                // Create a SQL command to select data from the table
                string query = $"SELECT Id,FirstName, LastName, PhoneNumber FROM {tableName}";
                SqlCommand command = new SqlCommand(query, connection);

                // Create a data reader to fetch the data
                SqlDataReader reader = command.ExecuteReader();

                // Read data and map it to Person objects
                while (reader.Read())
                {
                    Person person = new Person
                    {
                        Id = (int)reader["Id"],
                        FirstName = reader["FirstName"].ToString(),
                        LastName = reader["LastName"].ToString(),
                        PhoneNumber = reader["PhoneNumber"].ToString()
                    };

                    people.Add(person);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                connection.Close();
                
            }
            return people;
        }
    }

    public bool InsertPerson(Person person)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();

                string tableName = "drpharms_LearningCsharp.Person";

                // Create a SQL command to insert a new person record
                string query = $"INSERT INTO {tableName} (Id,FirstName, LastName, PhoneNumber) " +
                               "VALUES (@Id,@FirstName, @LastName, @PhoneNumber)";
                SqlCommand command = new SqlCommand(query, connection);

                // Add parameters to the SQL command
                command.Parameters.AddWithValue("@Id", person.Id);
                command.Parameters.AddWithValue("@FirstName", person.FirstName);
                command.Parameters.AddWithValue("@LastName", person.LastName);
                command.Parameters.AddWithValue("@PhoneNumber", person.PhoneNumber);

                // Execute the insert query
                int rowsAffected = command.ExecuteNonQuery();

                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
