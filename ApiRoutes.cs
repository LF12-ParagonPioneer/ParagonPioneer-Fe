namespace ParagonPioneerFe;

public static class ApiRoutes
{
    public const string BaseUri = "http://localhost:8080/api/v1/";
    public const string GetAllGoods = BaseUri + "good";
    public const string GetAllBuildings = BaseUri + "building";
    public const string GetAllPopulations = BaseUri + "population";
    public static string GetGood(int id) => GetAllGoods + "/" + id;
    public static string GetBuilding(int id) => GetAllBuildings + "/" + id;
    public static string GetPopulation(int id) => GetAllPopulations + "/" + id;
}