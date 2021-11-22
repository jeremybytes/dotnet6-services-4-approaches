using Microsoft.AspNetCore.Mvc;

namespace People.Service.Controllers;

[ApiController]
[Route("[controller]")]
public class PeopleController : ControllerBase
{
    private readonly IPeopleProvider _provider;
    private readonly ILogger<PeopleController> _logger;

    public PeopleController(IPeopleProvider provider, ILogger<PeopleController> logger)
    {
        _provider = provider;
        _logger = logger;
    }

    [HttpGet]
    public async Task<IEnumerable<Person>> Get()
    {
        return await _provider.GetPeople();
    }
}
