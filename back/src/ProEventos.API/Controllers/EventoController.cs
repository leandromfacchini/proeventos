using Microsoft.AspNetCore.Mvc;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{
    private readonly ILogger<EventoController> _logger;

    public EventoController(ILogger<EventoController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public string Get()
    {
        return "Olá Get";
    }

    [HttpPost]
    public string Post()
    {
        return "Olá Post";
    }


    [HttpPut("{id}")]
    public string Put(int id)
    {
        return $"Olá Put: {id}";
    }


    [HttpDelete("{id}")]
    public string Delete(int id)
    {
        return $"Olá Delete: {id}";
    }
}