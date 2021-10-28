using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Actividad2_Ejercicio1.Domain;
using Actividad2_Ejercicio1.Services;

namespace Actividad2_Ejercicio1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResistenciaController : ControllerBase
    {

        [HttpGet]
        public IActionResult CalcularResistencia(Resistencia oResistencia)
        {
            var srv = new ResistenciaService();
            var resultado = srv.CalcularResistencia(oResistencia.banda1, oResistencia.banda2, oResistencia.banda3, oResistencia.banda4);
            
            return Ok(resultado);
        }
    }
}