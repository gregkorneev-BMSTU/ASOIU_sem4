namespace seminar_4;

/// <summary>
/// Абстрактная фигура
/// </summary>
/// <param name="type">Название типа фигуры</param>
internal abstract class Figure(string type) : IComparable
{
    // Параметр "string type" задается при объявлении класса
    // Это механизм "первичного конструктора"

    /// <summary>
    /// Тип фигуры
    /// Только для чтения
    /// Инициализируется значением из первичного конструктора
    /// </summary>
    public string Type { get; } = type;

    /// <summary>
    /// Вычисление площади
    /// Вычисляемой свойство только для чтения
    /// </summary>
    public abstract double Area { get; }

    /// <summary>
    /// Приведение к строке, переопределение метода Object
    /// используются:
    /// - строковая интерполяция ($"...") для удобства форматирования
    /// - expression-bodied member (=> вместо фигурных скобок) для лаконичности
    /// </summary>
    public override string ToString() => $"{Type} площадью {Area}";

    /// <summary>
    /// Сравнение фигур по площади (по возрастанию)
    /// </summary>
    public int CompareTo(object? obj) =>
        obj is Figure other
            ? Area.CompareTo(other.Area)
            : throw new ArgumentException("Объект не является фигурой");
}
