using System;
using Fluid;

namespace OrchardCore.Liquid
{
    public class LiquidTemplateContext : TemplateContext
    {
        public const int MaxShapeRecursions = 3;

        public LiquidTemplateContext(IServiceProvider services)
        {
            Services = services;
        }

        public IServiceProvider Services { get; }

        public bool IsInitialized { get; set; }

        public int ShapeRecursions { get; set; }
    }
}
