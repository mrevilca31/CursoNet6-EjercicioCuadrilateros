using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCuadrilateros.Modelo
{
    internal class Cuadrado : Cuadrilatero
    {
        public Cuadrado(List<decimal> coord) : base(coord){}

        public override decimal CalcularArea()
        {
            var baseCuadrado = base.Coordenadas[2] - base.Coordenadas[0]; // Coord x2 - x1
            var alturaCuadrado = base.Coordenadas[5] - base.Coordenadas[1]; // Coord y3 - y1

            return baseCuadrado * alturaCuadrado;
        }
    }
}
