using Sem4;

var rect = new Rectangle(5, 4);
var square = new Square(5);
var circle = new Circle(5);

Console.WriteLine("Геометрические фигуры:");
Console.WriteLine(rect);
Console.WriteLine(square);
Console.WriteLine(circle);

Console.WriteLine();
Console.WriteLine("Разреженная матрица:");

var matrix = new Matrix<Figure>(3, 3, new FigureMatrixCheckEmpty())
{
    ColumnWidth = 30
};

matrix[0, 0] = rect;
matrix[1, 1] = square;
matrix[2, 2] = circle;
matrix[2, 0] = new Rectangle(2, 8);

Console.WriteLine(matrix);

Console.WriteLine("Список фигур:");

var list = new SimpleList<Figure>();
list.Add(circle);
list.Add(rect);
list.Add(square);

Console.WriteLine("До сортировки:");
foreach (var figure in list)
{
    Console.WriteLine(figure);
}

list.Sort();

Console.WriteLine();
Console.WriteLine("После сортировки:");
foreach (var figure in list)
{
    Console.WriteLine(figure);
}

Console.WriteLine();
Console.WriteLine("Стек фигур:");

var stack = new SimpleStack<Figure>();
stack.Push(rect);
stack.Push(square);
stack.Push(circle);

while (stack.Count > 0)
{
    Console.WriteLine(stack.Pop());
}
