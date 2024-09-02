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
```

# SQL Запрос из 3 вопроса
```sql
SELECT 
    p.ProductName,
    c.CategoryName
FROM 
    Products p
LEFT JOIN 
    ProductCategories pc ON p.ProductID = pc.ProductID
LEFT JOIN 
    Categories c ON pc.CategoryID = c.CategoryID;
