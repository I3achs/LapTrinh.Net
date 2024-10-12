using System;
using System.Collections.Generic;

// Abstract class PhuongTien
public abstract class PhuongTien
{
    public string TenPhuongTien { get; set; }
    public string LoaiNhienLieu { get; set; }

    // Abstract method
    public abstract void DiChuyen();
}

// Interface IThongTinThem
public interface IThongTinThem
{
    int TocDoToiDa();
    double MucTieuThuNhienLieu();
}

// Class XeHoi inheriting from PhuongTien and implementing IThongTinThem
public class XeHoi : PhuongTien, IThongTinThem
{
    private int tocDoToiDa;
    private double mucTieuThuNhienLieu;

    public XeHoi()
    {
        Console.Write("Nhap ten phuong tien: ");
        TenPhuongTien = Console.ReadLine();

        Console.Write("Nhap loai nhien lieu (Xang/Dau): ");
        LoaiNhienLieu = Console.ReadLine();

        Console.Write("Nhap toc do toi da cua xe hoi: ");
        tocDoToiDa = int.Parse(Console.ReadLine());

        Console.Write("Nhap muc tieu thu nhien lieu (L/100km): ");
        mucTieuThuNhienLieu = double.Parse(Console.ReadLine());
    }

    public override void DiChuyen()
    {
        Console.WriteLine($"{TenPhuongTien} di chuyen bang dong co.");
    }

    public int TocDoToiDa()
    {
        return tocDoToiDa;
    }

    public double MucTieuThuNhienLieu()
    {
        return mucTieuThuNhienLieu;
    }
}

// Class XeDap inheriting from PhuongTien and implementing IThongTinThem (only TocDoToiDa method)
public class XeDap : PhuongTien, IThongTinThem
{
    private int tocDoToiDa;

    public XeDap()
    {
        Console.Write("Nhap ten phuong tien (Xe Dap): ");
        TenPhuongTien = Console.ReadLine();

        LoaiNhienLieu = "Khong dung nhien lieu"; // Xe dap khong dung nhien lieu

        Console.Write("Nhap toc do toi da cua xe dap: ");
        tocDoToiDa = int.Parse(Console.ReadLine());
    }

    public override void DiChuyen()
    {
        Console.WriteLine($"{TenPhuongTien} di chuyen bang luc dap.");
    }

    public int TocDoToiDa()
    {
        return tocDoToiDa;
    }

    public double MucTieuThuNhienLieu()
    {
        throw new NotImplementedException("Xe dap khong su dung nhien lieu.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create list of vehicles
        List<PhuongTien> danhSachPhuongTien = new List<PhuongTien>();

        string c;
        do
        {
            // Ask user which type of vehicle to enter
            Console.WriteLine("Ban muon nhap thong tin cho loai phuong tien nao? (1: Xe Hoi, 2: Xe Dap, 0: Thoat)");
            c = Console.ReadLine();

            if (c == "1")
            {
                // Enter information for car
                Console.WriteLine("Nhap thong tin cho xe hoi:");
                danhSachPhuongTien.Add(new XeHoi());
            }
            else if (c == "2")
            {
                // Enter information for bicycle
                Console.WriteLine("Nhap thong tin cho xe dap:");
                danhSachPhuongTien.Add(new XeDap());
            }

        } while (c != "0");

        // Display vehicle information
        Console.WriteLine("\nThong tin cac phuong tien:");
        foreach (PhuongTien phuongTien in danhSachPhuongTien)
        {
            Console.WriteLine($"Ten phuong tien: {phuongTien.TenPhuongTien}");
            Console.WriteLine($"Loai nhien lieu: {phuongTien.LoaiNhienLieu}");
            phuongTien.DiChuyen();

            // Check and print additional information if the vehicle implements IThongTinThem
            if (phuongTien is IThongTinThem thongTinThem)
            {
                Console.WriteLine($"Toc do toi da: {thongTinThem.TocDoToiDa()} km/h");

                try
                {
                    Console.WriteLine($"Muc tieu thu nhien lieu: {thongTinThem.MucTieuThuNhienLieu()}L/100km");
                }
                catch (NotImplementedException)
                {
                    Console.WriteLine("Khong su dung nhien lieu.");
                }
            }

            Console.WriteLine(); // New line between vehicles
        }
    }
}
