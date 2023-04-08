using Store.FileOperation;
using Store.Interfaces;
using Store.Products;
using Store.Services;

//Storage storage1 = new Storage(@"..\\..\\..\\Files\\ListOfProducts.txt");
//Console.WriteLine(storage1);

DairyProducts dairyProd1 = new DairyProducts("Milk", 10.2, new DateTime (2023, 03, 28));
DairyProducts dairyProd2 = new DairyProducts("Kefir", 11.6, new DateTime(2023, 04, 13));

Storage stor1 = new Storage();
stor1.AddingFreshProducts += storage_AddProd;

stor1.Add(dairyProd1);
stor1.Add(dairyProd2);

void storage_AddProd(object sender, EventArgs e)
{
    Console.WriteLine("Alert! It's an expire product!");
}

Console.WriteLine(stor1);