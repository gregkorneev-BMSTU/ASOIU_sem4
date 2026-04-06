namespace seminar_4;

/// <summary>
/// Класс Круг
/// </summary>
/// <param name="radius"></param>
internal class Circle(double radius) : Figure("Круг")
{
    /// <summary>
    /// Площадь круга
    /// Переопределяем get-аксессор абстрактного свойства Area
    /// </summary>
    public override double Area => Math.PI * radius * radius;
}
