static class LogLine
{
    public static string Message(string logLine)
    {
        var splitString = logLine.Split(":");
        var logMessage = splitString[1].Trim();
        return logMessage;
    }

    public static string LogLevel(string logLine)
    {
        var splitString = logLine.Split(":");
        var logLevel = splitString[0];
        var result = logLevel switch
        {
            "[ERROR]" => "error",
            "[WARNING]" => "warning",
            "[INFO]" => "info"
        };
        return result;
    }

    public static string Reformat(string logLine)
    {
        var splitString = logLine.Split(":");
        var logLevel = splitString[0];
        logLevel = logLevel switch
        {
            "[ERROR]" => "(error)",
            "[WARNING]" => "(warning)",
            "[INFO]" => "(info)"
        };
        var logMessage = splitString[1].Trim();
        return $"{logMessage} {logLevel}";
    }
}
