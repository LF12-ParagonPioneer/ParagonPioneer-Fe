using Microsoft.AspNetCore.Components;
using ParagonPioneerFe.Models;
using ParagonPioneerFe.Services;

namespace ParagonPioneerFe.Pages;

public partial class Home
{
    private double _productionRate;
    private Good? _selectedGood;

    private List<Good> _goods = new();

    [Inject]
    public required IBackendService BackendService { get; set; }

    protected override async Task OnInitializedAsync()
    {
        _goods = await BackendService.GetAllGoods();
    }
}