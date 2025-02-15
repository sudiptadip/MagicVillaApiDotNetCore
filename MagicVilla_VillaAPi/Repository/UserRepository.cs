using MagicVilla_VillaAPi.Data;
using MagicVilla_VillaAPi.Models;
using MagicVilla_VillaAPi.Models.Dto;
using MagicVilla_VillaAPi.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace MagicVilla_VillaAPi.Repository
{
    public class UserRepository : IUserReposetory
    {
        private readonly ApplicationDbContext _db;
        private string secretKey;
        public UserRepository(ApplicationDbContext db, IConfiguration configuration)
        {
            _db = db;
            secretKey = configuration.GetValue<string>("ApiSettings:Serect");
        }

        public bool IsUniqueUser(string userName)
        {
            var user = _db.LocalUsers.FirstOrDefault(x => x.UserName == userName);
            if(user == null)
            {
                return false;
            }
            return true;
        }

        public async Task<LoginResponseDTO> Login(LoginUserDto loginRequestDto)
        {
            var user = await _db.LocalUsers.FirstOrDefaultAsync(x => x.UserName.ToLower() == loginRequestDto.UserName.ToLower() && x.Password == loginRequestDto.Password);
            if(user == null)
            {
                return new()
                {
                    Token = "",
                    User = null
                };
            }
            var tokenHandeler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(secretKey);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.Id.ToString()),
                    new Claim(ClaimTypes.Role, user.Role.ToString()),
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature),
            };
            var token = tokenHandeler.CreateToken(tokenDescriptor);
            LoginResponseDTO loginResponseDTO = new LoginResponseDTO()
            {
                Token = tokenHandeler.WriteToken(token),
                User = user,
            };
            
            return loginResponseDTO;
        }

        public async Task<LocalUser> Register(RegisterationRequestDTO registerationRequestDTO)
        {
            LocalUser user = new LocalUser()
            {
                UserName = registerationRequestDTO.UserName,
                Password = registerationRequestDTO.Password,
                Name = registerationRequestDTO.Name,
                Role = registerationRequestDTO.Role,
            };
            await _db.LocalUsers.AddAsync(user);
           await _db.SaveChangesAsync();
            user.Password = "";
            return user;
        }
    }
}
