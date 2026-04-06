namespace Sem4;

internal sealed class Circle(double radius) : Figure("Круг")
{
    public override double Area => Math.PI * radius * radius;
}
