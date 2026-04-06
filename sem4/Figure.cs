namespace Sem4;

internal abstract class Figure(string type) : IComparable
{
    public string Type { get; } = type;

    public abstract double Area { get; }

    public int CompareTo(object? obj) =>
        obj is Figure other
            ? Area.CompareTo(other.Area)
            : throw new ArgumentException("Объект не является фигурой.", nameof(obj));

    public override string ToString() => $"{Type} площадью {Area:F2}";
}
