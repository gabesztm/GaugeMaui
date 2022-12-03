namespace MauiGauge;

public partial class GaugeView : ContentView
{
    private readonly GraphicsView _graphicsView;
    private GaugeBase GaugeDrawable => _graphicsView?.Drawable as GaugeBase;

    public static readonly BindableProperty GaugeTypeProperty =
        BindableProperty.Create(nameof(GaugeType), typeof(GaugeTypes), typeof(GaugeTypes), default(GaugeTypes), propertyChanged: OnGaugeTypeChanged);

    public GaugeTypes GaugeType
    {
        get { return (GaugeTypes)GetValue(GaugeTypeProperty); }
        set { SetValue(GaugeTypeProperty, value); }
    }

    public static readonly BindableProperty GaugeMinimumProperty =
           BindableProperty.Create(nameof(GaugeMinimum), typeof(double), typeof(double), default(double), propertyChanged: OnGaugeMinimumChanged);

    public double GaugeMinimum
    {
        get { return (double)GetValue(GaugeMinimumProperty); }
        set { SetValue(GaugeMinimumProperty, value); }
    }

    public static readonly BindableProperty GaugeMaximumProperty =
            BindableProperty.Create(nameof(GaugeMaximum), typeof(double), typeof(double), default(double), propertyChanged: OnGaugeMaximumChanged);

    public double GaugeMaximum
    {
        get { return (double)GetValue(GaugeMaximumProperty); }
        set { SetValue(GaugeMaximumProperty, value); }
    }

    public static readonly BindableProperty GaugeValueProperty =
        BindableProperty.Create(nameof(GaugeValue), typeof(double), typeof(double), default(double), propertyChanged: OnGaugeValueChanged);

    public double GaugeValue
    {
        get { return (double)GetValue(GaugeValueProperty); }
        set { SetValue(GaugeValueProperty, value); }
    }


    public GaugeView()
	{
		InitializeComponent();
        _graphicsView = this.graphicsView;
        InnerInitialize();
    }

    private void InnerInitialize()
    {
        _graphicsView.WidthRequest = 220;
        _graphicsView.HeightRequest = 150;
        SetGaugeType(GaugeType);
    }

    private static void OnGaugeTypeChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
        var gaugeView = bindable as GaugeView;
        gaugeView.SetGaugeType((GaugeTypes)newvalue);

    }

    private void SetGaugeType(GaugeTypes newType)
    {
        switch(newType)
        {
            case GaugeTypes.Curved:
                _graphicsView.Drawable = new CurvedGauge();
                break;
            default:
                throw new NotImplementedException($"No drawable is implemented for {newType}");
        }
    }

    private static void OnGaugeMinimumChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
        var gaugeView = bindable as GaugeView;
        gaugeView.SetGaugeDrawableMinimum((double)newvalue);
    }

    private void SetGaugeDrawableMinimum(double minimum)
    {
        GaugeDrawable.GaugeMinimum = minimum;
        _graphicsView.Invalidate();
    }

    private static void OnGaugeMaximumChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
        var gaugeView = bindable as GaugeView;
        gaugeView.SetGaugeDrawableMaximum((double)newvalue);
    }

    private void SetGaugeDrawableMaximum(double maximum)
    {
        GaugeDrawable.GaugeMaximum = maximum;
        _graphicsView.Invalidate();
    }

    private static void OnGaugeValueChanged(BindableObject bindable, object oldvalue, object newvalue)
    {
        var gaugeView = bindable as GaugeView;
        gaugeView.SetGaugeDrawableValue((double)newvalue);
    }

    private void SetGaugeDrawableValue(double value)
    {
        GaugeDrawable.GaugeValue = value;
        _graphicsView.Invalidate();
    }


}