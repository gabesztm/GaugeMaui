namespace MauiGauge
{
    internal class HorizontalSymmetricGauge : GaugeBase
    {
        protected override void InternalDraw(ICanvas canvas, RectF dirtyRect)
        {
            int gaugeTotalLength = 200;
            canvas.StrokeLineCap = LineCap.Round;
            canvas.StrokeSize = 8;

            canvas.StrokeColor = BackgroundColor;
            canvas.DrawLine(10, 10, 10 + gaugeTotalLength, 10);

            double middleValue = (GaugeMaximum + GaugeMinimum) / 2;

            double range = GaugeMaximum - middleValue;
            double length = (ConstrainedValue - middleValue) / range * gaugeTotalLength / 2;

            canvas.StrokeColor = GaugeColor;
            if (ConstrainedValue >= middleValue)
            {
                canvas.DrawLine(10 + gaugeTotalLength / 2, 10, 10 + gaugeTotalLength / 2 + (float)length, 10);
            }
            else
            {
                canvas.DrawLine(10 + gaugeTotalLength / 2 + (float)length, 10, 10 + gaugeTotalLength / 2 , 10);
            }

            if (IsLabelShown)
            {
                canvas.FontColor = LabelColor;
                canvas.FontSize = 36;
                canvas.DrawString(ConstrainedValue.ToString(), 10 + gaugeTotalLength / 2, 50, HorizontalAlignment.Center);
            }
        }
    }
}
