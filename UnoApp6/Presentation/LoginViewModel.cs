namespace UnoApp6.Presentation;

public partial class LoginViewModel : ObservableObject
{
    private IAuthenticationService _authService;

    private INavigator _navigator;

    private IDispatcher _dispatcher;


    public LoginViewModel(
        IDispatcher dispatcher,
        INavigator navigator,
        IAuthenticationService authService)
    {
        _dispatcher = dispatcher;
        _navigator = navigator;
        _authService = authService;
        Login = new AsyncRelayCommand(DoLogin);
    }

    private async Task DoLogin()
    {
        var success = await _authService.LoginAsync();
        Console.WriteLine("Login");
    }

    public string Title { get; } = "Login";

    public ICommand Login { get; }
}
