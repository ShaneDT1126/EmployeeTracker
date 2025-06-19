using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementSystem.API.Controllers.User
{
    [Route("api/v1/users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly EmployeeManagementSystem.Application.Interfaces.Services.IUserService _userService;

        public UserController(EmployeeManagementSystem.Application.Interfaces.Services.IUserService userService)
        {
            _userService = userService;
        }


    }
}
