using System;


namespace PolymorphismExercise
{
    public class SqlConnection : DbConnection
    {
        // obtain the connection string with the instantiation of a new SQL connection
        public SqlConnection(string connectionString) : base(connectionString)
        {
            
        }

        // open the SQL connection
        public override void Open()
        {
            Console.WriteLine($"SQL connection opened to '{ConnectionString}.'");
        }

        // close the SQL connection
        public override void Close()
        {
            Console.WriteLine($"SQL connection closed from '{ConnectionString}.'");
        }
    }
}
