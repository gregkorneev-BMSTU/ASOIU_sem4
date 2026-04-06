namespace seminar_4;

/// <summary>
/// Контейнерный элемент списка
/// </summary>
/// <typeparam name="T">Тип элемента списка</typeparam>
/// <param name="data">Параметр, соответствующий типу элемента списка</param>
public class SimpleListItem<T>(T data)
{
    /// <summary>
    /// Данные
    /// </summary>
    public T Data { get; set; } = data;

    /// <summary>
    /// Следующий элемент
    /// </summary>
    public SimpleListItem<T>? Next { get; set; }
}
