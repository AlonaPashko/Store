# Store

It`s a store progect with base class Product and subclasses Meat, DairyProducts. Also there is a HouseholdChemical class. 
Class Product implements the interface IComparable for comparation objects.

Also project has a classes Buy, Check, CheckDecor and Storage which perform the functions implied in the name.

The folder Interfaces has an interfaces: IViewerBuy, IPrint (IPrint inherits IViewerBuy), IExiceGoods (includes properties and methods
relating to the licence), IFragileGoods (includes Marking and Type properties), IHazardousMaterial (includes properties relating 
to the substance class and unification number), IPerishableProducts (includes methods of counting days before spoilage).

The folder Enums has a two enums: Category (for the distribution of products by varieties), and TypeMeat (especially for Meat class).

The folder FileOperations has a FileReader class for reading information from a file.

The folder Services has a CompareByPrice, StorageComparer, ArrivedProducts, SoldedProducts, ExpiredProducts classes, each of which 
performs its specific tasks.

The folder Exceptions has exception classes and ExceptionHandler.