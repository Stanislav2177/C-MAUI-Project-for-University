using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using ProjectMaui.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjectMaui.Services
{
    public class DatabaseService
    {
        private readonly SQLiteAsyncConnection _database;

        public DatabaseService(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Student>().Wait();
            _database.CreateTableAsync<User>().Wait();
        }

        // Student operations
        public Task<List<Student>> GetStudentsAsync() => _database.Table<Student>().ToListAsync();
        public Task<int> SaveStudentAsync(Student student) => _database.InsertAsync(student);

        // User operations
        public Task<List<User>> GetUsersAsync() => _database.Table<User>().ToListAsync();
        public Task<int> SaveUserAsync(User user) => _database.InsertAsync(user);
    }
}
