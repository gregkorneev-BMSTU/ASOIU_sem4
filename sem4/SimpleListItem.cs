namespace Sem4;

public class SimpleListItem<T>(T data)
{
    public T Data { get; set; } = data;

    public SimpleListItem<T>? Next { get; set; }
}
