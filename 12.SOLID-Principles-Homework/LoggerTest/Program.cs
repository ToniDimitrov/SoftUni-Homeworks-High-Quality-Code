namespace LoggerTest
{
    using _1.Logger;
    using _1.Logger.Interfaces;
    using _1.Logger.Models;
    class Program
    {
        static void Main(string[] args)
        {
            var simpleLayout = new SimpleLayout();
            var consoleAppender = new ConsoleAppender(simpleLayout);
            consoleAppender.ReportLevel = ReportLevel.Error;

            var fileAppender = new FileAppender(simpleLayout);

            var logger = new Logger(consoleAppender, fileAppender);

            logger.Info("Everything seems fine");
            logger.Warn("Warning: ping is too high - disconnect imminent");
            logger.Error("Error parsing request");
            logger.Critical("No connection string found in App.config");
            logger.Fatal("mscorlib.dll does not respond");

        }
    }
}
