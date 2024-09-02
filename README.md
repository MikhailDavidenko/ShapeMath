# Использование
Необходимо добавить ссылку на данный проект в своем приложении.

Пример использования библиотеки:

```csharp
using ShapeMath.Shapes;

var triangle = new Triangle(3, 4, 5);
bool isRight = triangle.IsRightTriangle();
double area = triangle.GetArea();

Console.WriteLine($"Is Right Triangle: {isRight}");
Console.WriteLine($"Area: {area}");
