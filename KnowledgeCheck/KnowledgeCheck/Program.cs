Console.WriteLine("How many records do you want to add? ");
        var numberOfRecords = int.Parse(Console.ReadLine());

        var recordList = new List<CatFood>(); 

        for (int i = 0; i < numberOfRecords; i++)
        {
            var catFood = new CatFood(); 

            Console.WriteLine("Enter the value for Price: ");
            catFood.Price = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value for Name: ");
            catFood.Name = Console.ReadLine();

            Console.WriteLine("Enter the value for Quantity: ");
            catFood.Quantity = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value for Description: ");
            catFood.Description = Console.ReadLine();

            recordList.Add(catFood);
        }

        // Print out the list of records
        foreach (var catFood in recordList)
        {
            Console.WriteLine(catFood.ToString());
        }
class Product
{
    public double Price { get; set; }
    public string Name { get; set; }
    public int Quantity { get; set; }
    public string Description { get; set; }
}
class CatFood : Product
{
    // This would be properties that are specific to cat food if that was necessary
}
