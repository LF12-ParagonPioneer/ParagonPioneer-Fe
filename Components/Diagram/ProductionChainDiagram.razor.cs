using Blazor.Diagrams;
using Blazor.Diagrams.Core.Anchors;
using Blazor.Diagrams.Core.Geometry;
using Blazor.Diagrams.Core.Models;
using Blazor.Diagrams.Core.PathGenerators;
using Blazor.Diagrams.Core.Routers;
using Blazor.Diagrams.Options;
using Microsoft.AspNetCore.Components;
using ParagonPioneerFe.Components.Diagram.Nodes;
using ParagonPioneerFe.Models;

namespace ParagonPioneerFe.Components.Diagram
{
    public partial class ProductionChainDiagram
    {
        [Parameter]
        public Recipe? Recipe { get; set; }
        
        private BlazorDiagram Diagram { get; set; } = new();

        protected override void OnInitialized()
        {
            base.OnInitialized();
            
            var options = new BlazorDiagramOptions
            {
                AllowMultiSelection = true,
                Zoom =
                {
                    Enabled = false,
                },
                Links =
                {
                    DefaultRouter = new NormalRouter(),
                    DefaultPathGenerator = new SmoothPathGenerator()
                },
            };

            Diagram = new BlazorDiagram(options);
            Diagram.RegisterComponent<GoodNode, GoodNodeWidget>();
            if (Recipe is null) return;
            
            var outputNode = Diagram.Nodes.Add(new GoodNode(good: Recipe.Output, quantity: 1, position: new Point(200, 100)));

            foreach (var input in Recipe.Inputs)
            {
                var inputNode = Diagram.Nodes.Add(new GoodNode(good: input.Good, quantity: input.Quantity, position: new Point(50, 50))
                {
                    Good = input.Good,
                    Quantity = input.Quantity
                });
                
                var link = Diagram.Links.Add(new LinkModel(inputNode, outputNode));
                link.TargetMarker = LinkMarker.Arrow;
            }
        }
    }
}
