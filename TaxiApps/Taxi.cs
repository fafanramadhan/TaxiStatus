//membuat objek taksi
namespace TaxiApps
{
    public class Taxi
    {
        //membuat properti
        public string Name { get; set; }
        public bool Status { get; set; }
        public int Passenger { get; set; }
        


        //membuat method
        public void TaxiInfo()
        {
            Console.WriteLine("--- Driver Status ---");
            Console.WriteLine("Driver Name : {0}", Name);
            
        }

        public void PickUpPassenger()
        {
            if (Status == true)
            {
                Console.WriteLine("{0} Picking up passenger", Name);
            }
            else
            {
                Console.WriteLine("{0} Laying down on his bed at home", Name);
            }

            
        }

        public void DropOffPassenger()
        {
            if (Passenger == 0)
            {
                Console.WriteLine("{0} Dropping off passenger", Name);
            }
            else
            {
                Console.WriteLine("{0} Transporting passengers to their destination", Name);
            }
            
        }

    }
}