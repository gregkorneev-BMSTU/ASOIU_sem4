using System.Text;

namespace Sem4;

public class Matrix<T>(int maxX, int maxY, IMatrixCheckEmpty<T> checkEmpty)
{
    private readonly Dictionary<(int x, int y), T> _matrix = [];

    public int ColumnWidth { get; set; } = 32;

    public T this[int x, int y]
    {
        get
        {
            CheckBounds(x, y);

            return _matrix.TryGetValue((x, y), out var element)
                ? element
                : checkEmpty.GetEmptyElement();
        }
        set
        {
            CheckBounds(x, y);

            if (checkEmpty.CheckEmptyElement(value))
            {
                _matrix.Remove((x, y));
                return;
            }

            _matrix[(x, y)] = value;
        }
    }

    private void CheckBounds(int x, int y)
    {
        if (x < 0 || x >= maxX)
        {
            throw new ArgumentOutOfRangeException(nameof(x), $"x={x} выходит за границы матрицы.");
        }

        if (y < 0 || y >= maxY)
        {
            throw new ArgumentOutOfRangeException(nameof(y), $"y={y} выходит за границы матрицы.");
        }
    }

    public override string ToString()
    {
        var builder = new StringBuilder();

        for (var y = 0; y < maxY; y++)
        {
            builder.Append('|');

            for (var x = 0; x < maxX; x++)
            {
                var element = this[x, y];
                var cell = checkEmpty.CheckEmptyElement(element) ? "-" : element?.ToString() ?? "-";

                builder.Append(cell.PadRight(ColumnWidth));
                builder.Append('|');
            }

            builder.AppendLine();
        }

        return builder.ToString();
    }
}
