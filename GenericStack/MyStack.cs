public class MyStack<T>
{
    private T[] _stack;
    private int _count;

    public int Count => _count;
    public bool IsEmpty => _count == 0;

    public MyStack(int cap)
    {
        _stack = new T[cap];
    }

    public void Push(T item)
    {
        if (_count > _stack.Length - 1) return;

        _stack[_count++] = item;
    }

    public T Pop()
    {
        T data = Peek();
        _count--;
        return data;
    }

    public T Peek() => _stack[_count - 1];
}