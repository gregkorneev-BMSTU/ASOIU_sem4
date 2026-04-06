namespace Sem4;

public class SimpleStack<T> : SimpleList<T>
    where T : IComparable
{
    public void Push(T element) => Add(element);

    public T Pop()
    {
        if (Count == 0)
        {
            return default!;
        }

        T result;

        if (Count == 1)
        {
            result = first!.Data;
            first = null;
            last = null;
        }
        else
        {
            var newLast = GetItem(Count - 2);
            result = newLast.Next!.Data;
            last = newLast;
            newLast.Next = null;
        }

        Count--;
        return result;
    }
}
