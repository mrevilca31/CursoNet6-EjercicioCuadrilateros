using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCuadrilateros.Modelo
{
    abstract class Cuadrilatero
    {
        private List<decimal> _coordenadas;

        public List<decimal> Coordenadas {
            get => _coordenadas;
            set {
                _coordenadas = value;
            } 
        }

        public Cuadrilatero(List<decimal> coord)
        {
            Coordenadas = coord;
        }

        abstract public decimal CalcularArea();
    }
}
