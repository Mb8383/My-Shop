#region using
namespace MobileShop.Domain.DTOS;
#endregion
public class UserRegDTO
{
    public string? FirstName { get; set; }
    public string? LasttName { get; set; }
    public string? Email { get; set; }
    public string? password { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Avatar { get; set; }
}
