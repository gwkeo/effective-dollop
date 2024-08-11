using Microsoft.AspNetCore.Mvc;
using Api.Infrastructure.Data;


namespace Api.Web.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController(ApplicationContext context) : ControllerBase
{
    private readonly ApplicationContext _context = context;

}
