namespace VentillutionApp.Services;
public static class UserService
{
    public static string RegisteredName { get; private set; } = "";
    public static string RegisteredEmail { get; private set; } = "";
    public static string RegisteredPassword { get; private set; } = "";

    public static bool HasAccount =>
        !string.IsNullOrWhiteSpace(RegisteredEmail);

    public static void Register(
        string name,
        string email,
        string password)
    {
        RegisteredName = name;
        RegisteredEmail = email;
        RegisteredPassword = password;
    }

    public static bool Login(
        string email,
        string password)
    {
        return email == RegisteredEmail &&
               password == RegisteredPassword;
    }
}