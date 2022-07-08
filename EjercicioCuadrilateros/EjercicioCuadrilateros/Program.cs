using EjercicioCuadrilateros.Modelo;

// coordenadas de la base de los cuadrilateros
var x1 = 0;
var y1 = 0;
var x2 = 4;
var y2 = 0;

// coordenadas altura de cuadrado
// se usan x1 y x2 para hc
var hc = 4;

// coordenadas altura de rectangulo
// se usan x1 y x2 para hr
var hr = 2;

// coordenadas lado superior de trapecio
var x3 = 1;
var y3 = 2;
var x4 = 3;
var y4 = 2;

List<decimal> listc = new List<decimal> { x1,y1,x2,y2,x1,hc,x2,hc};
List<decimal> listr = new List<decimal> { x1, y1, x2, y2, x1, hr, x2, hr };
List<decimal> listt = new List<decimal> { x1, y1, x2, y2, x3, y3, x4, y4 };

Trapecio t = new Trapecio(listt);
Cuadrado c = new Cuadrado(listc);
Rectangulo r = new Rectangulo(listr);

Console.WriteLine("El área del cuadrado de base = 4cm es: " + c.CalcularArea() + "cm2");
Console.WriteLine("El área del rectangulo de base = 4cm y de altura igual a 2cm es: " + r.CalcularArea() + "cm2");
Console.WriteLine("El área del trapecio de base inferior = 4cm y  de base superior = 2cm es: " + t.CalcularArea() + "cm2");
