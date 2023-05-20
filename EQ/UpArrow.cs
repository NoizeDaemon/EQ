using LiveChartsCore.SkiaSharpView.Drawing;
using SkiaSharp;

namespace EQ
{
    public class UpArrow : LiveChartsCore.SkiaSharpView.Drawing.Geometries.SVGPathGeometry
    {
        public static SKPath svgPath = SKPath.ParseSvgPathData(
        "M 230.846 147.178 L 312.499 310.484 L 149.193 310.484 L 230.846 147.178 Z");

        public UpArrow() : base(svgPath)
        { }
    }
}
