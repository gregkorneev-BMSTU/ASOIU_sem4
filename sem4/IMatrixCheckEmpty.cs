namespace seminar_4;

/// <summary>
/// Интерфейс для взаимодействия с пустыми элементами
/// </summary>
/// <typeparam name="T">Класс который предполагается помещать в ячейку матрицы</typeparam>
public interface IMatrixCheckEmpty<T>
{
    /// <summary>
    /// Возвращает пустой элемент
    /// </summary>
    T GetEmptyElement();

    /// <summary>
    /// Проверка что элемент является пустым
    /// </summary>
    bool CheckEmptyElement(T element);
}
