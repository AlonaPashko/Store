# Store

It`s a store progect with base class Product and subclasses Meat, DairyProducts. Also there is a HouseholdChemical class. Class Product implements the interface IComparable for comparation objects.

Also project has a classes Buy, Check, CheckDecor and Storage which perform the functions implied in the name.

The folder Interfaces has a two customer interfaces: IViewerBuy and IPrint, and IPrint inherits IViewerBuy.

The folder Enums has a two enums: Category (for the distribution of products by varieties), and TypeMeat (especially for Meat class).

The folder FileOperations has a FileReader class for reading information from a file.

The folder Services has a CompareByPrice, ExceptionHandler and StorageComparer classes, each of which performs its specific tasks.