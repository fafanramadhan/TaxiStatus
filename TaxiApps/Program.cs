//membuat objek taksi
using TaxiApps;


Taxi taksi1 = new Taxi();
Console.WriteLine("--- Driver Info ---");
Console.Write("Input Driver Name: ");
taksi1.Name = Console.ReadLine();
Console.Write("Input On Duty(Yes/No): ");
taksi1.Status = Console.ReadLine().ToLower() == "yes" ? true : false;


if (taksi1.Status)
{
    Console.Write("Number of Passanger: ");
    taksi1.Passenger = Convert.ToInt32(Console.ReadLine());
    
    Console.Clear();
    taksi1.TaxiInfo();
    taksi1.PickUpPassenger();
    taksi1.DropOffPassenger();

    Console.ReadKey();
}
else
{
    Console.Clear();
    taksi1.TaxiInfo();
    taksi1.PickUpPassenger();
    taksi1.DropOffPassenger();

    Console.ReadKey(); 
}




 
