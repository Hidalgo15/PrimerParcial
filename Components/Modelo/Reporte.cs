using System.ComponentModel.DataAnnotations;


class Reporte{
    public string Id { get; set; }

    public DateTime Fecha { get; set; } = DateTime.Now;
    public string Matricula { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Curso { get; set; }
    public string Motivo { get; set; }

}