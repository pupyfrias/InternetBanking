using InternetBanking.Core.Applicacion.Dtos.Account;
using InternetBanking.Core.Applicacion.Services;
using InternetBanking.Core.Applicacion.ViewsModels.User;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using InternetBanking.Core.Applicacion.Helpers;

namespace InternetBanking.WebApp.Controllers
{
    public class UserController : Controller
    {
        private readonly IClientService _clientService;
       

        public UserController(IClientService clientService)
        {
            _clientService = clientService;
           
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LogIn(LoginViewModel vm)
        {
            if (!ModelState.IsValid)
                return View(vm);

            var response = await _clientService.LoginAsync(vm);
            if (response.HasError)
            {
                vm.HasError = true;
                vm.Error = response.Error;
                return View(vm);
            }

           
            HttpContext.Session.Set<AuthentificationResponse>("user", response);
            return Redirect("/");
        }

        [HttpGet]
        public async Task<IActionResult> LogOut(LoginViewModel vm)
        {
            await _clientService.SignOutAsync();
            return Redirect("/");
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View(new UserSaveViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Register(UserSaveViewModel vm)
        {
            if (!ModelState.IsValid)
                return View(vm);

            if(vm.Password != vm.ConfirmPassword)
            {
                ModelState.AddModelError("ConfirmPassword", "Passwords don't match");
                return View(vm);
            }

            var origin =Request.Headers["origin"];
            var response = await _clientService.RegisterAsync(vm, origin);

            if (response.HasError)
            {
                vm.HasError = true;
                vm.Error = response.Error;
                return View(vm);
            }


            return View("Confirm");
        }
    }
}
