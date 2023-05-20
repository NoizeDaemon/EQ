using LiveChartsCore.SkiaSharpView.Drawing;
using SkiaSharp;

namespace EQ
{
    public class IndicatorHorizontal : LiveChartsCore.SkiaSharpView.Drawing.Geometries.SVGPathGeometry
    {
        public static SKPath svgPath = SKPath.ParseSvgPathData(
        "M 295.364 330.645 L 295.364 341.734 L 149.195 341.734 L 149.195 330.645 L 295.364 330.645 Z");

        public IndicatorHorizontal() : base(svgPath)
        { }
    }
}
