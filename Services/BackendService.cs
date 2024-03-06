using Newtonsoft.Json;
using ParagonPioneerFe.Models;
using ParagonPioneerFe.Services.Models;

namespace ParagonPioneerFe.Services;

public class BackendService(HttpClient httpClient) : IBackendService
{
    public async Task<List<Good>> GetAllGoods()
    {
        var result = await httpClient.GetStringAsync(ApiRoutes.GetAllGoods);
        
        return JsonConvert.DeserializeObject<Paged<Good>>(result)?.Content ?? [];
    }

    public async Task<Good?> GetGood(string goodId)
    {
        var result = await httpClient.GetStringAsync(ApiRoutes.GetGood(goodId));

        return JsonConvert.DeserializeObject<Paged<Good>>(result)?.Content.SingleOrDefault();
    }

    public async Task<Recipe?> GetRecipe(string goodId)
    {
        var result = await httpClient.GetStringAsync(ApiRoutes.GetRecipe(goodId));

        return JsonConvert.DeserializeObject<Recipe>(result);
    }

    public async Task<List<Building>> GetAllBuildings()
    {
        var result = await httpClient.GetStringAsync(ApiRoutes.GetAllBuildings);

        return JsonConvert.DeserializeObject<Paged<Building>>(result)?.Content ?? [];
    }

    public async Task<Building?> GetBuilding(int buildingId)
    {
        var result = await httpClient.GetStringAsync(ApiRoutes.GetBuilding(buildingId));

        return JsonConvert.DeserializeObject<Paged<Building>>(result)?.Content.SingleOrDefault();
    }

    public async Task<List<Population>> GetAllPopulations()
    {
        var result = await httpClient.GetStringAsync(ApiRoutes.GetAllPopulations);

        return JsonConvert.DeserializeObject<Paged<Population>>(result)?.Content ?? [];
    }

    public async Task<Population?> GetPopulation(int populationId)
    {
        var result = await httpClient.GetStringAsync(ApiRoutes.GetPopulation(populationId));

        return JsonConvert.DeserializeObject<Paged<Population>>(result)?.Content.SingleOrDefault();
    }
}