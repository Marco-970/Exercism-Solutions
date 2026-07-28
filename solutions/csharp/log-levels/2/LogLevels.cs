static class LogLine
{
    public static string Message(string logLine)
    {
        var splitString = logLine.Split(":");
        return splitString[1].Trim();
    }

    public static string LogLevel(string logLine)
    {
        var splitString = logLine.Split(":");
        var logLevel = splitString[0];
        return logLevel switch
        {
            "[ERROR]" => "error",
            "[WARNING]" => "warning",
            "[INFO]" => "info"
        };
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
