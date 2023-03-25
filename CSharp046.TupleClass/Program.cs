namespace CSharp046.TupleClass
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Get FacilityInfo using Tuple.Create");

            var facilityInfo = FacilityDistanceCalculator.CalculateFacilityDistance("Hospital");

            Console.WriteLine(facilityInfo);

            Console.WriteLine("Get FacilityInfo using Tuple Constructor");

            var facilityInfoV2 = FacilityDistanceCalculator.CalculateFacilityDistanceV2("Hospital");

            Console.WriteLine(facilityInfoV2);

            Console.WriteLine("Get FacilityInfo using Tuple.Create / Access Item");

            var facilityInfoV3 = FacilityDistanceCalculator.CalculateFacilityDistanceV3("Hospital");
            Console.WriteLine($"{facilityInfoV3.Item1} ....... {facilityInfoV3.Item2.ToString("F2")} km");

            // Equality

            var t1 = Tuple.Create("hospial1", 2.5);
            var t2 = Tuple.Create("hospial1", 2.5);

            Console.WriteLine(t1.Equals(t2));

            Console.ReadKey();
        }
    }
}