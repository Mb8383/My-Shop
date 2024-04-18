#region MyRegion
using Microsoft.EntityFrameworkCore;
using MobileShop.Data.AppDbContext;
using MobileShop.Domain.IRepositories;
using MobileShop.Domain.Model.User;
namespace MobileShop.Data.Repositories.Users;
#endregion
public class UserRepository : IUserRepositories
{
    #region Ctor
    public readonly AppdbContext _Context;
    public UserRepository(AppdbContext context)
    {
        _Context = context;
    }
    #endregion

    public async Task AddUser(User user)
    {
        _Context.Users.Add(user);
    }
    public async Task<bool> IsExistUserByMobile(string Moblie)
    {
      return await _Context.Users.AnyAsync(e => e.PhoneNumber == Moblie);
    }
}
