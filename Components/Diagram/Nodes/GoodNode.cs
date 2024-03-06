using Blazor.Diagrams.Core.Geometry;
using Blazor.Diagrams.Core.Models;
using ParagonPioneerFe.Models;

namespace ParagonPioneerFe.Components.Diagram.Nodes;

public class GoodNode : NodeModel
{
    public GoodNode(Good good, int quantity, Point? position = null) : base(position)
    {
        Good = good;
        Quantity = quantity;
    }
    
    public Good Good { get; set; }
    public int Quantity { get; set; }
}