using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using qubitcode_server.Controllers;
using Models.User;
using qubitcode_server.Models;
using QubitDBApi.User;
using qubitcode_server.Service;

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
    public dynamic LoginUser([FromBody] LoginUserDto body)
    {
      if (body.email == null || body.password == null || body.clientID == null)
      {
        return new Error(1);
      }

      if (body.email.Length == 0 || body.clientID.Length == 0)
      {
        return new Error(1);
      }

      if (body.password.Length < 6)
      {
        return new Error(3);
      }

      if (AuthService.IsValidEmail(body.email) != true)
      {
        return new Error(2);
      }
      
      return _userService.GetAllUsers();
    }
  }
}
