using System;
using System.Collections.Generic;
using System.Linq;

namespace DesafioTecnico
{
    public static class Ejercicio1
    {
        public static string SimplificarFraccion(string fraccion)
        {
            var (numerador, denominador) = ObtenerNumeradorDenominador(fraccion);

            if (denominador == 0) return "infinito";

            (numerador, denominador) = Simplificar(numerador, denominador);
            return denominador == 1 ? numerador.ToString() : numerador + "/" + denominador;
        }

        private static (int, int) ObtenerNumeradorDenominador(string fraccion)
        {
            var s = fraccion.Split("/");
            var (numerador, denominador) = Tuple.Create(s[0], s[1]);
            return (int.Parse(numerador), int.Parse(denominador));
        }

        private static (int, int) Simplificar(int numerador, int denominador)
        {
            var mcd = MaximoComunDivisor(numerador, denominador);

            return (numerador / mcd, denominador / mcd);
        }

        private static List<int> ObtenerDivisores(int number)
        {
            var divisores = new List<int> { 1 };
            for (int i = 2; i <= number; i++)
            {
                if (number % i == 0)
                {
                    divisores.Add(i);
                }
            }
            return divisores;
        }

        private static int MaximoComunDivisor(int a, int b)
        {
            var divisoresDeA = ObtenerDivisores(a);
            var divisoresDeB = ObtenerDivisores(b);

            var divisoresComunes = divisoresDeA.Intersect(divisoresDeB);
            return divisoresComunes.Max();

        }
    }
}
