namespace Sem4;

public class SimpleList<T> : IEnumerable<T>
    where T : IComparable
{
    protected SimpleListItem<T>? first;
    protected SimpleListItem<T>? last;

    public int Count { get; protected set; }

    public void Add(T element)
    {
        var newItem = new SimpleListItem<T>(element);
        Count++;

        if (last is null)
        {
            first = newItem;
            last = newItem;
        }
        else
        {
            last.Next = newItem;
            last = newItem;
        }
    }

    public SimpleListItem<T> GetItem(int number)
    {
        if (number < 0 || number >= Count)
        {
            throw new IndexOutOfRangeException($"Индекс {number} выходит за границы списка.");
        }

        var current = first;

        for (var i = 0; i < number; i++)
        {
            current = current!.Next;
        }

        return current!;
    }

    public T Get(int number) => GetItem(number).Data;

    public IEnumerator<T> GetEnumerator()
    {
        var current = first;

        while (current is not null)
        {
            yield return current.Data;
            current = current.Next;
        }
    }

    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() => GetEnumerator();

    public void Sort()
    {
        if (Count > 1)
        {
            Sort(0, Count - 1);
        }
    }

    private void Sort(int low, int high)
    {
        var i = low;
        var j = high;
        var pivot = Get((low + high) / 2);

        do
        {
            while (Get(i).CompareTo(pivot) < 0)
            {
                i++;
            }

            while (Get(j).CompareTo(pivot) > 0)
            {
                j--;
            }

            if (i <= j)
            {
                Swap(i, j);
                i++;
                j--;
            }
        } while (i <= j);

        if (low < j)
        {
            Sort(low, j);
        }

        if (i < high)
        {
            Sort(i, high);
        }
    }

    private void Swap(int i, int j)
    {
        var left = GetItem(i);
        var right = GetItem(j);

        (left.Data, right.Data) = (right.Data, left.Data);
    }
}
