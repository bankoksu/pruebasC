using Practica1.Domain;
using Practica1.Domain.Interfaces;

namespace Practica1.Application
{
    public class Calculadora : ICalculadora
    {
        private ICientifica _cientifica;
        private IResultadoDivision _resultadoDivision;

        public string Name => "calculadora";

        public Calculadora(ICientifica cientifica, IResultadoDivision resultadoDivision) {
            _cientifica = cientifica;
            _resultadoDivision = resultadoDivision;
        }

        public int Restar(int a, int b)
        {
            return a - b;
        }

        public int Sumar(int a, int b)
        {
            return a + b;
        }

        public Domain.ResultadoDivision Dividir(int a, int b)
        {
            return _resultadoDivision.Division(a, b);
            
        }
        public int Multiplicar(int a, int b) 
        { 
            return a * b;
        }

        public bool Espar(int entero) {

            return _cientifica.Espar(entero);
        }
    }
}
