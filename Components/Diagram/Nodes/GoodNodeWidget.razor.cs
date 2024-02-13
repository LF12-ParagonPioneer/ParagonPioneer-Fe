using Microsoft.AspNetCore.Components;

namespace ParagonPioneerFe.Components.Diagram.Nodes;

public partial class GoodNodeWidget
{
    [Parameter] public GoodNode Node { get; set; } = null!;
}