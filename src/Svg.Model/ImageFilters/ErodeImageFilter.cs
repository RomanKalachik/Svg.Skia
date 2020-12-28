﻿
using Svg.Model.Painting;

namespace Svg.Model.ImageFilters
{
    public sealed class ErodeImageFilter : ImageFilter
    {
        public int RadiusX { get; set; }
        public int RadiusY { get; set; }
        public ImageFilter? Input { get; set; }
        public CropRect? CropRect { get; set; }
    }
}
