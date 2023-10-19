using System.Numerics;

namespace Class
{
    class Product
    {
        public string cost;
        public string size;
        public string name;
        public int weight;
        public bool fragility;

        public Product(string cost, string size, string name, int weight, bool fragility)
        {
            this.cost = cost;
            this.size = size;
            this.name = name;
            this.weight = weight;
            this.fragility = fragility;
        }
    }

    static class ProductFabric
    {
        public static Product Create(string cost, string size, string name, int weight, bool fragility)
        {
            return new Product(cost, size, name, weight, fragility);
        }

    }
}
