namespace BlazorSales.Client.Auth
{
    public interface ILoginService
    {
        Task LoginAsync(string token);
        Task LogoutAsync();
    }
}
