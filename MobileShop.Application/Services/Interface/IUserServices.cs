using MobileShop.Domain.DTOS;
using MobileShop.Domain.Model.User;

namespace MobileShop.Application.Services.Interface
{
    public interface IUserServices
    {
        Task AddUser(UserRegDTO userDTO);
        Task<bool> IsExistUserByMobile(string Moblie);
    }
}
