using System;

namespace YaRpgApp.Data
{
    public interface IDbContext
    {
        void Insert<T>(T profile);
    }
}