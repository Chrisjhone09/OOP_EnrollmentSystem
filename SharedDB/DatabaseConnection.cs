using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SharedDB
{
    public class DatabaseConnection<T> : IDisposable where T : DbContext
    {
        private readonly string _connectionString;
        public T Context { get; private set; }

        public DatabaseConnection(string serverName, string databaseName)
        {
            if (string.IsNullOrWhiteSpace(serverName) || string.IsNullOrWhiteSpace(databaseName))
                throw new ArgumentException("Server name and database name cannot be empty.");

            _connectionString = $"Server={serverName};Database={databaseName};Trusted_Connection=True;TrustServerCertificate=true";
        }

        public DatabaseConnection(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentException("Connection string cannot be empty.");

            _connectionString = connectionString;
        }

        public string GetConnectionString() => _connectionString;

        public DbContextOptions<T> GetOptions()
        {
            return new DbContextOptionsBuilder<T>()
                .UseSqlServer(_connectionString)
                .Options;
        }

        public void ContextInitialize()
        {
            if (Context == null)
            {
                Context = (T)Activator.CreateInstance(typeof(T), GetOptions())!;
            }
        }

        public void Dispose()
        {
            Context?.Dispose();
        }
    }

}
