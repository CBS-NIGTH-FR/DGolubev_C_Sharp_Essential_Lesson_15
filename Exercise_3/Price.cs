using System;

namespace Exercise_3
{
    struct Price
    {
        string product_name;
        string store_name;
        double product_price;
        public string ProductName => product_name;
        public string StoreName => store_name;
        public double ProductPrice => product_price;

        public Price(string product_name, string store_name, double product_price)
        {
            this.product_name = product_name;
            this.store_name = store_name;
            this.product_price = product_price;
        }
        public override string ToString()
        {
            return $"Магазин - {store_name}\nТовар - {product_name}\nЦена - {product_price} UAH";
        }
    }
}
