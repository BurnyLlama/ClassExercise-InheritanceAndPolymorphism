namespace Class_Inheritance_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle myVolvo = new Volvo();
            myVolvo.Accelerate();
            myVolvo.Accelerate();
            myVolvo.HonkHorn();
            myVolvo.Decelerate();
            myVolvo.Accelerate();
            Console.WriteLine();

            Vehicle myBMW = new BMW();
            myBMW.Accelerate();
            myBMW.Accelerate();
            myBMW.HonkHorn();
            myBMW.Decelerate();
            myBMW.Accelerate();
            Console.WriteLine();


            Vehicle myHarleyDavidson = new HarleyDavidson();
            myHarleyDavidson.Accelerate();
            myHarleyDavidson.Accelerate();
            myHarleyDavidson.HonkHorn();
            myHarleyDavidson.Decelerate();
            myHarleyDavidson.Accelerate();
            Console.WriteLine();

            Vehicle myHonda = new Honda();
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
        }
    }
}