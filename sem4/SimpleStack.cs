namespace seminar_4;

/// <summary>
/// Класс стек
/// </summary>
class SimpleStack<T> : SimpleList<T> where T : IComparable
{
    /// <summary>
    /// Добавление в стек
    /// </summary>
    public void Push(T element) => Add(element);

    /// <summary>
    /// Удаление и чтение из стека
    /// </summary>
    public T Pop()
    {
        T result;

        // Если стек пуст, возвращается значение по умолчанию для типа
        if (Count == 0)
            return default!;
        else if (Count == 1)
        {
            // Единственный элемент — читаем и обнуляем список
            result = first!.Data;
            first = null;
            last = null;
        }
        else
        {
            // Поиск предпоследнего элемента
            var newLast = GetItem(Count - 2);
            // Чтение значения из последнего элемента
            result = newLast.Next!.Data;
            // Предпоследний элемент становится последним
            last = newLast;
            newLast.Next = null;
        }
        Count--;
        return result;
    }
}
