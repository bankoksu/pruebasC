using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Practica1.Domain.Interfaces;

namespace Practica1.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class CalculadoraController : ControllerBase
    {
        private ICalculadora _calculadora;

        public CalculadoraController(ICalculadora calculadora)
        {
            _calculadora = calculadora;
        }
        [HttpGet(Name = "sumar")]
        public int Sumar(int a, int b) {
        
            return _calculadora.Sumar(a,b);

        }

        [HttpGet(Name = "resta")]
        public int Resta(int a, int b)
        {

            return _calculadora.Restar(a, b);

        }

        [HttpGet(Name = "multiplicar")]
        public int Multiplicar(int a, int b)
        {

            return _calculadora.Multiplicar(a, b);

        }

        [HttpGet(Name = "dividir")]
        public Domain.ResultadoDivision Dividir(int a, int b)
        {
            return _calculadora.Dividir(a, b);
        }

    }
}
