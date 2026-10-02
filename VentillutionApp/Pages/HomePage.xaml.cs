using VentillutionApp.Services;

namespace VentillutionApp.Pages;

public partial class HomePage : ContentPage
{
    public HomePage()
    {
        InitializeComponent();

        UserNameLabel.Text = UserService.RegisteredName; 
    }

    private async void LogoutButton_Clicked(object sender, EventArgs e)
    {
        bool logout = await DisplayAlert(
            "Log Out",
            "Are you sure you want to log out?",
            "Yes",
            "Cancel");

        if (logout)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}