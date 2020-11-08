using System;


namespace PolymorphismExercise
{
    public class OracleConnection : DbConnection
    {

        // obtain the connection string with the instantiation of a new Oracle connection
        public OracleConnection(string connectionString) : base(connectionString)
        {
            
        }


        // open the Oracle connection
        public override void Open()
        {
            Console.WriteLine($"Oracle connection opened to '{ConnectionString}.'");
        }

        // close the Oracle connection
        public override void Close()
        {
            Console.WriteLine($"Oracle connection closed from '{ConnectionString}.'");
        }
    }
}
