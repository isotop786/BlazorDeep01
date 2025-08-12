namespace BlazorDeep01.Models
{
    public class CityRepository
    {
        private static List<string> cities = new List<string>()
        {
            "Toronto",
            "Halifax",
            "Montreal",
            "Ottawa",
            "Calgary"
        };

        public static List<string> GetCities() => cities;
    }
}
