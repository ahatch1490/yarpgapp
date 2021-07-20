using System;
using System.Collections;
using System.ComponentModel.Design;
using LiteDB;

namespace YaRpgApp.Data
{
    public class DbLiteContext: IDbContext, IDisposable
    {
        private readonly LiteDatabase _db;
        public DbLiteContext(LiteDatabase db)
        {
            _db = db;
        }
        /// <summary>
        /// @"C:\Temp\MyData.db"
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static IDbContext GetDbContext(string path)
        {
            return new DbLiteContext(new LiteDatabase(path));
        }

        public void Dispose()
        {
            _db?.Dispose();
           
        }

        public void Insert<T>(T value)
        {
            var col = _db.GetCollection<T>(typeof(T).Name);
            col.Insert(value);
        }
    }
}