using Figure.Library.Models;
using Figure.Library.Services;

var circle = new Circle(5.0, true);
var triangle = new Triangle(3.0, 4.0, 5.0);

Console.WriteLine($"Радиус: {circle.Radius}");
Console.WriteLine($"Диаметр: {circle.Diameter}");
Console.WriteLine($"Площадь: {circle.CalculateSquare()}");

Console.WriteLine($"Площадь: {triangle.CalculateSquare()}");
Console.WriteLine($"Треугольник прямоугольный? - {triangle.IsRightAngled()}");

Console.WriteLine($"Площадь фигуры 1: {FigureParametersCalculator.CalculateSquare(circle)}");
Console.WriteLine($"Площадь фигуры 2: {FigureParametersCalculator.CalculateSquare(triangle)}");

Console.ReadKey();