using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FilesController : ControllerBase
{
    [HttpGet]
    public async ValueTask<IActionResult> GetAll()
    {
        return Ok("sfs");
    }
    [HttpPost]
    public async ValueTask<IActionResult> Create()
    {
        return Ok("sfs");
    }
    [HttpDelete]
    public async ValueTask<IActionResult> Delete()
    {
        return Ok("sfs");
    }
    [HttpPut]
    public async ValueTask<IActionResult> Update()
    {
        return Ok("sfs");
    }
    [HttpHead]
    public async ValueTask<IActionResult> Head()
    {
        return Ok("sfs");
    }
    [HttpOptions]
    public async ValueTask<IActionResult> Options()
    {
        return Ok("sfs");
    }
}
