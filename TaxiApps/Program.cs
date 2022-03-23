//membuat objek taksi
using TaxiApps;

Taxi taksi1 = new Taxi();

//pengesetan nilai properties
taksi1.Name = "John";
taksi1.Status = true;
taksi1.Passenger = 3;

//pemanggilan method
taksi1.TaxiInfo();
taksi1.PickUpPassenger();
taksi1.DropOffPassenger();

Console.ReadKey();



