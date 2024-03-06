using ParagonPioneerFe.Models;

namespace ParagonPioneerFe.Services;

public interface IBackendService
{
    Task<List<Good>> GetAllGoods();
    Task<Good?> GetGood(string goodId);
    Task<Recipe?> GetRecipe(string goodId);
    Task<List<Building>> GetAllBuildings();
    Task<Building?> GetBuilding(int buildingId);
    Task<List<Population>> GetAllPopulations();
    Task<Population?> GetPopulation(int populationId);
}