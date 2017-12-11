using System;

namespace udemy_csharp_intermediate.Polymorphism
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString)
        {
        }

        public override void Open()
        {
            Console.WriteLine("SqlConnection is open.");
        }

        public override void Close()
        {
            Console.WriteLine("SqlConnection is closed.");
        }
    }
}