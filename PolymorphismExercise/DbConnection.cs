using System;

namespace PolymorphismExercise
{
    // base class for different DB connections
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        // constructor ensures a connection string is passed.  Throw error if it is null.
        public DbConnection(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new InvalidOperationException("Variable 'connectionString' cannot be blank or of type null");
            
            ConnectionString = connectionString;
        }

        // open and closing methods don't have enough context in the base class.  Must rely on derived classes.
        public abstract void Open();

        public abstract void Close();
    }
}
