string productName;
string productParkod;
decimal productCost;
decimal productsalePrice;
decimal Total;
int Quantity = 0;
const double Product_Tax = 0.10;
decimal descount = 0m;
do
{
    Console.WriteLine("Please Enter The Product Name : ");
    productName = Console.ReadLine();
}
while (string.IsNullOrWhiteSpace(productName));

do
{
    Console.WriteLine("Please Enter The Product Parkod : ");
    productParkod = Console.ReadLine();
}
while (string.IsNullOrWhiteSpace(productParkod));

do
{
    Console.WriteLine("Please Enter The Product Cost : ");
}
while (!decimal.TryParse(Console.ReadLine(), out productCost));

do
{
    Console.WriteLine("Please Enter The Product Sale Price : ");
}
while (!decimal.TryParse(Console.ReadLine(), out productsalePrice) || productsalePrice < 0);

do
{
    Console.WriteLine("Please Enter The Product  Quantity : ");
}
while (!int.TryParse(Console.ReadLine(), out Quantity));


if (productsalePrice > 100)
{
    descount = productsalePrice * 15 / 100;

}
else if (productsalePrice < 100 && productsalePrice > 50)
{
    descount = productsalePrice * 15 / 100;
}

Console.WriteLine("==============The Bill===============");
Console.WriteLine($"The product name :\t\t{productName}");
Console.WriteLine($"The product Parkode :\t\t{productParkod}");
Console.WriteLine($"The product price:\t\t{productsalePrice}");
Console.WriteLine($"The products quantity:\t\t{Quantity}");
Console.WriteLine($"The products price:\t\t{Quantity * productsalePrice}");
Console.WriteLine($"The 1 product  descount :\t {descount}");
Total = (productsalePrice - descount) * Quantity;
Console.WriteLine($"The total After descount:\t {Total}");
Console.WriteLine($"The 1 product tax :\t\t{Product_Tax}");
Total = Total + (productsalePrice * Convert.ToDecimal(Product_Tax) * Quantity);
Console.WriteLine($"The total After tax:\t\t{Total}");
Total = (productsalePrice - descount + (productsalePrice * Convert.ToDecimal(Product_Tax))) * Quantity;
Console.WriteLine($"THE FINAL AMOUNT is :\t\t{Total}");



Console.WriteLine("Please enter product count ?");
int counter = int.Parse(Console.ReadLine());
string[] product = new string[counter];
double[] price = new double[counter];
double total = 0;
for (int i = 0; i < product.Length; i++)
{
    Console.WriteLine("Please enter product name ?");
    product[i] = Console.ReadLine();
    Console.WriteLine("Please enter product price ?");
    price[i] = int.Parse(Console.ReadLine());
    total += price[i];
}

for (int i = 0; i < product.Length; i++)
{
    Console.WriteLine($"Name : {product[i]} price : {price[i]}");


}
Console.WriteLine($"Total is {total}");
