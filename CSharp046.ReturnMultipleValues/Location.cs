namespace CSharp046.ReturnMultipleValues
{
    public class Location
    {
        public string Name { get; set; }
        public double DistanceInKm { get; set; }

        public override string ToString()
        {
            return $"{Name} ....... {DistanceInKm.ToString("F2")} km";
        }
    }
}
