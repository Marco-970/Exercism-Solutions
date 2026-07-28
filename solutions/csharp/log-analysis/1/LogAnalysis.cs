public static class LogAnalysis 
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string str, string delimiter) => str.Substring(str.IndexOf(delimiter.Last())+1);

    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string str, string startDelimiter, string endDelimiter)
    {
    int start = str.IndexOf(startDelimiter) + startDelimiter.Length;
    int end = str.IndexOf(endDelimiter);
    return str[start..end];
    }
    
    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string str) => str.Substring(str.IndexOf(':') + 2);

    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string str) => str.Substring(str.IndexOf('[') + 1, str.IndexOf(']') - 1);
}