// AuthState.cs
public class AuthState
{
    public bool IsAuthenticated { get; private set; }
    public string Username { get; private set; }

    public event Action OnChange;

    public void Login(string username)
    {
        IsAuthenticated = true;
        Username = username;
        NotifyStateChanged();
    }

    public void Logout()
    {
        IsAuthenticated = false;
        Username = string.Empty;
        NotifyStateChanged();
    }

    private void NotifyStateChanged() => OnChange?.Invoke();
}

// Register in Program.cs
builder.Services.AddScoped<AuthState>();