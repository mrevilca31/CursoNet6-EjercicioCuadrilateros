using EjercicioCuadrilateros.Modelo;

List<decimal> list = new List<decimal>();
list.Add(0); // x1
list.Add(0); // y1
list.Add(7); // x2
list.Add(0); // y2
list.Add(2); // x3
list.Add(4); // y3
list.Add(5); // x4
list.Add(4); // y4

Trapecio t = new Trapecio(list);

Console.WriteLine(t.CalcularArea());
