namespace Sem4;

internal class Rectangle(double height, double width, string type = "Прямоугольник") : Figure(type)
{
    public override double Area => width * height;
}
