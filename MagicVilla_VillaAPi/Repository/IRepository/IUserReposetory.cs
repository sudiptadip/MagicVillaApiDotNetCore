using MagicVilla_VillaAPi.Models;
using MagicVilla_VillaAPi.Models.Dto;

namespace MagicVilla_VillaAPi.Repository.IRepository
{
    public interface IUserReposetory
    {
        bool IsUniqueUser(string userName);
        Task<LoginResponseDTO> Login(LoginUserDto loginRequestDto);
        Task<LocalUser> Register(RegisterationRequestDTO registerationRequestDTO);
    }
}
