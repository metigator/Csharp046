namespace CSharp046.ValueTuples
{
    public static class FacilityDistanceCalculator
    {
        private static Random random = new Random();

        // ValueTuple.Create 
        public static ValueTuple<string, string> CalculateFacilityDistance(string facilityName)
        {
            return ValueTuple.Create(facilityName, $"{(random.NextDouble() * 10.0).ToString("F2")} km");
        }

        // Implicit Names
        public static (string, string) CalculateFacilityDistanceV2(string facilityName)
        {
            return ValueTuple.Create(facilityName, $"{(random.NextDouble() * 10.0).ToString("F2")} km");
        }

        // Explicit Names
        public static (string Name, string distanceInKm) CalculateFacilityDistanceV3(string facilityName)
        {
            return ValueTuple.Create(facilityName, $"{(random.NextDouble() * 10.0).ToString("F2")} km");
        }
    }
}
