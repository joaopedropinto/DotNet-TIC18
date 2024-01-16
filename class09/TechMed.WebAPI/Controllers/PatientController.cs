using Microsoft.AspNetCore.Mvc;
using TechMed.WebAPI.Model;
namespace TechMed.WebAPI.Controllers;

[ApiController]
[Route("[controller]")]

public class PatientController : ControllerBase{
    private static List<Patient> Summaries = new List<Patient>
    {
        new Patient{
            PatientId = 1,
            Name = "Valber",
        },
        new Patient{
            PatientId = 2,
            Name = "Vitu",
        },
        new Patient{
            PatientId = 3,
            Name = "Zaca",
        },
        new Patient{
            PatientId = 4,
            Name = "Marcusao",
        }
    };

    private readonly ILogger<PatientController> _logger;

    public PatientController(ILogger<PatientController> logger)
    {
        _logger = logger;
    }
    [HttpGet(Name = "GetPatient")]
    public IActionResult Get()
    {
        return Ok(Summaries);
    }
    [HttpDelete("/{id}")]
    public IActionResult Delete(int id){

        var patient = Summaries.FirstOrDefault(x => x.PatientId == id);
        if (patient == null){
            return NotFound();
        }
        Summaries.Remove(patient);
        return Ok(Summaries);
    }

}