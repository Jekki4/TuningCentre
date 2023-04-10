using TuningCentre.Web.Services.Contracts;
using Microsoft.AspNetCore.Components;
using System.ComponentModel.DataAnnotations;

namespace TuningCentre.Web.Pages
{
    public class LoginBase:ComponentBase
    {
        [Inject]
        public ILocalStorageService LocalStorageService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        public LoginBase()
        {
            LoginData = new LoginViewModel();
        }
        public LoginViewModel LoginData { get; set; }
        protected async Task LoginAsync()
        {

            if (LoginData.UserName == "test" && LoginData.Password == "test" || LoginData.UserName == "Oleg" && LoginData.Password == "123")
            {
                
                var token = new SecurityToken
                {
                    AccessToken = LoginData.Password,
                    UserName = LoginData.UserName
                };
                await LocalStorageService.SetAsync(nameof(SecurityToken), token);

                NavigationManager.NavigateTo("/", true);
            }
            else
            {
                NavigationManager.NavigateTo("/login", true);
            }

        }
    }
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Поле з логіном повинно бути заповненим!")]
        [StringLength(20, ErrorMessage = "Логін занадто великий!")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Поле з паролем повинно бути заповненим!")]
        public string Password { get; set; }

    }
    public class SecurityToken 
    {
        public string UserName { get; set; }
        public string AccessToken { get; set; }
    }
}
