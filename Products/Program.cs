using Store.Enums;
using Store.FileOperation;
using Store.Interfaces;
using Store.Products;
using Store.Services;

//Storage storage1 = new Storage(@"..\\..\\..\\Files\\ListOfProducts.txt");
//Console.WriteLine(storage1);

DairyProducts dairyProd1 = new DairyProducts("Milk", 10.2, new DateTime (2023, 03, 28));
DairyProducts dairyProd2 = new DairyProducts("Kefir", 11.6, new DateTime(2023, 04, 13));
DairyProducts dairyProd3 = new DairyProducts("Jogurt", 12.3, new DateTime(2023, 03, 12));

HouseholdChemicals chem1 = new HouseholdChemicals("Detergent", 2.3, AggregateState.Powder);
HouseholdChemicals chem2 = new HouseholdChemicals("Dish soap", 2.5, AggregateState.Liquid);

Storage stor1 = new Storage();
stor1.AddingFreshProducts += storage_AddProd;

stor1.Add(dairyProd1);
stor1.Add(dairyProd2);
stor1.Add(dairyProd3);

stor1.Add(chem1);
stor1.Add(chem2);

void storage_AddProd(object sender, EventArgs e)
{
    Console.WriteLine("Alert! It's an expire product!");
}

Console.WriteLine(Finder.FindProduct(stor1.Products, "dish soap"));
Console.WriteLine(stor1);