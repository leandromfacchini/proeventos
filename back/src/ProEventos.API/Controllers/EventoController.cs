using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{
    private readonly ILogger<EventoController> _logger;
    private readonly DataContext _context;


    public EventoController(ILogger<EventoController> logger, DataContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet]
    public IEnumerable<Evento> Get()
    {
        return _context.Eventos;
    }

    [HttpGet("{id}")]
    public Evento Get(int id)
    {
        return _context.Eventos.FirstOrDefault(c => c.EventoId == id);
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