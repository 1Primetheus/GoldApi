using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GoldApi.Controllers;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v1/[controller]")]
public class UserController : BaseController
{
    public UserController()
    {
    }
    
    [HttpGet]
    [Route("{userId}")]
    public string Get(int userId)
    {
        return $"success: {userId}";
    }

    // [HttpPost]
    // [Route("add")]
    // public void AddUser()
    // {
    //     //return "success!";
    //     UserHandler.AddNewUser(_context);
    // } 
}
