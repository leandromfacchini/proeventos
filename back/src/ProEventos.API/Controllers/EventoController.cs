using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{
    private readonly ILogger<EventoController> _logger;

    private IEnumerable<Evento> eventos = [
            new Evento(){
                EventoId = 1,
                Tema = "Angular 11",
                Local = "São Paulo",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.ToString(),
                ImagemUrl = "Imagem Web",
                Lote = "Lote Web"
            },
            new Evento(){
                EventoId = 2,
                Tema = ".NET 10",
                Local = "São Paulo",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.ToString(),
                ImagemUrl = "Imagem Web",
                Lote = "Lote Web"
            }
        ];

    public EventoController(ILogger<EventoController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<Evento> Get()
    {
        return eventos;
    }

    [HttpGet("{id}")]
    public IEnumerable<Evento> Get(int id)
    {
        return eventos.Where(c => c.EventoId == id);
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