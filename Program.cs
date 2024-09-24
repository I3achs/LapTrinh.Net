using System;
using System.Collections.Generic;
using System.Linq;
public class SinhVien {
    public string HoTen { get; set; }
    public string MSSV { get; set;  }
    public double DiemTB { get; set; }
    public void Nhap()
    {
        Console.Write("Nhap ho ten sinh vien: ");
        HoTen = Console.ReadLine();
        Console.Write("Nhap ma so sinh vien: ");
        MSSV = Console.ReadLine();
        Console.Write("Nhap diem trung binh: ");
        DiemTB = Convert.ToDouble(Console.ReadLine());
    }
    public void Xuat()
    {
        Console.WriteLine("Ho ten: " + HoTen);
        Console.WriteLine("Ma so sinh vien: " + MSSV);
        Console.WriteLine("Diem trung binh: " + DiemTB);
    }
}

public class DanhSachSinhVien {
    private List<SinhVien> dssv;
    public DanhSachSinhVien()
    {
        dssv = new List<SinhVien>();
    }
    public void ThemSV(SinhVien s)
    {
        dssv.Add(s);
    }
    public void HienThi()
    {
        for (int i = 0; i < dssv.Count; i++)
        {
            Console.WriteLine($"Sinh vien thu {i + 1}: ");
            dssv[i].Xuat();
            Console.WriteLine();
        }
    }
    public void TimKiem(string msv)
    {
        for (int i = 0; i < dssv.Count; i++)
        {
            if (dssv[i].MSSV == msv)
            {
                Console.WriteLine("Thong tin sinh vien tim thay: ");
                dssv[i].Xuat();
                return;
            }
        }
        Console.WriteLine("Khong tim thay sinh vien voi ma so " + msv);
    }
    public SinhVien DiemTrungBinhCaoNhat()
    {
        if (dssv.Count == 0) return null;

        SinhVien svMax = dssv[0];
        for (int i = 1; i < dssv.Count; i++)
        {
            if (dssv[i].DiemTB > svMax.DiemTB)
            {
                svMax = dssv[i];
            }
        }
        return svMax;
    }

}

class Program
{
    static void Main(string[] args)
    {
        DanhSachSinhVien dssv= new DanhSachSinhVien();
        for(int i = 0; i<3; i++)
        {
            Console.WriteLine("Nhap thong tin cho sinh vien " + (i + 1) + ": ");
            SinhVien sv= new SinhVien();
            sv.Nhap();
            dssv.ThemSV(sv);
            Console.WriteLine();
        }
        Console.WriteLine("Danh sach sinh vien: ");
        dssv.HienThi();

        SinhVien svMax= dssv.DiemTrungBinhCaoNhat();
        if (svMax != null)
        {
            Console.WriteLine("Sinh vien co diem trung binh cao nhat: ");
            svMax.Xuat();
        }

        Console.Write("Nhap ma sinh vien can tim: ");
        string msv = Console.ReadLine();
        dssv.TimKiem(msv);
    }
}