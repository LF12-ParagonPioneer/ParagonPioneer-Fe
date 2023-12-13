using Microsoft.AspNetCore.Components;
using ParagonPioneerFe.Components.Models;
using ParagonPioneerFe.Components.Services;

namespace ParagonPioneerFe.Components.Pages;

public partial class Home
{
    private double _productionRate;
    private Good? _selectedGood;

    private List<Good> _goods = new();

    [Inject]
    public IBackendService BackendService { get; set; } = default!;

    protected override async Task OnInitializedAsync()
    {
        _goods = await BackendService.GetAllGoods();
    }
}