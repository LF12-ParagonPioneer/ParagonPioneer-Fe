using Microsoft.AspNetCore.Components;

namespace ParagonPioneerFe.Components.Diagram.Nodes;

public partial class GoodNodeWidget
{
    [Parameter] public required GoodNode Node { get; set; }
}