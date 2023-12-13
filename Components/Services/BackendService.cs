using Newtonsoft.Json;
using ParagonPioneerFe.Components.Models;

namespace ParagonPioneerFe.Components.Services;

public class BackendService(HttpClient httpClient) : IBackendService
{
    public async Task<List<Good>> GetAllGoods()
    {
        var result = await httpClient.GetStringAsync(ApiRoutes.GetAllGoods);
        
        return JsonConvert.DeserializeObject<List<Good>>(result)!;
    }

    public async Task<Good> GetGood(int goodId)
    {
        var result = await httpClient.GetStringAsync(ApiRoutes.GetGood(goodId));

        return JsonConvert.DeserializeObject<Good>(result)!;
    }

    public async Task<List<Building>> GetAllBuildings()
    {
        var result = await httpClient.GetStringAsync(ApiRoutes.GetAllBuildings);

        return JsonConvert.DeserializeObject<List<Building>>(result)!;
    }

    public async Task<Building> GetBuilding(int buildingId)
    {
        var result = await httpClient.GetStringAsync(ApiRoutes.GetGood(buildingId));

        return JsonConvert.DeserializeObject<Building>(result)!;
    }

    public async Task<List<Population>> GetAllPopulations()
    {
        var result = await httpClient.GetStringAsync(ApiRoutes.GetAllPopulations);

        return JsonConvert.DeserializeObject<List<Population>>(result)!;
    }

    public async Task<Population> GetPopulation(int populationId)
    {
        var result = await httpClient.GetStringAsync(ApiRoutes.GetGood(populationId));

        return JsonConvert.DeserializeObject<Population>(result)!;
    }
}