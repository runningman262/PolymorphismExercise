using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PolymorphismExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            // ********* code for Exercise 1 **********

            //// new SQL DB connection
            //string sqlConnectionString = "sql";
            //SqlConnection sqlConnect = new SqlConnection(sqlConnectionString);

            //// open the SQL DB connection
            //sqlConnect.Open();

            //// close the SQL DB connection
            //sqlConnect.Close();

            //// new oracle DB connection
            //string oracleConnectionString = "oracle";
            //OracleConnection oraConnect = new OracleConnection(oracleConnectionString);

            //// open the Oracle DB connection
            //oraConnect.Open();

            //// close the Oracle DB connection
            //oraConnect.Close();

            //// 2. Execute some code (added in exercise 2)
            ///




            // ********* code for Exercise 2 **********

            // set variables for connection string and DB instruction
            string connectionString = "connection";
            string instruction = "instruction";

            // SQL connection and instruction execution
            SqlConnection sqlConnect = new SqlConnection(connectionString);

            DbCommand sqlDbCommand = new DbCommand(sqlConnect, instruction);
            sqlDbCommand.Execute();

            System.Console.WriteLine("\n");

            // Oracle connection and instruction execution
            OracleConnection oraConnect = new OracleConnection(connectionString);

            DbCommand oraDbCommand = new DbCommand(oraConnect, instruction);
            oraDbCommand.Execute();


        }
    }
}
