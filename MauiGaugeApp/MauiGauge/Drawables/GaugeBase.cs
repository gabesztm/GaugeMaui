using Microsoft.Maui.Graphics;

namespace MauiGauge
{
    internal abstract class GaugeBase : IDrawable
    {
        public double GaugeMinimum { get; set; }
        public double GaugeMaximum { get; set; }
        public double GaugeValue { get; set; }
        protected double ConstrainedValue => (GaugeValue < GaugeMinimum) ? GaugeMinimum : (GaugeValue > GaugeMaximum) ? GaugeMaximum : GaugeValue;
        public Color GaugeColor { get; set; }
        public Color LabelColor { get; set; }
        public Color BackgroundColor { get; set; }
        public bool IsLabelShown { get; set; }
        
        public void Draw(ICanvas canvas, RectF dirtyRect)
        {
            InternalDraw(canvas, dirtyRect);
        }

        protected abstract void InternalDraw(ICanvas canvas, RectF dirtyRect);
    }
}
