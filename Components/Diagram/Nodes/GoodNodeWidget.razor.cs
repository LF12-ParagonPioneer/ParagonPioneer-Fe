using Microsoft.AspNetCore.Components;

namespace ParagonPioneerFe.Components.Diagram.Nodes;

public partial class GoodNodeWidget
{
    [Parameter] public required GoodNode Node { get; set; }

    private string GetImagePath() => $"assets/goods/{Node.Good.Name.Replace(" ", "_")}.webp";
}