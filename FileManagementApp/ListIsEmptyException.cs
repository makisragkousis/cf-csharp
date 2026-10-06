namespace StackApp;

internal class ListIsEmptyException : Exception
{
    public ListIsEmptyException() : base("Stack is empty.") { }
    public ListIsEmptyException(string message) : base(message) { }
    public ListIsEmptyException(string message, Exception innerException) : base(message, innerException) { }
}
