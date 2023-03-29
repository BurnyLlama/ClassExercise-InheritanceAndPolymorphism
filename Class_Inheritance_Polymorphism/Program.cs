namespace Class_Inheritance_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle myVolvo = new Volvo();
            myVolvo.ShowPassengers();
            myVolvo.Accelerate();
            myVolvo.Accelerate();
            myVolvo.HonkHorn();
            myVolvo.Decelerate();
            myVolvo.Accelerate();
            Console.WriteLine();

            Vehicle myBMW = new BMW();
            myBMW.ShowPassengers();
            myBMW.Accelerate();
            myBMW.Accelerate();
            myBMW.HonkHorn();
            myBMW.Decelerate();
            myBMW.Accelerate();
            Console.WriteLine();


            Vehicle myHarleyDavidson = new HarleyDavidson();
            myHarleyDavidson.ShowPassengers();
            myHarleyDavidson.Accelerate();
            myHarleyDavidson.Accelerate();
            myHarleyDavidson.HonkHorn();
            myHarleyDavidson.Decelerate();
            myHarleyDavidson.Accelerate();
            Console.WriteLine();

            Vehicle myHonda = new Honda();
            myHonda.ShowPassengers();
            myHonda.Accelerate();
            myHonda.Accelerate();
            myHonda.HonkHorn();
            myHonda.Decelerate();
            myHonda.Accelerate();
            Console.WriteLine();

            Garage myGarage = new Garage(4);
            myGarage.ParkVehicle(myVolvo);
            myGarage.ParkVehicle(myBMW);
            myGarage.ParkVehicle(myHarleyDavidson);
            myGarage.ParkVehicle(myHonda);
            Console.WriteLine();

            myGarage.ListParkedVehicles();

            myGarage.GetVehicle(3);
            myGarage.ListParkedVehicles();

            myGarage.GetVehicle(1);
            myGarage.ListParkedVehicles();

            // Test name generation:
            //while (true)
            //{
            //    Console.Clear();
            //    for (int i = 0; i < 15; i++)
            //    {
            //        string name = IdentityGenerator.WholeName();
            //        Console.WriteLine(name);
            //    }
            //    Console.ReadKey();
            //}
        }
    }
}