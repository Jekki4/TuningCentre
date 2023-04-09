using TuningCentre.Web;
using TuningCentre.Web.Services.Contracts;
using TuningCentre.Web.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.AspNetCore.Components.Authorization;
using Blazored.LocalStorage;
using System.Security.Claims;
using TuningCentre.Web.Pages;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddOptions();
builder.Services.AddAuthorizationCore();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7233/") });
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IShoppingCartService, ShoppingCartService>();
builder.Services.AddScoped<IManageProductsLocalStorageService, ManageProductsLocalStorageService>();
builder.Services.AddScoped<IManageCartItemsLocalStorageService, ManageCartItemsLocalStorageService>();

builder.Services.AddScoped<AuthenticationStateProvider, TokenAuthenticationStateProvider>();
builder.Services.AddScoped<TuningCentre.Web.Services.Contracts.ILocalStorageService, LocalStorageService>();

builder.Services.AddBlazoredLocalStorage();


await builder.Build().RunAsync();

public class TokenAuthenticationStateProvider : AuthenticationStateProvider
{
    private readonly TuningCentre.Web.Services.Contracts.ILocalStorageService _localStorageService;
    public TokenAuthenticationStateProvider(TuningCentre.Web.Services.Contracts.ILocalStorageService localStorageService)
    {
        _localStorageService = localStorageService;
    }
    public override async Task<AuthenticationState> GetAuthenticationStateAsync()
    {
        AuthenticationState CreateAnonymous()
        {
            var anonymousIdentity = new ClaimsIdentity();
            var anonymousPrincipal = new ClaimsPrincipal(anonymousIdentity);
            return new AuthenticationState(anonymousPrincipal);
        }
        var token = await _localStorageService.GetAsync<SecurityToken>(nameof(SecurityToken));
        if (token == null)
        {
            return CreateAnonymous();
        }
        if (string.IsNullOrEmpty(token.AccessToken))
        {
            return CreateAnonymous();
        }
        // create real user state
        var claims = new List<Claim>()
        {
            new Claim("1", "1"),
            new Claim("Жека", "1")
        };


        var identity = new ClaimsIdentity(claims, "Token");
        var principal = new ClaimsPrincipal(identity);
        return new AuthenticationState(principal);
    }
    public void MakeUserAnonymous()
    {
        _localStorageService.RemoveAsync(nameof(SecurityToken));

        var anonymousIdentity = new ClaimsIdentity();
        var anonymousPrincipal = new ClaimsPrincipal(anonymousIdentity);
        var authState = Task.FromResult(new AuthenticationState(anonymousPrincipal));
        NotifyAuthenticationStateChanged(authState);
    }
}