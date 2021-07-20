using System;
using Xunit;
using YaRpgApp.Data;
using YaRpgApp.Data.Account;
using LiteDB;
namespace YaRpgApp.Test.Data
{
    public class AccountRepositoryTest
    {
        private string _dbString = "Filename=~\\DataBase\\database.db;Password=1234;Connection=shared";
        private readonly IDbContext _dbContext;
        public AccountRepositoryTest()
        {
            _dbContext = new DbLiteContext(new LiteDatabase(_dbString));
        }
        [Fact]
        public void ShouldBeAbleToReturnProfileById()
        {
            var id = Guid.NewGuid();
            var expected = new Profile {ProfileId = id.ToString(), Login = "foobar", IsAdmin = false};

            var repo = new AccountRepository(_dbContext);
            repo.CreateProfile(expected);
            var actual = repo.GetProfileById(id);
            
        }   
    }
}