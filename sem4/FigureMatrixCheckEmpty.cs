namespace seminar_4;

/// <summary>
/// Реализация проверки на пустоту для геометрической фигуры
/// </summary>
internal class FigureMatrixCheckEmpty : IMatrixCheckEmpty<Figure>
{
    /// <summary>
    /// В качестве пустого элемента возвращается null
    /// Обратите внимание на ! после null
    /// </summary>
    public Figure GetEmptyElement() => null!;

    /// <summary>
    /// Проверка что переданный параметр равен null
    /// </summary>
    public bool CheckEmptyElement(Figure element) => element is null;
}
