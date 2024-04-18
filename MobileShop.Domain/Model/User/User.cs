#region Using
namespace MobileShop.Domain.Model.User;
#endregion
public class User
{
    public int id { get; set; }
    public string FirstName { get; set; }  
    public string LasttName { get; set; }
    public string Email { get; set; }
    public string password { get; set; }
    public string PhoneNumber { get; set; }
    public DateTime CreateDate { get; set; }= DateTime.Now;
    public string Avatar { get; set; }


}
