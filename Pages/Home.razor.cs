using Microsoft.AspNetCore.Components;
using ParagonPioneerFe.Components.Diagram;
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

    private ProductionChainDiagram? _diagram;
    private Recipe? _recipe = new()
    {
        Id = "B77BC074-7C0C-4EB5-A6D6-D9DF5EFECB30",
        Output = new Good
        {
            Id = "C824D1C0-8E1F-41D1-A59F-950FE482C53D",
            Name = "Bread"
        },
        Inputs = new List<Input>
        {
            new()
            {
                Quantity = 1,
                Good = new Good
                {
                    Id = "624D29D9-BF4D-4448-8453-F6899C63A529",
                    Name = "Land Tile"
                }
            },
            new()
            {
                Quantity = 3,
                Good = new Good
                {
                    Id = "01EA552E-7E1E-4BDB-8D10-EAEE05A8626D",
                    Name = "Flour"
                }
            }
        }
    };

    protected override async Task OnInitializedAsync()
    {
        _goods = await BackendService.GetAllGoods();

    }
}