using System.Diagnostics;
using System.Xml.Linq;

public abstract class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
    public abstract void HienThi();
    public abstract void GiamGia(decimal percentage);
}

public interface ISellable
{
    void Sell(int quantity);
    bool InStock();
}

public class MobilePhone : Product, ISellable
{
    public string Brand { get; set; }
    public override void HienThi()
    {
        Console.WriteLine($"Mobile Phone - Name: {Name}, Brand: {Brand}, Price: {Price}, Stock: {Stock}");
    }
    public override void GiamGia(decimal percentage)
    {
        Price -= Price * (percentage / 100);
    }
    public void Sell(int quantity)
    {
        if (InStock() && quantity <= Stock)
        {
            Stock -= quantity;
            Console.WriteLine($"Sold {quantity} Mobile Phones. Remaining stock: {Stock}");
        }
        else
        {
            Console.WriteLine("Not enough stock to sell.");
        }
    }
    public bool InStock()
    {
        return Stock > 0;
    } 
}

public class Laptop : Product, ISellable
{
    public string Model { get; set; }
    public override void HienThi()
    {
        Console.WriteLine($"Laptop - Name: {Name}, Model: {Model}, Price: {Price}, Stock: {Stock}");
    }
    public override void GiamGia(decimal percentage)
    {
        Price -= Price * (percentage / 100);
    }
    public void Sell(int quantity)
    {
        if (InStock() && quantity <= Stock)
        {
            Stock -= quantity;
            Console.WriteLine($"Sold {quantity} Laptops. Remaining stock: {Stock}");
        }
        else
        {
            Console.WriteLine("Not enough stock to sell.");
        }
    }
    public bool InStock()
    {
        return Stock > 0;
    }
}

public class Accessory : Product, ISellable
{
    public string Type { get; set; }
    public override void HienThi()
    {
        Console.WriteLine($"Laptop - Name: {Name}, Type: {Type}, Price: {Price}, Stock: {Stock}");
    }
    public override void GiamGia(decimal percentage)
    {
        Price -= Price * (percentage / 100);
    }
    public void Sell(int quantity)
    {
        if (InStock() && quantity <= Stock)
        {
            Stock -= quantity;
            Console.WriteLine($"Sold {quantity} Accessories. Remaining stock: {Stock}");
        }
        else
        {
            Console.WriteLine("Not enough stock to sell.");
        }
    }
    public bool InStock()
    {
        return Stock > 0;
    }
}
class Program
{
    static void Main(string[] args)
    {
        MobilePhone phone = new MobilePhone { Name = "IPhone 16", Brand = "Apple", Price = 999, Stock = 100 };
        Laptop laptop = new Laptop { Name = "Acer Aspire 7", Model = "Acer", Price = 199, Stock = 99 };
        Accessory accessory = new Accessory { Name = "Charger", Type = "USB-C", Price = 19, Stock = 88 };

        phone.HienThi();
        laptop.HienThi();
        accessory.HienThi();
        Console.WriteLine();

        phone.Sell(10);
        laptop.Sell(20);
        accessory.Sell(88);
        Console.WriteLine();

        Console.WriteLine($"Is {phone.Name} in stock? {phone.InStock()}");
        Console.WriteLine($"Is {laptop.Name} in stock? {laptop.InStock()}");
        Console.WriteLine($"Is {accessory.Name} in stock? {accessory.InStock()}");
        Console.WriteLine();

        phone.GiamGia(10);
        laptop.GiamGia(15);
        accessory.GiamGia(10);

        phone.HienThi();
        laptop.HienThi();
        accessory.HienThi();
    }
}