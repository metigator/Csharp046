namespace CSharp046.ValueTuples
{
    class Program
    {
        static void Main()
        {
            Tuple<string, double> t1 = new Tuple<string, double>("Hospital", 2.4);
            Console.WriteLine($"t1: {t1}");

            ValueTuple<string, double> t2 = new ValueTuple<string, double>("Hospital", 2.4);
            Console.WriteLine($"t2: {t2}");

            var t3 = FacilityDistanceCalculator.CalculateFacilityDistance("Hospital");
            Console.WriteLine($"t3: {t3}");

            // Access Implicit Name
            var t4 = FacilityDistanceCalculator.CalculateFacilityDistanceV2("Hospital");
            Console.WriteLine($"t4: {t4}");
            Console.WriteLine($"FacilityName: {t4.Item1}");

            // Access Explicit name
            var t5 = FacilityDistanceCalculator.CalculateFacilityDistanceV3("Hospital");
            Console.WriteLine($"t5: {t5.Name}");
            Console.WriteLine($"t5: {t5.distanceInKm}");

            // Deconstructing of Tuple
            (string nm, string ds) = t5;

            Console.WriteLine($"name: {nm}");
            Console.WriteLine($"distance: {ds} km");
        }
    }
}