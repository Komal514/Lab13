namespace Activity_01.Components.Models
{
    public class CitiesRepository
    {
        private static List<string> cities = new List<string>()
        {
            "Toronto",
           "Montreal",
           "Ottama",
           "Calgary",
           "Halifex"


        };
        public static List<string> GetCities() => cities;

    }
}
