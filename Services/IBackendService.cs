using ParagonPioneerFe.Models;

namespace ParagonPioneerFe.Services;

public interface IBackendService
{
    Task<List<Good>> GetAllGoods();
    Task<Good> GetGood(int goodId);
    Task<List<Building>> GetAllBuildings();
    Task<Building> GetBuilding(int buildingId);
    Task<List<Population>> GetAllPopulations();
    Task<Population> GetPopulation(int populationId);
}