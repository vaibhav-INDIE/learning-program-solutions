using E_commerce_Platform_Search_Function;

Product[] products = new Product[]
            {
                new Product(1, "Laptop", "Electronics"),
                new Product(2, "Shoes", "Fashion"),
                new Product(3, "Watch", "Accessories"),
                new Product(4, "Camera", "Electronics"),
                new Product(5, "Shirt", "Fashion")
            };

Console.WriteLine("== Linear Search ==");
var foundLinear = Search.LinearSearch(products, "Camera");
Console.WriteLine(foundLinear != null ? foundLinear.ToString() : "Not Found");

// Sort for binary search
var sortedProducts = products.OrderBy(p => p.ProductName).ToArray();

Console.WriteLine("\n== Binary Search ==");
var foundBinary = Search.BinarySearch(sortedProducts, "Camera");
Console.WriteLine(foundBinary != null ? foundBinary.ToString() : "Not Found");
        