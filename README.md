# Store

It`s a store progect with base class Product and subclasses: 

- Meat - describes meat, 
- DairyProducts - describes dairy products, 
- HouseholdChemical - describes household chemical products.

Class Product implements the interface IComparable for comparation objects.

Also project has classes: 

- Buy - can parse a string, show a purchase, 
- Check (implemented IPrint) - can check a purchase,
- Storage - is a collection of Products.

The folder Interfaces has interfaces: 

- IViewerBuy - has a method for showing the class Buy,
- IPrint (inherits IViewerBuy) - has a method for printing the purchase,
- IExpressionReader - for the Reader class,
- IExpressionWriter - for the Writer class,
- IExiceProducts - includes properties and methods relating to the licence, 
- IFragileProducts - includes Marking and Type properties, 
- IHazardousMaterial - includes properties relating to the substance class and unification number, 
- IPerishableProducts - includes methods of counting days before spoilage.

The folder Enums has enums: 

- Category - for the distribution of products by varieties,
- TypeMeat - especially for Meat class.

The folder FileOperations has classes: 

- FileReader - for reading information from a file,
- FileWriter - for writing information to a file.

The folder Services has classes:

- CompareByPrice - for compare products by price, 
- StorageComparer - for comparare storages, 
- ArrivedProducts - is a collection of Products, which was arrived to the Storage, 
- SoldedProducts - is a collection of Products, which was solded from the Storage, 
- ExpiredProducts - is a collection of Products on the Storage, which expiration date has expired.

The folder Exceptions has classes:

- DefectiveProductException - throw exception when the Product isn't normal,
- ExceptionHandler - for the manage exceptions,
- ExpirationDateException - throw exception when the Product is exipired,
- NoAvailableException - throw exception, when the Product doesn't exist.