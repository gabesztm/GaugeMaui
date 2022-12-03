using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiGauge
{
    internal class CurvedGauge : GaugeBase
    {
        protected override void InternalDraw(ICanvas canvas, RectF dirtyRect)
        {
            canvas.StrokeLineCap = LineCap.Round;
            canvas.StrokeSize = 8;

            canvas.StrokeColor = Colors.LightGray;
            canvas.DrawArc(10, 10, 200, 200, 0, 180, false, false);

            double range = GaugeMaximum - GaugeMinimum;
            double angle = (ConstrainedValue - GaugeMinimum) / range * 180;

            canvas.StrokeColor = Colors.Red;
            canvas.DrawArc(10, 10, 200, 200, 180 - (float)angle, 180, false, false);

            canvas.FontColor = Colors.Black;
            canvas.FontSize = 36;
            canvas.DrawString(ConstrainedValue.ToString(), 110, 100, HorizontalAlignment.Center);
        }
    }
}
