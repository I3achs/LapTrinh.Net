using System.Net.NetworkInformation;

namespace KiemTra01
{
    internal class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public int Quantity { get; set; }
        public Product(string name, decimal price, string image, int quantity = 1)
        {
            Name = name;
            Price = price;
            Image = image;
            Quantity = 1;
        }
        public override bool Equals(object? obj)
        {
            if (obj is Product product)
            {
                return this.Name == product.Name && this.Price == product.Price;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Price);
        }
        public override string ToString()
        {
            return $"{Name}-{Price} VND (Số lượng: {Quantity}";
        }
    }
}