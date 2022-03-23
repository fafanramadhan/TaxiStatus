//membuat objek taksi
using TaxiApps;
string Dname;

Console.WriteLine("Input Driver Name: ");
Dname = Console.ReadLine();

Taxi taksi1 = new Taxi();

//pengesetan nilai properties
taksi1.Name = Dname;
taksi1.Status = true;
taksi1.Passenger = 3;

//pemanggilan method
Console.Clear();
taksi1.TaxiInfo();
taksi1.PickUpPassenger();
taksi1.DropOffPassenger();

Console.ReadKey();



