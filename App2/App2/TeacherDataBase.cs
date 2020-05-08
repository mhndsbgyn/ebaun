using SQLite;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ebaun.DTO;

namespace ebaun
{
    public class TeacherDataBase
    {
        readonly SQLiteAsyncConnection _database;

        public TeacherDataBase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Teacher>().Wait();
        }

        public Task<List<Teacher>> GetAllAsync()
        {
            return _database.Table<Teacher>().ToListAsync();
        }

        public Task<Teacher> GetByQueryAsync(System.Linq.Expressions.Expression<Func<Teacher, bool>> query)
        {
            return _database.Table<Teacher>().FirstOrDefaultAsync(query);
        }
        private async Task<int> GetNo(int no = 1)
        {
            Teacher teacher = await GetByQueryAsync(c => c.Id == no);
            if (teacher == null)
                return no;
            else
                return await GetNo(++no);
        }
        public Task<Teacher> CreateNew(bool save = false)
        {
            return Task.Run(async () =>
            {
               Teacher entity = new Teacher();
               
                entity.Id = await GetNo();
                if (save)
                    await SaveAsync(entity);
                return entity;
            });
        }

        public Task<int> SaveAsync(Teacher entity)
        {
            return _database.InsertAsync(entity);
        }

        public Task<int> DeleteAsync(Teacher entity)
        {
            return _database.DeleteAsync(entity);
        }
    }
}
