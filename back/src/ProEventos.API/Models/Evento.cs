namespace ProEventos.API.Models;

public class Evento
{
    public int EventoId { get; set; }
    public required string Local { get; set; }
    public required string Tema { get; set; }
    public int QtdPessoas { get; set; }
    public required string DataEvento { get; set; }
    public required string Lote { get; set; }
    public required string ImagemUrl { get; set; }
}
