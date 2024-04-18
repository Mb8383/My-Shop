using MobileShop.Domain.Model.User;
namespace MobileShop.Domain.IRepositories;


public interface IUserRepositories
{
    Task AddUser(User user);
   Task<bool> IsExistUserByMobile(string Moblie);
}
