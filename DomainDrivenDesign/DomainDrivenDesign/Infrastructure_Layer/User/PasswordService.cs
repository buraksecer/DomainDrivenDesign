using Common_Layer.IUserService;
using System;

namespace Infrastructure_Layer.User
{
    public class PasswordService : IPassword
    {
        public void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            throw new NotImplementedException();
        }

        public bool VerifyPasswordHash(string password, byte[] storedHash, byte[] storedSalt)
        {
            throw new NotImplementedException();
        }
    }
}
