using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("1. Nhap va sap xep cac so nguyen");
            Console.WriteLine("2. Nhap ten va tuoi");
            Console.WriteLine("3. Nhap ten hoc sinh va diem");
            Console.WriteLine("4. Thoat");
            Console.Write("Lua chon: ");
            string c = Console.ReadLine();

            switch (c)
            {
                case "1":
                    Bai1();break;
                case "2":
                    Bai2(); break;
                case "3":
                    Bai3(); break;
                case "4":
                    Console.WriteLine("Thoat chuong trinh.");
                    return;
                default:
                    Console.WriteLine("Error. Try again.");
                    break;
            }
            Console.WriteLine();
        }
    }
    static void Bai1()
    {
        ArrayList a = new ArrayList();
        Console.WriteLine("Nhap cac so nguyen (nhap ki tu bat ki de dung): ");
        while (true)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out int number))
            {
                a.Add(number);
            }
            else
            {
                break;
            }
        }
        a.Sort();
        Console.WriteLine("Danh sach cac so nguyen da nhap (tang dan): ");
        foreach (int number in a)
        {
            Console.WriteLine(number);
        }
    }
    static void Bai2()
    {
        Hashtable p = new Hashtable();
        Console.WriteLine("Nhap ten va tuoi (nhap 'null' de dung): ");
        while (true)
        {
            Console.Write("Nhap ten: ");
            string name = Console.ReadLine();
            if (name.ToLower() == "null")
            {
                break;
            }
            Console.Write("Nhap tuoi: ");
            if (int.TryParse(Console.ReadLine(), out int age))
            {
                if (age > 0)
                {
                    p[name] = age;
                }
                else
                {
                    Console.WriteLine("Tuoi phai la 1 so nguyen: ");
                }
            }
        }
        Console.WriteLine("Danh sach ten va tuoi: ");
        foreach (DictionaryEntry pp in p)
        {
            Console.WriteLine($"{pp.Key} - {pp.Value}");
        }
    }
    static void Bai3()
    {
        Console.WriteLine("Nhap ten hoc sinh (nhap 'null' de dung): ");
        Dictionary<string, int> s = new Dictionary<string, int>();
        while (true)
        {
            Console.Write("Nhap ten hoc sinh: ");
            string name = Console.ReadLine();
            if (name.ToLower() == "null")
            {
                break;
            }
            Console.Write("Nhap diem: ");
            if (int.TryParse(Console.ReadLine(), out int diem))
            {
                if (diem > 0)
                {
                    s[name] = diem;
                }
                else
                {
                    Console.WriteLine("Diem phai la 1 so duong.");
                }
            }
        }
        Console.WriteLine("Danh sach hoc sinh va diem: ");
        foreach (var st in s)
        {
            Console.WriteLine($"{st.Key} - {st.Value}");
        }
    }
}
