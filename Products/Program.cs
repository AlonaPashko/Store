using Store.Products;
using Store.Services;

HouseholdChemicals chemical1 = new HouseholdChemicals();
chemical1.Name = "Glass Cleaner";
chemical1.Price = 22.4;
Console.WriteLine(chemical1);
Console.WriteLine("----------------------------");

HouseholdChemicals chemical2 = new HouseholdChemicals();
chemical2.Name = "Dishwashing Liquid";
chemical2.Price = 11.4;

ArrivedProducts products1 = new ArrivedProducts();
products1.ArrivedGoods.Add(chemical1);
products1.ArrivedGoods.Add(chemical2);
Console.WriteLine(products1);
Console.WriteLine("----------------------------");

SoldedProducts products2 = new SoldedProducts();
products2.AddSoldProduct(chemical1);
products2.AddSoldProduct(chemical2);
Console.WriteLine(products2);
Console.WriteLine("----------------------------");

ExpiredProducts products3 = new ExpiredProducts();
products3.AddExpireProduct(chemical1);
products3.AddExpireProduct(chemical2);
Console.WriteLine(products3);
