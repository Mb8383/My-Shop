using MobileShop.Application.Services.Interface;
using MobileShop.Domain.DTOS;
using MobileShop.Domain.Model.User;
namespace MobileShop.Application.Services.Implementation
{
    public class UserServices : IUserServices
    {
        #region ctor
        public readonly IUserServices _userServices;
        public UserServices(IUserServices userServices) {  _userServices = userServices; }
        #endregion


        public User FillUserEntity(UserRegDTO userRegDTO)
        {
           User user=new()
            {
                Avatar = userRegDTO.Avatar,
                FirstName = userRegDTO.FirstName,
                LasttName = userRegDTO.LasttName,
                Email = userRegDTO.Email,
                password = userRegDTO.password
            };
            return user;
        }
        public async Task<bool> RegisterUser(UserRegDTO userRegDTO, CancellationToken cancellation)
        {
            //is Exist user
            if (await IsExistUserByMobile(userRegDTO.PhoneNumber))
            {
                return false;
            }
            //fill entity
            User user = FillUserEntity(userRegDTO);
            //add user
            await AddUser(userRegDTO);
            return true;

           ;
        }
        public async Task AddUser(UserRegDTO userDTO)
        {
          await  _userServices.AddUser(userDTO);
           
        }
        public async Task<bool> IsExistUserByMobile(string Moblie)
        {
          return  await  _userServices.IsExistUserByMobile(Moblie);
        }

    }
}
