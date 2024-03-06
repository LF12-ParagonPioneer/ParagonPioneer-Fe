using Microsoft.AspNetCore.Components;
using ParagonPioneerFe.Models;
using ParagonPioneerFe.Services;

namespace ParagonPioneerFe.Pages.Home.Tabs;

public partial class RecursiveRecipeTab
{
    [Parameter] public List<Good> Goods { get; set; } = [];
    // [Inject] public required IBackendService BackendService { get; set; }

    
    private double _productionRate;
    private Good? _selectedGood;
    
    private Recipe? _recipe = new()
    {
        Id = "B77BC074-7C0C-4EB5-A6D6-D9DF5EFECB30",
        Output = new Good
        {
            Id = "C824D1C0-8E1F-41D1-A59F-950FE482C53D",
            Name = "Bread"
        },
        QuantityOfGoods = 
        [
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
        ]
    };
}