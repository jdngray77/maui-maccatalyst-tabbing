using BindableLayout.ViewModel;

namespace BindableLayout;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        BindingContext = new ItemsViewModel();
        InitializeComponent();
    }
}