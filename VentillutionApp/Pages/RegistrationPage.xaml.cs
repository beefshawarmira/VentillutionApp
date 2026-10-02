using VentillutionApp.Services;

namespace VentillutionApp.Pages;

public partial class RegistrationPage : ContentPage
{
    public RegistrationPage()
    {
        InitializeComponent();
    }

    private async void CreateAccountButton_Clicked(object sender, EventArgs e)
    {
        string fullName = FullNameEntry.Text?.Trim() ?? "";
        string email = EmailEntry.Text?.Trim() ?? "";
        string password = PasswordEntry.Text ?? "";
        string confirmPassword = ConfirmPasswordEntry.Text ?? "";

        if (string.IsNullOrWhiteSpace(fullName) ||
            string.IsNullOrWhiteSpace(email) ||
            string.IsNullOrWhiteSpace(password) ||
            string.IsNullOrWhiteSpace(confirmPassword))
        {
            await DisplayAlert(
                "Registration Error",
                "Please complete all fields.",
                "OK");

            return;
        }

        if (password != confirmPassword)
        {
            await DisplayAlert(
                "Registration Error",
                "Passwords do not match.",
                "OK");

            return;
        }

        UserService.Register(
            fullName,
            email,
            password);

        await DisplayAlert(
            "Success",
            "Your account has been created!",
            "OK");

        await Shell.Current.GoToAsync("..");
    }


    private async void LoginHere_Tapped(object sender, TappedEventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
}