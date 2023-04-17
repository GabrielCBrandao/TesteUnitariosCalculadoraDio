using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class CalculadoraImp
    {
        public int Somar(int numero1, int numero2)
        {
            return numero1 + numero2 ;
        }

        public bool EhPar(int numero)
        {
            return numero % 2==0;
        }
        
    }
}