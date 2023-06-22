using TuningCentre.Web.Services.Contracts;
using Microsoft.AspNetCore.Components;
using System.ComponentModel.DataAnnotations;

namespace TuningCentre.Web.PagesEn
{
    public class LoginEnBase:ComponentBase
    {
        [Inject]
        public ILocalStorageService LocalStorageService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        public LoginEnBase()
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

                NavigationManager.NavigateTo("/en/", true);
            }
            else
            {
                NavigationManager.NavigateTo("/en/login", true);
            }

        }
    }
    public class LoginViewModel
    {
        [Required(ErrorMessage = "The login field must be filled in!")]
        [StringLength(20, ErrorMessage = "Login is too long!")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "The password field must be filled in!")]
        public string Password { get; set; }

    }
    public class SecurityToken 
    {
        public string UserName { get; set; }
        public string AccessToken { get; set; }
    }
}
