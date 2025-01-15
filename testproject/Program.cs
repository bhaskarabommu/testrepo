using System.Diagnostics;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
internal class Program
{
    private static object GetDebuggerDisplay()
    {
        throw new NotImplementedException();
    }

    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

}