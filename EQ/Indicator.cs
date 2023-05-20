using LiveChartsCore.SkiaSharpView.Drawing;
using SkiaSharp;

namespace EQ
{
    public class Indicator : LiveChartsCore.SkiaSharpView.Drawing.Geometries.SVGPathGeometry
    {
        public static SKPath svgPath = SKPath.ParseSvgPathData(
        "M 79.638 156.25 H 90.727 V 302.419 H 79.638 V 156.25 Z");

        public Indicator() : base(svgPath)
        { }
    }
}
