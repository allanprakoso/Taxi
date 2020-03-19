using System;


namespace Taxi
{
    public class Taxi
    {
        public string DriverName;
        public bool OnDuty;
        public int NumPassenger;

        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name :" + DriverName);
            if (OnDuty == true)
            {
                Console.WriteLine("On Duty: Yes");
            }
            else
            {
                Console.WriteLine("On Duty: No");
            }
            Console.WriteLine("Number of Passaenger: " + NumPassenger + Environment.NewLine);
        }

        public void PickUpPassanger()
        {
            Console.WriteLine(DriverName + " sedang menjemput penumpang");
        }
        public void DropOffPassanger()
        {
            Console.WriteLine(DriverName + " selesai mengantar penumpang");
        }

    }
}