using Microsoft.AspNetCore.Mvc;

namespace TodoApi.Controllers;

[ApiController]
[Route("[controller]")]
public class QuoteController : ControllerBase
{
    public string quotes;

    private readonly ILogger<QuoteController> _logger;

    public QuoteController(ILogger<QuoteController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetQuote")]
    public IEnumerable<quotes> Get()
    {
        return Enumerable.Range(1, 36).Select(index => new QuoteArray
        {

        // Generate a random index within the array's bounds
        int randomIndex = random.Next(0, fruits.Length);

        // Retrieve the string at the random index
        string randomFruit = fruits[randomIndex];
        })
        .ToArray();
    }
}
