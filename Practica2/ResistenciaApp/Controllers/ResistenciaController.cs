using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ResistenciaApp.Infraestructure;

namespace ResistenciaApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ResistenciaController : ControllerBase
    {
        [HttpGet]
        public string CalcularResistencia (string Banda_1, string Banda_2, string Banda_3, string Banda_4)
        {
            var repository = new ResistenciaRepository();
            string resultado = repository.Calcular_Resistencia(Banda_1, Banda_2, Banda_3, Banda_4);
            return resultado;
        }
    }
}