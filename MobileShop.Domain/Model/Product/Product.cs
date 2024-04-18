#region Using
namespace MobileShop.Domain.Model.Product;
#endregion
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string ImageProduct { get; set; }
    public DateTime CreateDate { get; set; }

}
