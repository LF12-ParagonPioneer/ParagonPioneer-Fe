using Blazor.Diagrams;
using Blazor.Diagrams.Core.Anchors;
using Blazor.Diagrams.Core.Geometry;
using Blazor.Diagrams.Core.Layers;
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
        
        [Parameter]
        public EventCallback<Recipe?> RecipeChanged { get; set; }

        private BlazorDiagram Diagram { get; set; } = null!;

        protected override void OnInitialized()
        {
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
        }

        protected override void OnParametersSet()
        {
            Diagram.Links.Clear();
            Diagram.Nodes.Clear();
            
            if (Recipe is null) return;
            
            var outputNode = Diagram.Nodes.Add(new GoodNode(good: Recipe.Output, quantity: 1, position: new Point(500, 100)));

            var inputY = 20;
            foreach (var input in Recipe.QuantityOfGoods)
            {
                if (input.Good is null) continue;
                
                var inputNode = Diagram.Nodes.Add(new GoodNode(good: input.Good, quantity: input.Quantity, position: new Point(50, inputY))
                {
                    Good = input.Good,
                    Quantity = input.Quantity
                });
                
                var link = Diagram.Links.Add(new LinkModel(inputNode, outputNode));
                link.TargetMarker = LinkMarker.Arrow;

                inputY += 150;
            }

            // ReSharper disable once PossibleLossOfFraction
            Diagram.Nodes[0].SetPosition(500, 20 + 150 * (Diagram.Nodes.Count - 2) / 2);
        }
    }
}
