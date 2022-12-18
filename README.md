# Store
It`s a store progect with system of interfaces:

- IProduct - has Name, Price and Producent properties,
- IPrint - has a method for printing,
- IExpressionReader - for the Reader class,
- IExpressionWriter - for the Writer class,
- IBuy,
- IExiceProducts (inherits IProduct, IPrint) - includes properties and methods relating to the licence, 
- IFragileProducts (inherits IProduct, IPrint) - includes Marking and Type properties, 
- IHazardousMaterial (inherits IProduct, IPrint) - includes properties relating to the substance class and unification number, 
- IPerishableProducts (inherits IProduct, IPrint) - includes methods of counting days before spoilage,
- IMovies (inherits IProduct, IPrint) - includes Genre and YearOfRelease properties.
 
Also project has a superclass Product (implements IProduct, IComparable, IPrint) and subclasses: 

- Meat - describes meat, 
- DairyProducts (implements IPerishableProducts) - describes dairy products, 
- HouseholdChemical - describes household chemical products.

Also project has classes: 

- Buy (implements IProduct) - show a purchase, 
- Check (implements IPrint) - can check a purchase,
- Storage - is a collection of Products.

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

The folder Diagrams has an interfaces diagram.