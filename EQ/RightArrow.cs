using LiveChartsCore.SkiaSharpView.Drawing;
using SkiaSharp;

namespace EQ
{
    public class RightArrow : LiveChartsCore.SkiaSharpView.Drawing.Geometries.SVGPathGeometry
    {
        public static SKPath svgPath = SKPath.ParseSvgPathData("M 312.499 228.831 L 149.193 310.484 L 149.193 147.178 L 312.499 228.831 Z");

        public RightArrow() : base(svgPath)
        {

        }
    }
}
