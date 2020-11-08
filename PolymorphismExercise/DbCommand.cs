using System;


namespace PolymorphismExercise
{
    public class DbCommand
    {
        public DbConnection Connection { get; set; }
        public string Instruction { get; set; }

        // constructor for new DB instruction
        public DbCommand(DbConnection connection, string instruction)
        {
            // throw execptions if connection or insturction is invalid
            if (connection == null)
                throw new InvalidOperationException("Object 'DbConnection' cannot be of type null.");

            if (string.IsNullOrWhiteSpace(instruction))
                throw new InvalidOperationException("Variable 'instruction' cannot be blank or of type null.");

            // if valid connection or instruction, store to this object
            Connection = connection;
            Instruction = instruction;

        }

        // open connection, perform instruction, and close connection
        public void Execute()
        {
            Connection.Open();

            Console.WriteLine($"Running the DB Command instruction '{Instruction}.'");

            Connection.Close();
        }
    }
}
