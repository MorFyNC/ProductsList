using Class;
using Newtonsoft.Json;

Product milk = ProductFabric.Create("80 рублей", "1 литр", "Простоквашино", 1000, true);
Product bread = ProductFabric.Create("40 рублей", "1 буханка", "БКК", 300, false);
Product crisps = ProductFabric.Create("90 рублей", "1 пачка", "Lays", 100, false);
Product soap = ProductFabric.Create("20 рублей", "1 кусок", "Avon", 150, false);
Product sausage = ProductFabric.Create("250 рублей", "20 штук/1 связка", "Папа может", 1500, false);
Product water = ProductFabric.Create("35 рублей", "1 литр", "Святой источник", 1000, true);
Product spoon = ProductFabric.Create("200 рублей", "5 штук/1 набор", "Амет", 200, false);
Product notebook = ProductFabric.Create("40 рублей", "1 шт/96 листов", "Каждый день", 50, false);
Product pen = ProductFabric.Create("10 рублей", "1 шт", "BIC", 50, false);
Product hat = ProductFabric.Create("2000 рублей", "1 шт", "GUCCI", 250, false);

List<Product> products = new List<Product>() { milk, bread, crisps, soap, sausage, water, spoon, notebook, pen, hat };
Console.WriteLine("\tОбычный список");
Print(jsonConvert(products));
Console.WriteLine();
Console.WriteLine("\tОтсортированный по весу список:");
SortByWeigth(products);

List<string> jsonConvert(List<Product> products)
{
    List<string> list = new List<string>();
    foreach (Product product in products)
    {
        string json = JsonConvert.SerializeObject(product);
        list.Add(json);
    }
    return list;
}

void Print(List<string> list)
{
    foreach (string item in list)
    {
        Console.WriteLine(item);
    }
}

void SortByWeigth(List<Product> products)
{
    for (int j = 0; j < products.Count; j++)
    {
        for (int i = 0; i < products.Count; i++)
        {
            if (i < 9 && products[i].weight < products[i + 1].weight)
            {
                var temp = products[i];
                products[i] = products[i + 1];
                products[i + 1] = temp;
            }
        }
    }
    Print(jsonConvert(products));
}