namespace Sem4;

public interface IMatrixCheckEmpty<T>
{
    T GetEmptyElement();

    bool CheckEmptyElement(T element);
}
