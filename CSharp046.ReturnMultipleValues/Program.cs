using CSharp046.ReturnMultipleValues;

namespace CSharp046.ConceptBehindTuple
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Using Class DS");
            var facilityName = FacilityDistanceCalculator.GetFacilityLocationInfoV1("Hospital");
            Console.WriteLine(facilityName);

            Console.WriteLine();
            Console.WriteLine("Using out Parameter");

            string name = "";
            double distanceInKm = 0;

            FacilityDistanceCalculator
                .GetFacilityLocationInfoV2("Hospital", out name, out distanceInKm);

            Console.WriteLine($"{name} ....... {distanceInKm.ToString("F2")} km");
            Console.ReadKey();
        }
    }
}