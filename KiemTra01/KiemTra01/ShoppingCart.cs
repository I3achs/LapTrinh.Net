namespace KiemTra01
{
    internal class ShoppingCart
    {
        private Dictionary<Product, int> pr;
        public ShoppingCart()
        {
            pr = new Dictionary<Product, int>();
        }
        public void Add(Product product)
        {
            if (pr.ContainsKey(product))
            {
                pr[product] ++;
            }
            else
            {
                pr.Add(product, 1);
            }
        }
        public void Remove(Product product)
        {
            if (pr.ContainsKey(product))
            {
                pr.Remove(product);
            }
        }
        public decimal TotalPrice()
        {
            return pr.Sum(p => p.Key.Price * p.Value);
        }
        public Dictionary<Product, int> GetProduct()
        {
            return pr;
        }
        public void Clear()
        {
            pr.Clear();
        }
    }
}