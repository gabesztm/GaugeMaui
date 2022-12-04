namespace MauiGauge
{
    internal class HorizontalGauge : GaugeBase
    {
        protected override void InternalDraw(ICanvas canvas, RectF dirtyRect)
        {
            int gaugeTotalLength = 200;
            canvas.StrokeLineCap = LineCap.Round;
            canvas.StrokeSize = 8;

            canvas.StrokeColor = BackgroundColor;
            canvas.DrawLine(10, 10, 10 + gaugeTotalLength, 10);

            double range = GaugeMaximum - GaugeMinimum;
            double length = (ConstrainedValue - GaugeMinimum) / range * gaugeTotalLength;

            canvas.StrokeColor = GaugeColor;
            canvas.DrawLine(10, 10, 10 + (float)length, 10);

            if (IsLabelShown)
            {
                canvas.FontColor = LabelColor;
                canvas.FontSize = 36;
                canvas.DrawString(ConstrainedValue.ToString(), 10 + gaugeTotalLength / 2, 50, HorizontalAlignment.Center);
            }
        }
    }
}
