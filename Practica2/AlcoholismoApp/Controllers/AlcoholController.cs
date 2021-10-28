using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AlcoholismoApp.Infraestructure;

namespace AlcoholismoApp.Controllers
{
    /*
Universidad Tecnologica Metropolitana
Aplicaciones Web Orientadas a Objetos
Joel Ivan Chuc Uc
Practica 2 Alcoholismo
Christian Jesus Balam Rosas
4to Cuatrimestre
4°C
Parcial 2
*/
    [Route("api/[controller]")]
    [ApiController]
    public class AlcoholController : ControllerBase
    {
        [HttpGet]
        [Route("{bebida}/{cantidad}/{peso}")]
        public string GetAlchohol(string bebida, int cantidad, double peso)
        {
            var repository = new AlcoholRepository();
            double BAC = repository.Calculo(bebida, cantidad, peso);
            if (BAC <= 0.8)
            {
                return Math.Round(BAC,3) + " Tenga un buen viaje";
            }
            else
            {
                return Math.Round(BAC, 3) + " Necesita apoyo";
            }
        }
    }
}