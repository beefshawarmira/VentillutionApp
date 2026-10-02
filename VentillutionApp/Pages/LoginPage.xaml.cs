using VentillutionApp.Services;

namespace VentillutionApp.Pages;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    private async void LoginButton_Clicked(object sender, EventArgs e)
    {
        string email = EmailEntry.Text?.Trim() ?? "";
        string password = PasswordEntry.Text ?? "";

        if (string.IsNullOrWhiteSpace(email) ||
            string.IsNullOrWhiteSpace(password))
        {
            await DisplayAlert(
                "Login Error",
                "Please enter your email and password.",
                "OK");

            return;
        }

        if (!UserService.HasAccount)
        {
            await DisplayAlert(
                "Login Error",
                "No account has been registered yet.",
                "OK");

            return;
        }

        if (!UserService.Login(email, password))
        {
            await DisplayAlert(
                "Login Error",
                "Incorrect email or password.",
                "OK");

            return;
        }

        await Shell.Current.GoToAsync(nameof(HomePage));
    }

    private async void RegisterHere_Tapped(object sender, TappedEventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(RegistrationPage));
    }
    private async void ForgotPassword_Tapped(object sender, TappedEventArgs e)
    {
        await DisplayAlert(
            "Forgot Password",
            "Password recovery will be available soon.",
            "OK");
    }
}