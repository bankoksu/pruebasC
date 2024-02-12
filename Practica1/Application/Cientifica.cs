using Practica1.Domain.Interfaces;

namespace Practica1.Application
{
    public class Cientifica:ICientifica
    {
        public bool Espar(int entero)
        {
            return entero % 2 == 0;
        }
    }
}
