namespace CSharp046.ReturnMultipleValues
{
    public static class FacilityDistanceCalculator
    {
        private static Random random = new Random();
        public static Location GetFacilityLocationInfoV1(string facilityName)
        {
            return new Location
            {
                Name = facilityName,
                DistanceInKm = random.NextDouble() * 10.0
            };
        }

        public static void GetFacilityLocationInfoV2(
            string facilityName, out string name, out double distanceInKm)
        {
            name = facilityName;
            distanceInKm = random.NextDouble() * 10.0;
        }
    }
}
