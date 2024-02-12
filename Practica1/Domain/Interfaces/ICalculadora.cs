

namespace Practica1.Domain.Interfaces
{
    public interface ICalculadora
    {   public string Name {get;}
        public int Sumar(int a, int b);
        public int Restar(int a, int b);
        public Domain.ResultadoDivision Dividir(int a, int b);
        public int Multiplicar(int a, int b);
        public bool Espar(int entero);
    }
}
