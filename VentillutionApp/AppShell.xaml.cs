namespace VentillutionApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(Pages.RegistrationPage), typeof(Pages.RegistrationPage));
            Routing.RegisterRoute(nameof(Pages.HomePage), typeof(Pages.HomePage));  
        }
    }
}
