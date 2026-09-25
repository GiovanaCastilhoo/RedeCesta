using RedeCesta.ViewModels;

namespace RedeCesta.Views.Login;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();

        BindingContext = new LoginViewModel();
    }
}