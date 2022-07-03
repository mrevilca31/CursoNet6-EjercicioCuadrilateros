using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCuadrilateros.Modelo
{
    internal class Trapecio : Cuadrilatero
    {
        public Trapecio(List<decimal> coord) : base(coord){}

        public override decimal CalcularArea()
        {
            // Base Inferior x2 - x1
            var baseInferior = base.Coordenadas[2] - base.Coordenadas[0];
            // Base Superior x4 - x3
            var baseSuperior = base.Coordenadas[6] - base.Coordenadas[4];
            // Altura y3 - y1
            var alturaTrapecio = base.Coordenadas[5] - base.Coordenadas[1]; 

            return (baseSuperior + baseInferior) * alturaTrapecio/2;
        }
    }
}
