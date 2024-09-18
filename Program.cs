using System;
using System.Collections.Generic;

public class Product
{
    public string Ten { get; set; }
    public float Gia { get; set; }
    public string Mota { get; set; }
    public int Sl { get; set; }
    public Product (string ten, float gia, string mota, int sl)
    {
        Ten= ten;
        Gia= gia;
        Mota= mota;
        Sl= sl;
    }
    public virtual void xuat()
    {
        Console.WriteLine($"Ten: {Ten}");
        Console.WriteLine($"Gia: {Gia}");
        Console.WriteLine($"Mo ta: {Mota}");
        Console.WriteLine($"So luong: {Sl}");

    }
}
public class Electronic : Product
{
    public int Bh { get; set; }
    public Electronic(string ten, float gia, string mota, int sl, int bh):base(ten, gia, mota, sl)
    {
        Bh=bh;
    }
    public override void xuat()
    {
        base.xuat();
        Console.WriteLine($"Bao hanh: {Bh} thang");
    }
}
public class Clothing : Product
{
    public string Size { get; set; }
    public string Mau { get; set; }
    public Clothing(string ten, float gia, string mota, int sl, string size, string mau):base(ten, gia, mota, sl)
    {
        Size= size;
        Mau= mau;
    }
    public override void xuat()
    {
        base.xuat();
        Console.WriteLine($"Size: {Size}");
        Console.WriteLine($"Mau: {Mau}");
    }
}
public class Food : Product
{
    public DateTime Hsd { get; set; }
    public Food(string ten, float gia, string mota, int sl, DateTime hsd):base(ten, gia, mota, sl)
    {
        Hsd= hsd;
    }
    public override void xuat()
    {
        base.xuat();
        Console.WriteLine($"Hsd: {Hsd.ToShortDateString()}");
    }
}
public class ShoppingCart
{
    private List<Product> pr;
    public ShoppingCart()
    {
        pr = new List<Product>();
    }
    public void addPr(Product p)
    {
        pr.Add(p);
        Console.WriteLine($"{p.Ten} da duoc them vao.");
    }
    public void xoaPr(Product p)
    {
        if (pr.Remove(p))
        {
            Console.WriteLine($"{p.Ten} da duoc loai bo.");
        }
        else
        {
            Console.WriteLine($"{p.Ten} khong ton tai.");
        }
    }
    public void xuat()
    {
        Console.WriteLine("Gio hang:");
        foreach(var p in pr)
        {
            p.xuat();
            Console.WriteLine();
        }
    }
    public float Tong()
    {
        float tong = 0;
        foreach(var p in pr)
        {
            tong += p.Gia*p.Sl;
        }
        return tong;
    }
}

class Program
{
    static void Main()
    {
        Product laptop = new Electronic("Laptop", 2000, "Acer", 1, 24);
        Product quanao = new Clothing("Ao thun", 300, "Cotton", 1, "XL", "Den");
        Product fruit = new Food("Xoai", 100, "Xoai chin", 10, DateTime.Now.AddDays(2));
        ShoppingCart cart = new ShoppingCart();
        cart.addPr(laptop);
        cart.addPr(quanao);
        cart.addPr(fruit);

        cart.xuat();

        float tong = cart.Tong();
        Console.WriteLine($"Tong tien: {tong}");

        cart.xoaPr(quanao);
        cart.xuat();
        tong=cart.Tong();
        Console.WriteLine($"Tong tien sau khi xoa: {tong}");
    }
}