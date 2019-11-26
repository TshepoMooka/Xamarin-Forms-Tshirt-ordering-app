using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;
namespace TshirtApp
{
    public class ShirtDatabase
    {
        readonly SQLiteAsyncConnection database;
        public ShirtDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Info>().Wait();
        }
        
        public Task<List<Info>> GetItemsAsync()
        {
            return database.Table<Info>().ToListAsync();
        }


        public Task<List<Info>> GetItemsNotDoneAsync()
        {
            return database.QueryAsync<Info>("SELECT * FROM [Info]");
        }
        

        public Task<Info> GetItemAsync(int id)
        {
            return database.Table<Info>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }
        
        public Task<int> InsertTShirtOrder(Info info)
        {
            return database.InsertAsync(info);
        }

        public Task<int> UpdateTShirtOrder(Info info)
        {
            return database.UpdateAsync(info);
        }


        public Task<int> SaveTShirtOrder(Info item)
        {
            if (item.ID != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }


        public Task<int> DeleteItemAsync(Info item)
        {
            return database.DeleteAsync(item);
        }
    }
}












