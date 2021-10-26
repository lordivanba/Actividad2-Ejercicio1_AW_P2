using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Actividad2_Ejercicio1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResistenciaController : ControllerBase
    {

        [HttpGet, Route("calcular/{banda1}/{banda2}/{banda3}/{banda4}")]
        public IActionResult CalcularResistencia(string banda1, string banda2,  string banda3, string banda4)
        {
            banda1 = banda1.ToLower();
            banda2 = banda2.ToLower();
            banda3 = banda3.ToLower();
            banda4 = banda4.ToLower();
            
            double valorBanda1 = 0;
            double valorBanda2 = 0;
            double valorBanda3 = 0;
            double valorBanda4 = 0;
            double tolerancia = 0;
            
            switch (banda1)
            {
                case "negro":
                    valorBanda1 = 0;
                    break;
                case "cafe":
                    valorBanda1 = 1;
                    break;
                case "rojo":
                    valorBanda1 = 2;
                    break;
                case "naranja":
                    valorBanda1 = 3;
                    break;
                case "amarillo":
                    valorBanda1 = 4;
                    break;
                case "verde":
                    valorBanda1 = 5;
                    break;
                case "azul":
                    valorBanda1 = 6;
                    break;
                case  "violeta":
                    valorBanda1 = 7;
                    break;
                case  "gris":
                    valorBanda1 = 8;
                    break;
                case "blanco":
                    valorBanda1 = 9;
                    break;
                default:
                    return Ok("El color ingresado es incorrecto");
            }
            switch (banda2)
            {
                case "negro":
                    valorBanda2 = 0;
                    break;
                case "cafe":
                    valorBanda2 = 1;
                    break;
                case "rojo":
                    valorBanda2 = 2;
                    break;
                case "naranja":
                    valorBanda2 = 3; 
                    break;
                case "amarillo":
                    valorBanda2 = 4;
                    break;
                case "verde":
                    valorBanda2 = 5;
                    break;
                case "azul":
                    valorBanda2 = 6;
                    break;
                case  "violeta":
                    valorBanda2 = 7;
                    break;
                case  "gris":
                    valorBanda2 = 8;
                    break;
                case "blanco":
                    valorBanda2 = 9;
                    break;
                default:
                    return Ok("El color ingresado es incorrecto");
            }
            switch (banda3)
            {
                case "negro":
                    valorBanda3 = 1;
                    break;
                case "cafe":
                    valorBanda3 = 10;
                    break;
                case "rojo":
                    valorBanda3 = 100;
                    break;
                case "naranja":
                    valorBanda3 = 1000;
                    break;
                case "amarillo":
                    valorBanda3 = 10000;
                    break;
                case "verde":
                    valorBanda3 = 100000;
                    break;
                case "azul":
                    valorBanda3 = 1000000;
                    break;
                case  "violeta":
                    valorBanda3 = 10000000;
                    break;
                case  "gris":
                    valorBanda3 = 100000000;
                    break;
                case "blanco":
                    valorBanda3 = 1000000000;
                    break;
                default:
                    return Ok("El color ingresado es incorrecto");
            }
            
            switch (banda4)
            {
                case "rojo":
                    valorBanda4 = 2;
                    tolerancia = 0.2;
                    break;
                case "dorado":
                    valorBanda4 = 5;
                    tolerancia = 0.5;
                    break;
                case "plata":
                    valorBanda4 = 10;
                    tolerancia = .10;
                    break;
                default:
                    return Ok("El color ingresado es incorrecto");
            }

            double resistencia = (double.Parse(valorBanda1.ToString() + valorBanda2.ToString())) * valorBanda3;
            double valorTolerancia = resistencia * tolerancia;
            
            string resultado = $"Colores ingresados: {banda1}, {banda2}, {banda3}, {banda4}. Resistencia: {resistencia}. Tolerancia de {tolerancia}: {valorTolerancia}";

            return Ok(resultado);
        }
    }
}