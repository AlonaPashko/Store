using Store.Interfaces;
using Store.Products;
using Store.Services;

//Storage storage1 = new Storage(@"..\\..\\..\\Files\\ListOfProducts.txt");
//Console.WriteLine(storage1);

Storage storage2 = new Storage();

DairyProducts dairyProducts1 = new DairyProducts("Milk", 0.96, DateTime.Now);
DairyProducts dairyProducts2 = new DairyProducts("Kefir", 1.45, new DateTime(2023, 03, 15));

storage2.Add(dairyProducts1);
storage2.Add(dairyProducts2);

Console.WriteLine("Days before " + dairyProducts2.Name + " spoilage: " 
    + dairyProducts2.CountDaysBeforeSpoilage().ToString());

Console.WriteLine("Days before " + dairyProducts1.Name + " spoilage: "
    + dairyProducts1.CountDaysBeforeSpoilage().ToString());

