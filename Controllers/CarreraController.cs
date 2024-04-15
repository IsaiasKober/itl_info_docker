using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

[Route("api/[controller]")]
[ApiController]
public class CarreraController : ControllerBase
{
    private static List<Carrera> carreras = new List<Carrera>
    {
        new Carrera
        {
            Id = 1,
            Nombre = "Ingeniería en Sistemas",
            Materias = new List<string> { "Programación", "Base de Datos", "Redes de Computadoras" },
            Especialidades = new List<string> { "Desarrollo de Software", "Seguridad Informática" }
        },
        new Carrera
        {
            Id = 2,
            Nombre = "Ingeniería en Gestión Empresarial",
            Materias = new List<string> { "Administración", "Contabilidad", "Economía" },
            Especialidades = new List<string> { "Marketing", "Finanzas" }
        },
        new Carrera
        {
            Id = 3,
            Nombre = "Ingeniería Industrial",
            Materias = new List<string> { "Producción", "Gestión de la Calidad", "Ingeniería de Métodos" },
            Especialidades = new List<string> { "Logística", "Automatización Industrial" }
        },
        new Carrera
        {
            Id = 4,
            Nombre = "Ingeniería Logística",
            Materias = new List<string> { "Gestión de Inventarios", "Distribución y Transporte", "Logística Internacional" },
            Especialidades = new List<string> { "Gestión de Cadenas de Suministro", "Operaciones y Producción" }
        },
        new Carrera
        {
            Id = 5,
            Nombre = "Ingeniería Electromecánica",
            Materias = new List<string> { "Diseño Mecánico", "Electrotecnia", "Control Automático" },
            Especialidades = new List<string> { "Energías Renovables", "Automatización y Robótica" }
        }
    };

    [HttpGet]
    public ActionResult<List<Carrera>> Get()
    {
        return Ok(carreras);
    }
}
