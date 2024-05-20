namespace app07.Model;


public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; } = decimal.Zero;

    public int CategoryId { get; set; }

    public bool IsDelete { get; set; }

    //Navigation Property
    public Category Category { get; set; }
    
}

