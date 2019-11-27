using System;

namespace Common_Layer.IUserService
{
    public interface IToken
    {
        string CreateToken(string secretKey, string issuer, string audience, Claim[] claims, DateTime expireTime);
        string GetValue(string token, string claimName);
        int GetUserId(string token);
        string GetPermissionList(string token);
    }
}
