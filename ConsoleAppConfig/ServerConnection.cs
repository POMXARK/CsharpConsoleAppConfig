namespace ConsoleAppConfig;

public class ServerConnection
{
    public string Url { get; set; }
    public string Password { get; set; }
    public int Port { get; set; }
    public bool IsSSL { get; set; }

    public override string ToString()
    {
        return $"${this.Url}:${this.Port},password=${this.Password},ssl=${this.IsSSL}";
    }
}