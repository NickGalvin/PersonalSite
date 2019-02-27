using PersonalSite.Shared;
using PersonalSite.Server.Data;
using PersonalSite.Server;
using PersonalSite.Shared.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.AspNet.Identity;

namespace PersonalSite.Server.Services
{
    public class UserService
    {
        private readonly SiteDbContext _db;
        private readonly SiteConfig _config;
        private readonly List<User> _users = new List<User>
        {
            new User{  Id = "1", Username = "nick.m.galvin@gmail.com", Password="Test", Role ="Administrator" }
        };

        public UserService(SiteDbContext db, SiteConfig config)
        {
            _db = db;
            _config = config;
        }

        public User GetUser()
        {
            return _users.First();
        }

        public string Authenticate(string username, string password)
        {
            var user = _users.Find(u => u.Username == username);

            if (user == null)
            {
                return null;
            }

            var signingKey = Convert.FromBase64String(_config.JWT.SigningSecret);
            var expiryDuration = _config.JWT.ExpiryDuration;

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Issuer = null,
                Audience = null,
                IssuedAt = DateTime.UtcNow,
                NotBefore = DateTime.UtcNow,
                Expires = DateTime.UtcNow.AddMinutes(expiryDuration),
                Subject = new ClaimsIdentity(new List<Claim>
                {
                    new Claim("userid", user.Id),
                    new Claim("role", user.Role)
                }),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(signingKey), SecurityAlgorithms.HmacSha256Signature)
            };

            var jwtTokenHandler = new JwtSecurityTokenHandler();
            var jwtToken = jwtTokenHandler.CreateJwtSecurityToken(tokenDescriptor);
            var token = jwtTokenHandler.WriteToken(jwtToken);
            return token;


        }
    }
}
