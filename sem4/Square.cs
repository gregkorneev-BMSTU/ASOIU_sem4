namespace seminar_4;

/// <summary>
/// Класс Квадрат
/// </summary>
/// <param name="size">размер стороны</param>
internal class Square(double size) : Rectangle(size, size, "Квадрат")
{
    // никакой реализации для класа не требуется, специфика реализации
    // задается передачей параметров в конструктор базового класса
}
