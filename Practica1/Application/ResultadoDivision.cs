using Practica1.Domain.Interfaces;

namespace Practica1.Application
{
    public class ResultadoDivision : IResultadoDivision
    {
        public Domain.ResultadoDivision Division(int a, int b)
        {
             Domain.ResultadoDivision divisores = new Domain.ResultadoDivision();
            

             divisores.Cociente= a / b;
             divisores.Resto = a % b;

            return divisores;
            
        }
    }
}
