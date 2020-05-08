using SQLite;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ebaun.DTO;

namespace ebaun
{
    public class ClassesDataBase
    {
        readonly SQLiteAsyncConnection _database;

        public ClassesDataBase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Classes>().Wait();
        }

        public Task<List<Classes>> GetAllAsync()
        {
            return _database.Table<Classes>().ToListAsync();
        }

        public Task<Classes> GetByQueryAsync(System.Linq.Expressions.Expression<Func<Classes, bool>> query)
        {
            Task<Classes> c = _database.Table<Classes>().FirstOrDefaultAsync(query);
            return c;
        }
        public Task<Classes> GetByIdAsync(int id)
        {
            return _database.Table<Classes>().FirstOrDefaultAsync(c => c.Id == id);
        }
        public Task<Classes> CreateNew(bool save = false)
        {
            return Task.Run(async () =>
            {
                Classes entity = new Classes();
                
                entity.Id = await GetNo();
                if (save)
                    await SaveAsync(entity);
                return entity;
            });
        }
        private async Task<int> GetNo(int no = 1)
        {
            Classes classes = await GetByQueryAsync(c => c.Id == no);
            if (classes == null)
                return no;
            else
                return await GetNo(++no);
        }


        public Task<int> SaveAsync(Classes entity)
        {
            return _database.InsertAsync(entity);
        }

        public Task<int> DeleteAsync(Classes entity)
        {
            return _database.DeleteAsync(entity);
        }
    }
}
