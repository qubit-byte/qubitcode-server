using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using qubitcode_server.Controllers;
using Models.User;
using QubitDBApi.User;

namespace qubitcode_server.Controllers
{
  [Route("api/[controller]")]
  public class AuthController
  {
    private readonly UserService _userService;

    public AuthController(UserService userService)
    {
      _userService = userService;
    }
    [HttpPost("login")]
    public List<UserModel> LoginUser([FromBody] LoginUserDto body)
    {
      return _userService.GetAllUsers();
    }
  }
}
