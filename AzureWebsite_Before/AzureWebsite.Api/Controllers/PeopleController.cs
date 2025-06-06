using AzureWebsite.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace AzureWebsite.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class PeopleController : ControllerBase
{
    private readonly ILogger<PeopleController> logger;

    public PeopleController(ILogger<PeopleController> logger)
    {
        this.logger = logger;
    }

    [HttpGet(Name = "GetPeople")]
    public IEnumerable<Person> Get()
    {
        var mock = new List<Person>
        {
            new Person(firstName: "Jan", lastName: "Nowak", phoneNumber: "123321123"),
            new Person(firstName: "Marek", lastName: "Kowalski")
        };

        return mock;
    }
}
