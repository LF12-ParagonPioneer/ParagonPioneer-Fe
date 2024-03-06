using Microsoft.AspNetCore.Components;
using ParagonPioneerFe.Models;
using ParagonPioneerFe.Services;

namespace ParagonPioneerFe.Pages.Home.Tabs;

public partial class SimpleRecipeTab
{
    [Parameter] public List<Good> Goods { get; set; } = [];
    [Inject] public required IBackendService BackendService { get; set; }

    private Recipe? _recipe;

    private async Task GetRecipe(Good good)
    {
        _recipe = await BackendService.GetRecipe(good.Id);
    }
}