using System.Data.SqlClient;

namespace ZarCare_Automation.Utilities
{
    public class Database_Utils
    {
        public static string Get_OTP_From_Database()
        {
            string otp = "NA";
            // Connect to the database
            string connectionString = "Server=tcp:devzarcaredb.database.windows.net;Database=OTP;User Id=DevSqlAdmin;Password=NDH&u3ur\\/C[Y{7txpZ;";
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                // Open the database connection
                connection.Open();

                // Query to retrieve OTP from database
                string query = "Select top 1 Pin from otp order by CreatedDate desc";
                SqlCommand command = new SqlCommand(query, connection);

                // Execute the query
                SqlDataReader reader = command.ExecuteReader();

                // Check if a record was found
                if (reader.Read())
                {
                    // Extract OTP from the database
                    otp = reader["Pin"].ToString().Trim(); // Corrected to match your query column name
                }
                else
                {
                    Console.WriteLine("No OTP found in the database.");
                }

                // Close the reader
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                // Close the connection
                connection.Close();
            }

            return otp;
        }

        public static void Check_WorkWithUs_Table_ForMultipleEntries(string email)
        {
            string connectionString = "Server=tcp:devzarcaredb.database.windows.net;Database=Zarcare;User Id=DevSqlAdmin;Password=NDH&u3ur\\/C[Y{7txpZ;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    // Adjust the query to check for the specific email
                    string query = "SELECT COUNT(*) FROM WorkWithUs WHERE Email = @Email";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Use parameterized query to prevent SQL injection
                        command.Parameters.AddWithValue("@Email", email);

                        // ExecuteScalar will return the number of rows matching the condition
                        object result = command.ExecuteScalar();

                        // Handle the result safely
                        int count = 0;
                        if (result != null && int.TryParse(result.ToString(), out count))
                        {
                            Console.WriteLine($"Number of entries in SQL Server for email '{email}': {count}");

                            // Check if multiple entries are logged
                            if (count > 1)
                            {
                                Console.WriteLine("Multiple entries found in SQL Server.");
                            }
                            else
                            {
                                Console.WriteLine("No multiple entries found in SQL Server.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error: Unable to retrieve count from the database.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Database check failed: {ex.Message}");
            }
        }

    }
}
