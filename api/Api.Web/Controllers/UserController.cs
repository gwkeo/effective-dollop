using Microsoft.AspNetCore.Mvc;
using Api.Infrastructure.Data;

namespace Api.Web.Controllers;

[Route("[controller]")]
[ApiController]
public class UserController(ApplicationContext context) : ControllerBase
{
    
}
