using System;

namespace YaRpgApp.Data.Account
{
    public class AccountRepository
    {
        private readonly IDbContext _context;

        public AccountRepository(IDbContext context)
        {
            _context = context;
        }

        public void CreateProfile(Profile profile)
        {
            throw new NotImplementedException();
        }

        public object GetProfileById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}