using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel;
using System.Diagnostics;

namespace WebApplication2.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ValuesController : ControllerBase
{
    private Car[] Cars { get; set; }
    public ValuesController()
    {
        Cars = new Car[]
        {
            new Car()
            {
                Model = "Supra",
                Color = "Red",
                Type = CarType.Sport
            },
            new Car()
            {
                Model = "Nissan GTR-35",
                Color = "White",
                Type = CarType.Sport
            },
            new Car()
            {
                Model = "Mercedes",
                Color = "Black",
                Type = CarType.Business
            },
            new Car()
            {
                Model = "Porsche",
                Color = "Yellow",
                Type = CarType.Sport
            }
        };
    }
    /// <summary>
    /// what's upo homie
    /// </summary>
    /// <returns></returns>
    [HttpGet("/cars")]

    [SwaggerOperation(Summary = "You can get delist of cars", Description = "")]
    public IActionResult GetList()
    {
        Debug.WriteLine(Cars.Length);
        return Ok(Cars);
    }
}
internal class Car
{
    public string Model { get; set; }
    public string Color { get; set; }
    public CarType Type { get; set; }
}

public enum CarType
{
    Sport = 1,
    Business = 2
}