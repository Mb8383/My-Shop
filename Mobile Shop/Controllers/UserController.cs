#region MyRegion
using Microsoft.AspNetCore.Mvc;
using MobileShop.Domain.DTOS;
using MobileShop.Application.Services.Interface;

namespace Mobile_Shop.Controllers;
#endregion
public class UserController : Controller
{
    #region ctor
    public readonly IUserServices _userServices;
    public UserController(IUserServices userServices)
    {
        _userServices = userServices;
    }
    #endregion
    #region RegisterUser
    public IActionResult RegisterUser()
    {
        return View();
    }
    [HttpPost]
    public IActionResult RegisterUser(UserRegDTO userRegDTO)
    {
        _userServices.AddUser(userRegDTO);
        return View();
    }
    #endregion
    #region Login

    #endregion
  


}
