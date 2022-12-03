namespace MauiGaugeDemo;

public partial class MainPage : ContentPage
{
    private readonly MainPageViewModel _viewModel;

    public MainPage()
	{
        _viewModel = new MainPageViewModel();
        BindingContext = _viewModel;
        InitializeComponent();
	}

    private void OnCounterPlusClicked(object sender, EventArgs e)
    {
        _viewModel.IncreaseDemoNumber();
    }

    private void OnCounterMinusClicked(object sender, EventArgs e)
    {
        _viewModel.DecreaseDemoNumber();
    }
}

