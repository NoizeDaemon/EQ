using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;
using System.Collections.Generic;
using LiveChartsCore.Defaults;
using LiveChartsCore.SkiaSharpView.Painting.Effects;
using LiveChartsCore.SkiaSharpView.Painting;
using SkiaSharp;
using LiveChartsCore.SkiaSharpView.Drawing.Geometries;

namespace EQ.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public string Greeting => "Welcome to Avalonia!";

        public ISeries[] Series1 { get; set; } = new ISeries[]
        {
            new LineSeries<ObservablePoint>
            {
                Values = new ObservablePoint[]
                {
                    new ObservablePoint(-7, (-4/3)),
                    new ObservablePoint(7, (10/3))
                },
                Fill = null,
                LineSmoothness = 0,
                GeometrySize = 0,
                IsHoverable = false
            },

            //x-Axis Arrow and Label
            new LineSeries<ObservablePoint, RightArrow>
            {
                Values = new ObservablePoint[]
                {
                    new ObservablePoint(7.41, 0)
                },
                Fill = null,
                Stroke = new SolidColorPaint(SKColors.Black) { StrokeThickness = 3 },
                GeometrySize = 20,
                GeometryFill = new SolidColorPaint(SKColors.Black),
                GeometryStroke = new SolidColorPaint(SKColors.Black),
                IsVisibleAtLegend = false,
                IsHoverable = false,
                DataLabelsSize = 20,
                DataLabelsPaint = new SolidColorPaint(SKColors.Black) { SKFontStyle = SKFontStyle.Bold },
                DataLabelsPosition = LiveChartsCore.Measure.DataLabelsPosition.Bottom,
                DataLabelsFormatter = (point) => "x"
            },

            //y-Axis Arrow and Label
            new LineSeries<ObservablePoint, UpArrow> 
            {
                Values = new ObservablePoint[]
                {
                    new ObservablePoint(0, 7.41)
                },
                Fill = null,
                Stroke = new SolidColorPaint(SKColors.Black) { StrokeThickness = 3 },
                GeometrySize = 20,
                GeometryFill = new SolidColorPaint(SKColors.Black),
                GeometryStroke = new SolidColorPaint(SKColors.Black),
                IsVisibleAtLegend = false,
                IsHoverable = false,
                DataLabelsSize = 20,
                DataLabelsPaint = new SolidColorPaint(SKColors.Black) { SKFontStyle = SKFontStyle.Bold },
                DataLabelsPosition = LiveChartsCore.Measure.DataLabelsPosition.Right,
                DataLabelsFormatter = (point) => "y"
            }
        };

        public ISeries[] Series2 { get; set; } = new ISeries[]
 {
            new LineSeries<ObservablePoint>
            {
                Values = new ObservablePoint[]
                {
                    new ObservablePoint(-7, (-4/3)),
                    new ObservablePoint(7, (10/3))
                },
                Fill = null,
                LineSmoothness = 0,
                GeometrySize = 0,
                IsHoverable = false
            },

            //x-Axis Arrow and Label
            new LineSeries<ObservablePoint, RightArrow>
            {
                Values = new ObservablePoint[]
                {
                    new ObservablePoint(7.5, 0)
                },
                Fill = null,
                Stroke = new SolidColorPaint(SKColors.Black) { StrokeThickness = 3 },
                GeometrySize = 20,
                GeometryFill = new SolidColorPaint(SKColors.Black),
                GeometryStroke = new SolidColorPaint(SKColors.Black),
                IsVisibleAtLegend = false,
                IsHoverable = false,
                DataLabelsSize = 20,
                DataLabelsPaint = new SolidColorPaint(SKColors.Black) { SKFontStyle = SKFontStyle.Bold },
                DataLabelsPosition = LiveChartsCore.Measure.DataLabelsPosition.Top,
                DataLabelsFormatter = (point) => "x"
            },

            //y-Axis Arrow and Label
            new LineSeries<ObservablePoint, UpArrow>
            {
                Values = new ObservablePoint[]
                {
                    new ObservablePoint(0, 7.5)
                },
                Fill = null,
                Stroke = new SolidColorPaint(SKColors.Black) { StrokeThickness = 3 },
                GeometrySize = 20,
                GeometryFill = new SolidColorPaint(SKColors.Black),
                GeometryStroke = new SolidColorPaint(SKColors.Black),
                IsVisibleAtLegend = false,
                IsHoverable = false,
                DataLabelsSize = 20,
                DataLabelsPaint = new SolidColorPaint(SKColors.Black) { SKFontStyle = SKFontStyle.Bold },
                DataLabelsPosition = LiveChartsCore.Measure.DataLabelsPosition.Right,
                DataLabelsFormatter = (point) => "y"
            },

            new LineSeries<ObservablePoint>
            {
                Values = new ObservablePoint[]
                {
                    new ObservablePoint(-0.3, 0)
                },
                Fill = null,
                GeometrySize = 0,
                GeometryFill = new SolidColorPaint(SKColors.Black),
                GeometryStroke = new SolidColorPaint(SKColors.Black),
                IsVisibleAtLegend = false,
                IsHoverable = false,
                DataLabelsSize = 20,
                DataLabelsPaint = new SolidColorPaint(SKColors.Black),
                DataLabelsPosition = LiveChartsCore.Measure.DataLabelsPosition.Bottom,
                DataLabelsFormatter = (point) => point.PrimaryValue.ToString(),
            },

            //x-Axis Scale
            new LineSeries<ObservablePoint, Indicator>
            {
                Values = new ObservablePoint[]
                {
                    new ObservablePoint(-7, 0),
                    new ObservablePoint(-6, 0),
                    new ObservablePoint(-5, 0),
                    new ObservablePoint(-4, 0),
                    new ObservablePoint(-3, 0),
                    new ObservablePoint(-2, 0),
                    new ObservablePoint(-1, 0),
                    new ObservablePoint(1, 0),
                    new ObservablePoint(2, 0),
                    new ObservablePoint(3, 0),
                    new ObservablePoint(4, 0),
                    new ObservablePoint(5, 0),
                    new ObservablePoint(6, 0),
                    new ObservablePoint(7, 0)
                },
                Fill = null,
                Stroke = null,
                DataLabelsSize = 20,
                DataLabelsPaint = new SolidColorPaint(SKColors.Black),
                DataLabelsPosition = LiveChartsCore.Measure.DataLabelsPosition.Bottom,
                DataLabelsFormatter = (point) => point.SecondaryValue.ToString(),
                GeometrySize = 20,
                GeometryFill = new SolidColorPaint(SKColors.Black),
                GeometryStroke = new SolidColorPaint(SKColors.Black),
                IsVisibleAtLegend = false,
                IsHoverable = false               
            },

            //y-Axis Scale
            new LineSeries<ObservablePoint, IndicatorHorizontal>
            {
                Values = new ObservablePoint[]
                {
                    new ObservablePoint(0, -7),
                    new ObservablePoint(0, -6),
                    new ObservablePoint(0, -5),
                    new ObservablePoint(0, -4),
                    new ObservablePoint(0, -3),
                    new ObservablePoint(0, -2),
                    new ObservablePoint(0, -1),
                    new ObservablePoint(0, 1),
                    new ObservablePoint(0, 2),
                    new ObservablePoint(0, 3),
                    new ObservablePoint(0, 4),
                    new ObservablePoint(0, 5),
                    new ObservablePoint(0, 6),
                    new ObservablePoint(0, 7)
                },
                Fill = null,
                Stroke = null,
                LineSmoothness = 0,
                DataLabelsSize = 20,
                DataLabelsPaint = new SolidColorPaint(SKColors.Black),
                DataLabelsPosition = LiveChartsCore.Measure.DataLabelsPosition.Left,
                DataLabelsFormatter = (point) => point.PrimaryValue.ToString(),
                GeometrySize = 20,
                GeometryFill = new SolidColorPaint(SKColors.Black),
                GeometryStroke = new SolidColorPaint(SKColors.Black),
                IsVisibleAtLegend = false,
                IsHoverable = false
            },

            //x-Axis Line
            new LineSeries<ObservablePoint> 
            {
                Values = new ObservablePoint[]
                {
                    new ObservablePoint(-7.5, 0),
                    new ObservablePoint(7.5, 0)
                },
                Fill = null,
                Stroke = new SolidColorPaint(SKColors.Black) { StrokeThickness = 5 },
                GeometrySize = 0,
                GeometryStroke = new SolidColorPaint(SKColors.Black),
                LineSmoothness = 0,
                IsVisibleAtLegend = false,
                IsHoverable = false
            },

            //y-Axis Line
            new LineSeries<ObservablePoint> 
            {
                Values = new ObservablePoint[]
                {
                    new ObservablePoint(0, -7.5),
                    new ObservablePoint(0, 7.5)
                },
                Fill = null,
                Stroke = new SolidColorPaint(SKColors.Black) { StrokeThickness = 5 },
                GeometrySize = 0,
                GeometryStroke = new SolidColorPaint(SKColors.Black),
                LineSmoothness = 0,
                IsVisibleAtLegend = false,
                IsHoverable = false
            }
        };

        public List<Axis> XAxes1 { get; set; } = new();
        public List<Axis> YAxes1 { get; set; } = new();

        public List<Axis> XAxes2 { get; set; } = new();
        public List<Axis> YAxes2 { get; set; } = new();

        public MainViewModel()
        {


            XAxes1.Add(GetNewAxis(false));
            YAxes1.Add(GetNewAxis(false));
            XAxes2.Add(GetNewAxis(true));
            YAxes2.Add(GetNewAxis(true));
        }

        Axis GetNewAxis(bool isCustom)
        {
            var newAxis = new Axis
            {
                //Position = LiveChartsCore.Measure.AxisPosition.End,
                IsVisible = true,
                MinLimit = -7.5,
                MaxLimit = 7.5,
                MinStep = 1,
                ForceStepToMin = true,

                SeparatorsPaint = new SolidColorPaint(SKColors.LightSlateGray)
                {
                    StrokeThickness = 1,
                    PathEffect = new DashEffect(new float[] { 3, 3 })
                }
            };

            if(isCustom)
            {
                newAxis.Labels = null;
                newAxis.Labels = new List<string>();
                newAxis.MaxLimit = 7.7;
            }
            else
            {
                newAxis.ZeroPaint = new SolidColorPaint(SKColors.Black)
                {
                    StrokeThickness = 5
                };
            }

            return newAxis;
        }
    }
}