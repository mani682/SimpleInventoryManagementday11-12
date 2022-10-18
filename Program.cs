namespace InventoryManagement
{

    public class Program
    {
        static void Main(string[] args)
        {
            string filePath = "C:/Users/ishwa/source/repos/c#208/InventoryManagement/InventoryManagement/Inventory.json";
            // string filePath = "C:\\Users\\ishwa\\source\\repos\\c#208\\InventoryManagement\\InventoryManagement\\Inventory.json";
            FetchForJsonInventoryData fetchForJsonInventoryData = new FetchForJsonInventoryData();

            Inventory data = new Inventory();

            data = fetchForJsonInventoryData.Read(filePath);


            Console.WriteLine("Name : " + data.typeOfRice.name);
            Console.WriteLine("Weight : " + data.typeOfRice.weight);
            Console.WriteLine("Price : " + data.typeOfRice.price);
            Console.WriteLine("___________________________");


            Console.WriteLine("Name : " + data.typeOfPulses.name);
            Console.WriteLine("Weight : " + data.typeOfPulses.weight);
            Console.WriteLine("Price : " + data.typeOfPulses.price);
            Console.WriteLine("_____________________________");

            Console.WriteLine("Name : " + data.typeOfWheat.name);
            Console.WriteLine("Weight : " + data.typeOfWheat.weight);
            Console.WriteLine("Price : " + data.typeOfWheat.price);
            Console.WriteLine("_____________________________");
        }
    }


}

